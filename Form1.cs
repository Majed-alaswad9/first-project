using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calacture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool NumberTwo = false;
        double firstNum;
        double SecondNum, num2;
        double result;
        bool isSow = false;
        string opirition;
        int count = 0;
        private void Btnclear_Click(object sender, EventArgs e)
        {
            SecondNum = 0;
            txtShow.Clear();
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnSeven.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnEight.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnNine.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnFour.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnFive.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnSix.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnOne.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnTwo.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnThree.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            string EnterNumber = txtShow.Text + btnZero.Text;
            txtShow.Text = EnterNumber;
        }

        private void BtmHit_Click(object sender, EventArgs e)
        {
            if (!isSow)
            {
                
                firstNum = Int32.Parse(txtShow.Text);
                txtShow.Text = "";
                opirition = "*";
                showmin = false;
                isSow = true;
                count = 0;
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {

            if (!isSow)
            {
              
                firstNum = Int32.Parse(txtShow.Text);
                txtShow.Text = "";
                opirition = "+";
                isSow = true;
                showmin = false;
                count = 0;
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (!isSow)
            {
             
                firstNum = Int32.Parse(txtShow.Text);
                txtShow.Text = "";
                opirition = "-";
                isSow = true;
                showmin = false;
                count = 0;
            }
        }

        private void Btndivision_Click(object sender, EventArgs e)
        {
            if (!isSow)
            {
               
                firstNum = Int32.Parse(txtShow.Text);
                txtShow.Text = "";
                opirition = "/";
                isSow = true;
                showmin = false;
                count = 0;
            }
        }


       
        private void BtnEqual_Click(object sender, EventArgs e)
        {

                showmin = false;
                SecondNum = Int32.Parse(txtShow.Text);
                
                NumberTwo = true;
            if (count == 0)
            {
                if (opirition == "+") result = (firstNum + SecondNum);
                if (opirition == "*")
                {
                    result = (int)(firstNum * SecondNum);
                }

                if (opirition == "/")
                {
                    result = firstNum / SecondNum;

                }
                if (opirition == "-")
                    result = (firstNum - SecondNum);
                count++;
                num2 = SecondNum;
            }
            else
            {
               
                if (opirition == "+") result += num2;
                if (opirition == "*")
                {
                    result *= num2;
                }

                if (opirition == "/")
                {
                    result /= num2;
                }
                if (opirition == "-")
                    result -= num2;
            }
            
            txtShow.Text = result + "";
                isSow = false;
                showmin = false;
            firstNum = 0;
           

        }
       
        private void BtnComma_Click(object sender, EventArgs e)
        {
            
        }
        bool showmin = false;
        private void BtnMinusPlus_Click(object sender, EventArgs e)
        {
            
            if (!showmin)
            {
                txtShow.Text = "-";
                showmin = true;
            }
            else
            {
                if (showmin)
                {
                    txtShow.Text = "";
                    showmin = false;
                }
            }
        }
    }
}
