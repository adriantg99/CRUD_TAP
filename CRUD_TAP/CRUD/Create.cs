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
    public partial class Create : Form
    {
        CRUD.Funciones Funciones = new Funciones();
        public Create()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.insertar(txtBoxUser.Text, txtboxPass.Text);
            MessageBox.Show(mensaje);
        }
    }
}
