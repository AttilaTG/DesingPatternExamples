using DesingPatternExamples.CreationalDesingPatterns.Builder.ConcreteBuilder;
using DesingPatternExamples.CreationalDesingPatterns.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Builder
{
    public class BuilderClient
    {
        private Director _director;
        public BuilderClient()
        {
            _director = new Director();
        }
        public void Demo()
        {
            MakeWarehouse(_director);

            MakeFamilyHouseHandbook(_director);
        }

        private void MakeWarehouse(Director director) 
        {
            HouseBuilder houseBuilder = new();

            director.MakeWarehouse(houseBuilder);

            House house = houseBuilder.GetResult();

            house.HouseInformation();
        }

        private void MakeFamilyHouseHandbook(Director director) 
        { 
            HouseHandbookBuilder builder = new();
            director.MakeFamilyHouse(builder);

            HouseInformationHandbook handbook = builder.Result();
            handbook.ReadHandbook();
        }
    }
}
