using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Circle
    {
        private  const float _Pi = 3.14f;
        private float _radius;
        private BorderOptions _borderOption;

        public Circle(float d, BorderOptions option)
        {

            this._borderOption = option;
            this._radius = d;
        }

        public float Radius
        {
            get
            {
                return _radius;
            }
        }

        public BorderOptions BorderOption
        {
            get
            {
                return _borderOption;
            }
        }

        public double CalculateArea()
        {
            return (_Pi*_radius*_radius);
        }


           



    }
}
