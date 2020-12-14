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
    public partial class Eliminar : Form
    {
        CRUD.Funciones Funciones = new Funciones();

        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var mensaje = Funciones.eliminar(Convert.ToInt32(txtBoxID.Text));
            MessageBox.Show(mensaje);
        }
    }
}
