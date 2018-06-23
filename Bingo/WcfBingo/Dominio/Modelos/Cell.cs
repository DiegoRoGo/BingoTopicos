﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BingoWCF.Dominio.Modelos
{
    [DataContract]
    public class Cell
    {
        [DataMember]
        public int Value { get; set; }
        [DataMember]
        public bool IsMarked { get; set; }


        public Cell(int value)
        {
            this.Value = value;
            this.IsMarked = false;
        }

        public Cell(int value, bool state)
        {
            this.IsMarked = state;
            this.Value = value;
        }

        public Cell(bool state)
        {
            this.IsMarked = state;
            this.Value = 0;
        }
    }
}
