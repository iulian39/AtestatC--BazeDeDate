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
    public partial class ModifyForm : Form
    {
        private MainForm fMain = null;
        private DataGridView dgr = null;

        public ModifyForm()
        {
            InitializeComponent();
        }

        public ModifyForm(MainForm f, DataGridView data)
        {
            fMain = f;
            dgr = data;
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            
            addType.DropDownStyle = ComboBoxStyle.DropDownList;
            addType.Text = "Other";
            fillBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mdfType.DropDownStyle = ComboBoxStyle.DropDownList;
            mdfType.Text = "Other";
            comboDel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDel.Text = "Id";
            if (dgr.Rows.Count - 1 == 0)
            {
                fillBox.Enabled = false;
                btnFill.Enabled = false;
            }
            else
                ModifyItems();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            labelError.ForeColor = Color.Red;
            string Verify = addName.Text;
            int cnt = 0;
            for (int i = 0; i < Verify.Length; ++i)
                if (Char.IsLetterOrDigit(Verify[i]))
                    cnt++;
            if (cnt < 3)
            {
                labelError.Text = "Eroare Nume";
                return;
            }

            int Price;
            bool Try = int.TryParse(addPrice.Text, out Price);

            if (!Try || Price < 0 || Price > 500)
            {
                labelError.Text = "Eroare Pret";
                return;
            }

            int Year;
            Try = int.TryParse(addYear.Text, out Year);

            if (!Try || Year < 1990 || Year > 2016)
            {
                labelError.Text = "Eroare An";
                return;
            }

            

            if(addDescription.Text == "")
            {
                string query = "INSERT INTO Games (Denumire, Firma, Pret, An_ap, Tip, Descriere) VALUES('" + addName.Text + "', '" + addFirm.Text + "', '" +
                        addPrice.Text + "', '" + addYear.Text + "', '" + addType.Text + "', '" + "Momentan nu exista nicio descriere pentru acest joc." + "')";

                fMain.Insert(query);
            }
            else
            {
                string query = "INSERT INTO Games (Denumire, Firma, Pret, An_ap, Tip, Descriere) VALUES('" + addName.Text + "', '" + addFirm.Text + "', '" +
                        addPrice.Text + "', '" + addYear.Text + "', '" + addType.Text + "', '" + addDescription.Text + "')";

                fMain.Insert(query);
            }
            if (dgr.Rows.Count - 1 > 0)
            {
                fillBox.Enabled = true;
                btnFill.Enabled = true;
            }
            fillBox.Items.Clear();

            ModifyItems();
           
        }

        private void ModifyItems()
        {
            fillBox.Items.Clear();
            int x = dgr.RowCount - 1;
            for (int i = 1; i <= x; ++i)
            {
                string z = dgr.Rows[i - 1].Cells[0].Value.ToString();
                fillBox.Items.Add(z);
            }
            fillBox.Text = dgr.Rows[x - 1].Cells[0].Value.ToString();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            
            int c;            
            int.TryParse(fillBox.Text, out c);
            mdfName.Text = dgr.Rows[c - 1].Cells[1].Value.ToString();
            mdfFirm.Text = dgr.Rows[c - 1].Cells[2].Value.ToString();
            mdfPrice.Text = dgr.Rows[c - 1].Cells[3].Value.ToString();
            mdfYear.Text = dgr.Rows[c - 1].Cells[4].Value.ToString();
            mdfType.Text = dgr.Rows[c - 1].Cells[5].Value.ToString();
            mdfDescription.Text = dgr.Rows[c - 1].Cells[6].Value.ToString();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            labelError1.Text = "";
            labelError1.ForeColor = Color.Red;
            string Verify = mdfName.Text;
            int cnt = 0;
            for (int i = 0; i < Verify.Length; ++i)
                if (Char.IsLetterOrDigit(Verify[i]))
                    cnt++;
            if (cnt < 3)
            {
                labelError1.Text = "Eroare Nume";
                return;
            }
            
            int Year;
            bool Try = int.TryParse(mdfYear.Text, out Year);

            if (!Try || Year < 1990 || Year > 2016)
            {
                labelError1.Text = "Eroare An";
                return;
            }

            int Price;
            Try = int.TryParse(mdfPrice.Text, out Price);

            if (!Try || Price < 0 || Price > 500)
            {
                labelError1.Text = "Eroare Pret";
                return;
            }

            if (mdfDescription.Text == "")
            {
                string query = "UPDATE Games SET Denumire='" + mdfName.Text + "', Firma='" + mdfFirm.Text + "', Pret='" +
                        mdfPrice.Text + "', An_ap='" + mdfYear.Text + "', Tip='" + addType.Text + "', Descriere='" + "Momentan nu exista nicio descriere pentru acest joc.'"+" WHERE Id='" + fillBox.Text + "'";
                fMain.Insert(query);
            }
            else
            {
                string query = "UPDATE Games SET Denumire='" + mdfName.Text + "', Firma='" + mdfFirm.Text + "', Pret='" +
                        mdfPrice.Text + "', An_ap='" + mdfYear.Text + "', Tip='" + addType.Text + "', Descriere='" + mdfDescription.Text + "' WHERE Id='" + fillBox.Text + "'";
                fMain.Insert(query);
            }


            fillBox.Items.Clear();
            ModifyItems();

        }


        private void btnDel_Click(object sender, EventArgs e)
        {
           
            string query = "DELETE FROM Games WHERE " + comboDel.Text + " = '" +
                        delBox.Text + "'";
            fMain.Insert(query);
            if (dgr.Rows.Count - 1 == 0)
            {
                fillBox.Enabled = false;
                btnFill.Enabled = false;
            }
            else
            {
                ModifyItems();
            }
                
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
