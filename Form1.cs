using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitIntegration.Logic;

namespace GitIntegration
{
    public partial class Form1 : Form
    {
        GitRepository _gitRepo;
        public Form1()
        {
            InitializeComponent();
            _gitRepo = new GitRepository(@"C:\temp\Git\bin\git.exe");
        }

        private void button_GetBranches_Click(object sender, EventArgs e)
        {
            textBox_DestFolder.Text = String.Empty;            
            listBox_Branches.Items.Clear(); 

            List<GitBranch> branches = _gitRepo.getRemoteRepositoryBranches(textBox_RepoUrl.Text);
            listBox_Branches.Items.AddRange(branches.ToArray());
            listBox_Branches.DisplayMember = "Name";
        }

        private void button_Clone_Click(object sender, EventArgs e)
        {
            GitBranch selectedBranch = listBox_Branches.SelectedItem as GitBranch;
            _gitRepo.cloneRepositoryBranch(textBox_RepoUrl.Text, selectedBranch, textBox_DestFolder.Text);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearAll();            
        }

        private void clearAll()
        {
            textBox_DestFolder.Text = String.Empty;
            textBox_RepoUrl.Text = String.Empty;
            listBox_Branches.Items.Clear();
        }
    }
}
