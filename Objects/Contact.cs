using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Contact
    {
        public Contact(string newName, int newPhoneNumber, Address newAddress)
        {
            _name = newName;
            _phoneNumber = newPhoneNumber;
            _address = newAddress;
            _id = _idCounter;
            _idCounter++;
        }

        private string _name;
        private int _phoneNumber;
        private Address _address;
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

        public void SetAddress(string newAddress)
        {
            _address = newAddress;
        }
        public string GetAddress()
        {
            return _address;
        }
    }
}
