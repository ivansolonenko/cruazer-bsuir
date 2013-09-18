﻿namespace Lab01.Forms
{
	partial class MainForm
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
			System.Windows.Forms.ToolStripStatusLabel lblSplitter;
			System.Windows.Forms.FlowLayoutPanel MainFormFlowLayoutPanel;
			System.Windows.Forms.GroupBox MainFormGroupBox;
			System.Windows.Forms.TableLayoutPanel MainFormTableLayoutPanel;
			System.Windows.Forms.StatusStrip MainFormStatusStrip;
			System.Windows.Forms.MenuStrip MainFormMenuStrip;
			System.Windows.Forms.ToolStripMenuItem leftFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem openLeftFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem closeLeftFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem saveLeftFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem rightFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem openRightFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem closeRightFileToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem saveRightFileToolStripMenuItem;
			this.MainFormPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.rbGridMethod = new System.Windows.Forms.RadioButton();
			this.rbCaesarMethod = new System.Windows.Forms.RadioButton();
			this.rbColumnsMethod = new System.Windows.Forms.RadioButton();
			this.rbRailwayFenceMethod = new System.Windows.Forms.RadioButton();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.txtLeftFileContent = new System.Windows.Forms.TextBox();
			this.txtRightFileContent = new System.Windows.Forms.TextBox();
			this.lblLeftFileName = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblRightFileName = new System.Windows.Forms.ToolStripStatusLabel();
			this.MainFormOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.MainFormSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			lblSplitter = new System.Windows.Forms.ToolStripStatusLabel();
			MainFormFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			MainFormGroupBox = new System.Windows.Forms.GroupBox();
			MainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			MainFormStatusStrip = new System.Windows.Forms.StatusStrip();
			MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
			leftFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			openLeftFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			closeLeftFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			saveLeftFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			rightFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			openRightFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			closeRightFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			saveRightFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			MainFormFlowLayoutPanel.SuspendLayout();
			MainFormGroupBox.SuspendLayout();
			MainFormTableLayoutPanel.SuspendLayout();
			MainFormStatusStrip.SuspendLayout();
			MainFormMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSplitter
			// 
			lblSplitter.Name = "lblSplitter";
			lblSplitter.Size = new System.Drawing.Size(389, 17);
			lblSplitter.Spring = true;
			// 
			// MainFormFlowLayoutPanel
			// 
			MainFormFlowLayoutPanel.Controls.Add(this.MainFormPropertyGrid);
			MainFormFlowLayoutPanel.Controls.Add(MainFormGroupBox);
			MainFormFlowLayoutPanel.Controls.Add(this.btnEncrypt);
			MainFormFlowLayoutPanel.Controls.Add(this.btnDecrypt);
			MainFormFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			MainFormFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			MainFormFlowLayoutPanel.Location = new System.Drawing.Point(175, 3);
			MainFormFlowLayoutPanel.Name = "MainFormFlowLayoutPanel";
			MainFormFlowLayoutPanel.Size = new System.Drawing.Size(274, 389);
			MainFormFlowLayoutPanel.TabIndex = 0;
			// 
			// MainFormPropertyGrid
			// 
			this.MainFormPropertyGrid.HelpVisible = false;
			this.MainFormPropertyGrid.Location = new System.Drawing.Point(3, 3);
			this.MainFormPropertyGrid.Name = "MainFormPropertyGrid";
			this.MainFormPropertyGrid.Size = new System.Drawing.Size(268, 180);
			this.MainFormPropertyGrid.TabIndex = 0;
			this.MainFormPropertyGrid.TabStop = false;
			this.MainFormPropertyGrid.ToolbarVisible = false;
			// 
			// MainFormGroupBox
			// 
			MainFormGroupBox.Controls.Add(this.rbGridMethod);
			MainFormGroupBox.Controls.Add(this.rbCaesarMethod);
			MainFormGroupBox.Controls.Add(this.rbColumnsMethod);
			MainFormGroupBox.Controls.Add(this.rbRailwayFenceMethod);
			MainFormGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			MainFormGroupBox.Location = new System.Drawing.Point(3, 189);
			MainFormGroupBox.Name = "MainFormGroupBox";
			MainFormGroupBox.Size = new System.Drawing.Size(268, 110);
			MainFormGroupBox.TabIndex = 0;
			MainFormGroupBox.TabStop = false;
			MainFormGroupBox.Text = "Метод шифрования";
			// 
			// rbGridMethod
			// 
			this.rbGridMethod.AutoSize = true;
			this.rbGridMethod.Location = new System.Drawing.Point(6, 65);
			this.rbGridMethod.Name = "rbGridMethod";
			this.rbGridMethod.Size = new System.Drawing.Size(206, 17);
			this.rbGridMethod.TabIndex = 0;
			this.rbGridMethod.Text = global::Lab01.Properties.Resources.Methods_Grid;
			this.rbGridMethod.UseVisualStyleBackColor = true;
			// 
			// rbCaesarMethod
			// 
			this.rbCaesarMethod.AutoSize = true;
			this.rbCaesarMethod.Location = new System.Drawing.Point(6, 88);
			this.rbCaesarMethod.Name = "rbCaesarMethod";
			this.rbCaesarMethod.Size = new System.Drawing.Size(95, 17);
			this.rbCaesarMethod.TabIndex = 0;
			this.rbCaesarMethod.Text = global::Lab01.Properties.Resources.Methods_Caesar;
			this.rbCaesarMethod.UseVisualStyleBackColor = true;
			// 
			// rbColumnsMethod
			// 
			this.rbColumnsMethod.AutoSize = true;
			this.rbColumnsMethod.Location = new System.Drawing.Point(6, 42);
			this.rbColumnsMethod.Name = "rbColumnsMethod";
			this.rbColumnsMethod.Size = new System.Drawing.Size(121, 17);
			this.rbColumnsMethod.TabIndex = 0;
			this.rbColumnsMethod.Text = global::Lab01.Properties.Resources.Methods_Columns;
			this.rbColumnsMethod.UseVisualStyleBackColor = true;
			// 
			// rbRailwayFenceMethod
			// 
			this.rbRailwayFenceMethod.AutoSize = true;
			this.rbRailwayFenceMethod.Location = new System.Drawing.Point(6, 19);
			this.rbRailwayFenceMethod.Name = "rbRailwayFenceMethod";
			this.rbRailwayFenceMethod.Size = new System.Drawing.Size(204, 17);
			this.rbRailwayFenceMethod.TabIndex = 0;
			this.rbRailwayFenceMethod.Text = global::Lab01.Properties.Resources.Methods_RailwayFence;
			this.rbRailwayFenceMethod.UseVisualStyleBackColor = true;
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEncrypt.Location = new System.Drawing.Point(3, 305);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(268, 23);
			this.btnEncrypt.TabIndex = 0;
			this.btnEncrypt.TabStop = false;
			this.btnEncrypt.Text = global::Lab01.Properties.Resources.Encrypt;
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDecrypt.Location = new System.Drawing.Point(3, 334);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(268, 23);
			this.btnDecrypt.TabIndex = 0;
			this.btnDecrypt.TabStop = false;
			this.btnDecrypt.Text = global::Lab01.Properties.Resources.Decrypt;
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// MainFormTableLayoutPanel
			// 
			MainFormTableLayoutPanel.ColumnCount = 3;
			MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
			MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			MainFormTableLayoutPanel.Controls.Add(this.txtLeftFileContent, 0, 0);
			MainFormTableLayoutPanel.Controls.Add(this.txtRightFileContent, 2, 0);
			MainFormTableLayoutPanel.Controls.Add(MainFormFlowLayoutPanel, 1, 0);
			MainFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			MainFormTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			MainFormTableLayoutPanel.Name = "MainFormTableLayoutPanel";
			MainFormTableLayoutPanel.RowCount = 1;
			MainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			MainFormTableLayoutPanel.Size = new System.Drawing.Size(624, 395);
			MainFormTableLayoutPanel.TabIndex = 0;
			// 
			// txtLeftFileContent
			// 
			this.txtLeftFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLeftFileContent.Location = new System.Drawing.Point(3, 3);
			this.txtLeftFileContent.Multiline = true;
			this.txtLeftFileContent.Name = "txtLeftFileContent";
			this.txtLeftFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLeftFileContent.Size = new System.Drawing.Size(166, 389);
			this.txtLeftFileContent.TabIndex = 1;
			// 
			// txtRightFileContent
			// 
			this.txtRightFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRightFileContent.Location = new System.Drawing.Point(455, 3);
			this.txtRightFileContent.Multiline = true;
			this.txtRightFileContent.Name = "txtRightFileContent";
			this.txtRightFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRightFileContent.Size = new System.Drawing.Size(166, 389);
			this.txtRightFileContent.TabIndex = 2;
			// 
			// MainFormStatusStrip
			// 
			MainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.lblLeftFileName,
						lblSplitter,
						this.lblRightFileName});
			MainFormStatusStrip.Location = new System.Drawing.Point(0, 419);
			MainFormStatusStrip.Name = "MainFormStatusStrip";
			MainFormStatusStrip.Size = new System.Drawing.Size(624, 22);
			MainFormStatusStrip.TabIndex = 0;
			// 
			// lblLeftFileName
			// 
			this.lblLeftFileName.Name = "lblLeftFileName";
			this.lblLeftFileName.Size = new System.Drawing.Size(110, 17);
			this.lblLeftFileName.Text = global::Lab01.Properties.Resources.NoFile;
			// 
			// lblRightFileName
			// 
			this.lblRightFileName.Name = "lblRightFileName";
			this.lblRightFileName.Size = new System.Drawing.Size(110, 17);
			this.lblRightFileName.Text = global::Lab01.Properties.Resources.NoFile;
			// 
			// MainFormMenuStrip
			// 
			MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						leftFileToolStripMenuItem,
						rightFileToolStripMenuItem});
			MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
			MainFormMenuStrip.Name = "MainFormMenuStrip";
			MainFormMenuStrip.Size = new System.Drawing.Size(624, 24);
			MainFormMenuStrip.TabIndex = 0;
			// 
			// leftFileToolStripMenuItem
			// 
			leftFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
						openLeftFileToolStripMenuItem,
						closeLeftFileToolStripMenuItem,
						saveLeftFileToolStripMenuItem});
			leftFileToolStripMenuItem.Name = "leftFileToolStripMenuItem";
			leftFileToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			leftFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.LeftFile;
			// 
			// openLeftFileToolStripMenuItem
			// 
			openLeftFileToolStripMenuItem.Name = "openLeftFileToolStripMenuItem";
			openLeftFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			openLeftFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.Open;
			openLeftFileToolStripMenuItem.Click += new System.EventHandler(this.openLeftFileToolStripMenuItem_Click);
			// 
			// closeLeftFileToolStripMenuItem
			// 
			closeLeftFileToolStripMenuItem.Name = "closeLeftFileToolStripMenuItem";
			closeLeftFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			closeLeftFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.Close;
			closeLeftFileToolStripMenuItem.Click += new System.EventHandler(this.closeLeftFileToolStripMenuItem_Click);
			// 
			// saveLeftFileToolStripMenuItem
			// 
			saveLeftFileToolStripMenuItem.Name = "saveLeftFileToolStripMenuItem";
			saveLeftFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			saveLeftFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.Save;
			saveLeftFileToolStripMenuItem.Click += new System.EventHandler(this.saveLeftFileToolStripMenuItem_Click);
			// 
			// rightFileToolStripMenuItem
			// 
			rightFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
						openRightFileToolStripMenuItem,
						closeRightFileToolStripMenuItem,
						saveRightFileToolStripMenuItem});
			rightFileToolStripMenuItem.Name = "rightFileToolStripMenuItem";
			rightFileToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			rightFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.RightFile;
			// 
			// openRightFileToolStripMenuItem
			// 
			openRightFileToolStripMenuItem.Name = "openRightFileToolStripMenuItem";
			openRightFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			openRightFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.Open;
			openRightFileToolStripMenuItem.Click += new System.EventHandler(this.openRightFileToolStripMenuItem_Click);
			// 
			// closeRightFileToolStripMenuItem
			// 
			closeRightFileToolStripMenuItem.Name = "closeRightFileToolStripMenuItem";
			closeRightFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			closeRightFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.Close;
			closeRightFileToolStripMenuItem.Click += new System.EventHandler(this.closeRightFileToolStripMenuItem_Click);
			// 
			// saveRightFileToolStripMenuItem
			// 
			saveRightFileToolStripMenuItem.Name = "saveRightFileToolStripMenuItem";
			saveRightFileToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			saveRightFileToolStripMenuItem.Text = global::Lab01.Properties.Resources.Save;
			saveRightFileToolStripMenuItem.Click += new System.EventHandler(this.saveRightFileToolStripMenuItem_Click);
			// 
			// MainFormOpenFileDialog
			// 
			this.MainFormOpenFileDialog.DefaultExt = global::Lab01.Properties.Resources.FileDialogDefaultExtension;
			this.MainFormOpenFileDialog.Filter = global::Lab01.Properties.Resources.FileDialogFilter;
			this.MainFormOpenFileDialog.RestoreDirectory = true;
			// 
			// MainFormSaveFileDialog
			// 
			this.MainFormSaveFileDialog.DefaultExt = global::Lab01.Properties.Resources.FileDialogDefaultExtension;
			this.MainFormSaveFileDialog.Filter = global::Lab01.Properties.Resources.FileDialogFilter;
			this.MainFormSaveFileDialog.RestoreDirectory = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(MainFormTableLayoutPanel);
			this.Controls.Add(MainFormStatusStrip);
			this.Controls.Add(MainFormMenuStrip);
			this.MainMenuStrip = MainFormMenuStrip;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "MainForm";
			this.Text = global::Lab01.Properties.Resources.WindowTitle;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			MainFormFlowLayoutPanel.ResumeLayout(false);
			MainFormGroupBox.ResumeLayout(false);
			MainFormGroupBox.PerformLayout();
			MainFormTableLayoutPanel.ResumeLayout(false);
			MainFormTableLayoutPanel.PerformLayout();
			MainFormStatusStrip.ResumeLayout(false);
			MainFormStatusStrip.PerformLayout();
			MainFormMenuStrip.ResumeLayout(false);
			MainFormMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripStatusLabel lblLeftFileName;
		private System.Windows.Forms.ToolStripStatusLabel lblRightFileName;
		private System.Windows.Forms.TextBox txtLeftFileContent;
		private System.Windows.Forms.TextBox txtRightFileContent;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.PropertyGrid MainFormPropertyGrid;
		private System.Windows.Forms.OpenFileDialog MainFormOpenFileDialog;
		private System.Windows.Forms.SaveFileDialog MainFormSaveFileDialog;
		private System.Windows.Forms.RadioButton rbRailwayFenceMethod;
		private System.Windows.Forms.RadioButton rbColumnsMethod;
		private System.Windows.Forms.RadioButton rbGridMethod;
		private System.Windows.Forms.RadioButton rbCaesarMethod;
	}
}

