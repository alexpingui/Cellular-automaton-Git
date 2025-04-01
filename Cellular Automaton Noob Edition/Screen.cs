using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellular_Automaton_Noob_Edition
{
    public class Screen : Control
    {
        private Drawer _drawer;
        
        public Drawer Drawer => _drawer;

        public Screen() 
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;

            _drawer = new Drawer();
            _drawer.Rectangle = new Rectangle(10, 10, Width - 21, Height - 21);
        }

        protected override void OnResize(EventArgs e)
        {
            _drawer.Rectangle = new Rectangle(10, 10, Width - 21, Height - 21);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            _drawer.Draw(e.Graphics);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (_drawer.Calculator == null) return;

            Point cell = _drawer.GetCellByCoordinates(e.Location);

            if (cell.X < 0 || cell.Y < 0) return;
            if (cell.X >= _drawer.Calculator.Map.GetLength(0) || 
                cell.Y >= _drawer.Calculator.Map.GetLength(1)) return;

            _drawer.Calculator.Map[cell.X, cell.Y] = !_drawer.Calculator.Map[cell.X, cell.Y];
            Invalidate();
        }
    }
}
