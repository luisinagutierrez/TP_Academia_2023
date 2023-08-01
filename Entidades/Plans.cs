using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Plans
    {
        int _idPlan;
        string _planDescription;
        int _idSpeciality;

        public int IdPlan { get { return _idPlan; } set { _idPlan = value; } }  
        public string PlanDescription { get { return _planDescription; } set { _planDescription = value; } }    
        public int IdSpeciality { get { return _idSpeciality; } set { _idSpeciality = value; } }    

        public Plans(int idPlan, string planDescription, int idSpeciality)
        {
            this._idPlan = idPlan;
            this._planDescription = planDescription;
            this._idSpeciality = idSpeciality;
        }
    }
}
