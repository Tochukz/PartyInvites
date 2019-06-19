using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please eneter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please eneter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Pleasse eneter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you will attend")]
        public bool? WillAttend { get; set; }
    }
}
