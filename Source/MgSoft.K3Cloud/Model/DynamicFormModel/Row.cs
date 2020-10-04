using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Row : IRow
    {
        public IModel Model { get; }
        public IRows Rows { get; }
        public int RowIndex { get; }

        public Row(IModel model, IRows rows, int rowIndex)
        {
            Model = model;
            Rows = rows;
            RowIndex = rowIndex;
        }

        public ICell this[string name]
        {
            get
            {
                return new Cell(Model, this, name);
            }
        }
    }
}
