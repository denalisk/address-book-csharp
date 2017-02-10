using System.Collections.Generic;
using System;

namespace AddressBook.Objects
{
    public class Book
    {
        private static List<Contact> _contactList = new List<Contact> {};
        private static Dictionary<int, Contact> _contactDictionary = new Dictionary<int, Contact>() {};

        public static List<Contact> NameSearch(string query)
        {
            List<Contact> results = new List<Contact> {};
            for (int index = 0; index < _contactList.Count; index++)
            {
                if (_contactList[index].GetName().ToLower().Contains(query.ToLower()))
                {
                    results.Add(_contactList[index]);
                }
            }
            results.Sort((x, y) => x.GetName().CompareTo(y.GetName()));
            return results;
        }

        public static void SaveContact(Contact newContact)
        {
            _contactList.Add(newContact);
            _contactList.Sort((x, y) => x.GetName().CompareTo(y.GetName()));
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

        public static List<Contact> GetContactList()
        {
            return _contactList;
        }
        public static Dictionary<int, Contact> GetContactDictionary()
        {
            return _contactDictionary;
        }
        public static void ClearContacts()
        {
            _contactDictionary.Clear();
            _contactList.Clear();
        }


    }
}
