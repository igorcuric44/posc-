using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Printing;
using System.Collections;
using System.Collections.Generic;

public class pos35:Form
{
private Button tipka1;
private Button tipka2;
private Button tipka3;
private Button tipka4;
private Button tipka5;
private Button tipka6;
private Button tipka7;
private Button tipka8;
private Button tipka9;
private Button tipka10;
private Label label1;

public pos35()
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
	this.MaximumSize = this.Size;
	this.MinimumSize = this.Size;
	this.Load+=new EventHandler(ucitao_poduzece);


	Font font=new Font("Verdana",14,FontStyle.Bold);

	label1=new Label();
	label1.Location=new Point(30,30);
	label1.Size=new Size(240,30);
	label1.Text="Blagajna";
	label1.BackColor=Color.White;
	label1.TextAlign = ContentAlignment.MiddleCenter;
	label1.Font=font;
	this.Controls.Add(label1);


	tipka1=new Button();
	tipka1.Location=new Point(30,70);
	tipka1.Size=new Size(240,30);
	tipka1.Text="Blagajna";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(30,110);
	tipka2.Size=new Size(240,30);
	tipka2.Text="Unos";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);

	tipka3=new Button();
	tipka3.Location=new Point(30,150);
	tipka3.Size=new Size(240,30);
	tipka3.Text="Skladiste";
	tipka3.Font=font;
	tipka3.Click+=new EventHandler(tipka3_click);
	this.Controls.Add(tipka3);

	tipka4=new Button();
	tipka4.Location=new Point(30,190);
	tipka4.Size=new Size(240,30);
	tipka4.Text="Popuna skladista";
	tipka4.Font=font;
	tipka4.Click+=new EventHandler(tipka4_click);
	this.Controls.Add(tipka4);
	
	tipka5=new Button();
	tipka5.Location=new Point(30,230);
	tipka5.Size=new Size(240,30);
	tipka5.Text="Brisanje artikla";
	tipka5.Font=font;
	tipka5.Click+=new EventHandler(tipka5_click);
	this.Controls.Add(tipka5);

	tipka6=new Button();
	tipka6.Location=new Point(30,270);
	tipka6.Size=new Size(240,30);
	tipka6.Text="Promijena cijene";
	tipka6.Font=font;
	tipka6.Click+=new EventHandler(tipka6_click);
	this.Controls.Add(tipka6);
	
	tipka7=new Button();
	tipka7.Location=new Point(30,310);
	tipka7.Size=new Size(240,30);
	tipka7.Text="Unos sifara";
	tipka7.Font=font;
	tipka7.Click+=new EventHandler(tipka7_click);
	this.Controls.Add(tipka7);
	
	tipka8=new Button();
	tipka8.Location=new Point(30,350);
	tipka8.Size=new Size(240,30);
	tipka8.Text="Sifrarnik";
	tipka8.Font=font;
	tipka8.Click+=new EventHandler(tipka8_click);
	this.Controls.Add(tipka8);


	tipka9=new Button();
	tipka9.Location=new Point(30,390);
	tipka9.Size=new Size(240,30);
	tipka9.Text="Djelatnici";
	tipka9.Font=font;
	tipka9.Click+=new EventHandler(tipka9_click);
	this.Controls.Add(tipka9);

	tipka10=new Button();
	tipka10.Location=new Point(30,430);
	tipka10.Size=new Size(240,30);
	tipka10.Text="Postavke";
	tipka10.Font=font;
	tipka10.Click+=new EventHandler(tipka10_click);
	this.Controls.Add(tipka10);

}

private void ucitao_poduzece(object sender,EventArgs e)
{	
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	

	con=new SQLiteConnection(cs);
	
	try
	{
		con.Open();

		sql="select poduzece from poduzece;"; 
		cmd=new SQLiteCommand(sql,con);
		//cmd.CommandText=sql;
		string poduzecex=Convert.ToString(cmd.ExecuteScalar());
		Console.WriteLine("poduzecex "+poduzecex);
		label1.Text=poduzecex;
		

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show(this,"Can not open connection"+ex.ToString());
	}	
}




private void tipka1_click(object sender,EventArgs e)
{	blagajnax bla1;
	Console.WriteLine("blagajnax");
	bla1=new blagajnax(tipka1);
	bla1.Show();
	((Button)sender).Enabled = false;
	
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
	Console.WriteLine("Promijena cijene");
	procijene pro1=new procijene(tipka6);
	pro1.Show();
	((Button)sender).Enabled = false;
}

private void tipka7_click(object sender,EventArgs e)
{
	Console.WriteLine("Unos sifara");
	unossifara sif1=new unossifara(tipka7);
	sif1.Show();
	((Button)sender).Enabled = false;
}


private void tipka8_click(object sender,EventArgs e)
{	sifrarnik sif1;
	Console.WriteLine("sifrarnik");
	sif1=new sifrarnik(tipka8);
	sif1.Show();
	((Button)sender).Enabled= false;
	
}


private void tipka9_click(object sender,EventArgs e)
{	djelatnici dje1;
	Console.WriteLine("djelatnici");
	dje1=new djelatnici(tipka9);
	
	((Button)sender).Enabled= false;
	
}

private void tipka10_click(object sender,EventArgs e)
{	postavke pos1;
	Console.WriteLine("postavke");
	pos1=new postavke(tipka10);
	pos1.Show();
	((Button)sender).Enabled= false;
	
}

public static void Main()
{
	Application.Run(new pos35());
}
}

class blagajnax:Form
{
private Button tipka1x;
private Button tipka1,tipka2;
private Label ime_label,zaporka_label;
private TextBox ime_text,zaporka_text;

public blagajnax(Button tipka1){
	tipka1x=tipka1;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="zaporka za blagajnu";
	this.Size=new Size(300,300);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.Disposed+=new EventHandler(Form1_FormClosed);
	this.StartPosition=FormStartPosition.CenterScreen;

	Font font=new Font("Verdana",14,FontStyle.Bold);

	ime_label=new Label();
	ime_label.Location=new Point(30,30);
	ime_label.Size=new Size(100,30);
	ime_label.Text="Unesi ime";
	ime_label.Font=font;
	this.Controls.Add(ime_label);

	ime_text=new TextBox();
	ime_text.Location=new Point(170,30);
	ime_text.Size=new Size(100,30);
	ime_text.Text="";
	ime_text.Font=font;
	this.Controls.Add(ime_text);
		
	zaporka_label=new Label();
	zaporka_label.Location=new Point(30,70);
	zaporka_label.Size=new Size(100,30);
	zaporka_label.Text="Zaporka";;
	zaporka_label.Font=font;
	this.Controls.Add(zaporka_label);

	zaporka_text=new TextBox();
	zaporka_text.Location=new Point(170,70);
	zaporka_text.Size=new Size(100,30);
	zaporka_text.Text="";
	zaporka_text.PasswordChar = '*'; 
	zaporka_text.Font=font;
	this.Controls.Add(zaporka_text);



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
	String ime=Convert.ToString(ime_text.Text);
	String zaporka=Convert.ToString(zaporka_text.Text);	

	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	

	con=new SQLiteConnection(cs);
	
	try
	{
		con.Open();

		sql="select zaporka from djelatnici where ime='"+ime.ToString()+"';"; 
		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		string zaporkax=Convert.ToString(cmd.ExecuteScalar());
		if(zaporka==zaporkax && zaporka!=""){
			blagajna bla1;
			Console.WriteLine("blagajna");
			this.Hide();
			tipka1x.Enabled=false;
			bla1=new blagajna(tipka1x,ime);
			bla1.Show();
			
			
			
		}else
		{
		MessageBox.Show(this,"Pogresna zaporka");
		this.Close();
		}

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show(this,"Can not open connection"+ex.ToString());
	}
	
	

}

private void tipka2_click(object sender,EventArgs e)
{
tipka1x.Enabled=true;	
this.Close();	
}

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
	
}

}


