using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Mono.Data.Sqlite;

public class pos1:Form
{
private Button tipka1;
private Button tipka2;
private Button tipka3;
private Button tipka4;

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
	this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

	tipka3=new Button();
	tipka3.Location=new Point(30,110);
	tipka3.Size=new Size(240,30);
	tipka3.Text="Skladiste";
	tipka3.Font=font;
	tipka3.Click+=new EventHandler(tipka3_click);
	this.Controls.Add(tipka3);

	tipka4=new Button();
	tipka4.Location=new Point(30,150);
	tipka4.Size=new Size(240,30);
	tipka4.Text="Popuna skladista";
	tipka4.Font=font;
	tipka4.Click+=new EventHandler(tipka4_click);
	this.Controls.Add(tipka4);
	
	
	
}

private void tipka1_click(object sender,EventArgs e)
{	blagajna bla1;
	Console.WriteLine("blagajna");
	bla1=new blagajna(tipka1);
	bla1.Show();
	(sender as Button).Enabled = false;
	
}

private void tipka2_click(object sender,EventArgs e)
{
	Console.WriteLine("unos");
	unos uno1=new unos(tipka2);
	uno1.Show();
	((Button)sender).Enabled = false;
}

private void tipka3_click(object sender,EventArgs e)
{
	Console.WriteLine("skladiste");
	skladiste skl1=new skladiste(tipka3);
	skl1.Show();
	((Button)sender).Enabled = false;
}


private void tipka4_click(object sender,EventArgs e)
{
	Console.WriteLine("skladisnica");
	skladisnica skl1=new skladisnica(tipka4);
	skl1.Show();
	((Button)sender).Enabled = false;
}
public static void Main()
{
	Application.Run(new pos1());
}
}

class blagajna:Form
{
private Button tipka1x;
public blagajna(Button tipka1){
	tipka1x=tipka1;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="blagajna";
	this.Size=new Size(800,600);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
	this.StartPosition=FormStartPosition.CenterScreen;
	
}


private void Form1_FormClosed(object sender, FormClosedEventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
}

}

class unos:Form
{
private Button tipka1,tipka2;
private Label id_label,artikl_label,kolicina_label,mjera_label,cijena_label;
private TextBox id_text,artikl_text,kolicina_text,mjera_text,cijena_text;
private Button tipka1x;
public unos(Button tipka1)
{
	tipka1x=tipka1;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Unos";
	this.Size=new Size(300,500);
	this.StartPosition=FormStartPosition.CenterScreen;
	this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
	this.MaximizeBox = false;
	this.FormBorderStyle = FormBorderStyle.FixedSingle;


	Font font=new Font("Verdana",12,FontStyle.Bold);

	id_label=new Label();
	id_label.Location=new Point(30,30);
	id_label.Size=new Size(100,30);
	id_label.Text="Id";
	id_label.Font=font;
	this.Controls.Add(id_label);

	id_text=new TextBox();
	id_text.Location=new Point(170,30);
	id_text.Size=new Size(100,30);
	id_text.Text="";
	id_text.Font=font;
	this.Controls.Add(id_text);
		
	artikl_label=new Label();
	artikl_label.Location=new Point(30,70);
	artikl_label.Size=new Size(100,30);
	artikl_label.Text="Artikl";;
	artikl_label.Font=font;
	this.Controls.Add(artikl_label);

	artikl_text=new TextBox();
	artikl_text.Location=new Point(170,70);
	artikl_text.Size=new Size(100,30);
	artikl_text.Text="";
	artikl_text.Font=font;
	this.Controls.Add(artikl_text);

	kolicina_label=new Label();
	kolicina_label.Location=new Point(30,110);
	kolicina_label.Size=new Size(100,30);
	kolicina_label.Text="Kolicina";
	kolicina_label.Font=font;
	this.Controls.Add(kolicina_label);

	kolicina_text=new TextBox();
	kolicina_text.Location=new Point(170,110);
	kolicina_text.Size=new Size(100,30);
	kolicina_text.Text="";
	kolicina_text.Font=font;
	this.Controls.Add(kolicina_text);

	mjera_label=new Label();
	mjera_label.Location=new Point(30,150);
	mjera_label.Size=new Size(100,30);
	mjera_label.Text="Mjera";
	mjera_label.Font=font;
	this.Controls.Add(mjera_label);

	mjera_text=new TextBox();
	mjera_text.Location=new Point(170,190);
	mjera_text.Size=new Size(100,30);
	mjera_text.Text="";
	mjera_text.Font=font;
	this.Controls.Add(mjera_text);

	cijena_label=new Label();
	cijena_label.Location=new Point(30,190);
	cijena_label.Size=new Size(100,30);
	cijena_label.Text="Cijena";
	cijena_label.Font=font;
	this.Controls.Add(cijena_label);

	cijena_text=new TextBox();
	cijena_text.Location=new Point(170,150);
	cijena_text.Size=new Size(100,30);
	cijena_text.Text="";
	cijena_text.Font=font;
	this.Controls.Add(cijena_text);






	tipka1=new Button();
	tipka1.Location=new Point(30,440);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(170,440);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);
}

