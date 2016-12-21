namespace Jocuri
{
    partial class MainForm
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
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btnModifyDB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minPrice = new System.Windows.Forms.TextBox();
            this.maxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lerror = new System.Windows.Forms.Label();
            this.btnPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(9, 102);
            this.dgw.Name = "dgw";
            this.dgw.Size = new System.Drawing.Size(771, 346);
            this.dgw.TabIndex = 0;
            // 
            // btnModifyDB
            // 
            this.btnModifyDB.Location = new System.Drawing.Point(13, 12);
            this.btnModifyDB.Name = "btnModifyDB";
            this.btnModifyDB.Size = new System.Drawing.Size(101, 75);
            this.btnModifyDB.TabIndex = 1;
            this.btnModifyDB.Text = "Modifica baza de date";
            this.btnModifyDB.UseVisualStyleBackColor = true;
            this.btnModifyDB.Click += new System.EventHandler(this.btnModifyDB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(129, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 75);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Reincarca baza de date";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Afisare dupa pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pret minim";
            // 
            // minPrice
            // 
            this.minPrice.Location = new System.Drawing.Point(608, 43);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(40, 20);
            this.minPrice.TabIndex = 5;
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(723, 43);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(46, 20);
            this.maxPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pret maxim";
            // 
            // lerror
            // 
            this.lerror.AutoSize = true;
            this.lerror.Location = new System.Drawing.Point(579, 74);
            this.lerror.Name = "lerror";
            this.lerror.Size = new System.Drawing.Size(0, 13);
            this.lerror.TabIndex = 8;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(705, 69);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPrice.TabIndex = 9;
            this.btnPrice.Text = "Sorteaza !";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 460);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.lerror);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxPrice);
            this.Controls.Add(this.minPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModifyDB);
            this.Controls.Add(this.dgw);
            this.Name = "MainForm";
            this.Text = "Forma principala a bazei de date";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModifyDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minPrice;
        private System.Windows.Forms.TextBox maxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lerror;
        private System.Windows.Forms.Button btnPrice;
    }
}

