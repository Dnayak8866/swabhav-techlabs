using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    class Player
    {
        private int _id;
        private string _name;
        private int _age;

        public Player(int id,string name,int age):this(id,name)
        {
            this._age = age;
        }

        public Player(int id,string name)
        {
            this._id = id;
            this._name = name;
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

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public override bool Equals(object obj)
        {
            Player p = (Player)obj;
            if (this.Age==p.Age && this.Id==p.Id && this.Name==p.Name)
            {
                return true;
            }
            return false;
        }

        public Player WhoIsElder(Player player)
        {
            if (this.Age > player.Age)
            {
                return this;
            }
            return player;
        }

        public override string ToString()
        {
            Console.WriteLine("Name is : " + this.Name
                + "\nID :" + this.Id
                + "\nAge :" + this.Age);
            return base.ToString();
        }
    }

}
