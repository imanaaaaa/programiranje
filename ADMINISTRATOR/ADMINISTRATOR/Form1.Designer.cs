namespace ADMINISTRATOR
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxImeTraži = new TextBox();
            textBoxPrezimeTraži = new TextBox();
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxGrad = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxKorisničkoIme = new TextBox();
            textBoxŠifra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonTraži = new Button();
            buttonKreiranjeKupca = new Button();
            buttonAžuriranjeKupca = new Button();
            textBoxIDKupca = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(497, 154);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxIDKupca);
            groupBox1.Controls.Add(buttonAžuriranjeKupca);
            groupBox1.Controls.Add(buttonKreiranjeKupca);
            groupBox1.Controls.Add(buttonTraži);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxŠifra);
            groupBox1.Controls.Add(textBoxKorisničkoIme);
            groupBox1.Controls.Add(textBoxTelefon);
            groupBox1.Controls.Add(textBoxAdresa);
            groupBox1.Controls.Add(textBoxGrad);
            groupBox1.Controls.Add(textBoxPrezime);
            groupBox1.Controls.Add(textBoxIme);
            groupBox1.Controls.Add(textBoxPrezimeTraži);
            groupBox1.Controls.Add(textBoxImeTraži);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(26, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 401);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kreiranje / Ažuriranje novog kupca";
            // 
            // textBoxImeTraži
            // 
            textBoxImeTraži.Location = new Point(6, 22);
            textBoxImeTraži.Name = "textBoxImeTraži";
            textBoxImeTraži.Size = new Size(133, 23);
            textBoxImeTraži.TabIndex = 1;
            // 
            // textBoxPrezimeTraži
            // 
            textBoxPrezimeTraži.Location = new Point(145, 24);
            textBoxPrezimeTraži.Name = "textBoxPrezimeTraži";
            textBoxPrezimeTraži.Size = new Size(153, 23);
            textBoxPrezimeTraži.TabIndex = 2;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(88, 213);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(100, 23);
            textBoxIme.TabIndex = 3;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(88, 242);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(100, 23);
            textBoxPrezime.TabIndex = 4;
            // 
            // textBoxGrad
            // 
            textBoxGrad.Location = new Point(88, 271);
            textBoxGrad.Name = "textBoxGrad";
            textBoxGrad.Size = new Size(100, 23);
            textBoxGrad.TabIndex = 5;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(88, 300);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(100, 23);
            textBoxAdresa.TabIndex = 6;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(295, 213);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(100, 23);
            textBoxTelefon.TabIndex = 7;
            // 
            // textBoxKorisničkoIme
            // 
            textBoxKorisničkoIme.Location = new Point(295, 245);
            textBoxKorisničkoIme.Name = "textBoxKorisničkoIme";
            textBoxKorisničkoIme.Size = new Size(100, 23);
            textBoxKorisničkoIme.TabIndex = 8;
            // 
            // textBoxŠifra
            // 
            textBoxŠifra.Location = new Point(295, 274);
            textBoxŠifra.Name = "textBoxŠifra";
            textBoxŠifra.Size = new Size(100, 23);
            textBoxŠifra.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 221);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 10;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 245);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 274);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Grad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 303);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 13;
            label4.Text = "Adresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 216);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 250);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 15;
            label6.Text = "Korisničko ime:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 277);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 16;
            label7.Text = "Šifra:";
            // 
            // buttonTraži
            // 
            buttonTraži.Location = new Point(320, 24);
            buttonTraži.Name = "buttonTraži";
            buttonTraži.Size = new Size(75, 23);
            buttonTraži.TabIndex = 17;
            buttonTraži.Text = "Traži";
            buttonTraži.UseVisualStyleBackColor = true;
            // 
            // buttonKreiranjeKupca
            // 
            buttonKreiranjeKupca.Location = new Point(276, 323);
            buttonKreiranjeKupca.Name = "buttonKreiranjeKupca";
            buttonKreiranjeKupca.Size = new Size(119, 23);
            buttonKreiranjeKupca.TabIndex = 18;
            buttonKreiranjeKupca.Text = "Kreiranje kupca";
            buttonKreiranjeKupca.UseVisualStyleBackColor = true;
            // 
            // buttonAžuriranjeKupca
            // 
            buttonAžuriranjeKupca.Location = new Point(276, 356);
            buttonAžuriranjeKupca.Name = "buttonAžuriranjeKupca";
            buttonAžuriranjeKupca.Size = new Size(119, 23);
            buttonAžuriranjeKupca.TabIndex = 19;
            buttonAžuriranjeKupca.Text = "Ažuriranje kupca";
            buttonAžuriranjeKupca.UseVisualStyleBackColor = true;
            // 
            // textBoxIDKupca
            // 
            textBoxIDKupca.Location = new Point(203, 357);
            textBoxIDKupca.Name = "textBoxIDKupca";
            textBoxIDKupca.Size = new Size(67, 23);
            textBoxIDKupca.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(140, 360);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 21;
            label8.Text = "ID Kupca:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBoxAdresa;
        private TextBox textBoxGrad;
        private TextBox textBoxPrezime;
        private TextBox textBoxIme;
        private TextBox textBoxPrezimeTraži;
        private TextBox textBoxImeTraži;
        private Button buttonTraži;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxŠifra;
        private TextBox textBoxKorisničkoIme;
        private TextBox textBoxTelefon;
        private Label label8;
        private TextBox textBoxIDKupca;
        private Button buttonAžuriranjeKupca;
        private Button buttonKreiranjeKupca;
    }
}
