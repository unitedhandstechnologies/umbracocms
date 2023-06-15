using System.ComponentModel.DataAnnotations;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
    public class ContactForm
    {
        [Required]
        public string FullName { get; set;}
        [Required]
        public string LastName { get; set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}
        [Required]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set;}
        [Required]
        public string YourQuestion { get; set;}
    
    }

}