﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Sommerhus.Model

{

    public class Summerhouse

    {

        // Properties 

        public int Id { get; set; }

        public string StreetName { get; set; }

        public string HouseNumber { get; set; }

        public int PostalCode { get; set; }

        public string City { get; set; }

        public string Floor { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }



        // Constructor 

        public Summerhouse()

        {

            Id = 0;

            StreetName = string.Empty;

            HouseNumber = string.Empty;

            PostalCode = 0;

            City = string.Empty;

            Floor = string.Empty;

            Description = string.Empty;

            Price = 0.0m;

        }



        public Summerhouse(int id, string streetName, string houseNumber, int postalCode, string city, string floor, string description, decimal price)

        {

            Id = id;

            StreetName = streetName;

            HouseNumber = houseNumber;

            PostalCode = postalCode;

            City = city;

            Floor = floor;

            Description = description;

            Price = price;

        }

    }

}