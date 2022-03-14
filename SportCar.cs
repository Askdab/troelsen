using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen
{
    public class SportCar : Car
    {
        public string GetPetName()
        {
            petName = "Tom";
            speed = 10;
            return petName;
        }
    }
}
