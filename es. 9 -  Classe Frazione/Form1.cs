using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es._9____Classe_Frazione
{
    public partial class Form1 : Form
    {
        Frazione numF;


        public Form1()
        {
            InitializeComponent();
            numF = new Frazione(4, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        //BOTTONE SEMPLIFICA FRAZIONE
        private void button1_Click(object sender, EventArgs e)
        {
            numF.SemplificaFrazione();
            MessageBox.Show("La frazione semplificata è: ");
        }
    }
}
