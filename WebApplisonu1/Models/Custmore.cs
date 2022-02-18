using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplisonu1.Models
{
    public class Custmore
    {
        [Key]
        public int id { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage ="First Name Accept only Latters !" )]
        [MinLength(3,ErrorMessage = "First name must be min 3 char ! ")]
        public string firstname {get;set;}
        [Required]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Last Name Accept only Latters !")]
        [MinLength(2, ErrorMessage = "last name must be min 2 char ! ")]
        public string lastname { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email is not valid !")]
        public string email { get; set; }
        [Required]
        public int mobile { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Address must be min 10 char !")]
        [MaxLength(200, ErrorMessage = "Address must be max 200 char !")]
        public string address { get; set; }
        [Required]
        public int Dob { get; set; }
        [Required]
       // [MinLength(1000,ErrorMessage ="Amount must be min 1000 char !")]
        //[mi(5000,ErrorMessage ="Amount must be max 5000 char !")]
        public int amount { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string gender { get; set; }

    }
}
