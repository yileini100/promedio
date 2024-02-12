using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_del_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            txt_nota4.Clear();
            txt_promedio.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int n1,n2,n3,n4;

            n1= int.Parse(txt_nota1.Text);
            n2 = int.Parse(txt_nota2.Text);
            n3 = int.Parse(txt_nota3.Text);
            n4 = int.Parse(txt_nota4.Text);
           

          int p = (n1 + n2 + n3 + n4)  / 4;

            txt_promedio.Text=p.ToString();
        }
    }
}
