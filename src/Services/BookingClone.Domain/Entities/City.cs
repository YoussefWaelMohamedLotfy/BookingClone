﻿using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Cities : BaseEntity<int>
{
<<<<<<< HEAD
<<<<<<< HEAD
    

    public string Name { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
    
    public int? CountryID { get; set; }
    
=======
   


    public string Name { get; set; }
    public int? CountryID { get; set; }
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    public Country Country { get; set; }
=======
   
>>>>>>> city view

    public List<Attraction>? Attractions { get; set; }

<<<<<<< HEAD
    public List<CityHotel>? CityHotels { get; set; }  
=======

    public City Country { get; set; }
=======
    public int? CountryID { get; set; }
    public Country Country { get; set; }
>>>>>>> api(country_continent_city)

    public List<Attraction>? Attractions { get; set; }

<<<<<<< HEAD
    public List<CityHotel> CityHotels { get; set; }
>>>>>>> first commit
=======
    public List<CityHotel>? CityHotels { get; set; }

<<<<<<< HEAD
    //public City(string name, City country, List<Attraction>? attractions, List<CityHotel>? cityHotels)
    //{
    //    Name = name;
    //    Country = country;
    //    Attractions = attractions;
    //    CityHotels = cityHotels;
    //}
>>>>>>> add city and country and continent
=======
   
>>>>>>> DeleteComments
=======
    public List<CityHotel>? CityHotels { get; set; }

   
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}