class blagajna:Form
{

private ListView listView;
private Button tipka1x;
private Button btn1,btn2,btn3;
private Label datum,racun,operatori,vrijeme;
private Label datumx,racunx,operatorix,vrijemex;
//private Label vrijeme;

private Label suma;
float sumax;
string ime;
string[] arr;
string str1=null,str2;
int p=0,s=1,i=0;
List<List<object>> results = new List<List<object>>();
string strx1,strx2;
DateTime now;
string sumaxy;
public blagajna(Button tipka1,string ime){
	tipka1x=tipka1;
	this.ime=ime;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="blagajna";
	this.Size=new Size(800,650);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.Disposed+= new EventHandler(Form1_FormClosed);
	this.Load+=new EventHandler(ucitao_load);
	this.StartPosition=FormStartPosition.CenterScreen;
	
	
	Font font1=new Font("Verdana",12,FontStyle.Bold);
	Font font=new Font("Times New Roman",12, FontStyle.Italic);;

    
	now = DateTime.Now;
	strx1=String.Format("{0:dd/MM/yyyy}", now);
	strx2=String.Format("{0:HH:mm:ss}", now);
	
	suma = new Label();
    suma.Location =new Point(650,50);
    suma.Size = new Size(100,50);
	suma.Text="";
	suma.Font=new Font("Verdana",18,FontStyle.Bold|FontStyle.Italic);
    this.Controls.Add(suma);
	

	datumx=new Label();
	datumx.Location=new Point(50,10);
	datumx.Size=new Size(100,30);
	datumx.Text="Datum";
	datumx.Font=font1;
	this.Controls.Add(datumx);

	vrijemex=new Label();
	vrijemex.Location=new Point(50,40);
	vrijemex.Size=new Size(100,30);
	vrijemex.Text="Vrijeme";
	vrijemex.Font=font1;
	this.Controls.Add(vrijemex);

	racunx=new Label();
	racunx.Location=new Point(50,70);
	racunx.Size=new Size(100,30);
	racunx.Text="Racun";
	racunx.Font=font1;
	this.Controls.Add(racunx);	

	operatorix=new Label();
	operatorix.Location=new Point(50,100);
	operatorix.Size=new Size(100,30);
	operatorix.Text="operator";
	operatorix.Font=font1;
	this.Controls.Add(operatorix);


	datum=new Label();
	datum.Location=new Point(150,10);
	datum.Size=new Size(150,30);
	datum.Text=strx1;
	datum.Font=font1;
	this.Controls.Add(datum);

	vrijeme=new Label();
	vrijeme.Location=new Point(150,40);
	vrijeme.Size=new Size(150,30);
	vrijeme.Text=strx2;
	vrijeme.Font=font1;
	this.Controls.Add(vrijeme);

	racun=new Label();
	racun.Location=new Point(150,70);
	racun.Size=new Size(100,30);
	racun.Text="racun";
	racun.Font=font1;
	this.Controls.Add(racun);	

	operatori=new Label();
	operatori.Location=new Point(150,100);
	operatori.Size=new Size(100,30);
	operatori.Text="";
	operatori.Font=font1;
	this.Controls.Add(operatori);

	listView=new ListView();
	listView.Location=new Point(50,150);
	listView.Size=new Size(725,400);
	listView.Font=font;
	this.Controls.Add(listView);

	listView.View = View.Details;
    listView.GridLines = true;
    listView.FullRowSelect = true;
	listView.ForeColor = Color.Black;
	listView.BorderStyle = BorderStyle.Fixed3D;;
	listView.KeyPress += new KeyPressEventHandler(this.txtInput_KeyPress);	

	listView.Columns.Add("Artikl", 120);
    listView.Columns.Add("Kolicina",120);
    listView.Columns.Add("Mjera", 120);
	listView.Columns.Add("Cijena", 120);
    listView.Columns.Add("Pdv", 120);
    listView.Columns.Add("Iznos", 120);

	btn1=new Button();
	btn1.Location=new Point(50,560);
	btn1.Size=new Size(100,30);
	btn1.Text="Obrisi";
	btn1.Font=font;
	btn1.Click+=new EventHandler(btn1_click);
	this.Controls.Add(btn1);

	btn2=new Button();
	btn2.Location=new Point(200,560);
	btn2.Size=new Size(100,30);
	btn2.Text="Isprintaj";
	btn2.Font=font;
	btn2.Click+=new EventHandler(btn2_click);
	this.Controls.Add(btn2);

	btn3=new Button();
	btn3.Location=new Point(350,560);
	btn3.Size=new Size(100,30);
	btn3.Text="Isprintaj Isprintaj";
	btn3.Font=font;
	btn3.Click+=new EventHandler(btn3_click);
	this.Controls.Add(btn3);

}



private void btn1_click(object sender, EventArgs  e) {
    Console.WriteLine("tipka1");	
	suma.Text="";
	sumax=0.0f;
	listView.Items.Clear();
	results.Clear();
	str1=String.Empty;
	i=0;
	
}

private void btn2_click(object sender, EventArgs  e) {
    Console.WriteLine("isprintaj1");
	Console.WriteLine(listView.Items.Count);
	for(int ii=0;ii<listView.Items.Count;ii++){
	Console.Write(listView.Items[ii].SubItems[0].Text+" ");
	Console.Write(listView.Items[ii].SubItems[1].Text+" ");
	Console.Write(listView.Items[ii].SubItems[2].Text+" ");
	Console.Write(listView.Items[ii].SubItems[3].Text+" ");
	Console.Write(listView.Items[ii].SubItems[4].Text+" ");
	Console.Write(listView.Items[ii].SubItems[5].Text+" ");
	Console.Write(listView.Items[ii].SubItems[6].Text+" ");
	Console.WriteLine();
	}
	
}

private void btn3_click(object sender, EventArgs  e) {
    Console.WriteLine("----------------------------------------");
	
	for (int i = 0; i < results.Count; i++) { 
		for (int j = 0; j < results[i].Count; j++) {
            Console.WriteLine("results {0} ",results[i][j]); 
        } 
	Console.WriteLine("=======================================");
	} 
}

private void txtInput_KeyPress(object sender ,KeyPressEventArgs e){
	Console.WriteLine("-----------------------------------");
	char keyChar;
	keyChar = e.KeyChar;

	
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	
	SQLiteDataReader rdr = null;
	con=new SQLiteConnection(cs);
		
	str1=str1+e.KeyChar;

	

	

	Console.WriteLine(str1+" "+e.KeyChar);
	
	if(keyChar==13 && p==1){
        Console.WriteLine("enter");
		Console.WriteLine("++++"+str2);
		Console.WriteLine(p);
	
    	ListViewItem.ListViewSubItem itemx,itemx1;
	
		
    	
			
		s=s+1;
		listView.Items[listView.Items.Count-1].SubItems[1].Text=s.ToString();

		itemx=listView.Items[listView.Items.Count-1].SubItems[3];		
		itemx1=listView.Items[listView.Items.Count-1].SubItems[5];

		itemx1.Text=string.Format("{0:0.00}",(s*Convert.ToSingle(itemx.Text)));
		sumax=sumax+Convert.ToSingle(itemx.Text);
		suma.Text=string.Format("{0:0.00}", sumax);
		
		
     }

if(keyChar!=13){
	p=0;
	s=1;}



if(keyChar==13 && p==0){
Console.WriteLine(str1);
Console.WriteLine(p);
arr = new string[6];
    	ListViewItem itm ;

    	//Add first item
 	
    	
			
		
			
		
		sql="select * from sifrarnik where id="+str1+";";
		try{
		con.Open();
		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		rdr=cmd.ExecuteReader();
    	rdr.Read();
		arr[0]=rdr[1].ToString();
		arr[1]=s.ToString();
    		arr[2]=(Convert.ToSingle(rdr[3])+Convert.ToSingle(rdr[7])).ToString();
		arr[3]=string.Format("{0:0.00}",(Convert.ToSingle(rdr[4])+Convert.ToSingle(rdr[8])));
		arr[4]=rdr[5].ToString();
		arr[5]=string.Format("{0:0.00}", arr[3]);
		
    		itm = new ListViewItem(arr);
    		listView.Items.Add(itm);
		results.Add(new List<object>());
		results[i].Add(rdr[0]);
        	results[i].Add(rdr[1]);
		results[i].Add(rdr[2]);
        	results[i].Add(rdr[3]);
		results[i].Add(rdr[4]);
        	results[i].Add(rdr[5]);
		results[i].Add(rdr[6]);
        	results[i].Add(rdr[7]);
		results[i].Add(rdr[8]);
		results[i].Add(rdr[9]);
		

		sumax=sumax+Convert.ToSingle(arr[3]);
		sumaxy=string.Format("{0:0.00}", sumax);;
		suma.Text=sumaxy;
		

		rdr.Dispose();
		cmd.Dispose();
		con.Close();
		}catch(SQLiteException)
		{
			MessageBox.Show(this,"Greska");
		}

		

		p=1;
		str2=str1;
		str1=String.Empty;
		i++;
}


	if (keyChar==32){
		Console.WriteLine("space");
		Console.WriteLine("-------------------------------------------------");
		int isi=0;
		int ps=0;
		string pstr;
		Console.WriteLine(listView.Items.Count);
	for(int ii=0;ii<listView.Items.Count;ii++){
	
	Console.WriteLine("");
	
	float kolicinaxx=Convert.ToSingle(listView.Items[ii].SubItems[1].Text);
	
	

	try
		{
		con.Open();
		if(Convert.ToInt32(results[ii][2])!=0){
		sql=@"select * from skladiste where id="+(results[ii][2]).ToString()+";";
    	cmd=con.CreateCommand();
		cmd.CommandText=sql;
		rdr=cmd.ExecuteReader();
    	rdr.Read();
    	float mjeraxx=Convert.ToSingle(results[ii][3]);
		float kolicina=Convert.ToSingle(rdr[3])-kolicinaxx*mjeraxx;
		Console.WriteLine("+++++"+rdr.GetFloat(3));
		Console.WriteLine("+++++"+kolicinaxx);
		Console.WriteLine("+++++"+mjeraxx);
		Console.WriteLine("+++++"+String.Format("{0:0.000}",kolicina));
		cmd=con.CreateCommand();
		cmd.CommandText="update skladiste set kolicina="+kolicina.ToString().Replace(",", ".")+" where id="+
				(results[ii][2]).ToString()+";";
		cmd.ExecuteNonQuery();
		
		rdr.Close();
		}
		
		
		
		
		if(Convert.ToInt32(results[ii][6])!=0){
		sql=@"select * from skladiste where id="+(results[ii][6]).ToString()+";";
    	cmd=con.CreateCommand();
		cmd.CommandText=sql;
		rdr=cmd.ExecuteReader();
    	rdr.Read();
    	float mjeraxx=Convert.ToSingle(results[ii][7]);
		float kolicina=rdr.GetFloat(3)-kolicinaxx*mjeraxx;
		Console.WriteLine("+++++"+rdr.GetFloat(3));
		Console.WriteLine("+++++"+kolicinaxx);
		Console.WriteLine("+++++"+mjeraxx);
		Console.WriteLine("+++++"+kolicina);
		
		cmd=con.CreateCommand();
		cmd.CommandText="update skladiste set kolicina="+kolicina.ToString().Replace(",", ".")+" where id="+
				rdr.GetInt32(0).ToString()+";";
		cmd.ExecuteNonQuery();
		

		rdr.Close();
		}
		
		
			
		cmd.Dispose();
		con.Close();		
		}
		catch(SQLiteException){
		MessageBox.Show("Greska unos");
		}

		}
	
	results.Clear();
	i=0;
	str1=String.Empty;
	now = DateTime.Now;
	strx2=String.Format("{0:dd/MM/yyyy}", now);
	strx1=String.Format("{0:HH:mm:ss}", now);
	datum.Text=strx2;
	vrijeme.Text=strx1;

	try
		{
		con.Open();
	sql="select count(*) from racun;";
		cmd=con.CreateCommand();
		cmd.CommandText=sql;

		rdr = cmd.ExecuteReader();
		rdr.Read();
		isi=Convert.ToInt32(rdr[0]);
		Console.WriteLine(rdr[0]);
		rdr.Close();
		ps=isi;
		ps++;		
		

		cmd=con.CreateCommand();
		cmd.CommandText=@"insert into racun (id_racun,vrijeme,datum,racun) values 
			("+ps+",'"+strx1+"','"+strx2+"',"+sumax.ToString().Replace(",", ".")+");";
		cmd.ExecuteNonQuery();
			
		cmd.Dispose();
		con.Close();		
		}
		catch(SQLiteException){
		MessageBox.Show("Greska unos");
		}

	pstr=ps.ToString("D4")+"/"+String.Format("{0:yy}",now);
	racun.Text=pstr;
	new printanje(strx2,strx1,listView,sumaxy,pstr);
	listView.Items.Clear();
	suma.Text="";
	
	//racun.Text=racund(sumax,strx1,strx2);
	sumax=0.0f;
	
	}
}

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
}

