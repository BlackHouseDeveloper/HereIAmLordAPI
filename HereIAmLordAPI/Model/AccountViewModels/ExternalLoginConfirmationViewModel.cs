using System;
using System.ComponentModel.DataAnnotations;

namespace HereIAmLordAPIAccount.Model.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
