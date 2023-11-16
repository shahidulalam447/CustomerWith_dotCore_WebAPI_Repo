using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models
{
    public class CustomerAddress
    {
        public int ID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        [Column(name:"Customer Address",TypeName ="NVARCHAR(500)")]
        public string Address { get; set; }

        //nev
        public Customer Customer { get; set; }
    }
}
