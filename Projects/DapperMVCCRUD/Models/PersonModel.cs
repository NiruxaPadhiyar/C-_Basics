
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperMVCCRUD.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }

        [Required(ErrorMessage =" First Name required !!")]
        [Display(Name = "First Name")]

        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = " Email Address required !!")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage ="Enter a valid email address!")]
        public string EmailID { get; set; }
        public string Gender { get; set; }

        public int AddressID { get; set; }





    }
}