using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnValidation
{
    static class ValidationDemo
    {
        
        private static void Validate(User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
                foreach (var error in results)
                    Console.WriteLine(error.ErrorMessage);
        }
        
        static void Main()
        {
            User user1 = new User { Id="", Name = "Tom", Age = -22};
            Validate(user1);
            Console.WriteLine();
            User user2 = new User { Id = "d3io", Name = "Alice", Age = 33 };
            Validate(user2);
        }
    }
}
