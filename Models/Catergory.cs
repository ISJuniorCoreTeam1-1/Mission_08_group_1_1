using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_08_group_1_1.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CatergoryId { get; set; }
        public string CatergoryName { get; set; }
    }
}