using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TeacherCourses
    {
        int _idDictation;
        int _idCourse;
        int _idTeacher;
        int _position;
        public int IdDictation { get { return _idDictation; } set { _idDictation = value; } }
        public int IdCourse { get { return _idCourse; } set { _idCourse = value; } }
        public int IdTeacher { get { return _idTeacher; } set { _idTeacher = value; } }
        public int Position { get { return _position; } set { _position = value; } }
        public TeacherCourses(int idDictation, int idCourse, int idTeacher, int position)
        {
            this._idDictation = idDictation;
            this._idCourse = idCourse;
            this._idTeacher = idTeacher;
            this._position = position;
        }

    }
}
