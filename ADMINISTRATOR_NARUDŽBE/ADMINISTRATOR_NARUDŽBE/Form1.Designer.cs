namespace ADMINISTRATOR_NARUDŽBE
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
            textBoxIDNarudžbe = new TextBox();
            label1 = new Label();
            buttonBrisanjeNarudžbe = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 207);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBrisanjeNarudžbe);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIDNarudžbe);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 290);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz / Brisanje narudžbe";
            // 
            // textBoxIDNarudžbe
            // 
            textBoxIDNarudžbe.Location = new Point(96, 248);
            textBoxIDNarudžbe.Name = "textBoxIDNarudžbe";
            textBoxIDNarudžbe.Size = new Size(69, 23);
            textBoxIDNarudžbe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 251);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "ID narudžbe:";
            // 
            // buttonBrisanjeNarudžbe
            // 
            buttonBrisanjeNarudžbe.Location = new Point(171, 248);
            buttonBrisanjeNarudžbe.Name = "buttonBrisanjeNarudžbe";
            buttonBrisanjeNarudžbe.Size = new Size(127, 23);
            buttonBrisanjeNarudžbe.TabIndex = 3;
            buttonBrisanjeNarudžbe.Text = "Brisanje narudžbe";
            buttonBrisanjeNarudžbe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
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
        private Button buttonBrisanjeNarudžbe;
        private Label label1;
        private TextBox textBoxIDNarudžbe;
    }
}
