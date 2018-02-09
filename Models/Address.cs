using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Address
		{
			private string _street;
			private string _city;
			private string _state;
			private int _zip;

			public Address (string street, string city, string state, int zip)
			{
				_street = street;
				_city = city;
				_state = state;
				_zip = zip;
			}

			public string GetStreet()
			{
				return _street;
			}
			public string GetCity()
			{
				return _city;
			}
			public string GetState()
			{
				return _state;
			}
			public int GetZip()
			{
				return _zip;
			}

			public void SetStreet(string newStreet)
			{
				_street = newStreet;
			}
			public void SetCity(string newCity)
			{
				_city = newCity;
			}
			public void SetState(string newState)
			{
				_state = newState;
			}
			public void SetZip(int newZip)
			{
				_zip = newZip;
			}

		}

}
