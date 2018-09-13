using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MtWebApi.Model
{
    public class User //veritabnında hangi tablodan veri cekeceksek o tablonun modellemesini burada yapıyoruz.
    {
        public int id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
    }
}
