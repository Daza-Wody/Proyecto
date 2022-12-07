using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Trabajador : Form
    {
        public Trabajador()
        {
            InitializeComponent();
            diseñoPersonalizado();
        }
        private void diseñoPersonalizado()
        {
            //Personalizando el diseño
            panelSubMenuServicio.Visible = false;
            panelSubMenuAlquilar.Visible = false;
            
        }
        private void ocultarSubMenu()
        {   
            //Estamos creando un metodo para ocultar los menus
            if (panelSubMenuServicio.Visible == true)
                panelSubMenuServicio.Visible = false;
            if (panelSubMenuAlquilar.Visible == true)
                panelSubMenuAlquilar.Visible = false;
            
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuServicio);
        }

        private void btnTrajes_Click(object sender, EventArgs e)
        {
            abrirHijoFormulario(new FormTrabajadorTrajes());
            //codigo por completar
            //
            //
            ocultarSubMenu();
        }

        

        
       //abrir los paneles hijos 
        private Form? activeForm = null;
        private void abrirHijoFormulario( Form hijoFormulario)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = hijoFormulario;
            hijoFormulario.TopLevel = false;
            hijoFormulario.FormBorderStyle = FormBorderStyle.None;
            hijoFormulario.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(hijoFormulario);
            panelFormularioHijo.Tag = hijoFormulario;
            hijoFormulario.BringToFront();
            hijoFormulario.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuAlquilar);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            abrirHijoFormulario(new FormRegistrar());
        }
        //modificamos en btn todo a un nuevo nombre registrocliente
        private void Btntodo_Click(object sender, EventArgs e)
        {
            abrirHijoFormulario(new FormRegistrarClientes());
        }

        

        
        //oficial boton todos los registros
        private void btntodosRegistros_Click(object sender, EventArgs e)
        {
            abrirHijoFormulario(new VistaRegistrados());
        }
    }
}
