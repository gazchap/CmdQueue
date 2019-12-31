namespace CmdQueue
{
	partial class frmJobDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobDetails));
			this.grpAddJob = new System.Windows.Forms.GroupBox();
			this.lblArguments = new System.Windows.Forms.Label();
			this.txtArguments = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStartIn = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnBrowseStartIn = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.grpAddJob.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpAddJob
			// 
			this.grpAddJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpAddJob.Controls.Add(this.btnOpenFile);
			this.grpAddJob.Controls.Add(this.btnBrowseStartIn);
			this.grpAddJob.Controls.Add(this.btnCancel);
			this.grpAddJob.Controls.Add(this.txtCommand);
			this.grpAddJob.Controls.Add(this.lblArguments);
			this.grpAddJob.Controls.Add(this.txtArguments);
			this.grpAddJob.Controls.Add(this.label3);
			this.grpAddJob.Controls.Add(this.txtStartIn);
			this.grpAddJob.Controls.Add(this.label2);
			this.grpAddJob.Controls.Add(this.label1);
			this.grpAddJob.Controls.Add(this.txtName);
			this.grpAddJob.Controls.Add(this.btnSave);
			this.grpAddJob.Location = new System.Drawing.Point(12, 12);
			this.grpAddJob.Name = "grpAddJob";
			this.grpAddJob.Size = new System.Drawing.Size(521, 161);
			this.grpAddJob.TabIndex = 14;
			this.grpAddJob.TabStop = false;
			this.grpAddJob.Text = "Edit Job";
			// 
			// lblArguments
			// 
			this.lblArguments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArguments.Location = new System.Drawing.Point(7, 48);
			this.lblArguments.Name = "lblArguments";
			this.lblArguments.Size = new System.Drawing.Size(112, 23);
			this.lblArguments.TabIndex = 14;
			this.lblArguments.Text = "Arguments";
			this.lblArguments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtArguments
			// 
			this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArguments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArguments.Location = new System.Drawing.Point(126, 48);
			this.txtArguments.Name = "txtArguments";
			this.txtArguments.Size = new System.Drawing.Size(386, 21);
			this.txtArguments.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 102);
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
			this.txtStartIn.Location = new System.Drawing.Point(126, 102);
			this.txtStartIn.Name = "txtStartIn";
			this.txtStartIn.Size = new System.Drawing.Size(352, 21);
			this.txtStartIn.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Description (optional)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(126, 75);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(386, 21);
			this.txtName.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(328, 129);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(89, 23);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtCommand
			// 
			this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCommand.Location = new System.Drawing.Point(126, 21);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(352, 21);
			this.txtCommand.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(423, 129);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 23);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnBrowseStartIn
			// 
			this.btnBrowseStartIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseStartIn.Location = new System.Drawing.Point(484, 101);
			this.btnBrowseStartIn.Name = "btnBrowseStartIn";
			this.btnBrowseStartIn.Size = new System.Drawing.Size(28, 23);
			this.btnBrowseStartIn.TabIndex = 5;
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
			this.btnOpenFile.Location = new System.Drawing.Point(484, 20);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
			this.btnOpenFile.TabIndex = 22;
			this.btnOpenFile.Text = "...";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// frmJobDetails
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(545, 186);
			this.Controls.Add(this.grpAddJob);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 225);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 225);
			this.Name = "frmJobDetails";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Job Details";
			this.TopMost = true;
			this.grpAddJob.ResumeLayout(false);
			this.grpAddJob.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpAddJob;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtStartIn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblArguments;
		private System.Windows.Forms.TextBox txtArguments;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnBrowseStartIn;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btnOpenFile;
	}
}