private void ucitao_load(object sender,EventArgs e)
{
	
	
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	
	string prezime=null;
	con=new SQLiteConnection(cs);
	
	try
	{
		con.Open();
		sql="select prezime from djelatnici where ime='"+ime+"';";
		 
		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		prezime=Convert.ToString(cmd.ExecuteScalar());
		Console.WriteLine("prezime "+prezime);

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
	

	operatori.Text=ime+" "+prezime;


}

private string racund(float sumax,string strx1,string strx2)
{
	
	
	string cs="Data Source=baza.db";
string sql=null;
SQLiteConnection con=null;
SQLiteCommand cmd=null;
SQLiteDataReader rdr=null;
int i=0;
int p=0;
con=new SQLiteConnection(cs);
try{
con.Open();
sql="select count(*) from racun;";
cmd=new SQLiteCommand(con);
cmd.CommandText=sql;

rdr = cmd.ExecuteReader();
rdr.Read();
i=Convert.ToInt32(rdr[0]);
Console.WriteLine(rdr[0]);
p=i;
p++;

	
	cmd=con.CreateCommand();
	cmd.CommandText=@"insert into racun (id_racun,vrijeme,datum,racun) values 
		("+p+",'"+strx1+"','"+strx2+"',"+sumax.ToString().Replace(",", ".")+");";
	cmd.ExecuteNonQuery();
	


rdr.Close();
cmd.Dispose();
con.Close();
}catch(SQLiteException ex)
{
Console.WriteLine(ex.ToString());
}

return i.ToString("D4")+"/"+String.Format("{0:yy}",now);;

	




}

}

