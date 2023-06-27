using MovieApp.Date.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Logo picture is require")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Full name is require")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name mast be beetwen 3 and 50 chars")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        [Required(ErrorMessage = "Description is require")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
