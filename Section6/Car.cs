using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Car
    {
        string color;
        int numberOfDoors;

        public string Color
        {
            get{ return Color; }
            set{ color = value; }
        }

        public Car(string carColor, int doors, bool convertable)
        {
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }

        public bool IsConvertable
        {
            get; set;
        }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if(value <= 4)
                {
                    numberOfDoors = value;
                }
                else
                {

                }
            }
        }

        public void Accelerate()
        {
            Console.WriteLine("I am accelerating");
        }

        public bool FamilyCar()
        {
            if(NumberOfDoors >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
