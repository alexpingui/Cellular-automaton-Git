using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular_Automaton_Noob_Edition
{
    public class ChangeValueRequest
    {
        private int _row;
        private int _column;
        private bool _value;

        public int Row => _row;
        public int Column => _column;
        public bool Value => _value;

        public ChangeValueRequest(int row, int column, bool value)
        {
            _row = row;
            _column = column;
            _value = !value;
        }

        
    }
}
