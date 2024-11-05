using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pbl
{
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20; // Define o raio da borda
        public Color BorderColor { get; set; } = Color.Black;  // Define a cor da borda
        public int BorderSize { get; set; } = 2;  // Define a espessura da borda

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Definindo os cantos arredondados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            // Aplicando a forma do botão
            this.Region = new Region(path);

            // Preenchendo o fundo do botão
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            // Desenhando a borda com a cor definida
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                pevent.Graphics.DrawPath(pen, path);
            }

            // Desenhando o texto do botão
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

}
