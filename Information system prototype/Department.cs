using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Information_system_prototype
{
    public struct Department
    {
        private string depname;
        private DateTime creationdate;
        private int employes;

        public string Depname { get { return this.depname; } set { this.depname = value; } }
        public DateTime Creationdate { get { return this.creationdate; } set { this.creationdate = value; } }
        public int Employes { get { return this.employes; } set { this.employes = value; } }
        
        public Department(string Depname, DateTime Creationdate,int Employes)
        {
            this.depname = Depname;
            this.creationdate = Creationdate;
            this.employes = Employes;
        }
        public Department(string Depname, DateTime Creationdate):this(Depname,Creationdate,0)
        { }
        public string Print()
        {
            return $"Department name:{depname,10};Creation date:{creationdate,15};Number of employes:{employes}";
        }
    }
}