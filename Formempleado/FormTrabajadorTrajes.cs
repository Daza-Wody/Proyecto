using System.Windows.Forms;
using System.Data;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FormTrabajadorTrajes : Form
    {
        CN_Trajes mostrartrajes_cp = new CN_Trajes();        
        public FormTrabajadorTrajes()
        {
            InitializeComponent();
        }

        private void FormTrabajadorTrajes_Load(object sender, EventArgs e)
        {
            mostrartrajes();
        }

        private void mostrartrajes()
        {
            VistaDatos.DataSource = mostrartrajes_cp.mostrartrajes();
        }
    }
}
