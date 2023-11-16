using System.ComponentModel.DataAnnotations.Schema;

namespace CIMS.Models
{
    public class Country
    {
        public int ID { get; set; }
        [Column(TypeName ="NVARCHAR(50)")]
        public string CountryName { get; set; }
        public List<Customer> Customers { get; set; }
    }

}