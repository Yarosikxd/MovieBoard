using MovieApp.Date.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = " Profile Picture URL")]
        [Required(ErrorMessage = "Profile picture is require")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = " Full Name")]
        [Required(ErrorMessage = "Full name is require")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name mast be beetwen 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = " Bio")]
        [Required(ErrorMessage = "Bio is require")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
