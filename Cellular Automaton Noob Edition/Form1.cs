using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Cellular_Automaton_Noob_Edition
{
    public partial class Form1 : Form
    {
        Timer timer;
        Screen screen;
        int timerCount;
        public Form1()
        {
            InitializeComponent();

            AddControls();
            timer = new Timer();
            timer.Tick += DoNextStep;
            timer.Interval = 1000;
            timerCount = 0;
        }

        private void DoNextStep(object sender, EventArgs e)
        {
            AutomatonScreen.Drawer.Calculator.CalculateNextStep();
            AutomatonScreen.Invalidate();
        }

        private void AddControls()
        {
            
        }

        private void createBtn_MouseClick(object sender, MouseEventArgs e)
        {
            int rows = int.Parse(rowsTextBox.Text);
            int columns = int.Parse(columnsTextBox.Text);
            AutomatonScreen.Drawer.Calculator = new Calculator(rows, columns);
            AutomatonScreen.Invalidate();

        }

        private void runStopBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (timer.Enabled) 
            {
                timer.Stop(); 
                return; 
            }
            
            timer.Start();
        }


    }
}
