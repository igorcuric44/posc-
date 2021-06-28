using System.Windows.Forms;
using System.Drawing;
using System;

public class pos1:Form
{
Button tipka1;
Button tipka2;

public pos1()
{
	InitializeComponent();
}

private void InitializeComponent()
{
	this.Text="pos blagajna";
	this.Size=new Size(300,500);
	this.StartPosition=FormStartPosition.CenterScreen;
	this.WindowState = FormWindowState.Minimized;
	this.MaximizeBox = false;

	Font font=new Font("Verdana",14,FontStyle.Bold);

	tipka1=new Button();
	tipka1.Location=new Point(30,30);
	tipka1.Size=new Size(240,30);
	tipka1.Text="Blagajna";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(30,70);
	tipka2.Size=new Size(240,30);
	tipka2.Text="Unos";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);

}

private void tipka1_click(object sender,EventArgs e)
{
	Console.WriteLine("blagajna");
	blagajna bla1=new blagajna();
	bla1.Show();

}

private void tipka2_click(object sender,EventArgs e)
{
	Console.WriteLine("unos");
	unos uno1=new unos();
	uno1.Show();

}


public static void Main()
{
	Application.Run(new pos1());
}
}

class blagajna:Form
{

public blagajna(){
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="blagajna";
	this.Size=new Size(800,600);
	this.StartPosition=FormStartPosition.CenterScreen;

}

}

class unos:Form
{
Button tipka1;
Button tipka2;

public unos(){
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Unos";
	this.Size=new Size(300,400);
	this.StartPosition=FormStartPosition.CenterScreen;

	tipka1=new Button();
	tipka1.Location=new Point(30,30);
	tipka1.Size=new Size(240,30);
	tipka1.Text="Zatvori";
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(30,70);
	tipka2.Size=new Size(240,30);
	tipka2.Text="Unos";
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);
}

private void tipka1_click(object sender,EventArgs e)
{
	Console.WriteLine("utrnio");
	this.Close();

}

private void tipka2_click(object sender,EventArgs e)
{
	

}
}





