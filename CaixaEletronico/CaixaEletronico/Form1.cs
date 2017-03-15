using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta guilerme = new Conta();
            Conta mauricio = new Conta();

            guilerme.saldo = 1500.0;
            mauricio.saldo = 2000.0;


            guilerme.Traferencia(200.0, mauricio);

            MessageBox.Show("O saldo do guilerme é " + guilerme.saldo);
            MessageBox.Show("O saldo do guilerme é " + mauricio.saldo);







        }
    }
}
