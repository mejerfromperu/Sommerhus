using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Model

{

    public class User

    {

        // Instans 

        private int _id;

        private string _firstName;

        private string _lastName;

        private string _email;

        private string _password;

        private string _phone;

        private string _streetName;

        private string _houseNumber;

        private string _floor;

        private string _city;

        private int _postalCode;

        private bool _isLandlord;

        private bool _isAdmin;



        // Properties 

        public int Id

        {

            get { return _id; }

            set { _id = value; }

        }



        public string FirstName

        {

            get { return _firstName; }

            set { _firstName = value; }

        }



        public string LastName

        {

            get { return _lastName; }

            set { _lastName = value; }

        }



        public string Email

        {

            get { return _email; }

            set { _email = value; }

        }



        public string Password

        {

            get { return _password; }

            set { _password = value; }

        }



        public string Phone

        {

            get { return _phone; }

            set { _phone = value; }

        }



        public string StreetName

        {

            get { return _streetName; }

            set { _streetName = value; }

        }



        public string HouseNumber

        {

            get { return _houseNumber; }

            set { _houseNumber = value; }

        }



        public string Floor

        {

            get { return _floor; }

            set { _floor = value; }

        }



        public string City

        {

            get { return _city; }

            set { _city = value; }

        }



        public int PostalCode

        {

            get { return _postalCode; }

            set { _postalCode = value; }

        }



        public bool IsLandlord

        {

            get { return _isLandlord; }

            set { _isLandlord = value; }

        }

        public bool IsAdmin

        {

            get { return _isAdmin; }

            set { _isAdmin = value; }

        }


        // Constructor 

        public User()

        {

            Id = 0;

            FirstName = string.Empty;

            LastName = string.Empty;

            Email = string.Empty;

            Password = string.Empty;

            Phone = string.Empty;

            StreetName = string.Empty;

            HouseNumber = string.Empty;

            Floor = string.Empty;

            PostalCode = 0;

            IsLandlord = false;

            IsAdmin = false;

        }



        public User(int id, string firstName, string lastName, string email, string password, string phone, string streetName, string houseNumber, string floor, int postalCode, bool isLandlord, bool isAdmin)

        {

            Id = id;

            FirstName = firstName;

            LastName = lastName;

            Email = email;

            Password = password;

            Phone = phone;

            StreetName = streetName;

            HouseNumber = houseNumber;

            Floor = floor;

            PostalCode = postalCode;

            IsLandlord = isLandlord;

            IsAdmin = isAdmin;
        }


        public User(string firstName, string lastName, string phone, string email , string password, string streetName, string houseNumber, string floor, int postalCode, bool isLandlord, bool isAdmin)

        {

            FirstName = firstName;

            LastName = lastName;

            Email = email;

            Password = password;

            Phone = phone;

            StreetName = streetName;

            HouseNumber = houseNumber;

            Floor = floor;

            PostalCode = postalCode;

            IsLandlord = isLandlord;

            IsAdmin = isAdmin;
        }


        public User(string firstName, string lastName, string email, string password, string phone, string streetName, string houseNumber, string floor, int postalCode)

        {

            FirstName = firstName;

            LastName = lastName;

            Email = email;

            Password = password;

            Phone = phone;

            StreetName = streetName;

            HouseNumber = houseNumber;

            Floor = floor;

            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Email)}={Email}, {nameof(Password)}={Password}, {nameof(Phone)}={Phone}, {nameof(StreetName)}={StreetName}, {nameof(HouseNumber)}={HouseNumber}, {nameof(Floor)}={Floor}, {nameof(City)}={City}, {nameof(PostalCode)}={PostalCode.ToString()}, {nameof(IsLandlord)}={IsLandlord.ToString()}, {nameof(IsAdmin)}={IsAdmin.ToString()}}}";
        }
    }

}
    