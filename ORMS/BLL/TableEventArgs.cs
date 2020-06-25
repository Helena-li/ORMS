using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.BLL
{
    // event args
    public class TableEventArgs:System.EventArgs
    {
        private string tableStatus;

        public string TableStatus
        {
            get { return tableStatus; }
        }
        private string tableID;

        public string TableID
        {
            get { return tableID; }
        }

        public TableEventArgs(string id, string status)
        {
            this.tableID = id;
            this.tableStatus = status;
        }
    }
}
