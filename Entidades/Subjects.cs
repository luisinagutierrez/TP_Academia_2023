using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Subjects
    {
        int _idSubject;
        string _subjectDescription;
        int _weeklyHours;
        int _totalHours;
        int _idPlan;
        public int IdSubject { get { return _idSubject; } set { _idSubject = value; } }
        public string SubjectDescription { get { return _subjectDescription; } set { _subjectDescription = value; } }
        public int WeeklyHours { get { return _weeklyHours; } set { _weeklyHours = value; } }
        public int TotalHours { get { return _totalHours; } set { _totalHours = value; } }
        public int IdPlan { get { return _idPlan; } set { _idPlan = value; } }
        public Subjects(int idSubject, string subjectDescription, int weeklyHours, int totalHours, int idPlan)
        {
            this._idSubject = idSubject;
            this._subjectDescription = subjectDescription;
            this._weeklyHours = weeklyHours;
            this._totalHours = totalHours;
            this._idPlan = idPlan;
        }

    }
}
