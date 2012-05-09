using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitIntegration.Logic
{
    public class GitBranch
    {
        private string _name;
        
        public string Name
        {
            get{ return _name; }
            set { _name = value; }
        }

        public GitBranch(string name)
        {
            Name = name;
        }
    }
}
