using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormControlsLibrary
{
    public class RedButton : Button
    {
        public RedButton()
        {
            this.BackColor = Color.FromArgb(192, 0, 0); // Rojo Oscuro
            this.ForeColor = Color.MistyRose;       // texto claro
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }


    };
    //public class TopBar : Panel
    //{
    //    public TopBar()
    //    {
    //        this.BackColor = Color.FromArgb(192, 0, 0);
    //        //this.Controls.Add(BtnSalir);
    //        this.Dock = DockStyle.Top;
    //    }
    //};
        

    //private BtnSalir()
    //{
    //    this.BackColor = Color.FromArgb(192, 0, 0);
    //    this.FlatAppearance.BorderSize = 0;
    //    this.FlatStyle = FlatStyle.Flat;
    //    this.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
    //    this.ForeColor = Color.MistyRose;
    //    this.Location = new Point(328, -5);
    //    this.Name = "btn_salir";
    //    this.Size = new Size(23, 30);
    //    this.TabIndex = 4;
    //    this.Text = "x";
    //    this.UseVisualStyleBackColor = false;
    //}

    }
