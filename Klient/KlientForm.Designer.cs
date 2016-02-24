namespace SägHej
{
	partial class KlientForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            this.btnSend = new System.Windows.Forms.Button();
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.tbxIPAdress = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.tbxBox = new System.Windows.Forms.TextBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSend.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSend.Location = new System.Drawing.Point(393, 252);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(59, 24);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSägHej_Click);
            // 
            // lblIPAdress
            // 
            this.lblIPAdress.AutoSize = true;
            this.lblIPAdress.Location = new System.Drawing.Point(12, 20);
            this.lblIPAdress.Name = "lblIPAdress";
            this.lblIPAdress.Size = new System.Drawing.Size(51, 13);
            this.lblIPAdress.TabIndex = 1;
            this.lblIPAdress.Text = "IP-adress";
            // 
            // tbxIPAdress
            // 
            this.tbxIPAdress.Location = new System.Drawing.Point(69, 17);
            this.tbxIPAdress.Name = "tbxIPAdress";
            this.tbxIPAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxIPAdress.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(175, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(207, 17);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(47, 20);
            this.tbxPort.TabIndex = 4;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(377, 17);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 5;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // tbxBox
            // 
            this.tbxBox.Location = new System.Drawing.Point(15, 78);
            this.tbxBox.Multiline = true;
            this.tbxBox.Name = "tbxBox";
            this.tbxBox.Size = new System.Drawing.Size(437, 153);
            this.tbxBox.TabIndex = 6;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(15, 252);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(372, 20);
            this.tbxMessage.TabIndex = 7;
            this.tbxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMessage_KeyPress);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(271, 17);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 8;
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 297);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxBox);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbxIPAdress);
            this.Controls.Add(this.lblIPAdress);
            this.Controls.Add(this.btnSend);
            this.Name = "KlientForm";
            this.Text = "Säg Hej!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KlientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label lblIPAdress;
		private System.Windows.Forms.TextBox tbxIPAdress;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.TextBox tbxBox;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxUsername;
	}
}

