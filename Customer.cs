using System.ComponentModel.DataAnnotations;

namespace EFCoreMigration
{
    public class Customer
    {
        public int CustomerID { get; set; }
        
        [StringLength(20)]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}