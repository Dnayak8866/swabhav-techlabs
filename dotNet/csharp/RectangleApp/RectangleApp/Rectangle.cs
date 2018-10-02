using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleApp
{
    public class Rectangle
    {
        private int _width;
        private int _height;
        private string _BorderColor = "Default Color";


        public Rectangle()
        {
            Console.WriteLine("Object created....");
        }

        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                int val= CheckWidthHeight(value);
                this._width = val;
            }
        }
        public int Height
        {
            get
            {
                return this._height;
            }
            set
            {
                int val = CheckWidthHeight(value);
                this._height = val;
            }
        }

        public string BorderColor
        {
            get
            {
                return this._BorderColor;
            }
            set
            {
                string color = CheckBorderColor(value);
                this._BorderColor = color;
            }
        }

       
        public int CalculateArea()
        {
            return Width * Height;

        }

        private int CheckWidthHeight(int val)
        {
            if (val>100)
            {
                return 100;
            }else if (val < 1)
            {
                return 1;
            }else
            {
                return val;
            }
        }

        private string CheckBorderColor(string color)
        {
            if (color.Equals("Red",StringComparison.CurrentCultureIgnoreCase))
            {
                return "Red";
            }
            else if (color.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
            {
                return "blue";
            }
            else if(color.Equals("Green", StringComparison.CurrentCultureIgnoreCase))
            {
                return "Green";
            }
            else
            {
                return "No colors";
            }
        }

    }
}
