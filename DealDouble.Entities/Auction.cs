using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Entities
{
   public  class Auction
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public Decimal CurrentPrice { get; set; }
      
    }

}
