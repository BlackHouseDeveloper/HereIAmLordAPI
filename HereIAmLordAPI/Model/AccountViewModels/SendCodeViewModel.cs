﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HereIAmLordAPIAccount.Model.AccountViewModels
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}
