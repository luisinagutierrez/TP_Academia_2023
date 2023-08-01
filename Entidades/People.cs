using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class People
    {
        int _idPerson;
        string _name;
        string _surname;
        string _address;
        string _email;
        string _telephone;
        DateTime _birthDate;
        int _fileId;
        int _personType;
        int _idPlan;

        public int IdPerson { get { return _idPerson; } set { _idPerson = value; } }    
        public string Name { get { return _name; } set { _name = value; } } 
        public string Surname { get { return _surname; } set { _surname = value; } }    
        public string Address { get { return _address; } set { _address = value; } }    
        public string Email { get { return _email; } set { _email = value; } }  
        public string Telephone { get { return _telephone; } set { _telephone = value; } }  
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }    
        public int FileId { get { return _fileId; } set { _fileId = value; } }    
        public int PersonType { get { return _personType; } set { _personType = value; } }  
        public int IdPlan { get { return _idPlan; } set { _idPlan = value; } }  

        public People(int idPerson, string name, string surname, string address, string email, string telephone, DateTime birthDate, int fileId, int personType, int idPlan)
        {
            this.IdPerson = idPerson;
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.Email = email;
            this.Telephone = telephone;
            this.BirthDate = birthDate;
            this.FileId = fileId;
            this.PersonType = personType;
            this.IdPlan = idPlan;
        }

    }
}
