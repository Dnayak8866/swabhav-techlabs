using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
    class Human
    {
        private string _name;
        private int _age;
        private float _height=5.0f;
        private float _weight = 69.0f;
        private  GenderType _gender;
        private float bmi;

        public Human(string name,int age,float height,float weight,GenderType gender):this(name,age,gender)
        {
            
        }
        public Human(string name,int age,GenderType gender)
        {
            this._name = name;
            this._age = age;
            this._gender = gender;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public float Height
        {
            get
            {
                return _height;
            }
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
        }

        public string Gender
        {
            get
            {
                return _gender.ToString();
            }
        }

        public void Eat()
        {
            this._weight += 0.25f;
        }

        public void Workout()
        {
            this._weight -= 0.3f;
            this._height += 0.2f;
        }

        public void CalculateBMI()
        {
            this._height = this._height / (3.28f);
            this.bmi = this._weight / (this._height * this._height);
        }

        public void HealthRecommendation()
        {
            CalculateBMI();
            Console.WriteLine("Your Bmi value is {0}",this.bmi);

            if (this.bmi > 0 && this.bmi < 18.5)
            {
                Console.WriteLine("Hey, you are underweight........");
            }
            else if (this.bmi > 18.5 && this.bmi < 24.9)
            {
                Console.WriteLine("Hey,You hava a Normal Weight");
            }
            else if (this.bmi > 25 && this.bmi < 29.9)
            {
                Console.WriteLine("hey buddy, you are over weighted.....");
            }
            else
            {
                Console.WriteLine("You are suffering from Obesity.......");
            }
        }

        public override string ToString()
        {
            return "Name :" + this.Name
                + "\nAge :" + this.Age
                + "\nHeight :" + this.Height
                + "\nWeight :" + this.Weight
                + "\nGender :" + this.Gender
                +"\n.......................................................";
        }
    }
}
