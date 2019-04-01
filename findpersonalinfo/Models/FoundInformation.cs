using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace findpersonalinfo.Models
{
    public class FoundInformation
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(200)]
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "nvarchar")]
        public string Password { get; set; }

        [DataType(DataType.Url)]
        [StringLength(2000)]
        [Column(TypeName = "nvarchar")]
        public string Website { get; set; }

        [StringLength(10)]
        [Column(TypeName = "nvarchar")]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Display(Name = "Account Creation Date")]
        public string AccountCreationDate { get; set; }

        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string IP { get; set; }
    }
}