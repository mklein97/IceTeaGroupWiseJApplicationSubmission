using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WisejWebPageApplication1
{
    public class Staff
    {
        [Key]
        [Required]
        public int StaffID { get; set; }
        [Key]
        [Required]
        public int OrgID { get; set; }
        [Required]
        public string Title { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }
        [DisplayName("Email Address")]
        [Required]
        public string EmailAddress { get; set; }
    }
}
