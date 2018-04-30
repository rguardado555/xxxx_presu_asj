using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System;

namespace ModuloPresupuesto
{
    public class clsColor
    {
        public static Color clrHorBG_GrayBlue = Color.FromArgb(43, 84, 144);
        public static Color clrHorBG_White = Color.FromArgb(43, 84, 144);
        public static Color clrSubmenuBG = Color.FromArgb(43, 84, 144);
        public static Color clrImageMarginBlue = Color.FromArgb(43, 84, 144);
        public static Color clrImageMarginWhite = Color.FromArgb(43, 84, 144);
        public static Color clrImageMarginLine = Color.FromArgb(43, 84, 144);
        public static Color clrSelectedBG_Blue = Color.FromArgb(43, 84, 144);
        public static Color clrSelectedBG_Header_Blue = Color.FromArgb(43, 84, 144);
        public static Color clrSelectedBG_White = Color.FromArgb(43, 84, 144);
        public static Color clrSelectedBG_Border = Color.FromArgb(43, 84, 144);
        public static Color clrSelectedBG_Drop_Blue = Color.FromArgb(43, 84, 144);
        public static Color clrSelectedBG_Drop_Border = Color.FromArgb(43, 84, 144);
        public static Color clrMenuBorder = Color.FromArgb(43, 84, 144);
        public static Color clrCheckBG = Color.FromArgb(43, 84, 144);

        public static Color clrVerBG_GrayBlue = Color.FromArgb(43, 84, 144);
        public static Color clrVerBG_White = Color.FromArgb(43, 84, 144);
        public static Color clrVerBG_Shadow = Color.FromArgb(39, 51, 63);

        public static Color clrToolstripBtnGrad_Blue = Color.FromArgb(43, 84, 144);
        public static Color clrToolstripBtnGrad_White = Color.White;
        public static Color clrToolstripBtn_Border = Color.FromArgb(15, 120, 120);
        public static Color clrToolstripBtnGrad_Blue_Pressed = Color.FromArgb(39, 51, 93);
        public static Color clrToolstripBtnGrad_White_Pressed = Color.FromArgb(15, 120, 100);

        public static void DrawRoundedRectangle(Graphics g, int x, int y,
            int width, int height, int m_diameter, Color color)
        {

            using (Pen pen = new Pen(color))
            {
                //Dim g As Graphics
                var BaseRect = new RectangleF(x, y, width, height);
                var ArcRect = new RectangleF(BaseRect.Location, new SizeF(m_diameter, m_diameter));
                //top left Arc
                g.DrawArc(pen, ArcRect, 180, 90);
                g.DrawLine(pen, x + Convert.ToInt32(m_diameter / 2), y, x + width - Convert.ToInt32(m_diameter / 2), y);

                // top right arc
                ArcRect.X = BaseRect.Right - m_diameter;
                g.DrawArc(pen, ArcRect, 270, 90);
                g.DrawLine(pen, x + width, y + Convert.ToInt32(m_diameter / 2), x + width, y + height - Convert.ToInt32(m_diameter / 2));

                // bottom right arc
                ArcRect.Y = BaseRect.Bottom - m_diameter;
                g.DrawArc(pen, ArcRect, 0, 90);
                g.DrawLine(pen, x + Convert.ToInt32(m_diameter / 2), y + height, x + width - Convert.ToInt32(m_diameter / 2), y + height);

                // bottom left arc
                ArcRect.X = BaseRect.Left;
                g.DrawArc(pen, ArcRect, 90, 90);
                g.DrawLine(pen, x, y + Convert.ToInt32(m_diameter / 2), x, y + height - Convert.ToInt32(m_diameter / 2));
            }
        }

    }
}
