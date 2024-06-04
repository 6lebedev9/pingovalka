using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingovalka
{
    public partial class Form1 : Form
    {
        private List<string> ipAddresses;
        private int successfulPings = 0;
        private int failedPings = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnPing_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select IPs.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ipAddresses = new List<string>(File.ReadAllLines(filePath));
                lblTotalIPs.Text = $"Total IPs: {ipAddresses.Count}";

                var tasks = new List<Task>();
                foreach (var ip in ipAddresses)
                {
                    tasks.Add(PingAsync(ip));
                }
                await Task.WhenAll(tasks);

                lblSuccessfulPings.Text = $"Successful Pings: {successfulPings}";
                lblFailedPings.Text = $"Failed Pings: {failedPings}";

                File.WriteAllLines(filePath, ipAddresses);
                MessageBox.Show("Ping process completed.");
            }
        }

        private async Task PingAsync(string ip)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = await ping.SendPingAsync(ip, 1000);
                    if (reply.Status == IPStatus.Success)
                    {
                        lock (ipAddresses)
                        {
                            int index = ipAddresses.IndexOf(ip);
                            ipAddresses[index] += $" - Avg Ping: {reply.RoundtripTime}ms";
                            successfulPings++;
                        }
                    }
                    else
                    {
                        lock (ipAddresses)
                        {
                            int index = ipAddresses.IndexOf(ip);
                            ipAddresses[index] += " - Unavailable";
                            failedPings++;
                        }
                    }
                }
                catch
                {
                    lock (ipAddresses)
                    {
                        int index = ipAddresses.IndexOf(ip);
                        ipAddresses[index] += " - Unavailable";
                        failedPings++;
                    }
                }
            }
        }


        private System.Windows.Forms.Button BtnPing;
        private System.Windows.Forms.Label lblTotalIPs;
        private System.Windows.Forms.Label lblSuccessfulPings;
        private System.Windows.Forms.Label lblFailedPings;
    }
}
