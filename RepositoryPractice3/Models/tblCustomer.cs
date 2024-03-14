using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice3.Models
{
    public class tblCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
