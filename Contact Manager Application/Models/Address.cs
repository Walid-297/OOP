namespace Contact_Manager_Application.Models
{
    public class Address
    {
        private string _Place;
        private string _Type;
        private string _Description;
        public Address(string place, string type, string description)
        {
            SetPlace(place);
            SetType(type);
            SetDescription(description);
        }
        public Address(string place, string type) : this(place, type, string.Empty)
        {

        }

        public void SetPlace(string place)
        {
            _Place = StringValidation(place);

            
        }
        public void SetType(string type)
        {
            _Type = StringValidation(type);

        }
        public void SetDescription(string description)
        {
            _Description = description ?? String.Empty;

        }
        public string GetAddress()
        {
            if (string.IsNullOrWhiteSpace(_Description))
            {
                return $"Place: {_Place}, Type: {_Type}";
            }

            return $"place: {_Place} ,type: {_Type} ,description: {_Description}";
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
    }
}
