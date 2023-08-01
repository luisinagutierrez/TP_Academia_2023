using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsersModules
    {
        int _idUserModule;
        int _idModule;
        int _idUser;
        bool _creation;
        bool _elimination;
        bool _modification;
        bool _query;

        public int IdUserModule { get { return _idUserModule; } set { _idUserModule = value; } }    
        public int IdModule { get { return _idModule; } set { _idModule = value; } }    
        public int IdUser { get { return _idUser; } set { _idUser = value; } }  
        public bool Creation { get { return _creation; } set { _creation = value; } }
        public bool Elimination { get { return _elimination; } set { _elimination = value; } }  
        public bool Modification { get { return _modification; } set { _modification = value; } }   
        public bool Query { get { return _query; } set { _query = value; } }    

        public UsersModules(int idUserModule, int idModule, int idUser, bool creation, bool elimination, bool modification, bool query)
        {
            this._idUserModule = idUserModule;
            this._idModule = idModule;  
            this._idUser = idUser;
            this._creation = creation;
            this._elimination = elimination;
            this._modification = modification;
            this._query = query;
        }
    }
}
