using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GitIntegration.Logic
{
    public class GitRepository
    {
        private string _gitExePath;

        public GitRepository(string gitExePath)
        {
            _gitExePath = gitExePath;
        }


        public List<GitBranch> getRemoteRepositoryBranches(string url)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = _gitExePath;
                p.StartInfo.Arguments = "ls-remote --heads " + url;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();

                // parse output
                string[] branchLines = output.Split('\n');
                List<GitBranch> branches = new List<GitBranch>();

                foreach (string line in branchLines)
                {
                    if (line.IndexOf(Path.AltDirectorySeparatorChar) > 0)
                    {
                        string branchName = line.Substring(line.LastIndexOf(Path.AltDirectorySeparatorChar) + 1);
                        branches.Add(new GitBranch(branchName));
                    }
                }


                return branches;
            }
            finally 
            {
                Cursor.Current = current;
            }
        }

        public void cloneRepositoryBranch(string url,GitBranch branch, string localPath)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = _gitExePath;
                p.StartInfo.Arguments = "clone -b " + branch.Name + " " + url + " " + localPath;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                p.WaitForExit();
            }
            finally
            {
                Cursor.Current = current;
            }
        }
    }
}
