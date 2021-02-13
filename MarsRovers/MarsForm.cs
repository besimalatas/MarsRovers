using MarsRovers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRovers
{
    public partial class MarsForm : Form
    {
        public MarsForm()
        {
            InitializeComponent();
        }

        private void runCommandButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text;
            var inputs = text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //string upperRightCoordinates = inputs[0];
            string rover1FirstPositionInputs = inputs[1];
            string rover1CommandInputs = inputs[2];

            string rover2FirstPositionInputs = inputs[3];
            string rover2CommandInputs = inputs[4];

            string rover3FirstPositionInputs = inputs[5];
            string rover3CommandInputs = inputs[6];

            string rover4FirstPositionInputs = inputs[7];
            string rover4CommandInputs = inputs[8];

            Rover rover1 = new Rover(rover1FirstPositionInputs);
            Rover rover2 = new Rover(rover2FirstPositionInputs);
            Rover rover3 = new Rover(rover3FirstPositionInputs);
            Rover rover4 = new Rover(rover4FirstPositionInputs);

            rover1.ChangePosition(rover1CommandInputs);
            rover2.ChangePosition(rover2CommandInputs);
            rover3.ChangePosition(rover3CommandInputs);
            rover4.ChangePosition(rover4CommandInputs);

            outputTextBox.Text = string.Empty;
            outputTextBox.Text += "Rover 1 Position= " + rover1.GetCurrentPositionAsString() + Environment.NewLine;
            outputTextBox.Text += "Rover 2 Position= " + rover2.GetCurrentPositionAsString() + Environment.NewLine;
            outputTextBox.Text += "Rover 3 Position= " + rover3.GetCurrentPositionAsString() + Environment.NewLine;
            outputTextBox.Text += "Rover 4 Position= " + rover4.GetCurrentPositionAsString() + Environment.NewLine;
        }

    }
}
