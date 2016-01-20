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

namespace CalcDaysWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var cdoc = new CalcDaysOldClient();
            var bornday = DateTime.ParseExact(textBoxBirthdate.Text,
                                            "dd.MM.yyyy",
                                            CultureInfo.InvariantCulture);

            labelResult.Text = cdoc.daysOld(bornday).ToString();
        }

    }
}
