namespace LibraryManagementSystem.Domain;
using System.Text.RegularExpressions;
public partial class Email
{
    // Intialize the email value
    private string _value = string.Empty; 

    public string Value
        {
            get => _value;
            set
            {
                if (MyRegex().IsMatch(value)) _value = value;
                else throw new InvalidDataException("Invalid email address");
            }
        }

        public Email(string value)
        {
            Value = value;
        }

        [GeneratedRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        private static partial Regex MyRegex();

}
