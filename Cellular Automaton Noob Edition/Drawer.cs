using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cellular_Automaton_Noob_Edition
{
    public class Drawer
    {
        private Calculator _calculator;
        private Pen _gridPen;

        private float _cellSize;

        private RectangleF _displayRect;
        private RectangleF _imageRect;
        public RectangleF Rectangle
        {
            get
            {
                return _displayRect;
            }

            set
            {
                _displayRect = value;
                SetImageRect();
            }
        }

        public Calculator Calculator
        {
            get { return _calculator; }
            set
            {
                _calculator = value;
                SetImageRect();
            }
        }

        public Drawer()
        {
            _gridPen = new Pen(Color.DarkGray, 0.5f);
        }

        private void SetImageRect()
        {
            if (_calculator == null) return;

            bool isWidthLess = _displayRect.Width < _displayRect.Height;

            float cellSizeX = _displayRect.Width / _calculator.Map.GetLength(1);
            float cellSizeY = _displayRect.Height / _calculator.Map.GetLength(0);

            /*float lessSide = Math.Min(_displayRect.Width, _displayRect.Height);
            int mapSide = isWidthLess ? 0 : 1;*/

            _cellSize = Math.Min(cellSizeY, cellSizeX);

            _imageRect = new RectangleF()
            {
                Width = _cellSize * _calculator.Map.GetLength(1),
                Height = _cellSize * _calculator.Map.GetLength(0)
            };

            _imageRect.X = _displayRect.X + (_displayRect.Width - _imageRect.Width) / 2;
            _imageRect.Y = _displayRect.Y + (_displayRect.Height - _imageRect.Height) / 2;
        }

        public Point GetCellByCoordinates(Point coordinates)
        {
            return new Point()
            {
                X = (int)((coordinates.Y - _imageRect.Top) / _cellSize),
                Y = (int)((coordinates.X - _imageRect.Left) / _cellSize)
            };
        }

        public void Draw(Graphics g)
        {
            if (_calculator == null) return;

            DrawGrid(g);
            DrawCells(g);
        }

        private void DrawGrid(Graphics g)
        {
            for (int row = 0; row < _calculator.Map.GetLength(0) + 1; row++)
            {
                PointF start = new PointF(_imageRect.Left, _imageRect.Y + row * _cellSize);
                PointF end = new PointF(_imageRect.Right, _imageRect.Y + row * _cellSize);

                g.DrawLine(_gridPen, start, end);
            }
           
            for (int col = 0; col < _calculator.Map.GetLength(1) + 1; col++)
            {
                PointF start = new PointF(_imageRect.X + col * _cellSize, _imageRect.Top);
                PointF end = new PointF(_imageRect.X + col * _cellSize, _imageRect.Bottom);

                g.DrawLine(_gridPen, start, end);
            }
        }

        private void DrawCells(Graphics g)
        {
            for (int row = 0; row < _calculator.Map.GetLength(0); row++)
            {
                for (int col = 0; col < _calculator.Map.GetLength(1); col++)
                {
                    if (_calculator.Map[row, col])
                    {
                        g.FillRectangle(Brushes.Black,
                            _imageRect.X + col * _cellSize,
                            _imageRect.Y + row * _cellSize,
                            _cellSize, _cellSize);
                    }
                }
            }
        }
    }
}
