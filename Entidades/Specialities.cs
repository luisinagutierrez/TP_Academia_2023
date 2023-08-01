using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Specialities
    {
        int _idSpeciality;
        string _specialityDescription;

        public int IdSpeciality { get { return _idSpeciality; } set { _idSpeciality = value; } } 
        public string SpecialityDescription { get { return _specialityDescription; } set { _specialityDescription = value; } }
        public Specialities(int idSpeciality, string specialityDescription) 
        { 
            this._idSpeciality = idSpeciality;
            this._specialityDescription = specialityDescription;
        }
    }
}
