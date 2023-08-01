using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StudentsRegistrations
    {
        int _idRegistration;
        int _idStudent;
        int _idCourse;
        string _condition;
        int _mark;

        public int IdRegistration { get { return _idRegistration; } set { _idRegistration = value; } }  
        public int IdStudent { get { return _idStudent; } set { _idStudent = value; } } 
        public int IdCourse { get { return _idCourse; } set { _idCourse = value; } }    
        public string Condition { get { return _condition; } set { _condition = value; } }  
        public int Mark { get { return _mark; } set { _mark = value; } }    

        public StudentsRegistrations(int idRegistration, int idStudent, int idCourse, string condition, int mark)
        {
            this._idRegistration = idRegistration;
            this._idStudent = idStudent;
            this._idCourse = idCourse;
            this._condition = condition;
            this._mark = mark;
        }
    }
}
