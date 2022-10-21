using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace FrogWorldOOP
{
    public class UndergroundFrog : Frog
    {
        public UndergroundFrog(Form form, string aName)
        : base(form, aName)
        {
            //base.Frog(form, name);
            this.imgFrog = Image.FromFile("undergroundFrog.gif");
            this.picFrog.Image = imgFrog;
            this.picFrog.MouseDoubleClick += new MouseEventHandler(this.MouseEventFrog);
            this.picFrog.BringToFront();
        }
        public void Up(int steps)
        {
            if (this.picFrog.Top >= 180)
                this.picFrog.Top = picFrog.Top - steps;
        }
        public void Down(int steps)
        {
            this.picFrog.Top = picFrog.Top + steps;
        }
        public override void MouseEventFrog(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.XButton1:
                    Up(50);
                    break;
                case MouseButtons.XButton2:
                    Down(50);
                    break;
                case MouseButtons.Right:
                    Right(30);
                    break;
                case MouseButtons.Left:
                    Left(30);
                    break;
            }
        }
    }
}
