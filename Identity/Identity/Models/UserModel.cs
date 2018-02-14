using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public string Complete { get; set; }
        public string Incomplete { get; set; }
        public string SetReminder { get; set; }

    }
}
