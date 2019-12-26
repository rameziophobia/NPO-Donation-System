using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.Components.Browser
{
    class circularPicBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (GraphicsPath obj = new GraphicsPath())
            {

                obj.AddEllipse(0, 0, Width - 1, Height - 1);
                Region = new Region(obj);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(new SolidBrush(BackColor), 1), 0, 0, Width - 1, Height - 1);


            }
        }

    }
}
