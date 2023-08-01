using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder.Products
{
    public class House
    {
        private bool _parking;
        private bool _equipedKitchen;
        private int _rooms;
        private int _bathrooms;

        public bool Parking { get => _parking;  set => _parking = value; }
        public bool EquipedKitchen { get => _equipedKitchen; set => _equipedKitchen = value; }
        public int Rooms { get => _rooms; set => _rooms = value; }
        public int Bathrooms { get => _bathrooms; set => _bathrooms = value; }

        public void HouseInformation() 
        {
            Console.WriteLine($"Rooms:{_rooms}; Bathrooms:{_bathrooms}; EquipedKitchen: {_equipedKitchen}; Parking:{_parking}");
        }
    }
}
