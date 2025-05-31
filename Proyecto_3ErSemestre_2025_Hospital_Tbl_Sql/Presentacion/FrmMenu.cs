using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.presentacion;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    public partial class FrmMenu : Form
    {
        //Constructor
        public FrmMenu()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Las varibles de posicion de la venta seran ejex y eje y de igual manera el tamacho de ancho (size width) y largo (size heigth)

        int EjeX, Ejey;
        int sizewidth, sizeheigth;

        private void btn_maximizar_Click(object sender, EventArgs e)
        {

            EjeX = this.Location.X;
            Ejey = this.Location.Y;
            sizewidth = this.Size.Width;
            sizeheigth = this.Size.Height;

            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;

            this.Size = new Size (sizewidth, sizeheigth);
            this.Location = new Point (EjeX, Ejey);

        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnGestionHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestioHabitaciones>();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmHabitaciones>();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPacientes>();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMedicamento>();
        }

        private void btnPagoCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPagoCitas>();
        }

        private void btnPagoEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPEmpleados>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuarios>();
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        // Metodo para abrir formularios dentro del panel

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

    }
}
