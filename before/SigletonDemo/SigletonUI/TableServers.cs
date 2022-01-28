using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigletonUI
{
    public class TableServers
    {
        private List<string> _servers = new List<string>();
        private int nextServer = 0;

        public TableServers()
        {
            _servers.Add("Tim");
            _servers.Add("Sue");
            _servers.Add("Mary");
            _servers.Add("Bob");
        }

        public string GetNextServer()
        {
            string output = _servers[nextServer];

            nextServer++;

            if (nextServer >= _servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}
