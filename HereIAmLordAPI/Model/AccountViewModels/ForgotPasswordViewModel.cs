using System.ComponentModel.DataAnnotations;


namespace HereIAmLordAPIAccount.Model.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
