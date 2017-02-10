using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common_Geometery_Formulas_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputHide(); //hide input components until they need to be revealed

        }

       
        private void rbtnTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
            //area txtInput1=top, txtInput2=bottom, txtInput3=height
            //perimeter txtInput1=top, txtInput2=bottom, txtInput3=leftSide, txtInput4=rightSide
            if (rbtnArea.Checked)
            {
                inputHide();
                txtInput1.Visible = true;
                txtInput2.Visible = true;
                txtInput3.Visible = true;
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "h";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;

            }
            else if (rbtnPerimeter.Checked)
            {
                inputHide();
                txtInput1.Visible = true;
                txtInput2.Visible = true;
                txtInput3.Visible = true;
                txtInput4.Visible = true;
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "c";
                label4.Text = "d";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            else if (rbtnAreaPerimeter.Checked)
            {
                inputHide();
                txtInput1.Visible = true;
                txtInput2.Visible = true;
                txtInput3.Visible = true;
                txtInput4.Visible = true;
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "c";
                label4.Text = "d";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
        }

        private void rbtnParallelogram_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTriangle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnRhombus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnArea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPerimeter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAreaPerimeter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtInput3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnswer1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtInput4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnswer2_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //display answer txtboxes
            //check if area, perimeter, or area and perimeter selected
            //display area
            //display perimeter
            //display area and perimeter
            /*if (rbtnArea.Checked)
            {
                lblAnswer1.Text = "Area";
                lblAnswer1.Visible = true;
                decimal Area = 0;//Area won't work for the switch statement.  FIX ME!!!
                //decide which formula method to call
                switch (Area)
                {
                    case rbtnCircle.Checked:
                        Area = CircleArea(Convert.ToDecimal(txtInput1.Text));
                        break;

                }



                //txtAnswer1.Text = Convert.ToString();
                txtAnswer1.Visible = true;
                
            }
            
            //change label to reflect Area or Perimeter selection
            lblAnswer1.Visible = true;
            txtAnswer1.Visible = true;
            //area and perimeter
            lblAnswer1.Visible = true;
            txtAnswer1.Visible = true;
            lblAnswer2.Visible = true;
            txtAnswer2.Visible = true;
            */
            btnCalculate.Text = "Answer";
            
        }

        private void btnAC_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal Area(decimal lengthBase, decimal widthHeight = 0)//width optional in case of square
            //txtInput1=lengthBase, txtInput2=widthHeight
        {
            if (widthHeight == 0)//test for second variable
            {
                widthHeight = lengthBase; //if it's a square, they are the same
            }
            decimal Area=lengthBase* widthHeight;
            return Area;
        }
        private decimal RectanglePerimeter(decimal lengthBase, decimal widthHeight = 0)
            //txtInput1=lengthBase, txtInput2=widthHeight
        {
            if (widthHeight == 0)//test for second variable
            {
                widthHeight = lengthBase; //if it's a square, they are the same
            }
            decimal Perimeter = 2*(lengthBase + widthHeight);
            return Perimeter;
        }
        private decimal TriangleArea (decimal lengthBase, decimal widthHeight)
            //txtInput1=lengthBase, txtInput2=widthHeight
        {
            decimal Area = (lengthBase * widthHeight) / 2;
            return Area;
        }
        private decimal TrianglePerimeter(decimal a, decimal b, decimal c)
        //txtInput1=lengthBase, txtInput2=widthHeight
        {
            decimal Perimeter = a+b+c;
            return Perimeter;
        }
        private decimal TrapezoidArea(decimal top, decimal bottom, decimal height)
        //txtInput1=top, txtInput2=bottom, txtInput3=height
        {
            decimal Area = ((top+bottom)/2)*height;
            return Area;
        }
        private decimal TrapezoidPerimeter(decimal top, decimal bottom, decimal leftSide, decimal rightSide)
        //txtInput1=top, txtInput2=bottom, txtInput3=leftSide, txtInput4=rightSide 
        {
            decimal Perimeter = top+bottom+leftSide+rightSide;
            return Perimeter;
        }
        private decimal CircleArea(decimal diameter)
        //txtInput1=diameter
        {
            decimal Area = Convert.ToDecimal( Math.Round(((Math.PI) * (Math.Pow(Convert.ToDouble(diameter), 2) ))/4));
            return Area;
        }
        private decimal CirclePerimeter(decimal diameter)
        //txtInput1=diameter
        {
            decimal Perimeter = Math.Round(Convert.ToDecimal(Math.PI) * diameter, 6);
            return Perimeter;
        }
        private void inputHide()
        {
            txtInput1.Visible = false;
            txtInput2.Visible = false;
            txtInput3.Visible = false;
            txtInput4.Visible = false;
            txtAnswer2.Visible = false;
            txtAnswer1.Visible = false;
            lblAnswer1.Visible = false;
            lblAnswer2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btnCalculate.Text = "Calculate";

        }
    }
}