class printanje {
string str1,str2,pstr;
private ListView listView;
string sumaxy;
public printanje(string str1,string str2,ListView listView,string sumaxy,string pstr){
this.str1=str1;
this.str2=str2;
this.listView=listView;
this.sumaxy=sumaxy;
this.pstr=pstr;
print();
}

public void print(){

PrintDocument pd = new PrintDocument();

pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
pd.Print();
}

public void pd_PrintPage(object o, PrintPageEventArgs ppeArgs)
{

Graphics g = ppeArgs.Graphics; 

SolidBrush redBrush = new SolidBrush (Color.Blue);     

Font font = new Font("Consolas", 10,FontStyle.Regular);
Font font1 = new Font("Consolas", 8,FontStyle.Regular);
 string[] t1; 

  t1 =poduzece();


g.DrawString(t1[0], font, redBrush,0,0);
g.DrawString(t1[1]+" "+t1[2], font1, redBrush,0,13);
g.DrawString(t1[4]+", "+t1[3], font1, redBrush,0,26);
g.DrawString("OIB "+t1[5], font1, redBrush,0,39);
g.DrawString("telefon "+t1[6], font1, redBrush,0,51);
g.DrawString("Datum ", font1, redBrush,0,64);
g.DrawString(this.str1, font1, redBrush,100,64);
g.DrawString("Vrijeme ", font1, redBrush,0,77);
g.DrawString(this.str2, font1, redBrush,100,77);

g.DrawString("Racun",font1,redBrush,0,100);
g.DrawString(this.pstr,font1,redBrush,100,100);
g.DrawString("Usluga",font1,redBrush,0,113);
g.DrawString("Kolicina",font1,redBrush,120,113);
g.DrawString("Cijena",font1,redBrush,0,126);
g.DrawString("Mjera",font1,redBrush,50,126);
g.DrawString("Pdv",font1,redBrush,100,126);
g.DrawString("Iznos",font1,redBrush,130,126);
g.DrawString("------------------------------------",font1,redBrush,0,139);
int p=0;
for(int ii=0;ii<this.listView.Items.Count;ii++){
	g.DrawString(this.listView.Items[ii].SubItems[0].Text.ToString(),font1,redBrush,0,154+p);
	g.DrawString(this.listView.Items[ii].SubItems[1].Text.ToString(),font1,redBrush,120,154+p);
	g.DrawString(this.listView.Items[ii].SubItems[2].Text.ToString(),font1,redBrush,0,167+p);
	g.DrawString(this.listView.Items[ii].SubItems[3].Text.ToString(),font1,redBrush,50,167+p);
	g.DrawString(this.listView.Items[ii].SubItems[4].Text.ToString(),font1,redBrush,100,167+p);
	g.DrawString(this.listView.Items[ii].SubItems[5].Text.ToString(),font1,redBrush,130,167+p);
	
	p+=26;
	}
g.DrawString("------------------------------------",font1,redBrush,0,167+p);
g.DrawString("Ukupno",font,redBrush,0,190+p);
g.DrawString(this.sumaxy,font,redBrush,130,190+p);
}

public string[] poduzece()
{
string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	
	SQLiteDataReader rdr;
	con=new SQLiteConnection(cs);
	string[] ret=null;
	try
	{
		con.Open();

		sql="select * from poduzece;"; 
		cmd=new SQLiteCommand(sql,con);
		rdr=cmd.ExecuteReader();
		rdr.Read();
		ret=new string[7]{rdr.GetString(0),rdr.GetString(1),rdr.GetString(2),rdr.GetString(3),
			rdr.GetString(4),rdr.GetString(5),rdr.GetString(6)};

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException)
	{
		
	}	

	return ret;
}


}








class unos:Form
{
private Button tipka1,tipka2;
private Label id_label,artikl_label,kolicina_label,mjera_label,cijena_label,pdv_label;
private TextBox id_text,artikl_text,kolicina_text,mjera_text,cijena_text,pdv_text;
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
	this.Disposed+= new EventHandler(Form1_FormClosed);
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

	pdv_label=new Label();
	pdv_label.Location=new Point(30,110);
	pdv_label.Size=new Size(100,30);
	pdv_label.Text="Pdv";
	pdv_label.Font=font;
	this.Controls.Add(pdv_label);

	pdv_text=new TextBox();
	pdv_text.Location=new Point(170,110);
	pdv_text.Size=new Size(100,30);
	pdv_text.Text="";
	pdv_text.Font=font;
	this.Controls.Add(pdv_text);


	kolicina_label=new Label();
	kolicina_label.Location=new Point(30,150);
	kolicina_label.Size=new Size(100,30);
	kolicina_label.Text="Kolicina";
	kolicina_label.Font=font;
	this.Controls.Add(kolicina_label);

	kolicina_text=new TextBox();
	kolicina_text.Location=new Point(170,150);
	kolicina_text.Size=new Size(100,30);
	kolicina_text.Text="";
	kolicina_text.Font=font;
	this.Controls.Add(kolicina_text);

	mjera_label=new Label();
	mjera_label.Location=new Point(30,190);
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
	cijena_label.Location=new Point(30,230);
	cijena_label.Size=new Size(100,30);
	cijena_label.Text="Cijena";
	cijena_label.Font=font;
	this.Controls.Add(cijena_label);

	cijena_text=new TextBox();
	cijena_text.Location=new Point(170,230);
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
	float pdv=Convert.ToSingle(pdv_text.Text);
	float kolicina=Convert.ToSingle(kolicina_text.Text);
	float mjera=Convert.ToSingle(mjera_text.Text);
	float cijena=Convert.ToSingle(cijena_text.Text);

	Console.WriteLine("utrnio");
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;

	con=new SQLiteConnection(cs);
	
	try
	{
		con.Open();
		cmd=new SQLiteCommand(con);
		cmd.CommandText=@"insert into skladiste(id,artikl,pdv,kolicina,mjera,cijena)
				values ("+id+",'"+artikl+"',"+pdv.ToString().Replace(",", ".")+
				","+kolicina.ToString().Replace(",", ".")+","+mjera.ToString().Replace(",", ".")+","+
				cijena.ToString().Replace(",", ".")+");";
	

	cmd.ExecuteNonQuery();
	cmd.Dispose();
	con.Close();



	}
	catch(SQLiteException ex)
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

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
}
}

