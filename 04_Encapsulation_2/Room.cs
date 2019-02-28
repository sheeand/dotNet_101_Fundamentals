using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_2
{
    // Combined logic (repo + business logic)
    public class Room
    {
        private const double MAX_LENGTH = 30d;
        private const double MIN_LENGTH = 6d;
        private const double MIN_HEIGHT = 10d;
        private const double MAX_HEIGHT = 12d;

        private double _length;
        private double _width;
        private double _height;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= MIN_HEIGHT || value >= MAX_HEIGHT)
                {
                    throw new ArgumentOutOfRangeException("Height is too short");
                }
                else
                {
                    _height = value;
                }
            }
        }

        // 10 < height < 12
        // no dimension smaller than 6
        // no length by width where length > 30 or width > 30
        // Get area of room (length by width times 2)


        public string TestRoom(double length, double width, double height)
        {
            string result = "";

            if (length < MIN_LENGTH || width < MIN_LENGTH)
            {
                result = "Room is too small";
            }
            else if (length > MAX_LENGTH || width > MAX_LENGTH)
            {
                result = "Room is too big";
            }
            //else
            //{
            //    double area = 
            //    result = "Wall space is " + area;
            //} 

            return result;
        }


    }
}