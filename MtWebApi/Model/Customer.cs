using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtWebApi.Model
{
    public class Customer
    {
        public int id { get; set; }
        public string account_title { get; set; }
        public string adress { get; set; }
        public string account_type { get; set; }
        public string contact_person { get; set; }
        public sbyte ispersonel { get; set; }
        
    }
}
