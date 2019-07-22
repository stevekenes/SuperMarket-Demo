using PandsMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Domain.ViewModels
{
    public class CreateCategoryViewModel
    {
        [Required]
        public Category Category { get; set; }
        public string Referer { get; set; }
    }
}
