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
private Button tipka5;
private Button tipka6;
private Button tipka7;
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
	
	tipka5=new Button();
	tipka5.Location=new Point(30,190);
	tipka5.Size=new Size(240,30);
	tipka5.Text="Brisanje artikla";
	tipka5.Font=font;
	tipka5.Click+=new EventHandler(tipka5_click);
	this.Controls.Add(tipka5);

	tipka6=new Button();
	tipka6.Location=new Point(30,230);
	tipka6.Size=new Size(240,30);
	tipka6.Text="Unos sifara";
	tipka6.Font=font;
	tipka6.Click+=new EventHandler(tipka6_click);
	this.Controls.Add(tipka6);
	
	tipka7=new Button();
	tipka7.Location=new Point(30,270);
	tipka7.Size=new Size(240,30);
	tipka7.Text="Djelatnici";
	tipka7.Font=font;
	tipka7.Click+=new EventHandler(tipka7_click);
	this.Controls.Add(tipka7);
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

private void tipka5_click(object sender,EventArgs e)
{
	Console.WriteLine("Brisanje artikla");
	brisanje bri1=new brisanje(tipka5);
	bri1.Show();
	((Button)sender).Enabled = false;
}

private void tipka6_click(object sender,EventArgs e)
{
	Console.WriteLine("Unos sifara");
	unossifara sif1=new unossifara(tipka6);
	sif1.Show();
	((Button)sender).Enabled = false;
}

private void tipka7_click(object sender,EventArgs e)
{	djelatnici dje1;
	Console.WriteLine("djelatnici");
	dje1=new djelatnici(tipka7);
	
	((Button)sender).Enabled= false;
	
}

public static void Main()
{
	Application.Run(new pos1());
}
}

class blagajna:Form
{
private ListView listView;
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
	
	listView=new ListView();
	listView.Location=new Point(50,100);
	listView.Size=new Size(700,400);
	this.Controls.Add(listView);

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
	mjera_text.Location=new Point(170,150);
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
	cijena_text.Location=new Point(170,190);
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
	sql="select * from skladiste  order by id asc"; 
		
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

	
    
	dgv.ColumnHeadersDefaultCellStyle.Font= new Font("Verdana", 12, FontStyle.Bold);
    
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
	string sql=null;	

	con=new SqliteConnection(cs);
	
