using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Address
    {
        public Address(string newStreetAddress, string newCity, string newState)
        {
            _streetAddress = newStreetAddress;
            _city = newCity;
            _state = newState;
        }

        private string _streetAddress;
        private string _city;
        private string _state;

        public void SetStreetAddress(string newStreetAddress)
        {
            _streetAddress = newStreetAddress;
        }
        public string GetStreetAddress()
        {
            return _streetAddress;
        }

        public void SetCity(string newCity)
        {
            _city = newCity;
        }
        public string GetCity()
        {
            return _city;
        }

        public void SetState(string newState)
        {
            _state = newState;
        }
        public string GetState()
        {
            return _state;
        }


    }
}
