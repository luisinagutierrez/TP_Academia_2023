using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Courses
    {
        int _idCourse;
        int _idSubject;
        int _idCommission;
        int _calendarYear;
        int _quota;

        public int IdCourse { get { return _idCourse; } set { _idCourse = value; } }
        public int IdSubject { get { return _idSubject; } set { _idSubject = value; } }
        public int IdCommission { get { return _idCommission; } set { _idCommission = value; } }
        public int CalendarYear { get { return _calendarYear; } set { _calendarYear = value; } }
        public int Quota { get { return _quota; } set { _quota = value; } }

        public Courses(int idCourse, int idSubject, int idCommission, int calendarYear, int quota)
        {
            this._idCourse = idCourse;
            this._idSubject = idSubject;
            this._idCommission = idCommission;
            this._calendarYear = calendarYear;
            this._quota = quota;

        }

    }
}
