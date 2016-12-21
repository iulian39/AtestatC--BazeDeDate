using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Jocuri
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private SqlConnection conn = null;
        private string connString = Properties.Settings.Default.GamesDBConnectionString;//Conectarea la GamesDB
        SqlDataReader dr = null;
        private static SqlConnection sqlconn = null;

        private void MainForm_Load(object sender, EventArgs e)
        {
            minPrice.Text = "0";
            maxPrice.Text = "0";
            dgw.ColumnCount = 7;
            dgw.Columns[0].HeaderText = "Id";
            dgw.Columns[1].HeaderText = "Nume";
            dgw.Columns[2].HeaderText = "Firma";
            dgw.Columns[3].HeaderText = "Pret";
            dgw.Columns[4].HeaderText = "Anul aparitiei";
            dgw.Columns[5].HeaderText = "Tip";
            dgw.Columns[6].HeaderText = "Descriere";
            RefreshDB();
        }

        private void RefreshDB()
        {
            dgw.Rows.Clear();
            conn = new SqlConnection(connString);
            sqlconn = conn;
            try
            {
                conn.Open();
                string query = "SELECT * FROM Games";

                SqlCommand cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string[] row = new string[7]
                    {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString()
                    };
                    dgw.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                dr.Close();
            }
        }

        private void SortPrice(string query)
        {
            dgw.Rows.Clear();
            conn = new SqlConnection(connString);
            sqlconn = conn;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string[] row = new string[7]
                    {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString()
                    };
                    dgw.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                dr.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDB();
        }

        private void btnModifyDB_Click(object sender, EventArgs e)
        {
            ModifyForm f = new ModifyForm(this, dgw);
            f.Show();
        }

        public void Insert(string query)
        {
            try
            {
                if (sqlconn != null)
                {
                    if (sqlconn.State == ConnectionState.Closed)
                        sqlconn.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.ExecuteNonQuery();
                    RefreshDB();

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            lerror.Text = "";
            lerror.ForeColor = Color.Red;
            int minP, maxP;
            bool tryp = int.TryParse(minPrice.Text, out minP);
            bool trypr = int.TryParse(maxPrice.Text, out maxP);
            if(tryp == false || trypr == false)
            {
                lerror.Text = "Eroare";
                return;
            }

            if (minP < 0 || maxP < 0)
            {
                lerror.Text = "Eroare";
                minPrice.Text = maxPrice.Text = "0";
                return;
            }
            else
                if (minP > maxP && maxP > 0)
                {
                   lerror.Text = "Eroare";
                   minPrice.Text = maxPrice.Text = "0";
                   return;
                }
                else
                    if (maxP == 0 && minP == 0)
                        RefreshDB();
                    else
                        if(minP == 0 && maxP > 0)
                        {
                            string query = "SELECT * FROM Games WHERE Pret < '" + maxP + "'";
                            SortPrice(query);
                        }
                        else
                            if (maxP == 0 && minP > 0)
                            {
                                string query = "SELECT * FROM Games WHERE Pret > '" + minP + "'";
                                SortPrice(query);
                    
                            }
                            else
                            {
                                string query = "SELECT * FROM Games WHERE Pret BETWEEN '" + minP + "' AND '" + maxP + "'";
                                SortPrice(query);

                            } 

        }


    }
}

