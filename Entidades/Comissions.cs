using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Commissions
    {
        int _idCommission;
        string _commissionDescription;
        int _specialityYear;
        int _idPlan;

        public int IdCommission { get { return _idCommission; } set { _idCommission = value; } }
        public string CommissionDescription { get { return _commissionDescription; } set { _commissionDescription = value; } }
        public int SpecialityYear { get { return _specialityYear; } set { _specialityYear = value; } }
        public int IdPlan { get { return _idPlan; } set { _idPlan = value; } }
        public Commissions(int idCommission, string commissionDescription, int specialityYear, int idPlan)
        {
            this._idCommission = idCommission;
            this._commissionDescription = commissionDescription;
            this._specialityYear = specialityYear;
            this._idPlan = idPlan;
        }

    }
}
