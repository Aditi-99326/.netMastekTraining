using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CalculatorForm : Form
    {
        double operand1, operand2, Result;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtFirst.Text);
            operand2 = Convert.ToDouble(txtSecond.Text);
            Result = operand1 + operand2;
            txtResult.Text = Result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtFirst.Text);
            operand2 = Convert.ToDouble(txtSecond.Text);
            Result = operand1 - operand2;
            txtResult.Text = Result.ToString();

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtFirst.Text);
            operand2 = Convert.ToDouble(txtSecond.Text);
            Result = operand1 * operand2;
            txtResult.Text = Result.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtSecond.Text) != 0)
            {
                operand1 = Convert.ToDouble(txtFirst.Text);
                operand2 = Convert.ToDouble(txtSecond.Text);
                Result = operand1 / operand2;
                txtResult.Text = Result.ToString();
            }

            else
            {
                
            }
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar)  == false && (e.KeyChar == '.'? txtFirst.Text.Contains('.') == true : true))
            e.Handled = true;
        }

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtSecond.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtFirst.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
           
        }

        private void lblSecond_Click(object sender, EventArgs e)
        {
            
        }
    }
}
