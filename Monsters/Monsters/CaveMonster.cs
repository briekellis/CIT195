using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class CaveMonster : Monster
    {
        private bool _isUnderground;
        public string _homeCountry;
        public string _origin;
        public int _noOfLegs;
        public bool _hasTeeth;
        private bool _isBlind;
        private bool _eatsDirt;

        public bool EatsDirt
        {
            get { return _eatsDirt; }
            set { _eatsDirt = value; }
        }


        public bool IsBlind
        {
            get { return _isBlind; }
            set { _isBlind = value; }
        }

        public bool HasTeeth
        {
            get { return _hasTeeth; }
            set { _hasTeeth = value; }
        }

        public bool IsUnderground
        {
            get { return _isUnderground; }
            set { _isUnderground = value; }
        }

        public string HomeCountry
        {
            get { return _homeCountry; }
            set { _homeCountry = value; }
        }

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public int Leggies
        {
            get { return _noOfLegs; }
            set { _noOfLegs = value; }
        }

        public override bool IsHappy()
        {
            return IsUnderground ? true : false;
        }
    }
}