	try
	{
		con.Open();

		sql="select kolicina from skladiste where id="+id; 
		cmd=new SqliteCommand(con);
		cmd.CommandText=sql;
		int count=Convert.ToInt32(cmd.ExecuteScalar());
		kolicina=kolicina+count;

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

class brisanje:Form
{
private Button tipka5x;
private Button tipka1,tipka2;
private Label id_label;
private TextBox id_text;

public brisanje(Button tipka5){
	tipka5x=tipka5;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Brisanje artikla";
	this.Size=new Size(300,300);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
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

	string cs="Data Source=baza.db";

	SqliteConnection con=null;
	SqliteCommand cmd=null;
	string sql=null;	

	con=new SqliteConnection(cs);
	sql="delete from skladiste where id="+id+";";
	try
	{
		con.Open();

		cmd=new SqliteCommand(con);
		cmd.CommandText=sql;
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
	tipka5x.Enabled=true;
	this.Close();
}

}

class unossifara:Form
{
private Button tipka6x;
public unossifara(Button tipka6){
	tipka6x=tipka6;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Unos sifara";
	this.Size=new Size(800,600);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
	this.StartPosition=FormStartPosition.CenterScreen;
	
}


private void Form1_FormClosed(object sender, FormClosedEventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka6x.Enabled=true;
	this.Close();
}

}

class djelatnici
{
private Form form7;
private Button tipka7x;
private Button tipka1,tipka2;
private Label id_label,ime_label,prezime_label,oib_label,zaporka_label;
private TextBox id_text,ime_text,prezime_text,oib_text,zaporka_text;

public djelatnici(Button tipka7){
	tipka7x=tipka7;
	InitalizeComponent();
}

private void InitalizeComponent()
{	
	form7=new Form();
	form7.Text="djelatnici";
	form7.Size=new Size(300,300);
	form7.FormBorderStyle = FormBorderStyle.FixedSingle;
	form7.MaximizeBox = false;
	form7.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
	form7.StartPosition=FormStartPosition.CenterScreen;
	form7.Show();

	Font font=new Font("Verdana",12,FontStyle.Bold);

	id_label=new Label();
	id_label.Location=new Point(30,30);
	id_label.Size=new Size(100,30);
	id_label.Text="Id";
	id_label.Font=font;
	form7.Controls.Add(id_label);

	id_text=new TextBox();
	id_text.Location=new Point(170,30);
	id_text.Size=new Size(100,30);
	id_text.Text="";
	id_text.Font=font;
	form7.Controls.Add(id_text);
		
	ime_label=new Label();
	ime_label.Location=new Point(30,70);
	ime_label.Size=new Size(100,30);
	ime_label.Text="Ime";;
	ime_label.Font=font;
	form7.Controls.Add(ime_label);

	ime_text=new TextBox();
	ime_text.Location=new Point(170,70);
	ime_text.Size=new Size(100,30);
	ime_text.Text="";
	ime_text.Font=font;
	form7.Controls.Add(ime_text);

	prezime_label=new Label();
	prezime_label.Location=new Point(30,110);
	prezime_label.Size=new Size(100,30);
	prezime_label.Text="Prezime";
	prezime_label.Font=font;
	form7.Controls.Add(prezime_label);

	prezime_text=new TextBox();
	prezime_text.Location=new Point(170,110);
	prezime_text.Size=new Size(100,30);
	prezime_text.Text="";
	prezime_text.Font=font;
	form7.Controls.Add(prezime_text);

	oib_label=new Label();
	oib_label.Location=new Point(30,150);
	oib_label.Size=new Size(100,30);
	oib_label.Text="Oib";
	oib_label.Font=font;
	form7.Controls.Add(oib_label);

	oib_text=new TextBox();
	oib_text.Location=new Point(170,150);
	oib_text.Size=new Size(100,30);
	oib_text.Text="";
	oib_text.Font=font;
	form7.Controls.Add(oib_text);

	zaporka_label=new Label();
	zaporka_label.Location=new Point(30,190);
	zaporka_label.Size=new Size(100,30);
	zaporka_label.Text="Zaporka";
	zaporka_label.Font=font;
	form7.Controls.Add(zaporka_label);

	zaporka_text=new TextBox();
	zaporka_text.Location=new Point(170,190);
	zaporka_text.Size=new Size(100,30);
	zaporka_text.Text="";
	zaporka_text.Font=font;
	form7.Controls.Add(zaporka_text);


	tipka1=new Button();
	tipka1.Location=new Point(30,240);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	form7.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(170,240);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	form7.Controls.Add(tipka2);
	
}

private void tipka1_click(object sender,EventArgs e) {
	int id=Convert.ToInt32(id_text.Text);
	string ime=Convert.ToString(ime_text.Text);
	string prezime=Convert.ToString(prezime_text.Text);
	string oib=Convert.ToString(oib_text.Text);
	string zaporka=Convert.ToString(zaporka_text.Text);

	Console.WriteLine("utrnio");
	string cs="Data Source=baza.db";

	SqliteConnection con=null;
	SqliteCommand cmd=null;

	con=new SqliteConnection(cs);
	
	try
	{
		con.Open();
		cmd=new SqliteCommand(con);
		cmd.CommandText=@"insert into djelatnici(id_djelatnik,ime,prezime,oib,zaporka)
				values ("+id+",'"+ime+"','"+prezime+"','"+oib+"','"+zaporka+"');";
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SqliteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}

	form7.Close();


}

private void tipka2_click(object sender,EventArgs e) {
form7.Close();
}

private void Form1_FormClosed(object sender, FormClosedEventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka7x.Enabled=true;
	form7.Close();
}

}

