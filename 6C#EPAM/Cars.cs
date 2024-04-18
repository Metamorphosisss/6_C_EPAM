using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6C_EPAM
{
    internal class Cars
    {
        public string name;
        public int max_velocity;
        public string Name { get; set; }
        public int Max_Velocity
        {
            get { return max_velocity; }
            set { max_velocity = value; }
        }
        public Cars(string carName, int carVelocity)
        {
            Name = carName;
            Max_Velocity = carVelocity;
        }
    }
}
