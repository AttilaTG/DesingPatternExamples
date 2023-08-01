using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder.Products
{
    public class HouseInformationHandbook
    {
        private string _parking;
        private string _equipedKitchen;
        private string _rooms;
        private string _bathrooms;

        public string Parking { get => _parking;  set => _parking = value; }
        public string EquipedKitchen { get => _equipedKitchen;  set => _equipedKitchen = value; }
        public string Rooms { get => _rooms;  set => _rooms = value; }
        public string Bathrooms { get => _bathrooms;  set => _bathrooms = value; }

        public void ReadHandbook() 
        {
            Console.WriteLine($"{_rooms}\n{_bathrooms}\n{_equipedKitchen}\n{_parking}");
        }
    }
}
