using System.ComponentModel.DataAnnotations;

namespace LearnValidation
{
    public class UserNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string userName = value.ToString();
                if (!userName.StartsWith("T"))
                    return true;
                else
                    this.ErrorMessage = "the name must not start with the letter T";
            }
            return false;

        }
    }
}
