using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven.Controller
{
    public class Crime
    {
        public Int32 CrimeType { get; set; }
        public Int32 Date { get; set; }
        public String Location { get; set; }
        public String CallerName { get; set; }
        public String CallerAddress { get; set; }
        public Int32 CallerNumber { get; set; }

        public Crime(int crimeType,
            int date,
            string location,
            string callerName,
            string callerAddress,
            int callerNumber)
        {
            this.Date = date;
            this.Location = location;
            this.CallerName = callerName;
            this.CallerAddress = callerAddress;
            this.CallerNumber = callerNumber;
        }
    }
}
