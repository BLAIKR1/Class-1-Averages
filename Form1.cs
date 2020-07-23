using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1ave
{
 //-----------------------------------------------------------------------------------------
			                /* Class 1 / Sum and Average */
 //------------------------------------------------------------------------------------------

 /* Program name: 	    Sum and Average from Class 1
   Project file name:   Class1ave
   Author:		        Kylie Blair
   Date:	            22/07/2020
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2019
   Purpose:		        Calculates the total of 5 numbers, then divides those numbers for the 
                        average.

   Description:		    The user enters 5 numbers, then clicks the sum button to calculate
                        the five numbers, then the user clicks the average to divide those
                        numbers to get the average.

   Known Bugs:		    No bugs, I got the idea on how to code this program with the help
                        of Joy.

   Additional Features: No additional features.
 */
 
 //------------------------------------------------------------------------------------------

 //------------------------------------------------------------------------------------------
    public partial class Form1 : Form
    {
        private const int TEXTBOXES = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = calculateSum();
            textBox6.Text = Convert.ToString(sum);
        }

        private int calculateSum()
        {
            int textboxone = Convert.ToInt32(textBox1.Text);
            int textboxtwo = Convert.ToInt32(textBox2.Text);
            int textboxthree = Convert.ToInt32(textBox3.Text);
            int textboxfour = Convert.ToInt32(textBox4.Text);
            int textboxfive = Convert.ToInt32(textBox5.Text);

            int sum = textboxone + textboxtwo + textboxthree + textboxfour
                + textboxfive;

            return sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = calculateSum();
            double average = sum / TEXTBOXES;
            textBox7.Text = Convert.ToString(Math.Round(average, 2));
        }
    }
}
