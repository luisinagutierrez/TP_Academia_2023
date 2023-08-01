using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Users
    {
        int _idUser;
        string _userName;
        string _password;
        bool _status;
        string _name;
        string _surname;
        string _email;
        bool _changePassword;
        int _idPerson;

        public int IdUser { get { return _idUser; } set { _idUser = value; } }  
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public bool Status { get { return _status; } set { _status = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Email { get { return _email; } set { _email = value; } }  
        public bool ChangePassword { get { return _changePassword; } set { _changePassword = value; } }
        public int IdPerson { get { return _idPerson; } set { _idPerson = value; } }

        public Users(int idUser, string userName, string password, bool status, string name, string surname, string email, bool changePassword, int idPerson)
        {
            this.IdUser = idUser;
            this.UserName = userName;
            this.Password = password;
            this.Status = status;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.ChangePassword = changePassword;
            this.IdPerson = idPerson;
        }
    }
}
