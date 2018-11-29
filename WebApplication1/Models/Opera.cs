using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Opera
    {
        [Required]
        public int OperaId { get; set; }


        [StringLength(200, ErrorMessage ="No debe superar los 200 caracteres")]
        public string Title { get; set; }

        [Required, CheckValidYear]
        public int Year { get; set; }


        public string Composer { get; set; }
    }

    public class CheckValidYear : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public CheckValidYear()  //Constructor
        {
            ErrorMessage = "The earliest opera is Daphne, 1598, by Corsi, Peri, and Rinuccini";
        }
    }

}