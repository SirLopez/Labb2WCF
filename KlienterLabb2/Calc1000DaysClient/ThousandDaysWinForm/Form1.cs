using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThousandDaysWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            var tdc = new ThousandDaysClient();

            var bornday = DateTime.ParseExact(textBoxBirthday.Text,
                                            "dd.MM.yyyy",
                                            CultureInfo.InvariantCulture);
            labelResult.Text = @"Your next celebrationdate will be at " + tdc.nextThousandDay(bornday).ToShortDateString();

        }
    }
}