private void tipka1_click(object sender,EventArgs e)
{	
	int id=Convert.ToInt32(id_text.Text);
	string artikl=Convert.ToString(artikl_text.Text);
	int kolicina=Convert.ToInt32(kolicina_text.Text);
	float mjera=Convert.ToSingle(mjera_text.Text);
	float cijena=Convert.ToSingle(cijena_text.Text);

	Console.WriteLine("utrnio");
	string cs="Data Source=baza.db";

	SqliteConnection con=null;
	SqliteCommand cmd=null;

	con=new SqliteConnection(cs);
	
	try
	{
		con.Open();
		cmd=new SqliteCommand(con);
		cmd.CommandText=@"insert into skladiste(id,artikl,kolicina,mjera,cijena)
				values ("+id+",'"+artikl+"',"+kolicina+","+mjera+","+cijena+");";
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SqliteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}




	this.Close();

}

private void tipka2_click(object sender,EventArgs e)
{
	Console.WriteLine("utrnio");
	this.Close();	

}

private void Form1_FormClosed(object sender, FormClosedEventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
}
}

class skladiste:Form
{
private DataGridView dgv;
private Button btn1;
private Button tipka2x;
public skladiste(Button tipka2){
	tipka2x=tipka2;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="SKLADISTE";
	this.Size=new Size(800,600);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
	this.MaximizeBox = false;
	this.StartPosition=FormStartPosition.CenterScreen;
	this.Load+=new EventHandler(dogodio);
	
	dgv=new DataGridView();
	dgv.Location=new Point(30,50);
	dgv.Size=new Size(740,400);
	this.Controls.Add(dgv);

	btn1 = new Button();
	btn1.Location = new Point(32, 20);
	btn1.Text="Tipka";	
	btn1.Click+=new EventHandler(dogodio);

    this.Controls.Add(btn1);
	}

	private void dogodio(object sender, EventArgs e)
    {

	SqliteConnection connection;
	SqliteCommand command;
	SqliteDataAdapter adapter=new SqliteDataAdapter();
	DataSet ds=new DataSet();
	DataTable dt=null;
	string ConnectionString=null;
	string sql=null;
	
	ConnectionString="Data Source=baza.db";
	sql="select * from skladiste"; 
		
	connection=new SqliteConnection(ConnectionString);
	try
	{
	connection.Open();
	command=new SqliteCommand(sql,connection);
	adapter.SelectCommand=command;
	adapter.Fill(ds);
		
	adapter.Dispose();		
	command.Dispose();
	connection.Close();
	
	dt = ds.Tables[0];
	dgv.DataSource = dt;
	int colCount = dgv.ColumnCount;
	for (int i = 0; i < colCount; i++)
 	{
    dgv.Columns[i].DefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Bold);
    }
	Console.WriteLine(colCount);
	}
	catch(SqliteException ex)
	{
	MessageBox.Show("Can not open connection"+ex.ToString());
	}

}
private void Form1_FormClosed(object sender, FormClosedEventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka2x.Enabled=true;
	this.Close();
}
}

class skladisnica:Form
{
private Button tipka1,tipka2;
private Button tipka4x;
private TextBox id_text,kolicina_text;
private Label id_label,kolicina_label; 

public skladisnica(Button tipka4){
	tipka4x=tipka4;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Popuna skladista";
	this.Size=new Size(300,300);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
	this.MaximizeBox = false;
	this.StartPosition=FormStartPosition.CenterScreen;

	Font font=new Font("Verdana",12,FontStyle.Bold);

	id_label=new Label();
	id_label.Location=new Point(30,30);
	id_label.Size=new Size(100,30);
	id_label.Text="Id";
	id_label.Font=font;
	this.Controls.Add(id_label);

	id_text=new TextBox();
	id_text.Location=new Point(170,30);
	id_text.Size=new Size(100,30);
	id_text.Text="";
	id_text.Font=font;
	this.Controls.Add(id_text);

	kolicina_label=new Label();
	kolicina_label.Location=new Point(30,70);
	kolicina_label.Size=new Size(100,30);
	kolicina_label.Text="Kolicina";
	kolicina_label.Font=font;
	this.Controls.Add(kolicina_label);

	kolicina_text=new TextBox();
	kolicina_text.Location=new Point(170,70);
	kolicina_text.Size=new Size(100,30);
	kolicina_text.Text="";
	kolicina_text.Font=font;
	this.Controls.Add(kolicina_text);

	tipka1=new Button();
	tipka1.Location=new Point(30,240);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(170,240);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);
	
}

private void tipka1_click(object sender,EventArgs e)
{
	int id=Convert.ToInt32(id_text.Text);
	int kolicina=Convert.ToInt32(kolicina_text.Text);	

	string cs="Data Source=baza.db";

	SqliteConnection con=null;
	SqliteCommand cmd=null;

	con=new SqliteConnection(cs);
	
	try
	{
		con.Open();
		cmd=new SqliteCommand(con);
		cmd.CommandText="update skladiste set kolicina="+kolicina+" where id="+id+";";
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SqliteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
	this.Close();

}

private void tipka2_click(object sender,EventArgs e)
{
	this.Close();
}

private void Form1_FormClosed(object sender, FormClosedEventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka4x.Enabled=true;
	this.Close();
}
}


