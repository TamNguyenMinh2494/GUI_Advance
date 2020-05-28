using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ctrlSketch
{
    public partial class SketchControl: Panel
    {
        Bitmap paper;
        public SketchControl()
        {
            InitializeComponent();
            paper = new Bitmap(Width, Height);
            DoubleBuffered = true; // cho đỡ giật giật panel khi vẽ mới 1 đường thẳng khác
        }
        PointF previousPoint;
        bool hasPrevious = false;
        public Color color;

        public void DrawWithColor(Color color)
        {
            //MessageBox.Show("Sketch color works");
            this.color = color;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Down Sketch runned");
            base.OnMouseDown(e);
            if (hasPrevious == false) // con trỏ chưa nhấn vào paper
            {
                previousPoint = PointToClient(Cursor.Position); // khởi tạo tọa điểm
                hasPrevious = true; // đã có điểm đầu
            }
            else
            {
                Graphics graphic = Graphics.FromImage(paper);
                {
                    graphic.DrawLine((new Pen(color)), previousPoint, PointToClient(Cursor.Position));
                    graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    hasPrevious = false;
                }
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Invalidate(); // di chuyển pointer để vẽ lại
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (paper != null)
            {
                e.Graphics.DrawImage(paper, new PointF(0, 0));
            }
            if (hasPrevious != false)
            {
                e.Graphics.DrawLine((new Pen(Color.Black, 1)), previousPoint, PointToClient(Cursor.Position));
            }
        }
    }
}
