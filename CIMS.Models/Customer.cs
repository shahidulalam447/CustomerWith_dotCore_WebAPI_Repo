using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string CustomerName { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string FatherName { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string MotherName { get; set; }
        public int MaritalStatus { get; set; }
        [Column(TypeName = "VARBINARY(MAX)")]
        public byte[] CustomerPhoto { get; set; }
        //nev
        public Country Country { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; }
    }

}
