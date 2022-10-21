using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FrogWorldOOP
{
    public class HoverFrog : Frog
    {
        public HoverFrog(Form form, string aName)
        : base (form, aName)
        {
            //base.Frog(form, name);
            this.imgFrog = Image.FromFile("hoverFrog.gif");
            this.picFrog.Image = imgFrog;
            this.picFrog.MouseDoubleClick += new MouseEventHandler(this.MouseEventFrog);
        }

        public void Up(int steps)
        {
            this.picFrog.Top = picFrog.Top - steps;
        }

        public void Down(int steps)
        {
            if (this.picFrog.Top <= 145)
                this.picFrog.Top = picFrog.Top + steps;
        }

        public override void MouseEventFrog(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    Down(50);
                    break;
                case MouseButtons.Left:
                    Up(50);
                    break;
            }
        }
    }
}
