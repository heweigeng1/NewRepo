using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNodify
{
    public static class TaskHelper
    {
        public static string TaskPost(Func<string[], int,string> action, string[] line, int tasknum)
        {
            return action(line, tasknum);
        }
    }
}
