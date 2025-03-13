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
                    g.DrawLine(boli, 50, 300, 100, 250);
                    g.DrawLine(boli, 100, 250, 150, 300);

                    g.DrawLine(boli, 100, 50, 100, 250);

                    g.DrawLine(boli, 100, 50, 200, 50);
                    g.DrawLine(boli, 200, 50, 200, 75);
                    break;
                case 2:
                    g.DrawEllipse(boli, 175, 75, 50, 50);
                    goto case 1;
                case 3:
                    g.DrawLine(boli, 200, 125, 200, 200);
                    goto case 2;
                case 4:
                    g.DrawLine(boli, 200, 140, 150, 170);
                    goto case 3;
                case 5:
                    g.DrawLine(boli, 200, 140, 250, 170);
                    goto case 4;
                case 6:
                    g.DrawLine(boli, 200, 200, 150, 230);
                    goto case 5;

                case 7:
                    g.DrawLine(boli, 200, 200, 250, 230);
                    goto case 6;
                default:
                    break;
            }
        }
    }
}

