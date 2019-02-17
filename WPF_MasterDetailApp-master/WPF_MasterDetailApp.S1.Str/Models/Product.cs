using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product : ObservableObject
    {
        #region ENUMS

        public enum GenderType { male, female }

        #endregion

        #region FIELDS

        private string _name;
        public string _type;
        public int _number;
        public string _description;
        private GenderType _gender;
        public bool _pokeStatus;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Types
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Pokedex
        {
            get { return _pokeStatus; }
            set { _pokeStatus = value; }
        }

        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
