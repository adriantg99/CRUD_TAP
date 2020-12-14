using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TAP
{
    public partial class Form1 : Form
    {

        CRUD_TAP.CRUD.Funciones function = new CRUD.Funciones();
        CRUD.Create Registro = new CRUD.Create();
        CRUD.Actualizar_Campos Update = new CRUD.Actualizar_Campos();
        CRUD.Eliminar eliminar = new CRUD.Eliminar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clasetopicosDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.clasetopicosDataSet1.usuarios);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Registro.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = function.mostrar();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            Update.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar.Show();
        }
    }
}
