using System.ComponentModel.DataAnnotations;

namespace WisejWebPageApplication1
{
    public class Organization
    {
        [Key]
        [Required]
        public int OrgID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int? Zip { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