class skladiste:Form
{

private Button tipka2x;
private Button tipka1;
private Button tipka2;
private ListView lv1;

public skladiste(Button tipka2){
	tipka2x=tipka2;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="SKLADISTE";
	this.Size=new Size(800,600);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.Disposed+= new EventHandler(Form1_FormClosed);
	this.MaximizeBox = false;
	this.StartPosition=FormStartPosition.CenterScreen;
	this.Load+=new EventHandler(dogodio);
	
	Font font=new Font("Times New Roman",12,FontStyle.Bold | FontStyle.Italic);

	lv1=new ListView();
	lv1.Location=new Point(25,50);
	lv1.Size=new Size(650,300);
	lv1.Text="sifra 1";
	lv1.Font=font;
	lv1.View = View.Details;
	lv1.FullRowSelect = true;
	lv1.GridLines = true;
	lv1.Columns.Add("Id",100);
	lv1.Columns.Add("Usluga",150);
	lv1.Columns.Add("Pdv",100);
	lv1.Columns.Add("Kolicina",100);
	lv1.Columns.Add("Mjera",100);
	lv1.Columns.Add("Cijena",100);
	//lv2.SelectedIndexChanged += new EventHandler(ListView1_SelectedIndexChanged);  
	this.Controls.Add(lv1);

	
	tipka1=new Button();
	tipka1.Location=new Point(30,500);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(670,500);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);
	}

	private void tipka1_click(object sender, EventArgs e)
    {
	}

	private void tipka2_click(object sender, EventArgs e)
    {
		this.Close();
	}

	private void dogodio(object sender, EventArgs e)
    {

	string sql = "select * from skladiste;";
    string connectionString="Data Source=baza.db";
	
	SQLiteCommand cmd=null;
	SQLiteDataReader r=null;
    SQLiteConnection con=new SQLiteConnection(connectionString);
    ListViewItem lvItem1;

	try{
		con.Open();
		cmd=con.CreateCommand();
		cmd.CommandText=sql;
		r = cmd.ExecuteReader();
		while (r.Read())
		{
        	lvItem1 = new ListViewItem(r[0].ToString());
        	lvItem1.SubItems.Add(r[1].ToString());
		lvItem1.SubItems.Add(string.Format("{0:0.00}",r[2]));
		lvItem1.SubItems.Add(string.Format("{0:0.000}",r[3]));
		lvItem1.SubItems.Add(string.Format("{0:0.000}",r[4]));
		lvItem1.SubItems.Add(string.Format("{0:0.00}",r[5]));

		lv1.Items.Add(lvItem1);
      }


		con.Close();
		
	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}




		
	}
