using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Row
    {
        public Biller Biller { get; }
        public Rows Rows { get; }
        public int RowIndex { get; }

        public Row(Biller biller, Rows rows, int rowIndex)
        {
            this.Biller = biller;
            this.Rows = rows;
            this.RowIndex = rowIndex;
        }

        public Cell this[string name]
        {
            get
            {
                return new Cell(Biller, this, name);
            }
        }
    }
}
