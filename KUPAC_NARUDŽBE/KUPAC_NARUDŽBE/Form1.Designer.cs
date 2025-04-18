namespace KUPAC_NARUDŽBE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxKreiranjeNarudžbe = new GroupBox();
            dataGridViewPogledArtikla = new DataGridView();
            label1 = new Label();
            buttonKreirajNarudžbu = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            buttonDodaj = new Button();
            buttonObriši = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxIDArtikla = new TextBox();
            textBoxKoličinaArtikla = new TextBox();
            textBoxTotal = new TextBox();
            groupBoxKreiranjeNarudžbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPogledArtikla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxKreiranjeNarudžbe
            // 
            groupBoxKreiranjeNarudžbe.Controls.Add(textBoxTotal);
            groupBoxKreiranjeNarudžbe.Controls.Add(textBoxKoličinaArtikla);
            groupBoxKreiranjeNarudžbe.Controls.Add(textBoxIDArtikla);
            groupBoxKreiranjeNarudžbe.Controls.Add(label6);
            groupBoxKreiranjeNarudžbe.Controls.Add(label5);
            groupBoxKreiranjeNarudžbe.Controls.Add(label4);
            groupBoxKreiranjeNarudžbe.Controls.Add(label3);
            groupBoxKreiranjeNarudžbe.Controls.Add(buttonObriši);
            groupBoxKreiranjeNarudžbe.Controls.Add(buttonDodaj);
            groupBoxKreiranjeNarudžbe.Controls.Add(label2);
            groupBoxKreiranjeNarudžbe.Controls.Add(dataGridView1);
            groupBoxKreiranjeNarudžbe.Controls.Add(buttonKreirajNarudžbu);
            groupBoxKreiranjeNarudžbe.Controls.Add(label1);
            groupBoxKreiranjeNarudžbe.Controls.Add(dataGridViewPogledArtikla);
            groupBoxKreiranjeNarudžbe.Location = new Point(12, 12);
            groupBoxKreiranjeNarudžbe.Name = "groupBoxKreiranjeNarudžbe";
            groupBoxKreiranjeNarudžbe.Size = new Size(536, 332);
            groupBoxKreiranjeNarudžbe.TabIndex = 0;
            groupBoxKreiranjeNarudžbe.TabStop = false;
            groupBoxKreiranjeNarudžbe.Text = "Kreiranje narudžbe";
            // 
            // dataGridViewPogledArtikla
            // 
            dataGridViewPogledArtikla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPogledArtikla.Location = new Point(6, 47);
            dataGridViewPogledArtikla.Name = "dataGridViewPogledArtikla";
            dataGridViewPogledArtikla.Size = new Size(234, 258);
            dataGridViewPogledArtikla.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Pogled artikla";
            // 
            // buttonKreirajNarudžbu
            // 
            buttonKreirajNarudžbu.Location = new Point(246, 17);
            buttonKreirajNarudžbu.Name = "buttonKreirajNarudžbu";
            buttonKreirajNarudžbu.Size = new Size(108, 27);
            buttonKreirajNarudžbu.TabIndex = 2;
            buttonKreirajNarudžbu.Text = "Kreiraj narudžbu";
            buttonKreirajNarudžbu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(246, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(211, 170);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 47);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Korpa";
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(246, 242);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(75, 23);
            buttonDodaj.TabIndex = 5;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            // 
            // buttonObriši
            // 
            buttonObriši.Location = new Point(246, 271);
            buttonObriši.Name = "buttonObriši";
            buttonObriši.Size = new Size(75, 23);
            buttonObriši.TabIndex = 6;
            buttonObriši.Text = "Obriši";
            buttonObriši.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 246);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 246);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "KOL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 305);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 305);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 10;
            label6.Text = "KM";
            // 
            // textBoxIDArtikla
            // 
            textBoxIDArtikla.Location = new Point(327, 264);
            textBoxIDArtikla.Name = "textBoxIDArtikla";
            textBoxIDArtikla.Size = new Size(42, 23);
            textBoxIDArtikla.TabIndex = 11;
            // 
            // textBoxKoličinaArtikla
            // 
            textBoxKoličinaArtikla.Location = new Point(375, 264);
            textBoxKoličinaArtikla.Name = "textBoxKoličinaArtikla";
            textBoxKoličinaArtikla.Size = new Size(40, 23);
            textBoxKoličinaArtikla.TabIndex = 12;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(368, 302);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(69, 23);
            textBoxTotal.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(groupBoxKreiranjeNarudžbe);
            Name = "Form1";
            Text = "Form1";
            groupBoxKreiranjeNarudžbe.ResumeLayout(false);
            groupBoxKreiranjeNarudžbe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPogledArtikla).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxKreiranjeNarudžbe;
        private Label label2;
        private DataGridView dataGridView1;
        private Button buttonKreirajNarudžbu;
        private Label label1;
        private DataGridView dataGridViewPogledArtikla;
        private TextBox textBoxTotal;
        private TextBox textBoxKoličinaArtikla;
        private TextBox textBoxIDArtikla;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonObriši;
        private Button buttonDodaj;
    }
}
