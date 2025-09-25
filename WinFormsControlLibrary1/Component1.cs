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
            this.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            //this.AutoSize = true;
            this.BackColor = Color.Transparent;
            this.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.MistyRose;
            this.Name = "label_basic";
            this.Text = "basic Label";
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
