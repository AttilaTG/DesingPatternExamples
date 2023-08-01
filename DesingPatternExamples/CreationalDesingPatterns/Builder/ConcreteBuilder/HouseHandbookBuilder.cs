using DesingPatternExamples.CreationalDesingPatterns.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder.ConcreteBuilder
{
    public class HouseHandbookBuilder : IAbstractBuilder

    {
        private HouseInformationHandbook _houseInformation;
        public HouseHandbookBuilder()
        {
            Reset(); 
        }

        public void Reset()
        {
            _houseInformation = new HouseInformationHandbook();
        }

        public void KitchenEquipment(bool isEquiped)
        {
            string isOrNot = isEquiped ? "" : "not";
            _houseInformation.EquipedKitchen = $"This house has {isOrNot} equiped kitchen.";
        }

        public void Parking(bool hasParking)
        {
            string isOrNot = hasParking ? "" : "not";
            _houseInformation.Parking = $"This house has {isOrNot} parking.";
        }

        public void SetBathrooms(int bathrooms)
        {
            _houseInformation.Bathrooms = $"This house has {bathrooms} bathrooms.";
        }

        public void SetRooms(int rooms)
        {
            _houseInformation.Rooms = $"This house has {rooms} rooms.";
        }

        public HouseInformationHandbook Result() 
        {
            return _houseInformation;
        }
    }
}
