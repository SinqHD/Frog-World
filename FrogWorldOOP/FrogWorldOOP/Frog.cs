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
    public class Frog 
    {
    //instance variables
    protected Image imgFrog = Image.FromFile("frog1.gif");
    protected PictureBox picFrog;
    protected string name;


    public Frog(Form form, string aName)
    {
        this.picFrog = new PictureBox();
        this.picFrog.Image = imgFrog;
        this.picFrog.SizeMode = PictureBoxSizeMode.StretchImage;
        this.picFrog.Left = 50;
        this.picFrog.Top = 150;
        this.picFrog.Visible = true;
        this.picFrog.BackColor = Color.Aqua;
        form.Controls.Add(picFrog);
        this.picFrog.MouseClick += new MouseEventHandler(MouseEventFrog);
        this.setName(aName);
    }

    public void setName(string aName)
    {
        name = aName;
    }

    public string getName() 
    {
        return name;

    }

    public void Left(int steps)
    {
        picFrog.Left = picFrog.Left - steps;
    }

    public void Right(int steps)
    {
        picFrog.Left = picFrog.Left + steps;
    }

    public int getXcoord()
    {
       return picFrog.Left;
    }

    public virtual void MouseEventFrog(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
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
