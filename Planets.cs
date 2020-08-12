using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spac3Game
{

	 class Planets
	 {
		public string planetName;
		public string planetDescription;
		public string planetStore;

        double xPos = 0.0;
        double yPos = 0.0;


		public Planets(string planetName, string planetDescription, string planetStore, double xPos, double yPos)
		{
			this.planetName = planetName;
			this.planetDescription = planetDescription;
			this.planetStore = planetStore;
            this.xPos = xPos;
            this.yPos = yPos;
        }

         public double DistanceTo(Planets destination)
        {
            var left = Math.Pow(this.xPos - destination.xPos, 2);
            var right = Math.Pow(this.yPos - destination.yPos, 2);

            return Math.Sqrt(left + right);
        }




        //Star / Planet coords: Sun / Earth (0 , 0)
        //Proxima Cent / Titan: (-3.3 , 4.2)
        //Alpha Cent / Alpha Proxima 1,2: (-2.5 , 4.367)
        //Bernard Star / Arad:(3.6, 5.978)
        //Planet general description: Earth is earth.  Tech advanced planet colonizing society)
        //Titan: "Brother" planet in the Centuari system. Planet though larger than Earth is mostly water. 
        //Alpha Proxima 1 and Alpha Proxima 2. "Sister" planets aka "Twins" in the Centauri system as they share a near identical orbit around Alpha Cent. Tropical Climate nearly all year round due to uniquely strong ozone layer.
        //Arad: Desert planet in far reaches of known colonized space. Money is law here. 
    }
}

