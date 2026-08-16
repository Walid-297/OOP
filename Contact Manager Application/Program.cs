using Contact_Manager_Application.Models;

namespace Contact_Manager_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Address

            // address test
            Address address = new Address("60 street", "house", "Infront of the bank");
            string addressDetails = address.GetAddress();
            Console.WriteLine(addressDetails);

            // setters test
            address.SetPlace("101 street");
            address.SetType("Apartment");
            address.SetDescription("third floor");

            addressDetails = address.GetAddress();
            Console.WriteLine(addressDetails);
            // constructor override test
            Address address1 = new Address("70 street", "Apartment");
            addressDetails = address1.GetAddress();
            Console.WriteLine(addressDetails);

            #endregion

            #region Email
            // email test
            Email email = new Email("1368UserName@gmail.com","google mail","used for learning");
            string emailDetails = email.GetEmail();
            Console.WriteLine(emailDetails);

            // setters test
            email.SetEmail("34UserName@yahoo.com");
            email.SetType("yahoo email");
            email.SetDescription("used for communication");

            // constructor override test
            Email email1 = new Email("student@std.edu.com","university account");
            emailDetails = email1.GetEmail();
            Console.WriteLine(emailDetails);
            #endregion

            #region Phone
            // Phone test 
            Phone phone = new Phone("01059876451","Vodafone","used for calling");
            string phoneDetails = phone.GetPhone();
            Console.WriteLine(phoneDetails);

            // test setters
            phone.SetPhone("01154879636");
            phone.SetType("Etisalat");
            phone.SetDescription("used for internet");

            // constructor override test
            Phone phone1 = new Phone("01565498702","We");
            phoneDetails = phone1.GetPhone();
            Console.WriteLine(phoneDetails);
            #endregion

        }
    }
}
