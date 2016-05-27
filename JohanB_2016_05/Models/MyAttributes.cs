using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JohanB_2016_05.Models
{
    public class MyAttributes : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var input = value.ToString().ToLower();
            if (input.Contains("knife"))
            {
                return false;
            }
            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Bad bad, dont use knife";
        }

        //kom ej på hur regex syntaxen såg ut
        }
}