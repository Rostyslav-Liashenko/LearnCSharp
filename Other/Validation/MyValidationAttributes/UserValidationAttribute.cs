using System.ComponentModel.DataAnnotations;

namespace LearnValidation
{
    public class UserValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            User user = value as User;
            if (user.Name == "Alice" && user.Age == 33)
            {
                this.ErrorMessage = "Name must not Alice and age = 33";
                return false;
            }

            return true;
        }
    }
}
