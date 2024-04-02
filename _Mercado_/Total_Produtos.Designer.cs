namespace _Mercado_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNovaVenda = new System.Windows.Forms.Label();
            this.dataGridViewPRODUTOS = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxUNIDADE = new System.Windows.Forms.TextBox();
            this.labelUNIDADE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTOTAL = new System.Windows.Forms.TextBox();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNovaVenda
            // 
            this.labelNovaVenda.AutoSize = true;
            this.labelNovaVenda.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaVenda.ForeColor = System.Drawing.Color.Black;
            this.labelNovaVenda.Location = new System.Drawing.Point(569, 9);
            this.labelNovaVenda.Name = "labelNovaVenda";
            this.labelNovaVenda.Size = new System.Drawing.Size(165, 35);
            this.labelNovaVenda.TabIndex = 1;
            this.labelNovaVenda.Text = "Nova Venda";
            // 
            // dataGridViewPRODUTOS
            // 
            this.dataGridViewPRODUTOS.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUTOS.Location = new System.Drawing.Point(49, 109);
            this.dataGridViewPRODUTOS.Name = "dataGridViewPRODUTOS";
            this.dataGridViewPRODUTOS.Size = new System.Drawing.Size(350, 271);
            this.dataGridViewPRODUTOS.TabIndex = 11;
            this.dataGridViewPRODUTOS.DoubleClick += new System.EventHandler(this.dataGridViewPRODUTOS_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(571, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(671, 109);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBoxUNIDADE
            // 
            this.textBoxUNIDADE.Location = new System.Drawing.Point(671, 156);
            this.textBoxUNIDADE.Name = "textBoxUNIDADE";
            this.textBoxUNIDADE.Size = new System.Drawing.Size(120, 20);
            this.textBoxUNIDADE.TabIndex = 23;
            // 
            // labelUNIDADE
            // 
            this.labelUNIDADE.AutoSize = true;
            this.labelUNIDADE.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUNIDADE.Location = new System.Drawing.Point(546, 156);
            this.labelUNIDADE.Name = "labelUNIDADE";
            this.labelUNIDADE.Size = new System.Drawing.Size(121, 21);
            this.labelUNIDADE.TabIndex = 22;
            this.labelUNIDADE.Text = "Valor_Unidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(122, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "Lista Produtos";
            // 
            // textBoxTOTAL
            // 
            this.textBoxTOTAL.Location = new System.Drawing.Point(277, 418);
            this.textBoxTOTAL.Name = "textBoxTOTAL";
            this.textBoxTOTAL.Size = new System.Drawing.Size(122, 20);
            this.textBoxTOTAL.TabIndex = 26;
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOTAL.Location = new System.Drawing.Point(215, 414);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(56, 25);
            this.labelTOTAL.TabIndex = 25;
            this.labelTOTAL.Text = "Total:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(405, 109);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(95, 23);
            this.buttonAdicionar.TabIndex = 27;
            this.buttonAdicionar.Text = "Add :)";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Finalizar-se :)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancelar :(";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxTOTAL);
            this.Controls.Add(this.labelTOTAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUNIDADE);
            this.Controls.Add(this.labelUNIDADE);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewPRODUTOS);
            this.Controls.Add(this.labelNovaVenda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovaVenda;
        private System.Windows.Forms.DataGridView dataGridViewPRODUTOS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxUNIDADE;
        private System.Windows.Forms.Label labelUNIDADE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTOTAL;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

