using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder
{
    public class Director
    {
        public void MakeFamilyHouse(IAbstractBuilder builder) 
        { 
            builder.Reset();
            builder.Parking(true);
            builder.KitchenEquipment(true);
            builder.SetBathrooms(1);
            builder.SetRooms(5);
        }

        public void MakeEmptyDepartmentHouse(IAbstractBuilder builder)
        {
            builder.Reset();
            builder.Parking(false);
            builder.SetBathrooms(1);
            builder.SetRooms(2);
            builder.KitchenEquipment(false);
        }

        public void MakeWarehouse(IAbstractBuilder builder)
        {
            builder.Reset();
            builder.Parking(false);
            builder.SetBathrooms(1);
        }
    }
}
