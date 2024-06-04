namespace pingovalka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPing = new System.Windows.Forms.Button();
            this.lblTotalIPs = new System.Windows.Forms.Label();
            this.lblSuccessfulPings = new System.Windows.Forms.Label();
            this.lblFailedPings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPing
            // 
            this.BtnPing.Location = new System.Drawing.Point(12, 12);
            this.BtnPing.Name = "BtnPing";
            this.BtnPing.Size = new System.Drawing.Size(75, 23);
            this.BtnPing.TabIndex = 0;
            this.BtnPing.Text = "Ping";
            this.BtnPing.UseVisualStyleBackColor = true;
            this.BtnPing.Click += new System.EventHandler(this.BtnPing_Click);
            // 
            // lblTotalIPs
            // 
            this.lblTotalIPs.AutoSize = true;
            this.lblTotalIPs.Location = new System.Drawing.Point(12, 50);
            this.lblTotalIPs.Name = "lblTotalIPs";
            this.lblTotalIPs.Size = new System.Drawing.Size(52, 13);
            this.lblTotalIPs.TabIndex = 1;
            this.lblTotalIPs.Text = "Total IPs:";
            // 
            // lblSuccessfulPings
            // 
            this.lblSuccessfulPings.AutoSize = true;
            this.lblSuccessfulPings.Location = new System.Drawing.Point(12, 75);
            this.lblSuccessfulPings.Name = "lblSuccessfulPings";
            this.lblSuccessfulPings.Size = new System.Drawing.Size(91, 13);
            this.lblSuccessfulPings.TabIndex = 2;
            this.lblSuccessfulPings.Text = "Successful Pings:";
            // 
            // lblFailedPings
            // 
            this.lblFailedPings.AutoSize = true;
            this.lblFailedPings.Location = new System.Drawing.Point(12, 100);
            this.lblFailedPings.Name = "lblFailedPings";
            this.lblFailedPings.Size = new System.Drawing.Size(67, 13);
            this.lblFailedPings.TabIndex = 3;
            this.lblFailedPings.Text = "Failed Pings:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(537, 389);
            this.Controls.Add(this.lblFailedPings);
            this.Controls.Add(this.lblSuccessfulPings);
            this.Controls.Add(this.lblTotalIPs);
            this.Controls.Add(this.BtnPing);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

