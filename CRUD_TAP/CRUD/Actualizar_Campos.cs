using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TAP.CRUD
{
    
    public partial class Actualizar_Campos : Form
    {
        CRUD.Funciones Funciones = new Funciones();
        public Actualizar_Campos()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.actualizar(Convert.ToInt32(txtboxID.Text), txtBoxUser.Text, txtboxPass.Text);
            MessageBox.Show(mensaje);
        }
    }
}
