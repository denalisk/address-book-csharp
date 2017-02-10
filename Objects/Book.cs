using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Book
    {
        private static List<Contact> _contactList = new List<Contact> {};
        private static Dictionary<string, Contact> _contactDictionary = new Dictionary<string, Contact>() {};

        public static void SaveContact(Contact newContact)
        {
            _contactList.Add(newContact);
            _contactDictionary[newContact.GetName()] = newContact;
        }
        public static void DeleteContact(Contact newContact)
        {
            bool success;
            for (int index = 0; index < _contactList.Count; index++)
            {
                if (_contactList[index].GetId() == newContact.GetId())
                {

                }
            }
        }

    }
}
