﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven.Controller
{
    public class Event
    {
        public String Kommentar { get; set; }
        public String Datum { get; set; }

        public Event(string kommentar)
        {
            this.Kommentar = kommentar;
            this.Datum = DateTime.Now.ToString("MM/dd");
        }
        public string getKommentar()
        {
            return Kommentar;
        }
        public string getDatum() 
        {
            return Datum;
        }
    }
}
