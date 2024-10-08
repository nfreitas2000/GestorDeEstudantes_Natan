﻿using System;
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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudantes inserirEstudantes = new FormInserirEstudantes();
            inserirEstudantes.Show();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listaAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaDeEstudantes listaDeEstudantes = new FormListaDeEstudantes();
            listaDeEstudantes.Show();
        }

        private void editarremoverAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarApagarEstudantes formAtualizarApagarEstudantes = new FormAtualizarApagarEstudantes();
            formAtualizarApagarEstudantes.Show();
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstatisticas formEstatisticas = new FormEstatisticas();
            formEstatisticas.Show();
        }
    }
}
