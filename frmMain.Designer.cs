namespace CmdQueue
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnAdd = new System.Windows.Forms.Button();
			this.cmbNewCommand = new System.Windows.Forms.ComboBox();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lstCurrentQueue = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStartIn = new System.Windows.Forms.TextBox();
			this.grpAddJob = new System.Windows.Forms.GroupBox();
			this.grpCurrentQueue = new System.Windows.Forms.GroupBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblWebURL = new System.Windows.Forms.LinkLabel();
			this.btnBrowseStartIn = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.grpAddJob.SuspendLayout();
			this.grpCurrentQueue.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(492, 102);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(59, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add Job";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cmbNewCommand
			// 
			this.cmbNewCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbNewCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbNewCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbNewCommand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbNewCommand.FormattingEnabled = true;
			this.cmbNewCommand.Location = new System.Drawing.Point(126, 21);
			this.cmbNewCommand.Name = "cmbNewCommand";
			this.cmbNewCommand.Size = new System.Drawing.Size(392, 21);
			this.cmbNewCommand.TabIndex = 1;
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveUp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoveUp.Location = new System.Drawing.Point(491, 23);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(59, 23);
			this.btnMoveUp.TabIndex = 22;
			this.btnMoveUp.Text = "Up";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoveDown.Location = new System.Drawing.Point(491, 52);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(59, 23);
			this.btnMoveDown.TabIndex = 23;
			this.btnMoveDown.Text = "Down";
			this.btnMoveDown.UseVisualStyleBackColor = true;
			this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(491, 81);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(59, 23);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Remove";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(8, 211);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(89, 23);
			this.btnStart.TabIndex = 21;
			this.btnStart.Text = "Start Queue";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(104, 211);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(446, 23);
			this.lblStatus.TabIndex = 7;
			this.lblStatus.Text = "Status";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(126, 48);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(425, 21);
			this.txtName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Command";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Description (optional)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lstCurrentQueue
			// 
			this.lstCurrentQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstCurrentQueue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCurrentQueue.FormattingEnabled = true;
			this.lstCurrentQueue.Location = new System.Drawing.Point(9, 23);
			this.lstCurrentQueue.Name = "lstCurrentQueue";
			this.lstCurrentQueue.Size = new System.Drawing.Size(476, 173);
			this.lstCurrentQueue.TabIndex = 20;
			this.lstCurrentQueue.SelectedIndexChanged += new System.EventHandler(this.lstCurrentQueue_SelectedIndexChanged);
			this.lstCurrentQueue.DoubleClick += new System.EventHandler(this.lstCurrentQueue_DoubleClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Start in";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtStartIn
			// 
			this.txtStartIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStartIn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStartIn.Location = new System.Drawing.Point(126, 75);
			this.txtStartIn.Name = "txtStartIn";
			this.txtStartIn.Size = new System.Drawing.Size(392, 21);
			this.txtStartIn.TabIndex = 3;
			// 
			// grpAddJob
			// 
			this.grpAddJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpAddJob.Controls.Add(this.btnOpenFile);
			this.grpAddJob.Controls.Add(this.btnBrowseStartIn);
			this.grpAddJob.Controls.Add(this.label3);
			this.grpAddJob.Controls.Add(this.txtStartIn);
			this.grpAddJob.Controls.Add(this.label2);
			this.grpAddJob.Controls.Add(this.label1);
			this.grpAddJob.Controls.Add(this.txtName);
			this.grpAddJob.Controls.Add(this.cmbNewCommand);
			this.grpAddJob.Controls.Add(this.btnAdd);
			this.grpAddJob.Location = new System.Drawing.Point(12, 12);
			this.grpAddJob.Name = "grpAddJob";
			this.grpAddJob.Size = new System.Drawing.Size(560, 136);
			this.grpAddJob.TabIndex = 13;
			this.grpAddJob.TabStop = false;
			this.grpAddJob.Text = "Add Job to Queue";
			// 
			// grpCurrentQueue
			// 
			this.grpCurrentQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpCurrentQueue.Controls.Add(this.lstCurrentQueue);
			this.grpCurrentQueue.Controls.Add(this.lblStatus);
			this.grpCurrentQueue.Controls.Add(this.btnStart);
			this.grpCurrentQueue.Controls.Add(this.btnDelete);
			this.grpCurrentQueue.Controls.Add(this.btnMoveDown);
			this.grpCurrentQueue.Controls.Add(this.btnMoveUp);
			this.grpCurrentQueue.Location = new System.Drawing.Point(12, 163);
			this.grpCurrentQueue.Name = "grpCurrentQueue";
			this.grpCurrentQueue.Size = new System.Drawing.Size(560, 244);
			this.grpCurrentQueue.TabIndex = 14;
			this.grpCurrentQueue.TabStop = false;
			this.grpCurrentQueue.Text = "Current Queue";
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(12, 419);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(24, 11);
			this.lblVersion.TabIndex = 15;
			this.lblVersion.Text = "v1.0";
			// 
			// lblWebURL
			// 
			this.lblWebURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWebURL.AutoSize = true;
			this.lblWebURL.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWebURL.Location = new System.Drawing.Point(514, 419);
			this.lblWebURL.Name = "lblWebURL";
			this.lblWebURL.Size = new System.Drawing.Size(58, 11);
			this.lblWebURL.TabIndex = 16;
			this.lblWebURL.TabStop = true;
			this.lblWebURL.Text = "gazchap.com";
			this.lblWebURL.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblWebURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWebURL_LinkClicked);
			// 
			// btnBrowseStartIn
			// 
			this.btnBrowseStartIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseStartIn.Location = new System.Drawing.Point(524, 74);
			this.btnBrowseStartIn.Name = "btnBrowseStartIn";
			this.btnBrowseStartIn.Size = new System.Drawing.Size(28, 23);
			this.btnBrowseStartIn.TabIndex = 4;
			this.btnBrowseStartIn.Text = "...";
			this.btnBrowseStartIn.UseVisualStyleBackColor = true;
			this.btnBrowseStartIn.Click += new System.EventHandler(this.btnBrowseStartIn_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFile.Location = new System.Drawing.Point(524, 20);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
			this.btnOpenFile.TabIndex = 13;
			this.btnOpenFile.Text = "...";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 441);
			this.Controls.Add(this.lblWebURL);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.grpCurrentQueue);
			this.Controls.Add(this.grpAddJob);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(600, 460);
			this.Name = "frmMain";
			this.Text = "CmdQueue";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpAddJob.ResumeLayout(false);
			this.grpAddJob.PerformLayout();
			this.grpCurrentQueue.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cmbNewCommand;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstCurrentQueue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtStartIn;
		private System.Windows.Forms.GroupBox grpAddJob;
		private System.Windows.Forms.GroupBox grpCurrentQueue;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.LinkLabel lblWebURL;
		private System.Windows.Forms.Button btnBrowseStartIn;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

