using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DibujoAhorcado
{
    [DefaultEvent("CambiaError")]
    [DefaultProperty("Errores")]
    public partial class AhorcadoComponent : UserControl
    {
        private int errores = 0;
        [Category("Properties")]
        [Description("Obtiene o establece los  errores del ahorcado")]
        public int Errores
        {
            set
            {
                if (value < 0 && value > 7)
                {
                    return;
                }


                if (value == 7)
                {
                    OnAhorcado(EventArgs.Empty);
                }
                errores = value;

                Refresh();
                OnCambiaError(EventArgs.Empty);
            }
            get
            {
                return errores;
            }
        }
        public AhorcadoComponent()
        {
            InitializeComponent();
        }

        [Category("Events")]
        [Description("Se lanza al aumentar los errores(o disminuirlos)")]
        public event EventHandler CambiaError;
        protected virtual void OnCambiaError(EventArgs e)
        {
            CambiaError?.Invoke(this, e);
        }

        [Category("Events")]
        [Description("Se lanza al completar la figura")]
        public event EventHandler Ahorcado;
        protected virtual void OnAhorcado(EventArgs e)
        {
            Ahorcado?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen boli = new Pen(Color.Black, 5);

            switch (errores)
            {
                case 1:
                    g.DrawLine(boli, Width * 0.05f, Height * 0.75f, Width * 0.1f, Height * 0.625f);
                    g.DrawLine(boli, Width * 0.1f, Height * 0.625f, Width * 0.15f, Height * 0.75f);

                    g.DrawLine(boli, Width * 0.1f, Height * 0.125f, Width * 0.1f, Height * 0.625f);

                    g.DrawLine(boli, Width * 0.1f, Height * 0.125f, Width * 0.2f, Height * 0.125f);
                    g.DrawLine(boli, Width * 0.2f, Height * 0.125f, Width * 0.2f, Height * 0.1875f);
                    break;
                case 2:
                    g.DrawEllipse(boli, Width * 0.175f, Height * 0.1875f, Width * 0.05f, Height * 0.125f);
                    goto case 1;
                case 3:
                    g.DrawLine(boli, Width * 0.2f, Height * 0.3125f, Width * 0.2f, Height * 0.5f);
                    goto case 2;
                case 4:
                    g.DrawLine(boli, Width * 0.2f, Height * 0.35f, Width * 0.15f, Height * 0.425f);
                    goto case 3;
                case 5:
                    g.DrawLine(boli, Width * 0.2f, Height * 0.35f, Width * 0.25f, Height * 0.425f);
                    goto case 4;
                case 6:
                    g.DrawLine(boli, Width * 0.2f, Height * 0.5f, Width * 0.15f, Height * 0.575f);
                    goto case 5;
                case 7:
                    g.DrawLine(boli, Width * 0.2f, Height * 0.5f, Width * 0.25f, Height * 0.575f);
                    goto case 6;
                default:
                    break;
            }
        }
    }
}

