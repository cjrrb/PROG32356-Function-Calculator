using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2.MathFunctions;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clears all text and unchecks boxes
            lowValueTextBox.Clear();
            highValueTextBox.Clear();
            intervalsTextBox.Clear();
            dgvResults.Rows.Clear();
            dgvResults.Columns.Clear();
            checkBoxSin.Checked = false;
            checkBoxCos.Checked = false;
            checkBoxTan.Checked = false;
            checkBoxExp.Checked = false;
            checkBoxLog.Checked = false;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //Initializes values
            double lower = Convert.ToDouble(lowValueTextBox.Text);
            double upper = Convert.ToDouble(highValueTextBox.Text);
            int numOfIntervals = Convert.ToInt32(intervalsTextBox.Text);
            double interval = (upper - lower) / (numOfIntervals - 1);

            //Adds columns based on what checkboxes are selected
            AddColumns();

            //Use MathFunctions to calculate values and put them in a row
            for (int i = 0; i < numOfIntervals; i++)
            {
                double theta = lower + i * interval;
                List<object> row = new List<object> { theta };
                if (checkBoxSin.Checked) row.Add(MathFunctions.MathFunctions.Sin(theta));
                if (checkBoxCos.Checked) row.Add(MathFunctions.MathFunctions.Cos(theta));
                if (checkBoxTan.Checked) row.Add(MathFunctions.MathFunctions.Tan(theta));
                if (checkBoxLog.Checked) row.Add(MathFunctions.MathFunctions.Log(theta));
                if (checkBoxExp.Checked) row.Add(MathFunctions.MathFunctions.Exp(theta));

                dgvResults.Rows.Add(row.ToArray());
            }

        }

        private void AddColumns()
        {
            //Clear columns first
            dgvResults.Rows.Clear();
            dgvResults.Columns.Clear();

            //Add columns for theta value
            dgvResults.Columns.Add("Theta", "Theta");

            //Add columns for checked checkboxes
            if (checkBoxSin.Checked) dgvResults.Columns.Add("Sin", "Sin(2θ)");
            if (checkBoxCos.Checked) dgvResults.Columns.Add("Cos", "Cos(3θ)");
            if (checkBoxTan.Checked) dgvResults.Columns.Add("Tan", "Tan(θ)");
            if (checkBoxLog.Checked) dgvResults.Columns.Add("Log", "Log(θ)");
            if (checkBoxExp.Checked) dgvResults.Columns.Add("Exp", "Exp(θ)");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a function calculator. Enter a range of values and how many intervals you want between them, then press 'Calculate'. Press 'Clear' to start over.", "Info", MessageBoxButtons.OK);
        }
    }
}
