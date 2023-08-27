using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double p = 0.5;
        double r;
        Random rand = new Random();
        private void btAnswer_Click(object sender, EventArgs e)
        {
            lbAnswer.Text.Trim();
            if (tbQuestion.Text != String.Empty)
            {
                r = rand.NextDouble();
                if (r < p) lbAnswer.Text = "Yes!";
                else lbAnswer.Text = "No!";
            }
            else lbAnswer.Text = "Ask me a question.";
        }
    }
}
