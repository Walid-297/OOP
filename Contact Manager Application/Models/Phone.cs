using System.Numerics;

namespace Contact_Manager_Application.Models
{
    public class Phone
    {
        private string _phone;
        private string _type;
        private string _description;

        public Phone(string phone, string type, string description)
        {
            SetPhone(phone);
            SetType(type);
            SetDescription(description);
        }
        public Phone(string phone, string type) : this(phone, type, string.Empty)
        {

        }
        public void SetPhone(string phone)
        {
            _phone = PhoneValidation(phone);
        }
        public void SetType(string type)
        {
            _type = StringValidation(type);
        }
        public void SetDescription(string description)
        {
            _description = description ?? String.Empty;
        }
        public string GetPhone()
        {
            if (string.IsNullOrWhiteSpace(_description))
            {
                return $"Phone: {_phone}, Type: {_type}";
            }

            return $"Phone: {_phone} ,type: {_type} ,description: {_description}";
        }
        private string StringValidation(string stringToBeValidate)
        {
            if (string.IsNullOrWhiteSpace(stringToBeValidate))
            {
                throw new ArgumentException("Value cannot be null or empty");
            }
            else
            {
                return stringToBeValidate;
            }
        }
        private string PhoneValidation(string phoneToBeValidate)
        {
            if (string.IsNullOrWhiteSpace(phoneToBeValidate) || phoneToBeValidate.Length > 11 || !int.TryParse(phoneToBeValidate, out _)) // out_ -> discard // !phoneToBeValidate.All(char.IsDigit))
            {
                throw new ArgumentException("invalid phone number");
            }
            return phoneToBeValidate;
        }
    }
}