private void Form1_FormClosed(object sender, EventArgs  e) {
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
	this.Disposed+= new EventHandler(Form1_FormClosed);
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
	float kolicina=Convert.ToSingle(kolicina_text.Text);	

	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	

	con=new SQLiteConnection(cs);
	
	try
	{
		con.Open();

		sql="select kolicina from skladiste where id="+id; 
		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		float count=Convert.ToSingle(cmd.ExecuteScalar());
		kolicina=kolicina+count;
		Console.WriteLine(kolicina);
		cmd=new SQLiteCommand(con);
		cmd.CommandText="update skladiste set kolicina="+kolicina.ToString().Replace(",", ".")+" where id="+id+";";
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
	this.Close();

}

private void tipka2_click(object sender,EventArgs e)
{
	this.Close();
}

private void Form1_FormClosed(object sender, EventArgs  e) {
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
	this.Disposed+= new EventHandler(Form1_FormClosed);
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

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	

	con=new SQLiteConnection(cs);
	sql="delete from skladiste where id="+id+";";
	try
	{
		con.Open();

		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
	this.Close();
}

private void tipka2_click(object sender,EventArgs e)
{
	this.Close();
}



private void Form1_FormClosed(object sender,EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka5x.Enabled=true;
	this.Close();
}

}

class procijene:Form
{
private Button tipka6x;
private Button tipka1,tipka2;
private Label id_label,cijena_label;
private TextBox id_text,cijena_text;

public procijene(Button tipka6){
	tipka6x=tipka6;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Promijena cijene";
	this.Size=new Size(300,300);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox = false;
	this.Disposed+= new EventHandler(Form1_FormClosed);
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

	cijena_label=new Label();
	cijena_label.Location=new Point(30,70);
	cijena_label.Size=new Size(100,30);
	cijena_label.Text="Cijena";
	cijena_label.Font=font;
	this.Controls.Add(cijena_label);

	cijena_text=new TextBox();
	cijena_text.Location=new Point(170,70);
	cijena_text.Size=new Size(100,30);
	cijena_text.Text="";
	cijena_text.Font=font;
	this.Controls.Add(cijena_text);

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
	float cijena=Convert.ToSingle(cijena_text.Text);

	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	string sql=null;	

	con=new SQLiteConnection(cs);
	sql="update skladiste set cijena="+cijena.ToString().Replace(",", ".")+" where id="+id+";";
	try
	{
		con.Open();

		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
	this.Close();
}

private void tipka2_click(object sender,EventArgs e)
{
	this.Close();
}



private void Form1_FormClosed(object sender,EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka6x.Enabled=true;
	this.Close();
}

}



class unossifara:Form
{
private Button tipka7x;
private Label sifra,id1_label,id2_label,mjera1_label,mjera2_label,usluga,cijena1_label,
cijena2_label,pdv1_label,pdv2_label;
private TextBox sifra_text,id1_text,id2_text,mjera1_text,mjera2_text,usluga_text,
cijena1_text,cijena2_text,pdv1_text,pdv2_text;
private ListView lv2;
private RadioButton radio1,radio2;
private GroupBox radiogroup; 
private Button tipka1,tipka2; 

public unossifara(Button tipka7){
	tipka7x=tipka7;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Unos sifara";
	this.Size=new Size(800,550);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	this.MaximizeBox=false;
	this.Disposed+= new EventHandler(Form1_FormClosed);
	this.Load += new EventHandler(this.first1_Load);
	this.StartPosition=FormStartPosition.CenterScreen;
	
	Font font=new Font("Times New Roman",12,FontStyle.Bold | FontStyle.Italic);
	Font font1=new Font("Times New Roman",10,FontStyle.Italic);

	sifra=new Label();
	sifra.Location=new Point(30,30);
	sifra.Size=new Size(100,30);
	sifra.Text="Sifra";
	sifra.Font=font;
	this.Controls.Add(sifra);

	sifra_text=new TextBox();
	sifra_text.Location=new Point(130,30);
	sifra_text.Size=new Size(100,30);
	sifra_text.Text="";
	sifra_text.Font=font;
	this.Controls.Add(sifra_text);

	usluga=new Label();
	usluga.Location=new Point(30,70);
	usluga.Size=new Size(100,30);
	usluga.Text="Usluga";
	usluga.Font=font;
	this.Controls.Add(usluga);

	usluga_text=new TextBox();
	usluga_text.Location=new Point(130,70);
	usluga_text.Size=new Size(100,30);
	usluga_text.Text="";
	usluga_text.Font=font;
	this.Controls.Add(usluga_text);

	id1_label=new Label();
	id1_label.Location=new Point(30,110);
	id1_label.Size=new Size(100,30);
	id1_label.Text="id1";
	id1_label.Font=font;
	this.Controls.Add(id1_label);

	id1_text=new TextBox();
	id1_text.Location=new Point(130,110);
	id1_text.Size=new Size(100,30);
	id1_text.Text="";
	id1_text.Font=font;
	this.Controls.Add(id1_text);
	
	mjera1_label=new Label();
	mjera1_label.Location=new Point(30,150);
	mjera1_label.Size=new Size(100,30);
	mjera1_label.Text="id1 mjera";
	mjera1_label.Font=font;
	this.Controls.Add(mjera1_label);

	mjera1_text=new TextBox();
	mjera1_text.Location=new Point(130,150);
	mjera1_text.Size=new Size(100,30);
	mjera1_text.Text="";
	mjera1_text.Font=font;
	this.Controls.Add(mjera1_text);

	cijena1_label=new Label();
	cijena1_label.Location=new Point(30,190);
	cijena1_label.Size=new Size(100,30);
	cijena1_label.Text="id1 cijena";
	cijena1_label.Font=font;
	this.Controls.Add(cijena1_label);

	cijena1_text=new TextBox();
	cijena1_text.Location=new Point(130,190);
	cijena1_text.Size=new Size(100,30);
	cijena1_text.Text="";
	cijena1_text.Font=font;
	this.Controls.Add(cijena1_text);

	pdv1_label=new Label();
	pdv1_label.Location=new Point(30,230);
	pdv1_label.Size=new Size(100,30);
	pdv1_label.Text="Pdv1";
	pdv1_label.Font=font;
	this.Controls.Add(pdv1_label);

	pdv1_text=new TextBox();
	pdv1_text.Location=new Point(130,230);
	pdv1_text.Size=new Size(100,30);
	pdv1_text.Text="";
	pdv1_text.Font=font;
	this.Controls.Add(pdv1_text);


	id2_label=new Label();
	id2_label.Location=new Point(30,270);
	id2_label.Size=new Size(100,30);
	id2_label.Text="id2";
	id2_label.Font=font;
	this.Controls.Add(id2_label);

	id2_text=new TextBox();
	id2_text.Location=new Point(130,270);
	id2_text.Size=new Size(100,30);
	id2_text.Text="";
	id2_text.Font=font;
	this.Controls.Add(id2_text);

	mjera2_label=new Label();
	mjera2_label.Location=new Point(30,310);
	mjera2_label.Size=new Size(100,30);
	mjera2_label.Text="id2 mjera";
	mjera2_label.Font=font;
	this.Controls.Add(mjera2_label);

	mjera2_text=new TextBox();
	mjera2_text.Location=new Point(130,310);
	mjera2_text.Size=new Size(100,30);
	mjera2_text.Text="";
	mjera2_text.Font=font;
	this.Controls.Add(mjera2_text);
	
	cijena2_label=new Label();
	cijena2_label.Location=new Point(30,350);
	cijena2_label.Size=new Size(100,30);
	cijena2_label.Text="id2 cijena";
	cijena2_label.Font=font;
	this.Controls.Add(cijena2_label);

	cijena2_text=new TextBox();
	cijena2_text.Location=new Point(130,350);
	cijena2_text.Size=new Size(100,30);
	cijena2_text.Text="";
	cijena2_text.Font=font;
	this.Controls.Add(cijena2_text);

	pdv2_label=new Label();
	pdv2_label.Location=new Point(30,390);
	pdv2_label.Size=new Size(100,30);
	pdv2_label.Text="Pdv2";
	pdv2_label.Font=font;
	this.Controls.Add(pdv2_label);

	pdv2_text=new TextBox();
	pdv2_text.Location=new Point(130,390);
	pdv2_text.Size=new Size(100,30);
	pdv2_text.Text="";
	pdv2_text.Font=font;
	this.Controls.Add(pdv2_text);

	lv2=new ListView();
	lv2.Location=new Point(450,30);
	lv2.Size=new Size(330,400);
	lv2.Text="sifra 1";
	lv2.Font=font1;
	lv2.View = View.Details;
	lv2.FullRowSelect = true;
	lv2.GridLines = true;
	ColumnHeader columnHeader1 = new ColumnHeader();
	columnHeader1.Text = "Id";
	columnHeader1.TextAlign = HorizontalAlignment.Right;
	columnHeader1.Width = 50;
	
	lv2.Columns.Add(columnHeader1);
	lv2.Columns.Add("Artikl", 200);
	ColumnHeader columnHeader2 = new ColumnHeader();
	columnHeader2.Text = "Pdv";
	columnHeader2.TextAlign = HorizontalAlignment.Left;
	columnHeader2.Width = 50;
	lv2.Columns.Add(columnHeader2);
	
	lv2.SelectedIndexChanged += new EventHandler(ListView1_SelectedIndexChanged);  
	this.Controls.Add(lv2);

	radiogroup = new GroupBox();
    radiogroup.Text = "Id skladista";
	radiogroup.Font=font1;
    radiogroup.Location = new Point(250,30);
    radiogroup.Size = new Size(180,200);
    Controls.Add(radiogroup);


	radio1 = new RadioButton();
    radio1.Location = new Point(50,50);
	radio1.Size = new Size(50,30);
	radio1.Text = "Id1";
	radio1.Font=font1;
    radiogroup.Controls.Add(radio1);
	
	radio2 = new RadioButton();
    radio2.Location = new Point(50,100);
	radio2.Size = new Size(50,30);
	radio2.Text = "Id2";
	radio2.Font=font1;
    radiogroup.Controls.Add(radio2);

	tipka1=new Button();
	tipka1.Location=new Point(30,450);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(680,450);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);


}

private void tipka1_click(object sender,EventArgs e) {
	int sifra=Convert.ToInt32(sifra_text.Text);
	string usluga=Convert.ToString(usluga_text.Text);
	int id1=Convert.ToInt32(id1_text.Text);
	float mjera1=Convert.ToSingle(mjera1_text.Text);
	float cijena1=Convert.ToSingle(cijena1_text.Text);
	float pdv1=Convert.ToSingle(pdv1_text.Text);
	int id2=Convert.ToInt32(id2_text.Text);
	float mjera2=Convert.ToSingle(mjera2_text.Text);
	float cijena2=Convert.ToSingle(cijena2_text.Text);
	float pdv2=Convert.ToSingle(pdv2_text.Text);

	Console.WriteLine("sifrarnik");
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;

	con=new SQLiteConnection(cs);
	
	

	try
	{
		con.Open();
		cmd=new SQLiteCommand(con);
		
		if(id2==0){
			cmd.CommandText=@"insert into sifrarnik(id,artikl,id1,mjera1,cijena1,pdv1,
		id2,mjera2,cijena2,pdv2) values ("+sifra+",'"+usluga+"',"+id1+","+mjera1.ToString().Replace(",", ".")+
		","+cijena1.ToString().Replace(",", ".")+","+pdv1.ToString().Replace(",", ".")+",0,0.0,0.0,0.0);";  
			cmd.ExecuteNonQuery();
		}
		else
		{
			cmd.CommandText=@"insert into sifrarnik(id,artikl,id1,mjera1,cijena1,pdv1,
			id2,mjera2,cijena2,pdv2) values ("+sifra+",'"+usluga+"',"+id1+","+mjera1.ToString().Replace(",", ".")+
			","+cijena1.ToString().Replace(",", ".")+","+pdv1.ToString().Replace(",", ".")+","+
			id2.ToString().Replace(",", ".")+","+mjera2.ToString().Replace(",", ".")+","+cijena2.ToString().Replace(",", ".")+
			","+pdv2.ToString().Replace(",", ".")+");";   
	
			cmd.ExecuteNonQuery();
		}

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}

	this.Close();

}

private void tipka2_click(object sender,EventArgs e) {
this.Close();
}



private void ListView1_SelectedIndexChanged(object sender, EventArgs e)  
{  
if(lv2.SelectedItems.Count == 0)
    return;


string str1=lv2.SelectedItems[0].SubItems[0].Text.ToString();
string str2=lv2.SelectedItems[0].SubItems[0].Text.ToString();
string str3=lv2.SelectedItems[0].SubItems[2].Text.ToString();
string str4=lv2.SelectedItems[0].SubItems[2].Text.ToString();


if(radio1.Checked){
MessageBox.Show(this,lv2.SelectedItems[0].SubItems[0].Text.ToString()+" "+lv2.SelectedItems[0].SubItems[1].Text.ToString()+" "+lv2.SelectedItems[0].SubItems[2].Text.ToString()); 
id1_text.Text=str1;
pdv1_text.Text=str3;

}
if(radio2.Checked){
MessageBox.Show(this,lv2.SelectedItems[0].SubItems[0].Text.ToString()+" "+lv2.SelectedItems[0].SubItems[1].Text.ToString()+" "+lv2.SelectedItems[0].SubItems[2].Text.ToString()); 
id2_text.Text=str2;
pdv2_text.Text=str4;

}
 
}   
private void first1_Load(object sender,EventArgs e)
    {
      string SQL = "select * from skladiste;";
      string connectionString="Data Source=baza.db";

      SQLiteConnection con = new SQLiteConnection(connectionString);
      SQLiteCommand cmd =null;

	try{
		con.Open();
 		cmd=new SQLiteCommand(SQL, con);
      	SQLiteDataReader r = null;
		ListViewItem lvItem2;
		r = cmd.ExecuteReader();
    
      while (r.Read())
      {
        //lvItem1 = new ListViewItem(r[0].ToString());
		lvItem2 = new ListViewItem(r[0].ToString());
        for (int i = 1; i <= r.FieldCount - 1; i++)
        {
          //lvItem1.SubItems.Add(r[i].ToString());
			lvItem2.SubItems.Add(r[i].ToString());
        }
        //lv1.Items.Add(lvItem1);
		
		lv2.Items.Add(lvItem2);
      }

		
      	con.Close();
		r.Dispose();
		cmd.Dispose();
	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
}

	

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka7x.Enabled=true;
	this.Close();
}

}

class djelatnici
{
private Form form8;
private Button tipka8x;
private Button tipka1,tipka2;
private Label id_label,ime_label,prezime_label,oib_label,zaporka_label;
private TextBox id_text,ime_text,prezime_text,oib_text,zaporka_text;

public djelatnici(Button tipka8){
	tipka8x=tipka8;
	InitalizeComponent();
}

private void InitalizeComponent()
{	
	form8=new Form();
	form8.Text="djelatnici";
	form8.Size=new Size(300,300);
	form8.FormBorderStyle = FormBorderStyle.FixedSingle;
	form8.MaximizeBox = false;
	form8.Disposed+= new EventHandler(Form1_FormClosed);
	form8.StartPosition=FormStartPosition.CenterScreen;
	form8.Show();

	Font font=new Font("Verdana",12,FontStyle.Bold);

	id_label=new Label();
	id_label.Location=new Point(30,30);
	id_label.Size=new Size(100,30);
	id_label.Text="Id";
	id_label.Font=font;
	form8.Controls.Add(id_label);

	id_text=new TextBox();
	id_text.Location=new Point(170,30);
	id_text.Size=new Size(100,30);
	id_text.Text="";
	id_text.Font=font;
	form8.Controls.Add(id_text);
		
	ime_label=new Label();
	ime_label.Location=new Point(30,70);
	ime_label.Size=new Size(100,30);
	ime_label.Text="Ime";;
	ime_label.Font=font;
	form8.Controls.Add(ime_label);

	ime_text=new TextBox();
	ime_text.Location=new Point(170,70);
	ime_text.Size=new Size(100,30);
	ime_text.Text="";
	ime_text.Font=font;
	form8.Controls.Add(ime_text);

	prezime_label=new Label();
	prezime_label.Location=new Point(30,110);
	prezime_label.Size=new Size(100,30);
	prezime_label.Text="Prezime";
	prezime_label.Font=font;
	form8.Controls.Add(prezime_label);

	prezime_text=new TextBox();
	prezime_text.Location=new Point(170,110);
	prezime_text.Size=new Size(100,30);
	prezime_text.Text="";
	prezime_text.Font=font;
	form8.Controls.Add(prezime_text);

	oib_label=new Label();
	oib_label.Location=new Point(30,150);
	oib_label.Size=new Size(100,30);
	oib_label.Text="Oib";
	oib_label.Font=font;
	form8.Controls.Add(oib_label);

	oib_text=new TextBox();
	oib_text.Location=new Point(170,150);
	oib_text.Size=new Size(100,30);
	oib_text.Text="";
	oib_text.Font=font;
	form8.Controls.Add(oib_text);

	zaporka_label=new Label();
	zaporka_label.Location=new Point(30,190);
	zaporka_label.Size=new Size(100,30);
	zaporka_label.Text="Zaporka";
	zaporka_label.Font=font;
	form8.Controls.Add(zaporka_label);

	zaporka_text=new TextBox();
	zaporka_text.Location=new Point(170,190);
	zaporka_text.Size=new Size(100,30);
	zaporka_text.Text="";
	zaporka_text.Font=font;
	form8.Controls.Add(zaporka_text);


	tipka1=new Button();
	tipka1.Location=new Point(30,240);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font;
	tipka1.Click+=new EventHandler(tipka1_click);
	form8.Controls.Add(tipka1);

	
	tipka2=new Button();
	tipka2.Location=new Point(170,240);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font;
	tipka2.Click+=new EventHandler(tipka2_click);
	form8.Controls.Add(tipka2);
	
}

private void tipka1_click(object sender,EventArgs e) {
	int id=Convert.ToInt32(id_text.Text);
	string ime=Convert.ToString(ime_text.Text);
	string prezime=Convert.ToString(prezime_text.Text);
	string oib=Convert.ToString(oib_text.Text);
	string zaporka=Convert.ToString(zaporka_text.Text);

	Console.WriteLine("utrnio");
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;

	con=new SQLiteConnection(cs);
	
	try
	{
		con.Open();
		cmd=new SQLiteCommand(con);
		cmd.CommandText=@"insert into djelatnici(id_djelatnik,ime,prezime,oib,zaporka)
				values ("+id+",'"+ime+"','"+prezime+"','"+oib+"','"+zaporka+"');";
		cmd.ExecuteNonQuery();

		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}

	form8.Close();


}

private void tipka2_click(object sender,EventArgs e) {
form8.Close();
}

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka8x.Enabled=true;
	form8.Close();
}

}

