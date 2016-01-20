using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyClientWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            TeamClient tc = new TeamClient();
            
                textBoxResult.Text = string.Join(Environment.NewLine, tc.GetTeamNames());
        }
    }
}
