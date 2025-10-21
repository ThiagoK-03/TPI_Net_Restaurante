using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsControlLibrary1
{


    //VER ULTIMA ENTRADA GPT

    // 🔴 Botón rojo estilado
    public partial class RedButton : Button
    {
        public RedButton()
        {
            this.BackColor = Color.FromArgb(192, 0, 0);      // rojo oscuro
            this.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.MistyRose;       // texto claro
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Name = "btn_basico";
            this.Text = "Puto el que lee";
        }

    }

    public partial class BasicLabel : Label 
    {
        public BasicLabel() 
        {
            this.AutoSize = false;
            this.BackColor = Color.Transparent;
            this.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.MistyRose;
            this.Name = "label_basic";
            this.Text = "basic Label";
        }

    }

    public partial class BasicTxtBox : TextBox
    {
        public BasicTxtBox()
        {
            this.BackColor = Color.MistyRose;
            this.BorderStyle = BorderStyle.None;
            this.Name = "basicTxtBox";
            this.PlaceholderText = "Content";
        }
    }

    public partial class BasicDataGridView : DataGridView
    {
        public BasicDataGridView()
        {
            // Quitar bordes y resaltar las celdas de forma moderna
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.EnableHeadersVisualStyles = false;
            //this.RowHeadersVisible = false;
            this.AllowUserToResizeRows = false;

            // Colores base
            this.BackgroundColor = Color.FromArgb(245, 220, 220); // tono rosado claro
            this.GridColor = Color.FromArgb(220, 120, 120);

            // Encabezados
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 40, 40);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            this.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
            this.DefaultCellStyle.ForeColor = Color.FromArgb(60, 0, 0);
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 60, 60);
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // Alternancia de filas (para mejor lectura)
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 245, 245);

            // Encabezado de filas (si lo usás)
            this.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 50, 50);
            this.RowHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
    public partial class TopBar : Panel
    {
        public TopBar()
        {
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(192, 0, 0);
        }
    }
}
