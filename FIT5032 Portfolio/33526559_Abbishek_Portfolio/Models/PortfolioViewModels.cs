using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _33526559_Abbishek_Portfolio.Models
{
    public class PortfolioViewModels
    {
    }
    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "name")]
        public string name { get; set; }
    }
}