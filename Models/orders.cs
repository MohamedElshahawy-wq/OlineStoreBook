using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeOnlineBook.Models
{
    public class orders
    {
        public int Id { get; set; }
        public int bookId { get; set; }
        public int userid { get; set; }
        public int quantity { get; set; }
        public DateTime orderdate { get; set; }

    }
}
