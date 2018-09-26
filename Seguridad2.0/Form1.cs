using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CambioDeHost;
using CapaInterfazMantenimientoUsuarios;
using CapaInterfazAsignacionDePerfiles;
using CapaInterfazIngresoModulos;
using CapaInterfazMantenimientoAplicaciones;
using BITACORA;
using InicioSesion;


namespace Seguridad2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  


        private void AbrirForm(object dshijo)
        { 
            if (this.panel1.Controls.Count > 2)
                this.panel1.Controls.RemoveAt(0);
            Form ds = dshijo as Form;
            ds.TopLevel = false;
            ds.Dock = DockStyle.None;
            this.panel1.Controls.Add(ds);
            this.panel1.Tag = ds;
            ds.Show();
            ds.BringToFront();


        }

        private void cambioDeServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazCambioDeHost ich = new InterfazCambioDeHost();
            AbrirForm(ich);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Size = this.Size;
            InicioSesionForm inicioSes = new InicioSesionForm();
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            DateTime fecha = DateTime.Now;
            this.labelFecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.labelHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
            timer1.Interval = 1000;
            timer1.Start();
            groupBox1.Location = new Point(50, this.Height - 220);
            groupBox2.Location = new Point(this.Width - 350, this.Height - 220);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelFecha.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            this.labelHora.Text = String.Format("{0:hh:mm:ss}", DateTime.Now);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(50, this.Height - 220);
            groupBox2.Location = new Point(this.Width - 350, this.Height - 220);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Size = this.Size;
        }

        private void ingresoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazCrearUsuarios imu = new InterfazCrearUsuarios();
            AbrirForm(imu);
        }

        private void consultaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazMostrarUsuarios imu = new InterfazMostrarUsuarios();
            AbrirForm(imu);
        }

        public void ModificarUsuario()
        {
            InterfazModificarUsuarios imu = new InterfazModificarUsuarios();
            AbrirForm(imu);
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazModificarUsuarios imu = new InterfazModificarUsuarios();
            AbrirForm(imu);
        }

        private void asignacionDePerfilesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazAsignacionDePerfiles iadp = new InterfazAsignacionDePerfiles();
            AbrirForm(iadp);
        }

        private void ingresarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazIngresoModulos iim = new InterfazIngresoModulos();
            AbrirForm(iim);
        }

        private void modificarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazModificarModulos imm = new InterfazModificarModulos();
            AbrirForm(imm);
        }

        private void consultarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazConsultarModulos imm = new InterfazConsultarModulos();
            AbrirForm(imm);
        }

        private void ingresarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazIngrearAplicaciones imm = new InterfazIngrearAplicaciones();
            AbrirForm(imm);
        }

        private void consultarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazMostrarAplicaciones imm = new InterfazMostrarAplicaciones();
            AbrirForm(imm);
        }

        private void modificarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazModificarAplicaciones imm = new InterfazModificarAplicaciones();
            AbrirForm(imm);
        }
    }
}
