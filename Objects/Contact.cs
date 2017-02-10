using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Contact
    {
        public Contact(string newName, string newPhoneNumber, Address newAddress, string newEmail)
        {
            _name = newName;
            _phoneNumber = newPhoneNumber;
            _address = newAddress;
            _email = newEmail;
            _id = _idCounter;
            _idCounter++;
        }

        private string _name;
        private string _phoneNumber;
        private Address _address;
        private string _email;
        private int _id;
        private static int _idCounter = 1;

        public void SetName(string newName)
        {
            _name = newName;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetPhoneNumber(string newPhoneNumber)
        {
            _phoneNumber = newPhoneNumber;
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public void SetAddress(Address newAddress)
        {
            _address = newAddress;
        }
        public Address GetAddress()
        {
            return _address;
        }

        public void SetEmail(string newEmail)
        {
            _email = newEmail;
        }
        public string GetEmail()
        {
            return _email;
        }

        public void SetId(int newId)
        {
            _id = newId;
        }
        public int GetId()
        {
            return _id;
        }
    }
}
