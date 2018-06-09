using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Column
/// </summary>
/// 
namespace BingoWCF.Dominio.Modelos
{
    public class Column
    {

        public int id { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public Column(int id, int maxIn, int minIn )
        {
            this.id = id;
            this.max = maxIn;
            this.min = minIn;
        }
    }
}
