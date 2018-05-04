namespace AsterNET.WinForm
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbAutoLogin = new System.Windows.Forms.CheckBox();
            this.cbAutostart = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMasterPassword = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.tbServerURI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.execAfterCall = new System.Windows.Forms.TextBox();
            this.execAfterAnswer = new System.Windows.Forms.TextBox();
            this.execBeforeAnswer = new System.Windows.Forms.TextBox();
            this.phonePattern = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveSettings);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.cbAutoLogin);
            this.groupBox1.Controls.Add(this.cbAutostart);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMasterPassword);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Controls.Add(this.tbServerURI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server configuration";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Enabled = false;
            this.btnSaveSettings.Location = new System.Drawing.Point(270, 19);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(117, 23);
            this.btnSaveSettings.TabIndex = 20;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(270, 72);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 23);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm number";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbAutoLogin
            // 
            this.cbAutoLogin.AutoSize = true;
            this.cbAutoLogin.Location = new System.Drawing.Point(147, 129);
            this.cbAutoLogin.Name = "cbAutoLogin";
            this.cbAutoLogin.Size = new System.Drawing.Size(107, 17);
            this.cbAutoLogin.TabIndex = 22;
            this.cbAutoLogin.Text = "Connect at logon";
            this.cbAutoLogin.UseVisualStyleBackColor = true;
            this.cbAutoLogin.Click += new System.EventHandler(this.cbAutoLogin_Click);
            // 
            // cbAutostart
            // 
            this.cbAutostart.AutoSize = true;
            this.cbAutostart.Location = new System.Drawing.Point(9, 129);
            this.cbAutostart.Name = "cbAutostart";
            this.cbAutostart.Size = new System.Drawing.Size(87, 17);
            this.cbAutostart.TabIndex = 21;
            this.cbAutostart.Text = "Start on boot";
            this.cbAutostart.UseVisualStyleBackColor = true;
            this.cbAutostart.Click += new System.EventHandler(this.cbAutostart_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(137, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 23);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 23);
            this.btnConnect.TabIndex = 19;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Master password";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(147, 74);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(117, 20);
            this.tbNumber.TabIndex = 17;
            this.tbNumber.Text = "100";
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your Number";
            // 
            // tbMasterPassword
            // 
            this.tbMasterPassword.Location = new System.Drawing.Point(147, 100);
            this.tbMasterPassword.Name = "tbMasterPassword";
            this.tbMasterPassword.PasswordChar = '*';
            this.tbMasterPassword.Size = new System.Drawing.Size(240, 20);
            this.tbMasterPassword.TabIndex = 18;
            this.tbMasterPassword.Text = "assembler";
            this.tbMasterPassword.TextChanged += new System.EventHandler(this.tbMasterPassword_TextChanged);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(6, 51);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(104, 13);
            this.lable1.TabIndex = 13;
            this.lable1.Text = "Elastix Web Address";
            // 
            // tbServerURI
            // 
            this.tbServerURI.Location = new System.Drawing.Point(147, 48);
            this.tbServerURI.Name = "tbServerURI";
            this.tbServerURI.Size = new System.Drawing.Size(240, 20);
            this.tbServerURI.TabIndex = 14;
            this.tbServerURI.Text = "http://192.168.1.2";
            this.tbServerURI.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.execAfterCall);
            this.groupBox2.Controls.Add(this.execAfterAnswer);
            this.groupBox2.Controls.Add(this.execBeforeAnswer);
            this.groupBox2.Controls.Add(this.phonePattern);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client configuration";
            // 
            // execAfterCall
            // 
            this.execAfterCall.Location = new System.Drawing.Point(147, 98);
            this.execAfterCall.Name = "execAfterCall";
            this.execAfterCall.ReadOnly = true;
            this.execAfterCall.Size = new System.Drawing.Size(240, 20);
            this.execAfterCall.TabIndex = 27;
            // 
            // execAfterAnswer
            // 
            this.execAfterAnswer.Location = new System.Drawing.Point(147, 74);
            this.execAfterAnswer.Name = "execAfterAnswer";
            this.execAfterAnswer.ReadOnly = true;
            this.execAfterAnswer.Size = new System.Drawing.Size(240, 20);
            this.execAfterAnswer.TabIndex = 26;
            // 
            // execBeforeAnswer
            // 
            this.execBeforeAnswer.Location = new System.Drawing.Point(147, 48);
            this.execBeforeAnswer.Name = "execBeforeAnswer";
            this.execBeforeAnswer.ReadOnly = true;
            this.execBeforeAnswer.Size = new System.Drawing.Size(240, 20);
            this.execBeforeAnswer.TabIndex = 25;
            // 
            // phonePattern
            // 
            this.phonePattern.Location = new System.Drawing.Point(147, 22);
            this.phonePattern.Name = "phonePattern";
            this.phonePattern.ReadOnly = true;
            this.phonePattern.Size = new System.Drawing.Size(240, 20);
            this.phonePattern.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Exec After Call";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Exec After Anwer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Exec Before Anwer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone patterns";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(79, 17);
            this.statusLabel.Text = "Disconnected";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 336);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMI Launcher for Elastix";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMasterPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox tbServerURI;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox execAfterCall;
        private System.Windows.Forms.TextBox execAfterAnswer;
        private System.Windows.Forms.TextBox execBeforeAnswer;
        private System.Windows.Forms.TextBox phonePattern;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAutoLogin;
        private System.Windows.Forms.CheckBox cbAutostart;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnConfirm;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

	}
}