class postavke:Form
{
private Button tipka1,tipka2,tipka1x;
private Label poduzece_label,ime_label,prezime_label,oib_label,telefon_label,adresa_label,mjesto_label;
private TextBox poduzece_text,ime_text,prezime_text,oib_text,telefon_text,adresa_text,mjesto_text;
 
public postavke(Button tipka1)
{
	tipka1x=tipka1;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Postavke";
	this.Size=new Size(300,500);
	this.StartPosition=FormStartPosition.CenterScreen;
	this.Disposed+= new EventHandler(Form1_FormClosed);
	this.MaximizeBox = false;
	this.FormBorderStyle = FormBorderStyle.FixedSingle;
	
	
	Font font=new Font("Times New Roman",12,FontStyle.Bold | FontStyle.Italic);
	

	poduzece_label=new Label();
	poduzece_label.Location=new Point(30,30);
	poduzece_label.Size=new Size(100,30);
	poduzece_label.Text="Poduzece";
	poduzece_label.Font=font;
	this.Controls.Add(poduzece_label);

	poduzece_text=new TextBox();
	poduzece_text.Location=new Point(170,30);
	poduzece_text.Size=new Size(100,30);
	poduzece_text.Text="";
	poduzece_text.Font=font;
	this.Controls.Add(poduzece_text);
		
	ime_label=new Label();
	ime_label.Location=new Point(30,70);
	ime_label.Size=new Size(100,30);
	ime_label.Text="Ime";;
	ime_label.Font=font;
	this.Controls.Add(ime_label);

	ime_text=new TextBox();
	ime_text.Location=new Point(170,70);
	ime_text.Size=new Size(100,30);
	ime_text.Text="";
	ime_text.Font=font;
	this.Controls.Add(ime_text);

	prezime_label=new Label();
	prezime_label.Location=new Point(30,110);
	prezime_label.Size=new Size(100,30);
	prezime_label.Text="Prezime";
	prezime_label.Font=font;
	this.Controls.Add(prezime_label);

	prezime_text=new TextBox();
	prezime_text.Location=new Point(170,110);
	prezime_text.Size=new Size(100,30);
	prezime_text.Text="";
	prezime_text.Font=font;
	this.Controls.Add(prezime_text);

	adresa_label=new Label();
	adresa_label.Location=new Point(30,150);
	adresa_label.Size=new Size(100,30);
	adresa_label.Text="Adresa";
	adresa_label.Font=font;
	this.Controls.Add(adresa_label);

	adresa_text=new TextBox();
	adresa_text.Location=new Point(170,150);
	adresa_text.Size=new Size(100,30);
	adresa_text.Text="";
	adresa_text.Font=font;
	this.Controls.Add(adresa_text);

	mjesto_label=new Label();
	mjesto_label.Location=new Point(30,190);
	mjesto_label.Size=new Size(100,30);
	mjesto_label.Text="Mjesto";
	mjesto_label.Font=font;
	this.Controls.Add(mjesto_label);

	mjesto_text=new TextBox();
	mjesto_text.Location=new Point(170,190);
	mjesto_text.Size=new Size(100,30);
	mjesto_text.Text="";
	mjesto_text.Font=font;
	this.Controls.Add(mjesto_text);


	oib_label=new Label();
	oib_label.Location=new Point(30,230);
	oib_label.Size=new Size(100,30);
	oib_label.Text="Oib";
	oib_label.Font=font;
	this.Controls.Add(oib_label);

	oib_text=new TextBox();
	oib_text.Location=new Point(170,230);
	oib_text.Size=new Size(100,30);
	oib_text.Text="";
	oib_text.Font=font;
	this.Controls.Add(oib_text);

	telefon_label=new Label();
	telefon_label.Location=new Point(30,270);
	telefon_label.Size=new Size(100,30);
	telefon_label.Text="Telefon";
	telefon_label.Font=font;
	this.Controls.Add(telefon_label);

	telefon_text=new TextBox();
	telefon_text.Location=new Point(170,270);
	telefon_text.Size=new Size(100,30);
	telefon_text.Text="";
	telefon_text.Font=font;
	this.Controls.Add(telefon_text);



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


	string poduzece=Convert.ToString(poduzece_text.Text);
	string ime=Convert.ToString(ime_text.Text);
	string prezime=Convert.ToString(prezime_text.Text);
	string adresa=Convert.ToString(adresa_text.Text);
	string mjesto=Convert.ToString(mjesto_text.Text);
	string oib=Convert.ToString(oib_text.Text);
	string telefon=Convert.ToString(telefon_text.Text);


	string cs="Data Source=baza.db";

		SQLiteConnection con=null;
		SQLiteCommand cmd=null;

		con=new SQLiteConnection(cs);
	try{
		con.Open();
		cmd=new SQLiteCommand(con);
		cmd.CommandText="drop table if exists poduzece;";
		cmd.ExecuteNonQuery();

		cmd.CommandText=@"create table poduzece(
				poduzece text not null,
				ime text not null,
				prezime text not null,
				adresa text not null,
				mjesto text not null,
				oib text not null,
				telefon text not null);";
		cmd.ExecuteNonQuery();

		cmd.CommandText=@"insert into poduzece(poduzece,ime,prezime,adresa,mjesto,oib,telefon) values    ('"+poduzece+"','"+ime+"','"+prezime+"','"+adresa+"','"+mjesto+"','"+oib+"','"+telefon+"');";
		cmd.ExecuteNonQuery();

		Console.WriteLine("Table created succesfully");

		cmd.Dispose();
		con.Close();
		
	}catch(SQLiteException ex)
	{
		Console.WriteLine("Error {0}",ex.ToString());
	}
	this.Close();

}

