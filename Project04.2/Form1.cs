using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project 04
// Date: 02/13/2015 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project04._2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make a meesage box appear that will display programmers name and class
            MessageBox.Show("Matthew Vaughan\nCS1400 Section 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close program when activated
            this.Close();
        }

        /// <summary>
        /// Calculate Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare a constant
            const double TRIANGLES_TOTAL = 180;

            //Take the values for side A, SideB, Angle A and store in a variable
            double sideA = double.Parse(txtSideA.Text);
            double sideB = double.Parse(txtSideB.Text);
            double angleC = double.Parse(txtAngleC.Text);

            //Convert Angle A into Radians by calling the conversion method
            double radiansAngleC = ConvertDegreesToRadians(angleC);

            //Find the length of the third side by calling the Side Angle Side Method
            double sideC = SideAngleSide(sideA, radiansAngleC, sideB);

            //Package the answer and Display it
            string answerSideC = ($"{sideC:N2}");
            txtSideC.Text = answerSideC;

            //Call Side Side Side Method to find Angle A
            double angleA = SideSideSide(sideA, sideB, sideC);

            //Convert from radians to degrees
            angleA = angleA / (Math.PI/TRIANGLES_TOTAL);

            //Package and display Angle A
            string answerAngleA = ($"{angleA:N2}");
            txtAngleA.Text = answerAngleA;

            //Find the last angle by adding up the two we have and subtracting them from 180
            double angleB = TRIANGLES_TOTAL - (angleA + angleC);

            //Package and display Angle B
            string answerAngleB = ($"{angleB:N2}");
            txtAngleB.Text = answerAngleB;
        }

        /// <summary>
        /// SideAngleSide
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="angle1"></param>
        /// <param name="side2"></param>
        /// <returns="side3"></returns>
        private double SideAngleSide(double side1, double angle1, double side2)
        {
            //Declare some variables
            const double TWO = 2.0;

            //Plug the sides and angle in the Side Angle Side formula
            double side3 = (Math.Sqrt(((side1 * side1) + (side2 * side2)) - (TWO * side1 * side2 * (Math.Cos(angle1)))));

            return side3;
        }

        /// <summary>
        /// ConvertDegreesToRadians
        /// </summary>
        /// <param name="angleInDegrees"></param>
        /// <returns="radians"></returns>
        private double ConvertDegreesToRadians(double angleInDegrees)
        {
            //Declare some variables used to convert an angle in degrees to radians
            const double HALF_CIRCLE = 180.0;

            //Convert the angle in degrees into radians by multiplying by PI/180.0
            double radians = (angleInDegrees * (Math.PI / HALF_CIRCLE));

            return radians;
        }

        /// <summary>
        /// SideSideSide
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns="angle"></returns>
        private double SideSideSide(double sideA, double sideB, double sideC)
        {
            //Declare some variables
            const double TWO = 2.0;

            //Plug all the sides into the broken down formula
            double angleBeforeDivision = Math.Pow(sideC, 2) + Math.Pow(sideB, 2) - Math.Pow(sideA, 2);
            double angleDivisor = TWO * sideC * sideB;
            double angleAfterDivision = angleBeforeDivision / angleDivisor;
            double angle = Math.Acos(angleAfterDivision);

            return angle;
        }

        /// <summary>
        /// Clear Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all txtBoxes
            txtAngleA.Text = "";
            txtAngleB.Text = "";
            txtAngleC.Text = "";
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtSideC.Text = "";
        }
    }
}
