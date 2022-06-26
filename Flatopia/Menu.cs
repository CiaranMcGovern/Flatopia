using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flatopia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Play_Btn_Click(object sender, EventArgs e)
        {
            GameScreen GS = new GameScreen();
            GS.Show();
        }
    }
}
