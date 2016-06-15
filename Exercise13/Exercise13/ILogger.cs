using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    interface ILogger
    {
        public List<string> LogPosts { get; private set; }
        public void Log(string message)
        {
            LogPosts.Add(message);
        }
    }
}
