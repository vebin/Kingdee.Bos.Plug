using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Row
    {
        private Biller biller;
        public string BodyName { get; }
        public int RowIndex { get; }

        public Row(Biller biller, string bodyName, int rowIndex)
        {
            this.biller = biller;
            this.BodyName = bodyName;
            this.RowIndex = rowIndex;
        }

        public Cell this[string name]
        {
            get
            {
                return new Cell(biller, this, name);
            }
        }
    }
}
