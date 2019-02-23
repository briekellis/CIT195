using System;
using System.Collections.Generic;
using System.Text;

namespace Monsters
{
    public class SeaMonster : Monster
    {
        private string _homeSea;
        private bool _hasGills;

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }

        public string HomeSea
        {
            get { return _homeSea; }
            set { _homeSea = value; }
        }

        public override bool IsHappy()
        {
            //if (_hasGills)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return _hasGills ? true : false;
        }
    }
}
