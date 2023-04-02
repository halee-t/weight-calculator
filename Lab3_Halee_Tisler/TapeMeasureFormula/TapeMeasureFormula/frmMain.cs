using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapeMeasureFormula
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            lblWaistHips.Text = "WAIST - Measure at greatest circumference" +
                "; relaxed and comfortable.";
            lblHipsThigh.Text = "HIPS - Feet 4 inches apart, measure" +
                " greated circumference around hips and butt.";
            lblForearmCalf.Text = "FOREARM - Clench fist, measure widest" +
                " part between wrist and elbow.";
            lblWristWrist.Text = "WRIST - Measure just above bony " +
                "protuberance towards the hand.";
        }

        private void lblWaistHips_Click(object sender, EventArgs e)
        {
            //accidental click
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            //accidental click
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //define the variables
            double WH = 0; // male waist or female hips
            double HT = 0; //male hips or female thighs
            double FC = 0; //male forearm or female calf
            double WW = 0; //male wrist or female wrist
            double W = 0; //weight 
            double B = 0; //body fat %
            double L = 0; //lean body mass
            double F = 0; //fat
            double I = 0; //ideal weight


            //convert the text box strings to numbers
            double.TryParse(txtBoxWaistHips.Text, out WH);
            double.TryParse(txtBoxHipsThigh.Text, out HT);
            double.TryParse(txtBoxForearmCalf.Text, out FC);
            double.TryParse(txtBoxWristWrist.Text, out WW);
            double.TryParse(txtBoxWeight.Text, out W);

            //if female is checked, preform this calculation and display the results
            if (rdoFemale.Checked)
                {
                    if (rdo30andUnder.Checked)
                    {
                        B = WH + (.8 * HT) - (2 * FC) - WW;
                        F = W * (B / 100);
                        L = W - F;
                        I = L / .78;

                        lblResults.Text = "You have about " + L.ToString("0.00") + "lbs of lean body weight " +
                        "with " + F.ToString("0.00") + "lbs of fat (" + B.ToString("0.00") +
                        "%). You should weigh no more than " + I.ToString("0.00") + 
                        "lbs (22% fat for females).";
                    }

                    if (rdoOver30.Checked)
                    {
                        B = WH + HT - (2 * FC) - WW;
                        F = W * (B / 100);
                        L = W - F;
                        I = L / .78;

                        lblResults.Text = "You have about " + L.ToString("0.00") + "lbs of lean body weight " +
                        "with " + F.ToString("0.00") + "lbs of fat (" + B.ToString("0.00") +
                        "%). You should weigh no more than " + I.ToString("0.00") + 
                        "lbs (22% fat for females).";
                    }
                }

            //if male is checked, preform this calculation and display the results
            if (rdoMale.Checked)
                {
                    if (rdo30andUnder.Checked)
                    {
                         B = WH + (.5 * HT) - (3 * FC) - WW;
                         F = W * (B / 100);
                         L = W - F;
                         I = L / .85;

                        lblResults.Text = "You have about " + L.ToString("0.00") + "lbs of lean body weight " +
                        "with " + F.ToString("0.00") + "lbs of fat (" + B.ToString("0.00") +
                        "%). You should weigh no more than " + I.ToString("0.00") +
                        "lbs (15% fat for males).";
                    }

                    if (rdoOver30.Checked)
                    {
                         B = WH + (.5 * HT) - (2.7 * FC) - WW;
                         F = W * (B / 100);
                         L = W - F;
                         I = L / .85;

                        lblResults.Text = "You have about " + L.ToString("0.00") + "lbs of lean body weight " +
                        "with " + F.ToString("0.00") + "lbs of fat (" + B.ToString("0.00") +
                        "%). You should weigh no more than " + I.ToString("0.00") +
                        "lbs (15% fat for males).";
                    }
                }
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            //change the label for the measurements depending on if male or female is checked
            //and clear the boxes after each check change.
            if (rdoFemale.Checked)
            {
                lblWaistHips.Text = "HIPS - Feet 4 inches apart, measure greatest " +
                    "circumference around hips and butt.";
                lblHipsThigh.Text = "THIGH - Stand with feet 12 inches apart, measure widest " +
                    "part of upper thigh.";
                lblForearmCalf.Text = "CALF - Stand with weight on both feet, widest part " +
                    "midway between knee and ankle.";
                lblWristWrist.Text = "WRIST - Measure just above bony " +
                    "protuberance towards the hand.";

                txtBoxWaistHips.Clear();
                txtBoxHipsThigh.Clear();
                txtBoxForearmCalf.Clear();
                txtBoxWristWrist.Clear();
                txtBoxWeight.Clear();

            }
            if (rdoMale.Checked)
            {
                lblWaistHips.Text = "WAIST - Measure at greatest circumference" +
                    "; relaxed and comfortable.";
                lblHipsThigh.Text = "HIPS - Feet 4 inches apart, measure" +
                    " greated circumference around hips and butt.";
                lblForearmCalf.Text = "FOREARM - Clench fist, measure widest" +
                    " part between wrist and elbow.";
                lblWristWrist.Text = "WRIST - Measure just above bony " +
                    "protuberance towards the hand.";

                txtBoxWaistHips.Clear();
                txtBoxHipsThigh.Clear();
                txtBoxForearmCalf.Clear();
                txtBoxWristWrist.Clear();
                txtBoxWeight.Clear();
            }
        }

        private void lblResults_Click(object sender, EventArgs e)
        {
            //accidental click
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear all of the textboxes and reset the buttons to their default
            //settings when the button is clicked

            txtBoxWeight.Clear();
            txtBoxWaistHips.Clear();
            txtBoxHipsThigh.Clear();
            txtBoxForearmCalf.Clear();
            txtBoxWristWrist.Clear();
            lblResults.Text = " ";
            rdoMale.Checked = true;
            rdo30andUnder.Checked = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application when the button is clicked

            this.Close();
        }
    }
}
