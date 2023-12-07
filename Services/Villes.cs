using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAp.Services
{
    internal class Ville
    {
        public class Villes
        {
            public List<string> LsVille;
            public Villes()
            {

                LsVille = new List<string>();

                LsVille.Add("Annecy");
                LsVille.Add("Marseille");
                LsVille.Add("Lyon");
                LsVille.Add("Paris");
            }
        }
    }
}
