using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Data;
using LinqToDB;

namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("ABMTest2") { }
        public ITable<Estudiante> _Estudiante => GetTable<Estudiante>();

        //public ITable<Estudiante> _Estudiante { get { return GetTable<Estudiante>(); } }

        //private ITable<T> GetTable<T>()
        //{
        //    return _Estudiante as ITable<T>;
        //    // return base.GetTable<T>();
        //    //throw new NotImplementedException();
        //}
    }
}

