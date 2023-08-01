using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder
{
    public interface IAbstractBuilder
    {
        void SetRooms(int rooms);
        void SetBathrooms(int bathrooms);
        void KitchenEquipment(bool isEquiped);
        void Parking(bool hasParking);
        void Reset();
    }
}
