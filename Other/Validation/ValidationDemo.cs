using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnValidation
{
    static class ValidationDemo
    {
        static void Main()
        {
            Console.WriteLine("Input the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            User user = new User {Name = name, Age = age};
            var result = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, result, true))
                foreach (var error in result)
                    Console.WriteLine(error.ErrorMessage);
        }
    }
}
