/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 09/06/2022
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;


namespace UAS_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection con = new MySqlConnection("Server=localhost; Database=dbkulkas; Uid=root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tampilkanData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void tampilkanData(){
			try{
				mycommand.Connection = con;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from datakulkas";
				DataSet ds = new DataSet();
				
				if (myadapter.Fill(ds,"dftpesan")>0){
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				 MessageBox.Show(ex.ToString());
			}
		}
		
		public void inputData(){
			try{
				con.Open();
				mycommand.Connection=con;
				mycommand.CommandText="insert into datakulkas values('"+Nama.Text+"','"+Harga.Text+"','"+Jenis.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
					tampilkanData();
				}
				con.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		public void clear(){
			Nama.Text =  "";
			Harga.Text =  "";
			Jenis.Text =  "";
		}
	
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Nama.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			Harga.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			Jenis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			inputData();			
		}
		
	}
}
