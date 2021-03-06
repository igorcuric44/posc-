using System;
using System.Windows.Forms;
using System.Drawing;
using Mono.Data.Sqlite;
using System.Data;

public class pos1:Form
{
private Button tipka1;
private Button tipka2;
private Button tipka3;

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

private void tipka3_click(object sender,EventArgs e)
{
	Console.WriteLine("skladiste");
	skladiste skl1=new skladiste();
	skl1.Show();

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
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.StartPosition=FormStartPosition.CenterScreen;
	
}

}

class unos:Form
{
private Button tipka1,tipka2;
private Label id_label,artikl_label,kolicina_label,mjera_label,cijena_label;
private TextBox id_text,artikl_text,kolicina_text,mjera_text,cijena_text;

public unos()
{
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Unos";
	this.Size=new Size(300,500);
	this.StartPosition=FormStartPosition.CenterScreen;
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
		MessageBox.Show("Can not open connection");
	}




	this.Close();

}

private void tipka2_click(object sender,EventArgs e)
{
	Console.WriteLine("utrnio");
	this.Close();	

}
}

class skladiste:Form
{
DataGridView dgv;
public skladiste(){
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="SKLADISTE";
	this.Size=new Size(800,600);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.StartPosition=FormStartPosition.CenterScreen;
	
	Font font=new Font("Verdana",12,FontStyle.Bold);
	

	dgv=new DataGridView();
	dgv.Location=new Point(30,50);
	dgv.Size=new Size(740,400);
	dgv.Font=font;
	this.Controls.Add(dgv);

	
	
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
	adapter.Fill(ds,"Table");
		
	adapter.Dispose();		
	command.Dispose();
	connection.Close();
	
	Font currentFont = dgv.Font;
	DataGridViewCellStyle newCellStyle = new DataGridViewCellStyle();
	newCellStyle.Font = new Font(currentFont, FontStyle.Bold);
	
	
	dt = ds.Tables[0];
		dgv.DataSource = dt;

	dgv.Columns["id"].DefaultCellStyle.Font =
            new Font("Verdana", 12, FontStyle.Bold);
	dgv.Columns[1].DefaultCellStyle = newCellStyle;
	dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

}



