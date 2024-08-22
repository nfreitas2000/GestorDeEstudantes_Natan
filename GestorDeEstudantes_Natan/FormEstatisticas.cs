using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes_Natan
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
          corPainelTotal = panelTotal.BackColor;
          corPainelMeninos = panelMeninos.BackColor;
          corPainelMeninas = panelMeninas.BackColor;
        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.Black;
            labelTotal.ForeColor = corPainelTotal;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = Color.Black;
            panelTotal.BackColor = corPainelTotal;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelMeninos;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            labelMeninos.ForeColor = Color.Black;
            panelMeninos.BackColor = corPainelMeninos;
        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelMeninas;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            labelMeninas.ForeColor = Color.Black;
            panelMeninas.BackColor = corPainelMeninas;
        }
    }
}
