using System.Collections.Generic;

namespace Divar
{
    public class City
    {
        //properties
        public string Name;
        private List<Vicinity> Vicinities;


        //constructor
        public City(string name, List<Vicinity> vicinities)
        {
            Name = name;
            Vicinities = new List<Vicinity>(); Vicinities = vicinities;
        }


        //methods
        public void AddVicinity(Vicinity vicinity)
        {

        }

        public bool DeleteVicinity(Vicinity vicinity)
        {
            return false;
        }

        public List<Vicinity> GetVicinities()
        {
            return new List<Vicinity>();
        }

    }
}
