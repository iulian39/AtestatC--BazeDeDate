namespace Jocuri
{
    partial class ModifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addName = new System.Windows.Forms.TextBox();
            this.addFirm = new System.Windows.Forms.TextBox();
            this.addPrice = new System.Windows.Forms.TextBox();
            this.addYear = new System.Windows.Forms.TextBox();
            this.addType = new System.Windows.Forms.ComboBox();
            this.addDescription = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.comboDel = new System.Windows.Forms.ComboBox();
            this.delBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mdfName = new System.Windows.Forms.TextBox();
            this.mdfFirm = new System.Windows.Forms.TextBox();
            this.mdfPrice = new System.Windows.Forms.TextBox();
            this.mdfYear = new System.Windows.Forms.TextBox();
            this.mdfType = new System.Windows.Forms.ComboBox();
            this.mdfDescription = new System.Windows.Forms.RichTextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.fillBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(257, 242);
            this.treeView1.TabIndex = 0;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(113, 22);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(147, 20);
            this.addName.TabIndex = 1;
            // 
            // addFirm
            // 
            this.addFirm.Location = new System.Drawing.Point(113, 49);
            this.addFirm.Name = "addFirm";
            this.addFirm.Size = new System.Drawing.Size(147, 20);
            this.addFirm.TabIndex = 2;
            // 
            // addPrice
            // 
            this.addPrice.Location = new System.Drawing.Point(113, 76);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(147, 20);
            this.addPrice.TabIndex = 3;
            // 
            // addYear
            // 
            this.addYear.Location = new System.Drawing.Point(113, 103);
            this.addYear.Name = "addYear";
            this.addYear.Size = new System.Drawing.Size(147, 20);
            this.addYear.TabIndex = 4;
            // 
            // addType
            // 
            this.addType.FormattingEnabled = true;
            this.addType.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "First-Person-Shooter(FPS)",
            "Platform",
            "Role-Playing Games (RPG)",
            "Strategy/Tactics",
            "Simulation",
            "Sports",
            "Fighting",
            "Dance/Rhythm",
            "Horror\t",
            "Survival",
            "MOBA",
            "Other"});
            this.addType.Location = new System.Drawing.Point(113, 130);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(147, 21);
            this.addType.TabIndex = 5;
            // 
            // addDescription
            // 
            this.addDescription.Location = new System.Drawing.Point(113, 158);
            this.addDescription.Name = "addDescription";
            this.addDescription.Size = new System.Drawing.Size(147, 54);
            this.addDescription.TabIndex = 6;
            this.addDescription.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adauga !";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Firma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Anul aparitiei";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descriere";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(276, 12);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(255, 320);
            this.treeView2.TabIndex = 14;
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(12, 261);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(258, 71);
            this.treeView3.TabIndex = 15;
            // 
            // comboDel
            // 
            this.comboDel.FormattingEnabled = true;
            this.comboDel.Items.AddRange(new object[] {
            "Id",
            "Denumire",
            "Firma",
            "Pret",
            "An_ap",
            "Tip",
            "Descriere"});
            this.comboDel.Location = new System.Drawing.Point(130, 274);
            this.comboDel.Name = "comboDel";
            this.comboDel.Size = new System.Drawing.Size(130, 21);
            this.comboDel.TabIndex = 16;
            // 
            // delBox
            // 
            this.delBox.Location = new System.Drawing.Point(22, 274);
            this.delBox.Name = "delBox";
            this.delBox.Size = new System.Drawing.Size(102, 20);
            this.delBox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sterge !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // mdfName
            // 
            this.mdfName.Location = new System.Drawing.Point(376, 87);
            this.mdfName.Name = "mdfName";
            this.mdfName.Size = new System.Drawing.Size(146, 20);
            this.mdfName.TabIndex = 19;
            // 
            // mdfFirm
            // 
            this.mdfFirm.Location = new System.Drawing.Point(376, 113);
            this.mdfFirm.Name = "mdfFirm";
            this.mdfFirm.Size = new System.Drawing.Size(146, 20);
            this.mdfFirm.TabIndex = 20;
            // 
            // mdfPrice
            // 
            this.mdfPrice.Location = new System.Drawing.Point(376, 139);
            this.mdfPrice.Name = "mdfPrice";
            this.mdfPrice.Size = new System.Drawing.Size(146, 20);
            this.mdfPrice.TabIndex = 21;
            // 
            // mdfYear
            // 
            this.mdfYear.Location = new System.Drawing.Point(376, 165);
            this.mdfYear.Name = "mdfYear";
            this.mdfYear.Size = new System.Drawing.Size(146, 20);
            this.mdfYear.TabIndex = 22;
            // 
            // mdfType
            // 
            this.mdfType.FormattingEnabled = true;
            this.mdfType.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "First-Person-Shooter(FPS)",
            "Platform",
            "Role-Playing Games (RPG)",
            "Strategy/Tactics",
            "Simulation",
            "Sports",
            "Fighting",
            "Dance/Rhythm",
            "Horror\t",
            "Survival",
            "MOBA",
            "Other"});
            this.mdfType.Location = new System.Drawing.Point(376, 191);
            this.mdfType.Name = "mdfType";
            this.mdfType.Size = new System.Drawing.Size(146, 21);
            this.mdfType.TabIndex = 23;
            // 
            // mdfDescription
            // 
            this.mdfDescription.Location = new System.Drawing.Point(376, 220);
            this.mdfDescription.Name = "mdfDescription";
            this.mdfDescription.Size = new System.Drawing.Size(146, 53);
            this.mdfDescription.TabIndex = 24;
            this.mdfDescription.Text = "";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(376, 52);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(146, 29);
            this.btnFill.TabIndex = 25;
            this.btnFill.Text = "Introdu datele !";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(442, 287);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 22);
            this.btnModify.TabIndex = 26;
            this.btnModify.Text = "Modifica !";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Denumire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Firma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Pret";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Anul aparitiei";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tip";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(19, 223);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 34;
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Location = new System.Drawing.Point(287, 260);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(0, 13);
            this.labelError1.TabIndex = 35;
            // 
            // fillBox
            // 
            this.fillBox.FormattingEnabled = true;
            this.fillBox.Location = new System.Drawing.Point(376, 25);
            this.fillBox.Name = "fillBox";
            this.fillBox.Size = new System.Drawing.Size(146, 21);
            this.fillBox.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Descriere";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(130, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(267, 23);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Inchideti forma !";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 367);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fillBox);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.mdfDescription);
            this.Controls.Add(this.mdfType);
            this.Controls.Add(this.mdfYear);
            this.Controls.Add(this.mdfPrice);
            this.Controls.Add(this.mdfFirm);
            this.Controls.Add(this.mdfName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delBox);
            this.Controls.Add(this.comboDel);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addDescription);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.addYear);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.addFirm);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.treeView1);
            this.Name = "ModifyForm";
            this.Text = "Modifica baza de date";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.TextBox addFirm;
        private System.Windows.Forms.TextBox addPrice;
        private System.Windows.Forms.TextBox addYear;
        private System.Windows.Forms.ComboBox addType;
        private System.Windows.Forms.RichTextBox addDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.ComboBox comboDel;
        private System.Windows.Forms.TextBox delBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox mdfName;
        private System.Windows.Forms.TextBox mdfFirm;
        private System.Windows.Forms.TextBox mdfPrice;
        private System.Windows.Forms.TextBox mdfYear;
        private System.Windows.Forms.ComboBox mdfType;
        private System.Windows.Forms.RichTextBox mdfDescription;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.ComboBox fillBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
    }
}