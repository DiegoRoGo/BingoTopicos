using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Modelos
{
    public class Cell
    {
        public int Value { get; set; }
        public bool IsMarked { get; set; }

        public Cell(int value)
        {
            this.Value = value;
            this.IsMarked = false;
        }
    }
}
