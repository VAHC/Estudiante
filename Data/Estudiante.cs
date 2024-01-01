using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace Data
{
    public class Estudiante
    {
        [PrimaryKey, Identity]
        public int id {  set; get; }
        public string nid { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string email { set; get; }
        public byte[] image { set; get; }
    }
}
