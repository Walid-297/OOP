namespace Contact_Manager_Application.Models
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private Gender _gender;
        private string _city;
        private DateTime _addedDate;

        // references , created lists of class type that holds references
        private List<Address> _addresses;
        private List<Email> _emails;
        private List<Phone> _phones;

        public int ID => _id;

        public User(int id, string firstName, string lastName, Gender gender, string city)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
            _city = city;
            _addedDate = DateTime.Now;

            // objects , made the references point to a list of objects ,
            // why not creating the lists in one go 
            _addresses = new List<Address>();
            _emails = new List<Email>();
            _phones = new List<Phone>();
        }


        public void AddAddress(Address address)
        {
            _addresses.Add(address); // adding element to the list 
        }
        public void EditAddress(int index, Address newAddress)
        {
            if (!IsValidIndex(index, _addresses))
            {
                throw new ArgumentOutOfRangeException("Invalid Address index");
            }
            _addresses[index] = newAddress; // so the old object will be deleted as there is no ref pointing to it 
            // as it says , the reference at index[] point to the new object passed by the user
        }
        public void DeleteAddress(int index)
        {
            if (!IsValidIndex(index, _addresses))
            {
                throw new ArgumentOutOfRangeException("Invalid Address index");
            }
            _addresses.RemoveAt(index); // remove element from the list
        }


        public void AddEmail(Email email)
        {
            _emails.Add(email);
        }
        public void EditEmail(int index, Email newEmail)
        {
            if (!IsValidIndex(index, _emails))
            {
                throw new ArgumentOutOfRangeException(" index");

            }
            _emails[index] = newEmail;
        }
        public void DeleteEmail(int index)
        {
            if (!IsValidIndex(index, _emails))
            {
                throw new ArgumentOutOfRangeException("index");

            }
            _emails.RemoveAt(index);
        }


        public void AddPhone(Phone phone)
        {
            _phones.Add(phone);
        }
        public void EditPhone(int index, Phone NewPhone)
        {
            if (!IsValidIndex(index, _phones))
            {
                throw new ArgumentOutOfRangeException(" index");
            }
            _phones[index] = NewPhone;
        }
        public void DeletePhone(int index)
        {
            if (!IsValidIndex(index, _phones))
            {
                throw new ArgumentOutOfRangeException(" index");
            }
            _phones.RemoveAt(index);
        }

        private bool IsValidIndex<T>(int index, List<T> list)
        {
            return index >= 0 && index < list.Count;
        }
        // from here , Ask
        public int Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return 0;

            // Perform case-insensitive check
            bool isMatch = _firstName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                           _lastName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                           _city.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                           _addresses.Any(a => a.GetAddress().Contains(query, StringComparison.OrdinalIgnoreCase)) ||
                           _emails.Any(e => e.GetEmail().Contains(query, StringComparison.OrdinalIgnoreCase)) ||
                           _phones.Any(p => p.GetPhone().Contains(query, StringComparison.OrdinalIgnoreCase));

            return isMatch ? 1 : 0; // Returns 1 if found, 0 if not
        }

        public string ShowInfo()
        {
            // using StringBuilder is much better
            string info =
                         $"Id: {_id}" +
                         $"Name: {_firstName} {_lastName}" +
                         $"Gender: {_gender}" +
                         $"City: {_city}" +
                         $"Added date:{_addedDate}";

            info += "--- Addresses ---\n";
            if (_addresses.Count == 0)
            {
                info += "No addresses added.\n";
            }
            else
            {
                for (int i = 0; i <= _addresses.Count; i++)
                {
                    info += $"{_addresses[i].GetAddress()}\n";
                }
            }

            info += "\n--- Emails ---\n";
            if (_emails.Count == 0)
            {
                info += "No emails added.\n";
            }
            else
            {
                for (int i = 0; i < _emails.Count; i++)
                {
                    info += $"[{i}] {_emails[i].GetEmail()}\n";
                }
            }

            info += "\n--- Phones ---\n";
            if (_phones.Count == 0)
            {
                info += "No phones added.\n";
            }
            else
            {
                for (int i = 0; i < _phones.Count; i++)
                {
                    info += $"[{i}] {_phones[i].GetPhone()}\n";
                }
            }

            return info;
        }
    }
}
