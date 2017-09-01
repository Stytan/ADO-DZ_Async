using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DZ_Async
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Employees"].ConnectionString);

        public Form1()
        {
            InitializeComponent();
            this.Load += textBoxQuery_TextChanged;
        }
        void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Делает кнопки неактивными если строка запроса пуста
        /// </summary>
        void textBoxQuery_TextChanged(object sender, EventArgs e)
        {
            buttonAsync.Enabled =
            buttonBegin.Enabled =
            toolStripButtonAsync.Enabled =
            toolStripButtonBegin.Enabled =
            beginEndToolStripMenuItem.Enabled =
            asyncToolStripMenuItem.Enabled = textBoxQuery.Text != "";
        }
        /// <summary>
        /// Читает результат запроса из ридера в таблицу
        /// </summary>
        /// <param name="reader">ридер полученный из запроса</param>
        /// <returns>таблица с результатом запроса</returns>
        DataTable getTableFromReader(SqlDataReader reader)
        {
            DataTable table = new DataTable();
            int line = 0;
            do
            {
                while (reader.Read())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; ++i)
                        {
                            table.Columns.Add(reader.GetName(i));
                        }
                        line++;
                    }
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; ++i)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
            } while (reader.NextResult());
            return table;
        }
        /// <summary>
        /// Обработка запросов методом begin-end
        /// </summary>
        void buttonBegin_Click(object sender, EventArgs e)
        {
            try
            {
                string comText = textBoxQuery.Text.Trim();
                SqlCommand com = new SqlCommand
                {
                    CommandText = comText,
                    Connection = connect
                };
                connect.Open();
                SqlDataReader reader = null;
                //Если первое слово = SELECT или выполняется процедура getEmployees выполняем запрос на выборку
                string select = comText.Split(new[] { ' ' })[0].ToUpper();
                if (select.Equals("SELECT") || comText.Contains("getEmployees"))
                {
                    toolStripStatusLabel1.Text = "Begin execute query...";
                    com.BeginExecuteReader(ar =>
                    {
                        try
                        {
                            //Получаем ридер из команды
                            reader = ((SqlCommand)ar.AsyncState).EndExecuteReader(ar);
                            //заполняем dataGridView1 (вдругом потоке) таблицей из ридера
                            dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = getTableFromReader(reader)));
                            //меняем статус бар
                            statusStrip1.Invoke(new Action(() => toolStripStatusLabel1.Text = "Request completed"));
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            toolStripStatusLabel1.Text = "Error";
                        }
                        finally
                        {
                            if (reader != null && !reader.IsClosed)
                                reader.Close();
                            if (connect != null && connect.State != ConnectionState.Closed)
                                connect.Close();
                        }
                    }, com);
                }
                else
                {
                    //Иначе выполняем запрос на изменение данных
                    com.BeginExecuteNonQuery(ar =>
                    {
                        try
                        {
                            //Показываем в статус бар
                            statusStrip1.Invoke(
                                new Action(() =>
                                //количество обработанных в результате запроса строк
                                toolStripStatusLabel1.Text = string.Format("Processed {0} records",
                                ((SqlCommand)ar.AsyncState).EndExecuteNonQuery(ar)))
                                );
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            toolStripStatusLabel1.Text = "Error";
                        }
                        finally
                        {
                            if (reader != null && !reader.IsClosed)
                                reader.Close();
                            if (connect != null && connect.State != ConnectionState.Closed)
                                connect.Close();
                        }
                    }, com);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                toolStripStatusLabel1.Text = "Error";
            }
        }
        /// <summary>
        /// Обработка запросов методом async-await
        /// </summary>
        private async void buttonAsync_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            try
            {
                string comText = textBoxQuery.Text.Trim();
                SqlCommand com = new SqlCommand
                {
                    CommandText = comText,
                    Connection = connect
                };
                await connect.OpenAsync();
                string select = comText.Split(new[] { ' ' })[0].ToUpper();
                //Если первое слово = SELECT или выполняется процедура getEmployees выполняем запрос на выборку
                if (select.Equals("SELECT") || comText.Contains("getEmployees"))
                {
                    toolStripStatusLabel1.Text = "Async execute query...";
                    //Выполняем асинхронный запрос
                    reader = await com.ExecuteReaderAsync();
                    //заполняем dataGridView1 из ридера
                    dataGridView1.DataSource = getTableFromReader(reader);
                    toolStripStatusLabel1.Text = "Request completed";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Async execute query...";
                    toolStripStatusLabel1.Text = string.Format("Processed {0} records", await com.ExecuteNonQueryAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                toolStripStatusLabel1.Text = "Error";
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
                if (connect != null && connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }
    }
}
//waitfor delay '0:0:5'; execute addEmployee 'Петров','Пётр','Петрович','монтажник','№15 от 01.02.2017',null,null
