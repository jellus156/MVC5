using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.ComponentModel.DataAnnotations;

namespace MVC5.Models
{
    public class OddAttribute : ValidationAttribute
    {
        public OddAttribute()
            : base("Odd")
        {

        }

        //public override bool IsValid (object value)
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if (int.Parse(value.ToString()) % 2 == 0)
                {
                    return ValidationResult.Success;
                }
            }
            catch
            {

            }

            string sErrorMsg = "必須為偶數!!!!";

            if (String.IsNullOrEmpty(ErrorMessage))
            {
                ErrorMessage = validationContext.DisplayName + sErrorMsg;
            }

            return new ValidationResult(ErrorMessage);
            /*try
            {
                int n;
                if (int.TryParse(value.ToString(), out n))
                {
                    if (n % 2 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }*/
        }
    }
}
            
