using System.Text.RegularExpressions;

namespace LibraryManagementSystem.Domain;

public partial class ISBN
{

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

        public ISBN(string value)
        {
            Value = value;
        }

        [GeneratedRegex(@"^(?:\d{9}[\dX]|\d{13})$")]
        private static partial Regex MyRegex();

}
