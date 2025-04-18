namespace KUPAC_PRIKAZ
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
            dataGridViewNarudžbe = new DataGridView();
            dataGridViewStavkeNarudžbi = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxIDNarudžbe = new TextBox();
            textBoxTotal = new TextBox();
            buttonPrikazStavki = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNarudžbe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavkeNarudžbi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonPrikazStavki);
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Controls.Add(textBoxIDNarudžbe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridViewStavkeNarudžbi);
            groupBox1.Controls.Add(dataGridViewNarudžbe);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz narudžbi i stavki";
            // 
            // dataGridViewNarudžbe
            // 
            dataGridViewNarudžbe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNarudžbe.Location = new Point(6, 44);
            dataGridViewNarudžbe.Name = "dataGridViewNarudžbe";
            dataGridViewNarudžbe.Size = new Size(240, 150);
            dataGridViewNarudžbe.TabIndex = 0;
            // 
            // dataGridViewStavkeNarudžbi
            // 
            dataGridViewStavkeNarudžbi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStavkeNarudžbi.Location = new Point(268, 44);
            dataGridViewStavkeNarudžbi.Name = "dataGridViewStavkeNarudžbi";
            dataGridViewStavkeNarudžbi.Size = new Size(240, 150);
            dataGridViewStavkeNarudžbi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Narudžbe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 26);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Stavke narudžbi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 210);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "ID narudžbe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 236);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 239);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 6;
            label5.Text = "KM";
            label5.Click += label5_Click;
            // 
            // textBoxIDNarudžbe
            // 
            textBoxIDNarudžbe.Location = new Point(347, 207);
            textBoxIDNarudžbe.Name = "textBoxIDNarudžbe";
            textBoxIDNarudžbe.Size = new Size(100, 23);
            textBoxIDNarudžbe.TabIndex = 7;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(347, 236);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(69, 23);
            textBoxTotal.TabIndex = 8;
            // 
            // buttonPrikazStavki
            // 
            buttonPrikazStavki.Location = new Point(453, 200);
            buttonPrikazStavki.Name = "buttonPrikazStavki";
            buttonPrikazStavki.Size = new Size(64, 51);
            buttonPrikazStavki.TabIndex = 9;
            buttonPrikazStavki.Text = "Prikaz stavki";
            buttonPrikazStavki.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNarudžbe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavkeNarudžbi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxTotal;
        private TextBox textBoxIDNarudžbe;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewStavkeNarudžbi;
        private DataGridView dataGridViewNarudžbe;
        private Button buttonPrikazStavki;
    }
}
