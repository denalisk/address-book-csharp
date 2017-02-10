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
    }
}
