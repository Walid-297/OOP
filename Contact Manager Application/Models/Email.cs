using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager_Application.Models
{
    public class Email
    {
        private string _email;
        private string _type;
        private string _description;

        public Email(string email, string type, string descrtiption)
        {
            SetEmail(email);
            SetType(type);
            SetDescription(descrtiption);
        }
        public Email(string email, string type) : this(email, type, string.Empty)
        {

        }
        public void SetEmail(string email)
        {
            _email = EmailValidation(email);
        }
        public void SetType(string type)
        {
            _type = StringValidation(type);
        }
        public void SetDescription(string description)
        {
            _description = description ?? string.Empty; // more explain
        }
        public string GetEmail()
        {
            if (string.IsNullOrWhiteSpace(_description))
            {
                return $"Place: {_email}, Type: {_type}";
            }

            return $"email: {_email} ,type: {_type} ,description: {_description}";
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
        private string EmailValidation(string emailToBeValidate)
        {
            StringValidation(emailToBeValidate);

            if (!emailToBeValidate.Contains("@") || !emailToBeValidate.Contains("."))
            {
                throw new ArgumentException("Invalid email format.");
            }

            return emailToBeValidate;

        }
    }
}
