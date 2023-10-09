using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristAttractions
{
    public partial class Form1 : Form
    {
        private string[] attractions = { "The Big Hole", "Table Mountain", "Kruger National Park", "Drakensberg Mountains" };
        private string[] provinces = { "Northern Cape", "Western Cape", "Mpumalanga", "Kwazulu Natal" };

        private int currentAttractionIndex = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayNextAttraction();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.Trim();

            if (currentAttractionIndex < attractions.Length)
            {
                string correctProvince = provinces[currentAttractionIndex];

                if (guess.Equals(correctProvince, StringComparison.OrdinalIgnoreCase))
                {
                    // Correct province guess
                    MessageBox.Show("Correct province guess! You've identified the province.");
                    txtGuess.Clear();
                    currentAttractionIndex++;

                    if (currentAttractionIndex < attractions.Length)
                    {
                        DisplayNextAttraction();
                    }
                    else
                    {
                        MessageBox.Show("Congratulations! You've completed the game.");
                        Application.Exit();
                    }
                }
                else
                {
                    // Incorrect province guess
                    MessageBox.Show("Incorrect province guess. Try again.");
                }
            }
        }
        private void DisplayNextAttraction()
        {
            if (currentAttractionIndex < attractions.Length)
            {
                lblAttractions.Text = attractions[currentAttractionIndex];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuess.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}






