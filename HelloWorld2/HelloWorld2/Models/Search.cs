using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2.Models
{
    class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Dates
        {
            get
            {
                return string.Format($"{CheckIn.ToString()} - {CheckOut.ToString()}");
            }
        }
    }
}
