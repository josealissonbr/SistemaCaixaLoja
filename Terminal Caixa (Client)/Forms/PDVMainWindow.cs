using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCaixaLoja.Forms
{
    public partial class PDVMainWindow : KryptonForm
    {
        public PDVMainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            panel2.Size = new Size(this.Size.Height, (30 / 100) * this.Size.Width);
            //pictureBox1.Location = new Point((panel1.Height / 2) - pictureBox1.Height, (panel1.Width / 2) - pictureBox1.Width);
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
