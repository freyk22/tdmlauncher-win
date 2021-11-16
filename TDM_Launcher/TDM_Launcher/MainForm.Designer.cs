/*
 * Created by SharpDevelop.
 * User: freek
 * Date: 29-8-2016
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TDM_Launcher
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tcLauncher;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox gbLauncher;
		private System.Windows.Forms.RadioButton rbTDM;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label lApplications;
		private System.Windows.Forms.Label lArguments;
		private System.Windows.Forms.Button bLauncherRun;
		private System.Windows.Forms.TextBox tbArguments;
		private System.Windows.Forms.RadioButton rbUpdater;
		private System.Windows.Forms.TextBox tbLog;
		private System.Windows.Forms.Label lbCreditsAuthor;
		private System.Windows.Forms.Label lbCreditsSite;
		private System.Windows.Forms.Button bTBLogClear;
		private System.Windows.Forms.Button bLogSave;
		private System.Windows.Forms.TextBox tbProcessRO;
		private System.Windows.Forms.Label lApplication;
		private System.Windows.Forms.GroupBox gbLog;
		private System.Windows.Forms.GroupBox gbScreenResolution;
		private System.Windows.Forms.Label lScreenHeight;
		private System.Windows.Forms.TextBox tbScreenHeight;
		private System.Windows.Forms.TextBox tbScreenWidth;
		private System.Windows.Forms.Label lScreenWidth;
		private System.Windows.Forms.Button bConfigLoad;
		private System.Windows.Forms.ComboBox cbScreenResolution;
		private System.Windows.Forms.CheckBox cbFPSShow;
		private System.Windows.Forms.Label lScreenResStandard;
		private System.Windows.Forms.CheckBox cbScreenResWindow;
		private System.Windows.Forms.Label lScreenRestCustom;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lAppVersion;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tcLauncher = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.gbLauncher = new System.Windows.Forms.GroupBox();
			this.lApplications = new System.Windows.Forms.Label();
			this.rbUpdater = new System.Windows.Forms.RadioButton();
			this.rbTDM = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.bConfigLoad = new System.Windows.Forms.Button();
			this.gbScreenResolution = new System.Windows.Forms.GroupBox();
			this.cbFPSShow = new System.Windows.Forms.CheckBox();
			this.lScreenResStandard = new System.Windows.Forms.Label();
			this.cbScreenResWindow = new System.Windows.Forms.CheckBox();
			this.cbScreenResolution = new System.Windows.Forms.ComboBox();
			this.lScreenRestCustom = new System.Windows.Forms.Label();
			this.lScreenHeight = new System.Windows.Forms.Label();
			this.tbScreenHeight = new System.Windows.Forms.TextBox();
			this.tbScreenWidth = new System.Windows.Forms.TextBox();
			this.lScreenWidth = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tbArguments = new System.Windows.Forms.TextBox();
			this.bLauncherRun = new System.Windows.Forms.Button();
			this.lArguments = new System.Windows.Forms.Label();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.lbCreditsAuthor = new System.Windows.Forms.Label();
			this.lbCreditsSite = new System.Windows.Forms.Label();
			this.bTBLogClear = new System.Windows.Forms.Button();
			this.bLogSave = new System.Windows.Forms.Button();
			this.tbProcessRO = new System.Windows.Forms.TextBox();
			this.lApplication = new System.Windows.Forms.Label();
			this.gbLog = new System.Windows.Forms.GroupBox();
			this.lAppVersion = new System.Windows.Forms.Label();
			this.tcLauncher.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.gbLauncher.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.gbScreenResolution.SuspendLayout();
			this.gbLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcLauncher
			// 
			this.tcLauncher.Controls.Add(this.tabPage1);
			this.tcLauncher.Controls.Add(this.tabPage2);
			this.tcLauncher.Controls.Add(this.tabPage3);
			this.tcLauncher.Location = new System.Drawing.Point(13, 7);
			this.tcLauncher.Name = "tcLauncher";
			this.tcLauncher.SelectedIndex = 0;
			this.tcLauncher.Size = new System.Drawing.Size(390, 186);
			this.tcLauncher.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.gbLauncher);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(382, 160);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main";
			// 
			// gbLauncher
			// 
			this.gbLauncher.Controls.Add(this.lApplications);
			this.gbLauncher.Controls.Add(this.rbUpdater);
			this.gbLauncher.Controls.Add(this.rbTDM);
			this.gbLauncher.Location = new System.Drawing.Point(6, 6);
			this.gbLauncher.Name = "gbLauncher";
			this.gbLauncher.Size = new System.Drawing.Size(203, 109);
			this.gbLauncher.TabIndex = 1;
			this.gbLauncher.TabStop = false;
			this.gbLauncher.Text = "Launcher";
			// 
			// lApplications
			// 
			this.lApplications.Location = new System.Drawing.Point(6, 27);
			this.lApplications.Name = "lApplications";
			this.lApplications.Size = new System.Drawing.Size(180, 17);
			this.lApplications.TabIndex = 5;
			this.lApplications.Text = "Which Program do you want to run?";
			// 
			// rbUpdater
			// 
			this.rbUpdater.Location = new System.Drawing.Point(6, 75);
			this.rbUpdater.Name = "rbUpdater";
			this.rbUpdater.Size = new System.Drawing.Size(120, 23);
			this.rbUpdater.TabIndex = 1;
			this.rbUpdater.TabStop = true;
			this.rbUpdater.Text = "TDM Updater";
			this.rbUpdater.UseVisualStyleBackColor = true;
			this.rbUpdater.CheckedChanged += new System.EventHandler(this.RbUpdaterCheckedChanged);
			// 
			// rbTDM
			// 
			this.rbTDM.Checked = true;
			this.rbTDM.Location = new System.Drawing.Point(6, 47);
			this.rbTDM.Name = "rbTDM";
			this.rbTDM.Size = new System.Drawing.Size(126, 23);
			this.rbTDM.TabIndex = 0;
			this.rbTDM.TabStop = true;
			this.rbTDM.Text = "The Dark Mod";
			this.rbTDM.UseVisualStyleBackColor = true;
			this.rbTDM.CheckedChanged += new System.EventHandler(this.RbTDMCheckedChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.bConfigLoad);
			this.tabPage2.Controls.Add(this.gbScreenResolution);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(382, 160);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "TestConfig";
			// 
			// bConfigLoad
			// 
			this.bConfigLoad.Enabled = false;
			this.bConfigLoad.Location = new System.Drawing.Point(199, 22);
			this.bConfigLoad.Name = "bConfigLoad";
			this.bConfigLoad.Size = new System.Drawing.Size(75, 31);
			this.bConfigLoad.TabIndex = 1;
			this.bConfigLoad.Text = "Load Config";
			this.bConfigLoad.UseVisualStyleBackColor = true;
			this.bConfigLoad.Click += new System.EventHandler(this.BConfigLoadClick);
			// 
			// gbScreenResolution
			// 
			this.gbScreenResolution.Controls.Add(this.cbFPSShow);
			this.gbScreenResolution.Controls.Add(this.lScreenResStandard);
			this.gbScreenResolution.Controls.Add(this.cbScreenResWindow);
			this.gbScreenResolution.Controls.Add(this.cbScreenResolution);
			this.gbScreenResolution.Controls.Add(this.lScreenRestCustom);
			this.gbScreenResolution.Controls.Add(this.lScreenHeight);
			this.gbScreenResolution.Controls.Add(this.tbScreenHeight);
			this.gbScreenResolution.Controls.Add(this.tbScreenWidth);
			this.gbScreenResolution.Controls.Add(this.lScreenWidth);
			this.gbScreenResolution.Location = new System.Drawing.Point(7, 15);
			this.gbScreenResolution.Name = "gbScreenResolution";
			this.gbScreenResolution.Size = new System.Drawing.Size(176, 136);
			this.gbScreenResolution.TabIndex = 0;
			this.gbScreenResolution.TabStop = false;
			this.gbScreenResolution.Text = "ScreenResolution";
			// 
			// cbFPSShow
			// 
			this.cbFPSShow.Location = new System.Drawing.Point(88, 102);
			this.cbFPSShow.Name = "cbFPSShow";
			this.cbFPSShow.Size = new System.Drawing.Size(83, 29);
			this.cbFPSShow.TabIndex = 2;
			this.cbFPSShow.Text = "Show FPS";
			this.cbFPSShow.UseVisualStyleBackColor = true;
			this.cbFPSShow.CheckedChanged += new System.EventHandler(this.CbFPSShowCheckedChanged);
			// 
			// lScreenResStandard
			// 
			this.lScreenResStandard.Location = new System.Drawing.Point(6, 86);
			this.lScreenResStandard.Name = "lScreenResStandard";
			this.lScreenResStandard.Size = new System.Drawing.Size(75, 20);
			this.lScreenResStandard.TabIndex = 10;
			this.lScreenResStandard.Text = "Standard Res:";
			// 
			// cbScreenResWindow
			// 
			this.cbScreenResWindow.Location = new System.Drawing.Point(7, 109);
			this.cbScreenResWindow.Name = "cbScreenResWindow";
			this.cbScreenResWindow.Size = new System.Drawing.Size(122, 22);
			this.cbScreenResWindow.TabIndex = 6;
			this.cbScreenResWindow.Text = "Windowed";
			this.cbScreenResWindow.UseVisualStyleBackColor = true;
			this.cbScreenResWindow.CheckedChanged += new System.EventHandler(this.CbScreenResWindowCheckedChanged);
			// 
			// cbScreenResolution
			// 
			this.cbScreenResolution.Enabled = false;
			this.cbScreenResolution.FormattingEnabled = true;
			this.cbScreenResolution.Items.AddRange(new object[] {
			"",
			"800 x 600",
			"1024 x 768",
			"1152 x 864",
			"1280 x 960",
			"1280 x 960",
			"1400 x 1050",
			"1920 x 1080"});
			this.cbScreenResolution.Location = new System.Drawing.Point(88, 83);
			this.cbScreenResolution.Name = "cbScreenResolution";
			this.cbScreenResolution.Size = new System.Drawing.Size(76, 21);
			this.cbScreenResolution.TabIndex = 2;
			// 
			// lScreenRestCustom
			// 
			this.lScreenRestCustom.Location = new System.Drawing.Point(7, 16);
			this.lScreenRestCustom.Name = "lScreenRestCustom";
			this.lScreenRestCustom.Size = new System.Drawing.Size(75, 18);
			this.lScreenRestCustom.TabIndex = 5;
			this.lScreenRestCustom.Text = "Custom:";
			// 
			// lScreenHeight
			// 
			this.lScreenHeight.Location = new System.Drawing.Point(7, 36);
			this.lScreenHeight.Name = "lScreenHeight";
			this.lScreenHeight.Size = new System.Drawing.Size(48, 15);
			this.lScreenHeight.TabIndex = 4;
			this.lScreenHeight.Text = "Height";
			// 
			// tbScreenHeight
			// 
			this.tbScreenHeight.Enabled = false;
			this.tbScreenHeight.Location = new System.Drawing.Point(5, 53);
			this.tbScreenHeight.Name = "tbScreenHeight";
			this.tbScreenHeight.Size = new System.Drawing.Size(76, 20);
			this.tbScreenHeight.TabIndex = 3;
			// 
			// tbScreenWidth
			// 
			this.tbScreenWidth.Enabled = false;
			this.tbScreenWidth.Location = new System.Drawing.Point(88, 54);
			this.tbScreenWidth.Name = "tbScreenWidth";
			this.tbScreenWidth.Size = new System.Drawing.Size(76, 20);
			this.tbScreenWidth.TabIndex = 1;
			// 
			// lScreenWidth
			// 
			this.lScreenWidth.Location = new System.Drawing.Point(88, 36);
			this.lScreenWidth.Name = "lScreenWidth";
			this.lScreenWidth.Size = new System.Drawing.Size(37, 15);
			this.lScreenWidth.TabIndex = 2;
			this.lScreenWidth.Text = "Width";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(382, 160);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Debug";
			// 
			// tbArguments
			// 
			this.tbArguments.Location = new System.Drawing.Point(13, 260);
			this.tbArguments.Name = "tbArguments";
			this.tbArguments.Size = new System.Drawing.Size(365, 20);
			this.tbArguments.TabIndex = 2;
			// 
			// bLauncherRun
			// 
			this.bLauncherRun.Location = new System.Drawing.Point(13, 286);
			this.bLauncherRun.Name = "bLauncherRun";
			this.bLauncherRun.Size = new System.Drawing.Size(75, 23);
			this.bLauncherRun.TabIndex = 3;
			this.bLauncherRun.Text = "Run";
			this.bLauncherRun.UseVisualStyleBackColor = true;
			this.bLauncherRun.Click += new System.EventHandler(this.BLauncherRunClick);
			// 
			// lArguments
			// 
			this.lArguments.Location = new System.Drawing.Point(13, 240);
			this.lArguments.Name = "lArguments";
			this.lArguments.Size = new System.Drawing.Size(75, 17);
			this.lArguments.TabIndex = 4;
			this.lArguments.Text = "Arguments:";
			// 
			// tbLog
			// 
			this.tbLog.BackColor = System.Drawing.SystemColors.HighlightText;
			this.tbLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLog.Location = new System.Drawing.Point(6, 19);
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.ReadOnly = true;
			this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbLog.Size = new System.Drawing.Size(360, 140);
			this.tbLog.TabIndex = 1;
			this.tbLog.TextChanged += new System.EventHandler(this.TbLogTextChanged);
			// 
			// lbCreditsAuthor
			// 
			this.lbCreditsAuthor.Location = new System.Drawing.Point(93, 517);
			this.lbCreditsAuthor.Name = "lbCreditsAuthor";
			this.lbCreditsAuthor.Size = new System.Drawing.Size(178, 14);
			this.lbCreditsAuthor.TabIndex = 2;
			this.lbCreditsAuthor.Text = "Created by Freek \'Freyk\' Borgerink";
			// 
			// lbCreditsSite
			// 
			this.lbCreditsSite.Location = new System.Drawing.Point(277, 517);
			this.lbCreditsSite.Name = "lbCreditsSite";
			this.lbCreditsSite.Size = new System.Drawing.Size(114, 14);
			this.lbCreditsSite.TabIndex = 3;
			this.lbCreditsSite.Text = "www.thedarkmod.com";
			// 
			// bTBLogClear
			// 
			this.bTBLogClear.Location = new System.Drawing.Point(6, 165);
			this.bTBLogClear.Name = "bTBLogClear";
			this.bTBLogClear.Size = new System.Drawing.Size(85, 28);
			this.bTBLogClear.TabIndex = 5;
			this.bTBLogClear.Text = "Clear Log";
			this.bTBLogClear.UseVisualStyleBackColor = true;
			this.bTBLogClear.Click += new System.EventHandler(this.BTBLogClearClick);
			// 
			// bLogSave
			// 
			this.bLogSave.Enabled = false;
			this.bLogSave.Location = new System.Drawing.Point(287, 165);
			this.bLogSave.Name = "bLogSave";
			this.bLogSave.Size = new System.Drawing.Size(79, 29);
			this.bLogSave.TabIndex = 6;
			this.bLogSave.Text = "Save Log";
			this.bLogSave.UseVisualStyleBackColor = true;
			// 
			// tbProcessRO
			// 
			this.tbProcessRO.Location = new System.Drawing.Point(13, 217);
			this.tbProcessRO.Name = "tbProcessRO";
			this.tbProcessRO.Size = new System.Drawing.Size(365, 20);
			this.tbProcessRO.TabIndex = 7;
			// 
			// lApplication
			// 
			this.lApplication.Location = new System.Drawing.Point(13, 196);
			this.lApplication.Name = "lApplication";
			this.lApplication.Size = new System.Drawing.Size(88, 18);
			this.lApplication.TabIndex = 8;
			this.lApplication.Text = "Application:";
			// 
			// gbLog
			// 
			this.gbLog.Controls.Add(this.tbLog);
			this.gbLog.Controls.Add(this.bTBLogClear);
			this.gbLog.Controls.Add(this.bLogSave);
			this.gbLog.Location = new System.Drawing.Point(12, 315);
			this.gbLog.Name = "gbLog";
			this.gbLog.Size = new System.Drawing.Size(379, 199);
			this.gbLog.TabIndex = 9;
			this.gbLog.TabStop = false;
			this.gbLog.Text = "Log";
			// 
			// lAppVersion
			// 
			this.lAppVersion.Location = new System.Drawing.Point(13, 517);
			this.lAppVersion.Name = "lAppVersion";
			this.lAppVersion.Size = new System.Drawing.Size(75, 14);
			this.lAppVersion.TabIndex = 10;
			this.lAppVersion.Text = "v20160830";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(408, 534);
			this.Controls.Add(this.lAppVersion);
			this.Controls.Add(this.gbLog);
			this.Controls.Add(this.lApplication);
			this.Controls.Add(this.tbProcessRO);
			this.Controls.Add(this.lbCreditsSite);
			this.Controls.Add(this.lArguments);
			this.Controls.Add(this.lbCreditsAuthor);
			this.Controls.Add(this.tbArguments);
			this.Controls.Add(this.bLauncherRun);
			this.Controls.Add(this.tcLauncher);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "TDM Launcher";
			this.tcLauncher.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.gbLauncher.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.gbScreenResolution.ResumeLayout(false);
			this.gbScreenResolution.PerformLayout();
			this.gbLog.ResumeLayout(false);
			this.gbLog.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
