using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Task14
{
    public class Person
    {
        [RegexEquals("^[A-Z][a-z]+$")]
        public string Name { get; set; }

        [RegexEquals("^[0-9]{1,2}$")]
        public int Age { get; set; } 

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public bool IsValid()
        {
            Type item = this.GetType();

            PropertyInfo[] properties = item.GetProperties(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);

            foreach (PropertyInfo property in properties)
            {
                foreach (var attr in property.GetCustomAttributes(false))
                {
                    var temp = attr as ValidationAttribute;
                    if (temp != null)
                    {
                        if (!temp.IsValid(property.GetValue(this)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
