using System;
using Turboaz.Entities;

namespace Turboaz.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CityId { get; set; }
        public bool IsNew { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int Year { get; set; }
        public double Km { get; set; }
        public string ImagePath { get; set; }
        public int FuelTypeId { get; set; }
        public string Engine { get; set; }


        public virtual City City { get; set; }
        public virtual Model Model { get; set; }
        public virtual CarsColor Color { get; set; }
        public virtual FuelType FuelType { get; set; }



    }
}