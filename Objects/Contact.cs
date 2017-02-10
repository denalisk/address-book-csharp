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

        public void SetPhoneNumber(int newPhoneNumber)
        {
            _phoneNumber = newPhoneNumber;
        }
        public int GetPhoneNumber()
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
