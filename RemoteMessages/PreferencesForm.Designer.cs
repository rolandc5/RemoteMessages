﻿namespace RemoteMessages
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.activateReplacement = new System.Windows.Forms.CheckBox();
            this.delayReplacement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delayUnfocus = new System.Windows.Forms.TextBox();
            this.activateUnfocus = new System.Windows.Forms.CheckBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.activateAutoIP = new System.Windows.Forms.CheckBox();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.deviceName = new System.Windows.Forms.TextBox();
            this.tips = new System.Windows.Forms.Button();
            this.minimizeToTray = new System.Windows.Forms.CheckBox();
            this.closeToTray = new System.Windows.Forms.CheckBox();
            this.escapeToTray = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showBalloon = new System.Windows.Forms.CheckBox();
            this.showFlash = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flashCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delayBalloon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.activateGhostMode = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textHotkey = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkWin = new System.Windows.Forms.CheckBox();
            this.checkAlt = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkCtrl = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.checkDrafts = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.checkSound = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.browseButton = new System.Windows.Forms.Button();
            this.soundBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // activateReplacement
            // 
            this.activateReplacement.AutoSize = true;
            this.activateReplacement.Checked = true;
            this.activateReplacement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activateReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateReplacement.Location = new System.Drawing.Point(39, 526);
            this.activateReplacement.Name = "activateReplacement";
            this.activateReplacement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activateReplacement.Size = new System.Drawing.Size(225, 24);
            this.activateReplacement.TabIndex = 1;
            this.activateReplacement.Text = "Activate smiley-replacement";
            this.activateReplacement.UseVisualStyleBackColor = true;
            this.activateReplacement.CheckedChanged += new System.EventHandler(this.activateReplacement_CheckedChanged);
            // 
            // delayReplacement
            // 
            this.delayReplacement.Location = new System.Drawing.Point(139, 559);
            this.delayReplacement.Name = "delayReplacement";
            this.delayReplacement.Size = new System.Drawing.Size(100, 20);
            this.delayReplacement.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delay (in ms) :";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Replaces the standard smileys :D by their EMOJI equivalent.";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Automatically unfocuses a conversation after a delay so that it is not marked as " +
                "read.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delay (in ms) :";
            // 
            // delayUnfocus
            // 
            this.delayUnfocus.Location = new System.Drawing.Point(139, 645);
            this.delayUnfocus.Name = "delayUnfocus";
            this.delayUnfocus.Size = new System.Drawing.Size(100, 20);
            this.delayUnfocus.TabIndex = 9;
            // 
            // activateUnfocus
            // 
            this.activateUnfocus.AutoSize = true;
            this.activateUnfocus.Checked = true;
            this.activateUnfocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activateUnfocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateUnfocus.Location = new System.Drawing.Point(39, 615);
            this.activateUnfocus.Name = "activateUnfocus";
            this.activateUnfocus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activateUnfocus.Size = new System.Drawing.Size(183, 24);
            this.activateUnfocus.TabIndex = 8;
            this.activateUnfocus.Text = "Activate auto-unfocus";
            this.activateUnfocus.UseVisualStyleBackColor = true;
            this.activateUnfocus.CheckedChanged += new System.EventHandler(this.activateUnfocus_CheckedChanged);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(149, 831);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(91, 33);
            this.ok.TabIndex = 12;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(265, 831);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 33);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.15F);
            this.label5.Location = new System.Drawing.Point(221, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 71);
            this.label5.TabIndex = 17;
            this.label5.Text = "Automatically finds the IP address of your device based on its name.\r\nYou must en" +
                "ter the port you chose on your iDevice.";
            // 
            // activateAutoIP
            // 
            this.activateAutoIP.AutoSize = true;
            this.activateAutoIP.Checked = true;
            this.activateAutoIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activateAutoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateAutoIP.Location = new System.Drawing.Point(39, 421);
            this.activateAutoIP.Name = "activateAutoIP";
            this.activateAutoIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activateAutoIP.Size = new System.Drawing.Size(195, 24);
            this.activateAutoIP.TabIndex = 14;
            this.activateAutoIP.Text = "Activate auto IP-update";
            this.activateAutoIP.UseVisualStyleBackColor = true;
            this.activateAutoIP.CheckedChanged += new System.EventHandler(this.activateAutoIP_CheckedChanged);
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.AutoSize = true;
            this.deviceNameLabel.Location = new System.Drawing.Point(51, 453);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(85, 13);
            this.deviceNameLabel.TabIndex = 19;
            this.deviceNameLabel.Text = "Device\'s Name :";
            // 
            // deviceName
            // 
            this.deviceName.Location = new System.Drawing.Point(139, 453);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(100, 20);
            this.deviceName.TabIndex = 18;
            // 
            // tips
            // 
            this.tips.Location = new System.Drawing.Point(380, 841);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(119, 23);
            this.tips.TabIndex = 26;
            this.tips.Text = "Tips and shortcuts";
            this.tips.UseVisualStyleBackColor = true;
            this.tips.Click += new System.EventHandler(this.tips_Click);
            // 
            // minimizeToTray
            // 
            this.minimizeToTray.AutoSize = true;
            this.minimizeToTray.Checked = true;
            this.minimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeToTray.Location = new System.Drawing.Point(48, 70);
            this.minimizeToTray.Name = "minimizeToTray";
            this.minimizeToTray.Size = new System.Drawing.Size(383, 20);
            this.minimizeToTray.TabIndex = 28;
            this.minimizeToTray.Text = "Minimize button minimizes Remote Messages to system tray";
            this.minimizeToTray.UseVisualStyleBackColor = true;
            // 
            // closeToTray
            // 
            this.closeToTray.AutoSize = true;
            this.closeToTray.Checked = true;
            this.closeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToTray.Location = new System.Drawing.Point(48, 47);
            this.closeToTray.Name = "closeToTray";
            this.closeToTray.Size = new System.Drawing.Size(347, 20);
            this.closeToTray.TabIndex = 29;
            this.closeToTray.Text = "Close button closes Remote Messages to system tray";
            this.closeToTray.UseVisualStyleBackColor = true;
            // 
            // escapeToTray
            // 
            this.escapeToTray.AutoSize = true;
            this.escapeToTray.Checked = true;
            this.escapeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.escapeToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapeToTray.Location = new System.Drawing.Point(48, 93);
            this.escapeToTray.Name = "escapeToTray";
            this.escapeToTray.Size = new System.Drawing.Size(345, 20);
            this.escapeToTray.TabIndex = 30;
            this.escapeToTray.Text = "Escape key closes Remote Messages to system tray";
            this.escapeToTray.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 98);
            this.panel1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Backgrounding";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Notifications";
            // 
            // showBalloon
            // 
            this.showBalloon.AutoSize = true;
            this.showBalloon.Checked = true;
            this.showBalloon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBalloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBalloon.Location = new System.Drawing.Point(48, 220);
            this.showBalloon.Name = "showBalloon";
            this.showBalloon.Size = new System.Drawing.Size(219, 20);
            this.showBalloon.TabIndex = 38;
            this.showBalloon.Text = "Show balloon notifications in tray";
            this.showBalloon.UseVisualStyleBackColor = true;
            this.showBalloon.CheckedChanged += new System.EventHandler(this.showBalloon_CheckedChanged);
            // 
            // showFlash
            // 
            this.showFlash.AutoSize = true;
            this.showFlash.Checked = true;
            this.showFlash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFlash.Location = new System.Drawing.Point(48, 245);
            this.showFlash.Name = "showFlash";
            this.showFlash.Size = new System.Drawing.Size(137, 20);
            this.showFlash.TabIndex = 37;
            this.showFlash.Text = "Show icon flashing";
            this.showFlash.UseVisualStyleBackColor = true;
            this.showFlash.CheckedChanged += new System.EventHandler(this.showFlash_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flashCount);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.delayBalloon);
            this.panel2.Location = new System.Drawing.Point(23, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 90);
            this.panel2.TabIndex = 40;
            // 
            // flashCount
            // 
            this.flashCount.Location = new System.Drawing.Point(356, 48);
            this.flashCount.Name = "flashCount";
            this.flashCount.Size = new System.Drawing.Size(100, 20);
            this.flashCount.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(284, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 48;
            this.label11.Text = "0 = until focus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Count:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Duration (in ms) :";
            // 
            // delayBalloon
            // 
            this.delayBalloon.Location = new System.Drawing.Point(356, 22);
            this.delayBalloon.Name = "delayBalloon";
            this.delayBalloon.Size = new System.Drawing.Size(100, 20);
            this.delayBalloon.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.port);
            this.panel3.Location = new System.Drawing.Point(23, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 80);
            this.panel3.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "RM\'s Port:";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(115, 53);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(23, 538);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 62);
            this.panel4.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(23, 628);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 60);
            this.panel5.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(116, 16);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 45;
            this.password.Text = "password";
            this.password.UseSystemPasswordChar = true;
            // 
            // activateGhostMode
            // 
            this.activateGhostMode.AutoSize = true;
            this.activateGhostMode.Checked = true;
            this.activateGhostMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activateGhostMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateGhostMode.Location = new System.Drawing.Point(39, 696);
            this.activateGhostMode.Name = "activateGhostMode";
            this.activateGhostMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activateGhostMode.Size = new System.Drawing.Size(178, 24);
            this.activateGhostMode.TabIndex = 44;
            this.activateGhostMode.Text = "Activate Ghost-Mode";
            this.activateGhostMode.UseVisualStyleBackColor = true;
            this.activateGhostMode.CheckedChanged += new System.EventHandler(this.activateGhostMode_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.textHotkey);
            this.panel6.Controls.Add(this.password);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.checkWin);
            this.panel6.Controls.Add(this.checkAlt);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.checkCtrl);
            this.panel6.Location = new System.Drawing.Point(23, 709);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 108);
            this.panel6.TabIndex = 47;
            // 
            // textHotkey
            // 
            this.textHotkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textHotkey.Location = new System.Drawing.Point(116, 49);
            this.textHotkey.MaxLength = 1;
            this.textHotkey.Name = "textHotkey";
            this.textHotkey.Size = new System.Drawing.Size(100, 20);
            this.textHotkey.TabIndex = 52;
            this.textHotkey.Text = "H";
            this.textHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "Hotkey:";
            // 
            // checkWin
            // 
            this.checkWin.AutoSize = true;
            this.checkWin.Location = new System.Drawing.Point(47, 80);
            this.checkWin.Name = "checkWin";
            this.checkWin.Size = new System.Drawing.Size(45, 17);
            this.checkWin.TabIndex = 48;
            this.checkWin.Text = "Win";
            this.checkWin.UseVisualStyleBackColor = true;
            // 
            // checkAlt
            // 
            this.checkAlt.AutoSize = true;
            this.checkAlt.Location = new System.Drawing.Point(173, 80);
            this.checkAlt.Name = "checkAlt";
            this.checkAlt.Size = new System.Drawing.Size(38, 17);
            this.checkAlt.TabIndex = 50;
            this.checkAlt.Text = "Alt";
            this.checkAlt.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(221, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 99);
            this.label14.TabIndex = 11;
            this.label14.Text = "Quickly Hide/Show the app by pressing the hotkey of your choice. When hidden, the" +
                " app will be invisible so that you won\'t get notifications.\r\nThe hotkey can stil" +
                "l be used when GM is disabled.";
            // 
            // checkCtrl
            // 
            this.checkCtrl.AutoSize = true;
            this.checkCtrl.Location = new System.Drawing.Point(110, 80);
            this.checkCtrl.Name = "checkCtrl";
            this.checkCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkCtrl.TabIndex = 49;
            this.checkCtrl.Text = "Ctrl";
            this.checkCtrl.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 841);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "Drafts";
            // 
            // checkDrafts
            // 
            this.checkDrafts.AutoSize = true;
            this.checkDrafts.Checked = true;
            this.checkDrafts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDrafts.Location = new System.Drawing.Point(24, 10);
            this.checkDrafts.Name = "checkDrafts";
            this.checkDrafts.Size = new System.Drawing.Size(111, 20);
            this.checkDrafts.TabIndex = 49;
            this.checkDrafts.Text = "Activate drafts";
            this.checkDrafts.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.checkDrafts);
            this.panel7.Location = new System.Drawing.Point(23, 137);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 38);
            this.panel7.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(141, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(227, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "(Experimental, disable if you experience issues)";
            // 
            // checkSound
            // 
            this.checkSound.AutoSize = true;
            this.checkSound.Checked = true;
            this.checkSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSound.Location = new System.Drawing.Point(24, 21);
            this.checkSound.Name = "checkSound";
            this.checkSound.Size = new System.Drawing.Size(110, 20);
            this.checkSound.TabIndex = 53;
            this.checkSound.Text = "Enable sound";
            this.checkSound.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(35, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 57;
            this.label18.Text = "Sound";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.browseButton);
            this.panel8.Controls.Add(this.soundBox);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.trackBarVolume);
            this.panel8.Controls.Add(this.checkSound);
            this.panel8.Location = new System.Drawing.Point(23, 311);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 90);
            this.panel8.TabIndex = 56;
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(378, 18);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 57;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // soundBox
            // 
            this.soundBox.Enabled = false;
            this.soundBox.FormattingEnabled = true;
            this.soundBox.Items.AddRange(new object[] {
            "3 Notes"});
            this.soundBox.Location = new System.Drawing.Point(140, 20);
            this.soundBox.Name = "soundBox";
            this.soundBox.Size = new System.Drawing.Size(231, 21);
            this.soundBox.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Volume:";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.LargeChange = 25;
            this.trackBarVolume.Location = new System.Drawing.Point(140, 44);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(316, 45);
            this.trackBarVolume.TabIndex = 54;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Value = 25;
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 867);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activateGhostMode);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.activateAutoIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showBalloon);
            this.Controls.Add(this.showFlash);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.escapeToTray);
            this.Controls.Add(this.closeToTray);
            this.Controls.Add(this.minimizeToTray);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.deviceNameLabel);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delayUnfocus);
            this.Controls.Add(this.activateUnfocus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayReplacement);
            this.Controls.Add(this.activateReplacement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox activateReplacement;
        private System.Windows.Forms.TextBox delayReplacement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delayUnfocus;
        private System.Windows.Forms.CheckBox activateUnfocus;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox activateAutoIP;
        private System.Windows.Forms.Label deviceNameLabel;
        private System.Windows.Forms.TextBox deviceName;
        private System.Windows.Forms.Button tips;
        private System.Windows.Forms.CheckBox minimizeToTray;
        private System.Windows.Forms.CheckBox closeToTray;
        private System.Windows.Forms.CheckBox escapeToTray;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox showBalloon;
        private System.Windows.Forms.CheckBox showFlash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox flashCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox delayBalloon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox activateGhostMode;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkWin;
        private System.Windows.Forms.CheckBox checkAlt;
        private System.Windows.Forms.CheckBox checkCtrl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textHotkey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkDrafts;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkSound;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ComboBox soundBox;
        private System.Windows.Forms.Button browseButton;
    }
}