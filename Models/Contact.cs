using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
		{
			private string _name;
			private string _phone;
			private string _email;
			public int _id;

			public Address _address;

			private static List<Contact> _instances = new List<Contact> {};

			public Contact (string name, string phone, string email)
			{
				_name = name;
				_phone = phone;
				_email = email;
				_instances.Add(this);
				_id = _instances.Count;
			}

			public static List<Contact> GetAll()
			{
				return _instances;
			}
			public string GetName()
			{
				return _name;
			}
			public string GetPhone()
			{
				return _phone;
			}
			public string GetEmail()
			{
				return _email;
			}
			public int GetId()
			{
				return _id;
			}
			public Address GetAddress()
			{
				return _address;
			}

			public void SetName(string newName)
			{
				_name = newName;
			}
			public void SetPhone(string newPhone)
			{
				_phone = newPhone;
			}
			public void SetEmail(string newEmail)
			{
				_email = newEmail;
			}
			public void SetAddress(Address newAddress)
			{
				_address = newAddress;
			}

			public static void ClearAll()
			{
				_instances.Clear();
			}
			public static Contact Find(int searchId)
			{
				return _instances[searchId-1];
			}

		}
}
