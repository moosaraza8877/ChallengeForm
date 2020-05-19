using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int xCord = random.Next(50, 300);
            int yCord = random.Next(50, 300);
            Point point = new Point(xCord, yCord);
            btnClick.Location = point;
        }
    }
}
