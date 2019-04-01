using System.ComponentModel.DataAnnotations;

namespace findpersonalinfo.Models
{
    public class Search
    {

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string SearchTerm { get; set; }

    }
}