private void tipka2_click(object sender,EventArgs e)
{
	Console.WriteLine("utrnio");
	this.Close();	

}

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
}
}

class sifrarnik:Form
{
private Button tipka1,tipka2,tipka1x;
private ListView lv1;

public sifrarnik(Button tipka1)
{
	tipka1x=tipka1;
	InitalizeComponent();
}

private void InitalizeComponent()
{
	this.Text="Sifrarnik";
	this.Size=new Size(800,600);
	this.StartPosition=FormStartPosition.CenterScreen;
	this.Disposed+= new EventHandler(Form1_FormClosed);
	this.MaximizeBox = false;
	this.Load += new EventHandler(this.first1_Load);
	this.FormBorderStyle = FormBorderStyle.FixedSingle;


	Font font=new Font("Times New Roman",10,FontStyle.Italic);
	Font font1=new Font("Times New Roman",10,FontStyle.Italic|FontStyle.Bold);

	lv1=new ListView();
	lv1.Location=new Point(25,50);
	lv1.Size=new Size(750,300);
	lv1.Text="sifra 1";
	lv1.Font=font;
	lv1.View = View.Details;
	lv1.FullRowSelect = true;
	lv1.GridLines = true;
	lv1.Columns.Add("Id", 50);
	lv1.Columns.Add("Usluga",100);
	lv1.Columns.Add("Id1",50);
	lv1.Columns.Add("Id1 mjera",100);
	lv1.Columns.Add("Id1 cijena",100);
	lv1.Columns.Add("Pdv1",50);
	lv1.Columns.Add("Id2",50);
	lv1.Columns.Add("Id2 mjera",100);
	lv1.Columns.Add("Id2 cijena",100);
	lv1.Columns.Add("Pdv2",50);
	//lv2.SelectedIndexChanged += new EventHandler(ListView1_SelectedIndexChanged);  
	this.Controls.Add(lv1);


	tipka1=new Button();
	tipka1.Location=new Point(30,440);
	tipka1.Size=new Size(100,30);
	tipka1.Text="Potvrdi";
	tipka1.Font=font1;
	tipka1.Click+=new EventHandler(tipka1_click);
	this.Controls.Add(tipka1);
	
	tipka2=new Button();
	tipka2.Location=new Point(675,440);
	tipka2.Size=new Size(100,30);
	tipka2.Text="Odustani";
	tipka2.Font=font1;
	tipka2.Click+=new EventHandler(tipka2_click);
	this.Controls.Add(tipka2);
}

private void first1_Load(object sender,EventArgs e)
    {
      
	string cs="Data Source=baza.db";

	SQLiteConnection con=null;
	SQLiteCommand cmd=null;
	SQLiteDataReader r = null;
	ListViewItem lvItem1=null;
	string sql=null;	
	con=new SQLiteConnection(cs);
	sql="select * from sifrarnik;";
	try
	{
		con.Open();

		 
		cmd=new SQLiteCommand(con);
		cmd.CommandText=sql;
		
		r = cmd.ExecuteReader();
    
      while (r.Read())
      {
        
		lvItem1 = new ListViewItem(r[0].ToString());
        for (int i = 1; i <= r.FieldCount - 1; i++)
        {
          	lvItem1.SubItems.Add(r[i].ToString());
				
        }
       
		
		lv1.Items.Add(lvItem1);
      }
		r.Dispose();
		cmd.Dispose();
		con.Close();



	}
	catch(SQLiteException ex)
	{
		MessageBox.Show("Can not open connection"+ex.ToString());
	}
}


private void tipka1_click(object sender,EventArgs e)
{	

	

}

private void tipka2_click(object sender,EventArgs e)
{
	Console.WriteLine("utrnio");
	
	this.Close();	

}

private void Form1_FormClosed(object sender, EventArgs  e) {
    Console.WriteLine("Form Closed");
	tipka1x.Enabled=true;
	this.Close();
}
}



