using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modules
    {
        int _idModule;
        string _moduleDescription;
        string _executionStatus;

        public int IdModule { get { return _idModule; } set { _idModule = value; } }    
        public string ModuleDescription { get { return _moduleDescription; } set { _moduleDescription = value; } }  
        public string ExecutionStatus { get { return _executionStatus; } set { _executionStatus = value; } }    

        public Modules(int idModule, string moduleDescription, string executionStatus) 
        { 
            this._idModule = idModule;
            this._moduleDescription = moduleDescription;
            this._executionStatus = executionStatus;
        }
    }
}
