/**
 * Program: Power Bill Calculator
 * Course Module: CPRG 200 OOSD
 * Purpose: This calculates total bill for each type of customer (Residential, Industrial 
 *  and Commercial based on power usage in kWh)
 * Author: : Louise Acosta
 * Date: Feb 24, 2019
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Louise_PowerBill
{
    public partial class frmPowerBill : Form
    {
        public frmPowerBill()
        {
            InitializeComponent();
        }

        // form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            radResidential.Checked = true; // default set to select residential
            txtUsage.Select(); // focus on usage input
        }

        // residential is selected
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            DefaultView(); // set to default view - hide industrial panel
        }

        // commercial is selected
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            DefaultView(); // set to default view - hide industrial panel
        }

        // industrial is selected
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            IndustrialView(); // set to industrial view - show industrial panel
        }

        // Calculate total bill based on kwh usage
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /**
             * Residentials = $0.052 per kWh usage + $6 flat rate
             * Commercial = $0.045 per kWh usage in excess of 1000kwh + $60 flat rate
             * Industrial - rate depends if usage occured during peak hours or off peak hours
             *        (peak hours) = $0.065 per kWh usage in excess of 1000kwh + $76 flat rate
             *        (off peak hours) = $0.028 per kWh usage in excess of 1000kWh + $40 flat rate
             **/

            // local declarations
            double usage;      // input: kwh usage
            double totalBill;  // output: total bill

            double peakUsage;       // input: peak hour usage
            double offPeakUsage;    // input: off peak hour usage
            double peakCharge;      // output: total charge for peak hours
            double offPeakCharge;   //output: total charge for off peak hours

            // RESIDENTIAL CHARGES
            const double RES_RATE = 0.052; // rate per kwh 
            const double RES_FLAT = 6; // flat rate

            // COMMERCIAL CHARFES
            const double COM_RATE = 0.045; // rate per kwh in excess of 1000 
            const double COM_FLAT = 60; // flat rate

            // INDUSTRIAL CHARGES
            // peak hours
            const double PEAK_RATE = 0.065; // rate per kwh in excess of 1000 
            const double PEAK_FLAT = 76; // flat rate

            // off-peak hours
            const double OFFPEAK_RATE = 0.028;  // rate per kwh in excess of 1000 
            const double OFFPEAK_FLAT = 40;     // flat rate

            const double EXCESS_BASE = 1000; // kwh usage above this amount will be charged based on variable rate for commercial and industrial
            
            totalBill = 0;

            if (radResidential.Checked) // residential is selected
            {
                if (IsValidData())
                {
                    CalculateResidentialBill(out usage, out totalBill, RES_RATE, RES_FLAT);
                }
                    
            }

            else if (radCommercial.Checked) // commercial is selected
            {
                if (IsValidData()) // input is valid
                {
                    CalculateCommercialBill(out usage, out totalBill, COM_RATE, COM_FLAT, EXCESS_BASE);
                }
            }

            else if (radIndustrial.Checked) // industrial is selected
            {
                if (IndustrialIsValidData()) //input is valid             
                {
                    CalculateIndustrialBill(out usage, out totalBill, out peakUsage, out offPeakUsage, out peakCharge, out offPeakCharge, PEAK_RATE, PEAK_FLAT, OFFPEAK_RATE, OFFPEAK_FLAT, EXCESS_BASE);
                }
            }

            // display results
            txtBill.Text = totalBill.ToString("c");
        }

        // reset to initial state
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsage.Text = "";
            txtBill.Text = "";
            txtOffPeakUsage.Text = "";
            txtPeakUsage.Text = "";
            txtPeakCharge.Text = "";
            txtOffPeakCharge.Text = "";

            radResidential.Checked = true; // select Residential
            txtUsage.Select(); // focus on usage input
        }

        // terminate execution
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // close and terminate
        }


        // METHODS
        private void DefaultView()
        {
            pnlindustrial.Visible = false; // hide peak and off peak usage (for industrial) panel
            pnlUsage.Visible = true; // show kwh usage input
            txtUsage.Select(); // focus on usage input
            txtBill.Text = ""; // clear total bill textbox
        }

        private void IndustrialView()
        {
            pnlindustrial.Visible = true; // show peak and off peak usage panel
            pnlUsage.Visible = false; // hide usage input for residential and commercial
            txtPeakUsage.Select(); // focus on usage input
            txtBill.Text = ""; // clear total bill textbox
        }

        private void CalculateResidentialBill(out double usage, out double totalBill, double RES_RATE, double RES_FLAT)
        {
            // obtain usage
            usage = Convert.ToDouble(txtUsage.Text);

            totalBill = (RES_RATE * usage) + RES_FLAT;
        }

        private void CalculateCommercialBill(out double usage, out double totalBill, double COM_RATE, double COM_FLAT, double EXCESS_BASE)
        {
            // obtain usage
            usage = Convert.ToDouble(txtUsage.Text);
            if (usage > EXCESS_BASE) // usage > 1000
            {
                totalBill = (COM_RATE * (usage - EXCESS_BASE)) + COM_FLAT;
            }
            else // usage <= 1000
            {
                totalBill = COM_FLAT;
            }
        }

        private void CalculateIndustrialBill(out double usage, out double totalBill, out double peakUsage, out double offPeakUsage, out double peakCharge, out double offPeakCharge, double PEAK_RATE, double PEAK_FLAT, double OFFPEAK_RATE, double OFFPEAK_FLAT, double EXCESS_BASE)
        {
            usage = 0;

            // obtain usage
            peakUsage = Convert.ToDouble(txtPeakUsage.Text);
            offPeakUsage = Convert.ToDouble(txtOffPeakUsage.Text);

            if (peakUsage > EXCESS_BASE) // peak hour usage > 1000
            {
                peakCharge = (PEAK_RATE * (peakUsage - EXCESS_BASE)) + PEAK_FLAT;
            }
            else // peak hour usage <= 1000
            {
                peakCharge = PEAK_FLAT;
            }
            if (offPeakUsage > EXCESS_BASE) // off peak usage > 1000
            {
                offPeakCharge = (OFFPEAK_RATE * (offPeakUsage - EXCESS_BASE)) + OFFPEAK_FLAT;
            }
            else // off peak usage <=100
            {
                offPeakCharge = OFFPEAK_FLAT;
            }
            totalBill = peakCharge + offPeakCharge; // peak + off peak charges

            // display results
            txtPeakCharge.Text = peakCharge.ToString("c"); // total charge for peak hour usage
            txtOffPeakCharge.Text = offPeakCharge.ToString("c"); // total charge for off-peak usage
        }

        // data validation for residential and commercial customer type
        public bool IsValidData()
        {
            return
                Validator.IsProvided(txtUsage, "Usage") &&
                Validator.IsNonNegativeDouble(txtUsage, "Usage");
        }

        // data validation for industrial customer type
        public bool IndustrialIsValidData() 
        {
            return
                Validator.IsProvided(txtPeakUsage, "Usage during peak hours") &&
                Validator.IsNonNegativeDouble(txtPeakUsage, "Usage during peak hours") &&
                Validator.IsProvided(txtOffPeakUsage, "Usage during off peak hours") &&
                Validator.IsNonNegativeDouble(txtOffPeakUsage, "Usage for off peak hours");
        } 
        // END METHODS
        
    } // end form
} // end name space 
