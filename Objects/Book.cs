using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Book
    {
        private static List<Contact> _contactList = new List<Contact> {};
        private static Dictionary<int, Contact> _contactDictionary = new Dictionary<int, Contact>() {};

        public static void SaveContact(Contact newContact)
        {
            _contactList.Add(newContact);
            _contactDictionary[newContact.GetId()] = newContact;
        }
        public static bool DeleteContact(Contact newContact)
        {
            bool success_list = false;
            bool success_dictionary = false;
            for (int index = 0; index < _contactList.Count; index++)
            {
                if (_contactList[index].GetId() == newContact.GetId())
                {
                    _contactList.RemoveAt(index);
                    success_list = true;
                    break;
                }
            }
            if (_contactDictionary.ContainsKey(newContact.GetId()))
            {
                _contactDictionary.Remove(newContact.GetId());
                success_dictionary = true;
            }
            return (success_dictionary && success_list);
        }
        public static Contact GetContact(int contactId)
        {
            return _contactDictionary[contactId];
        }

    }
}
