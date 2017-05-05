using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountHw.Models.ViewModels
{
    public class AccountViewModel
    {
        public string Category { get; set; }
        public DateTime Date{ get; set; }
        public int Money { get; set; }
        public int Water { get; set; }
    }
}