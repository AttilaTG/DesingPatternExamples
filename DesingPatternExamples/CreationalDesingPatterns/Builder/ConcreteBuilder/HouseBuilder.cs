using DesingPatternExamples.CreationalDesingPatterns.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder.ConcreteBuilder
{
    public class HouseBuilder : IAbstractBuilder
    {
        private House _house;
        public HouseBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _house = new House();
        }

        public void KitchenEquipment(bool isEquiped)
        {
            _house.EquipedKitchen = isEquiped;
        }

        public void Parking(bool hasParking)
        {
            _house.Parking = hasParking;
        }

        public void SetBathrooms(int bathrooms)
        {
            _house.Bathrooms = bathrooms;
        }

        public void SetRooms(int rooms)
        {
            _house.Rooms = rooms;   
        }

        public House GetResult() 
        { 
            return _house;
        }
    }
}
