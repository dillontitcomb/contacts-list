using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
		{
			private string _name;
			private int _phone;
			private string _email;
			public int _id;

			private static List<Contact> _instances = new List<Contact> {};

			public Contact (string name, int phone, string email)
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
			public int GetPhone()
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

			public void SetName(string newName)
			{
				_name = newName;
			}
			public void SetPhone(int newPhone)
			{
				_phone = newPhone;
			}
			public void SetEmail(string newEmail)
			{
				_email = newEmail;
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
