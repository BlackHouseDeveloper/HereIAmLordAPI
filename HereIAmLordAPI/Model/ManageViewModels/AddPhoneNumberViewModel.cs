using System;
using System.ComponentModel.DataAnnotations;

namespace HereIAmLordAPIAccount.Model.ManageViewModels
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
