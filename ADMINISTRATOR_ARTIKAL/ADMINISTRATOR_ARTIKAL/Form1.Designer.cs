namespace ADMINISTRATOR_ARTIKAL
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
            groupBox1 = new GroupBox();
            domainUpDownKoličinaArtikla = new DomainUpDown();
            label6 = new Label();
            label5 = new Label();
            textBoxIDArtikla = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxKoličina = new TextBox();
            textBoxCijena = new TextBox();
            textBoxVrstaArtikla = new TextBox();
            textBoxNazivArtikla = new TextBox();
            label1 = new Label();
            buttonAžuriranjeArtikla = new Button();
            buttonDodavanjeArtikla = new Button();
            buttonTraži = new Button();
            textBoxImeArtikla = new TextBox();
            textBoxŠifraArtikla = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(domainUpDownKoličinaArtikla);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxIDArtikla);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxKoličina);
            groupBox1.Controls.Add(textBoxCijena);
            groupBox1.Controls.Add(textBoxVrstaArtikla);
            groupBox1.Controls.Add(textBoxNazivArtikla);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAžuriranjeArtikla);
            groupBox1.Controls.Add(buttonDodavanjeArtikla);
            groupBox1.Controls.Add(buttonTraži);
            groupBox1.Controls.Add(textBoxImeArtikla);
            groupBox1.Controls.Add(textBoxŠifraArtikla);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje / Ažuriranje artikla";
            // 
            // domainUpDownKoličinaArtikla
            // 
            domainUpDownKoličinaArtikla.Location = new Point(379, 336);
            domainUpDownKoličinaArtikla.Name = "domainUpDownKoličinaArtikla";
            domainUpDownKoličinaArtikla.Size = new Size(54, 23);
            domainUpDownKoličinaArtikla.TabIndex = 18;
            domainUpDownKoličinaArtikla.Wrap = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 338);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 17;
            label6.Text = "Dodaj količinu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 308);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 16;
            label5.Text = "ID Artikla:";
            // 
            // textBoxIDArtikla
            // 
            textBoxIDArtikla.Location = new Point(379, 305);
            textBoxIDArtikla.Name = "textBoxIDArtikla";
            textBoxIDArtikla.Size = new Size(54, 23);
            textBoxIDArtikla.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 324);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 13;
            label4.Text = "Količina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 295);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "Cijena:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 266);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 11;
            label2.Text = "Vrsta artikla:";
            // 
            // textBoxKoličina
            // 
            textBoxKoličina.Location = new Point(98, 321);
            textBoxKoličina.Name = "textBoxKoličina";
            textBoxKoličina.Size = new Size(100, 23);
            textBoxKoličina.TabIndex = 10;
            // 
            // textBoxCijena
            // 
            textBoxCijena.Location = new Point(98, 292);
            textBoxCijena.Name = "textBoxCijena";
            textBoxCijena.Size = new Size(100, 23);
            textBoxCijena.TabIndex = 9;
            // 
            // textBoxVrstaArtikla
            // 
            textBoxVrstaArtikla.Location = new Point(98, 263);
            textBoxVrstaArtikla.Name = "textBoxVrstaArtikla";
            textBoxVrstaArtikla.Size = new Size(100, 23);
            textBoxVrstaArtikla.TabIndex = 8;
            // 
            // textBoxNazivArtikla
            // 
            textBoxNazivArtikla.Location = new Point(98, 234);
            textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            textBoxNazivArtikla.Size = new Size(100, 23);
            textBoxNazivArtikla.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 237);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "Naziv artikla:";
            label1.Click += label1_Click;
            // 
            // buttonAžuriranjeArtikla
            // 
            buttonAžuriranjeArtikla.Location = new Point(325, 363);
            buttonAžuriranjeArtikla.Name = "buttonAžuriranjeArtikla";
            buttonAžuriranjeArtikla.Size = new Size(108, 23);
            buttonAžuriranjeArtikla.TabIndex = 5;
            buttonAžuriranjeArtikla.Text = "Ažuriranje artikla";
            buttonAžuriranjeArtikla.UseVisualStyleBackColor = true;
            // 
            // buttonDodavanjeArtikla
            // 
            buttonDodavanjeArtikla.Location = new Point(85, 363);
            buttonDodavanjeArtikla.Name = "buttonDodavanjeArtikla";
            buttonDodavanjeArtikla.Size = new Size(113, 23);
            buttonDodavanjeArtikla.TabIndex = 4;
            buttonDodavanjeArtikla.Text = "Dodavanje artikla";
            buttonDodavanjeArtikla.UseVisualStyleBackColor = true;
            // 
            // buttonTraži
            // 
            buttonTraži.Location = new Point(172, 22);
            buttonTraži.Name = "buttonTraži";
            buttonTraži.Size = new Size(75, 23);
            buttonTraži.TabIndex = 3;
            buttonTraži.Text = "Traži";
            buttonTraži.UseVisualStyleBackColor = true;
            // 
            // textBoxImeArtikla
            // 
            textBoxImeArtikla.Location = new Point(66, 22);
            textBoxImeArtikla.Name = "textBoxImeArtikla";
            textBoxImeArtikla.Size = new Size(100, 23);
            textBoxImeArtikla.TabIndex = 2;
            // 
            // textBoxŠifraArtikla
            // 
            textBoxŠifraArtikla.Location = new Point(6, 22);
            textBoxŠifraArtikla.Name = "textBoxŠifraArtikla";
            textBoxŠifraArtikla.Size = new Size(54, 23);
            textBoxŠifraArtikla.TabIndex = 1;
            textBoxŠifraArtikla.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(438, 173);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxŠifraArtikla;
        private DataGridView dataGridView1;
        private TextBox textBoxImeArtikla;
        private Button buttonTraži;
        private Label label1;
        private Button buttonAžuriranjeArtikla;
        private Button buttonDodavanjeArtikla;
        private TextBox textBoxNazivArtikla;
        private TextBox textBoxKoličina;
        private TextBox textBoxCijena;
        private TextBox textBoxVrstaArtikla;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxIDArtikla;
        private DomainUpDown domainUpDownKoličinaArtikla;
        private Label label6;
        private Label label5;
    }
}
