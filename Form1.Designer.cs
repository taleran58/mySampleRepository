namespace GitIntegration
{
    partial class Form1
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
            this.listBox_Branches = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RepoUrl = new System.Windows.Forms.TextBox();
            this.button_GetBranches = new System.Windows.Forms.Button();
            this.button_Clone = new System.Windows.Forms.Button();
            this.textBox_DestFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_DestBrowse = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Branches
            // 
            this.listBox_Branches.FormattingEnabled = true;
            this.listBox_Branches.Location = new System.Drawing.Point(12, 86);
            this.listBox_Branches.Name = "listBox_Branches";
            this.listBox_Branches.Size = new System.Drawing.Size(444, 264);
            this.listBox_Branches.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Git Repo Url:";
            // 
            // textBox_RepoUrl
            // 
            this.textBox_RepoUrl.Location = new System.Drawing.Point(86, 17);
            this.textBox_RepoUrl.Name = "textBox_RepoUrl";
            this.textBox_RepoUrl.Size = new System.Drawing.Size(370, 20);
            this.textBox_RepoUrl.TabIndex = 3;
            // 
            // button_GetBranches
            // 
            this.button_GetBranches.Location = new System.Drawing.Point(353, 43);
            this.button_GetBranches.Name = "button_GetBranches";
            this.button_GetBranches.Size = new System.Drawing.Size(103, 23);
            this.button_GetBranches.TabIndex = 4;
            this.button_GetBranches.Text = "Get Branches";
            this.button_GetBranches.UseVisualStyleBackColor = true;
            this.button_GetBranches.Click += new System.EventHandler(this.button_GetBranches_Click);
            // 
            // button_Clone
            // 
            this.button_Clone.Location = new System.Drawing.Point(381, 424);
            this.button_Clone.Name = "button_Clone";
            this.button_Clone.Size = new System.Drawing.Size(75, 23);
            this.button_Clone.TabIndex = 5;
            this.button_Clone.Text = "Clone Repo";
            this.button_Clone.UseVisualStyleBackColor = true;
            this.button_Clone.Click += new System.EventHandler(this.button_Clone_Click);
            // 
            // textBox_DestFolder
            // 
            this.textBox_DestFolder.Location = new System.Drawing.Point(86, 372);
            this.textBox_DestFolder.Name = "textBox_DestFolder";
            this.textBox_DestFolder.Size = new System.Drawing.Size(289, 20);
            this.textBox_DestFolder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dest Folder:";
            // 
            // button_DestBrowse
            // 
            this.button_DestBrowse.Location = new System.Drawing.Point(381, 370);
            this.button_DestBrowse.Name = "button_DestBrowse";
            this.button_DestBrowse.Size = new System.Drawing.Size(75, 23);
            this.button_DestBrowse.TabIndex = 8;
            this.button_DestBrowse.Text = "(...)";
            this.button_DestBrowse.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(300, 424);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear All";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 468);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_DestBrowse);
            this.Controls.Add(this.textBox_DestFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Clone);
            this.Controls.Add(this.button_GetBranches);
            this.Controls.Add(this.textBox_RepoUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Branches);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Branches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_RepoUrl;
        private System.Windows.Forms.Button button_GetBranches;
        private System.Windows.Forms.Button button_Clone;
        private System.Windows.Forms.TextBox textBox_DestFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_DestBrowse;
        private System.Windows.Forms.Button button_Clear;
    }
}

