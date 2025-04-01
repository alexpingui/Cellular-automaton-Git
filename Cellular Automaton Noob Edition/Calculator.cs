using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cellular_Automaton_Noob_Edition
{
    public class Calculator
    {
        private bool[,] _map;

        private List<ChangeValueRequest> _changes;

        public bool[,] Map => _map;

        public Calculator(int height, int width) 
        {
            _map = new bool[height, width];
            
           _changes = new List<ChangeValueRequest>();
        }

        public void CalculateNextStep() 
        {
            for (int row = 0; row < _map.GetLength(0); row++)
            {
                for (int col = 0; col < _map.GetLength(1); col++)
                {
                    if (ShouldChangeValue(Environment(row, col), _map[row, col])) 
                        _changes.Add(new ChangeValueRequest(row, col, _map[row, col]));
                }
            }
            foreach (var change in _changes)
            {
                _map[change.Row, change.Column] = change.Value;
            }
            _changes.Clear();
        }

        private int Environment(int row, int column)
        {
            int environment = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;

                    int newRow = row + i;
                    int newCol = column + j;
                    if (newRow < 0 || newCol < 0 || newRow >= _map.GetLength(0) 
                        || newCol >= _map.GetLength(1)) continue;

                    if (_map[row + i, column + j]) environment++;
                }
            }
            return environment;
        }

        private bool ShouldChangeValue(int sum, bool isAlive)
        {
            if(sum < 2 && isAlive || sum > 3 && isAlive) return true;

            if(sum == 3 && !isAlive) return true;

            return false;
        }
    }
}
