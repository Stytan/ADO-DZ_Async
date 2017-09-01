using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Async
{
	public partial class Form1 : Form
	{
		SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Library"].ConnectionString);
		
		public Form1()
		{
			InitializeComponent();
		}
		void buttonExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		void textBoxQuery_TextChanged(object sender, EventArgs e)
		{
			buttonAsync.Enabled = 
			buttonBegin.Enabled = 
			toolStripButtonAsync.Enabled =
			toolStripButtonBegin.Enabled =
			beginEndToolStripMenuItem.Enabled =
			asyncToolStripMenuItem.Enabled = textBoxQuery.Text != "";
		}
		void buttonBegin_Click(object sender, EventArgs e)
		{
			SqlCommand com = null;
			try {
				string comText = textBoxQuery.Text.Trim();
				com = new SqlCommand {
					CommandText = comText,
					Connection = connect
				};
				connect.Open();
				//Если первое слово = SELECT выполняем запрос на выборку
				if (comText.Split(new []{ ' ' })[0].ToUpper().Equals("SELECT")) {
					com.BeginExecuteReader(ar => {
						statusStrip1.Text = "Begin execute query...";
						SqlDataReader reader = null;
						try {
							reader = ((SqlCommand)ar.AsyncState).EndExecuteReader(ar);
							
						} catch (Exception ex) {
							MessageBox.Show(ex.Message);
						} finally {
							reader.Close();
						}           	
					}, com);
				} else {
					//Иначе выполняем запрос на изменение данных
					com.BeginExecuteNonQuery(ar => {
						try {
					    	
						} catch (Exception ex) {
							MessageBox.Show(ex.Message);
						}
					}, com);
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			} finally {
				connect.Close();
			}
		}
	}
}
