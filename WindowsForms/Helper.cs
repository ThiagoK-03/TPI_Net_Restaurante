using System.Drawing;
using System.Windows.Forms;

//namespace WindowsForms
//{
//    public static class FormHelper
//    {
//        private static bool isDragging = false;
//        private static Point mouseOffset;

//        // Método que registra los eventos necesarios en el panel
//        public static void EnableDrag(Form form, Panel panel)
//        {
//            panel.MouseDown += (s, e) =>
//            {
//                if (e.Button == MouseButtons.Left)
//                {
//                    isDragging = true;
//                    mouseOffset = new Point(-e.X, -e.Y);
//                }
//            };

//            panel.MouseMove += (s, e) =>
//            {
//                if (isDragging)
//                {
//                    Point mousePos = Control.MousePosition;
//                    mousePos.Offset(mouseOffset.X, mouseOffset.Y);
//                    form.Location = mousePos;
//                }
//            };

//            panel.MouseUp += (s, e) =>
//            {
//                isDragging = false;
//            };
//        }
//    }
//}