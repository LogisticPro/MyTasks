using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Task14
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class RegexEqualsAttribute : ValidationAttribute
    {
        private string _regularExpression { get; set; }
        public RegexEqualsAttribute(string regulaxExpression)
        {
            _regularExpression = regulaxExpression;
        }

        public override bool IsValid(object value)
        {
            Regex regex = new Regex(_regularExpression);

            var matchResult = regex.Match(value.ToString());

            if (matchResult.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
