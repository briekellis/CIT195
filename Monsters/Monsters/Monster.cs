using System;
using System.Collections.Generic;
using System.Text;

namespace Monsters
{
    public abstract class Monster
    {
        public enum MonsterAction { Attack, Defend, Retreat }

        private int _age;
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Monster()
        {
            
        }

        public Monster(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public virtual string Greeting()
        {
            return $"Hello, my name is {_name}";
        }

        public abstract bool IsHappy();
    }
}
