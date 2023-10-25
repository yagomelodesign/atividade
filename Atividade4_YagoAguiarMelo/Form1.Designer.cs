namespace Atividade4_YagoAguiarMelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ValorPrincipal = new System.Windows.Forms.TextBox();
            this.txt_JurosAnual = new System.Windows.Forms.TextBox();
            this.txt_Parcelas = new System.Windows.Forms.TextBox();
            this.lbl_valorDaParcela = new System.Windows.Forms.Label();
            this.lbl_TotalJuros = new System.Windows.Forms.Label();
            this.lbl_TotalPago = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txt_ValorPrincipal
            // 
            this.txt_ValorPrincipal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_ValorPrincipal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_ValorPrincipal.Location = new System.Drawing.Point(436, 43);
            this.txt_ValorPrincipal.Name = "txt_ValorPrincipal";
            this.txt_ValorPrincipal.Size = new System.Drawing.Size(194, 22);
            this.txt_ValorPrincipal.TabIndex = 0;
            // 
            // txt_JurosAnual
            // 
            this.txt_JurosAnual.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_JurosAnual.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_JurosAnual.Location = new System.Drawing.Point(436, 96);
            this.txt_JurosAnual.Name = "txt_JurosAnual";
            this.txt_JurosAnual.Size = new System.Drawing.Size(194, 22);
            this.txt_JurosAnual.TabIndex = 1;
            // 
            // txt_Parcelas
            // 
            this.txt_Parcelas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Parcelas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Parcelas.Location = new System.Drawing.Point(436, 147);
            this.txt_Parcelas.Name = "txt_Parcelas";
            this.txt_Parcelas.Size = new System.Drawing.Size(194, 22);
            this.txt_Parcelas.TabIndex = 2;
            // 
            // lbl_valorDaParcela
            // 
            this.lbl_valorDaParcela.AutoSize = true;
            this.lbl_valorDaParcela.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valorDaParcela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_valorDaParcela.Location = new System.Drawing.Point(218, 326);
            this.lbl_valorDaParcela.Name = "lbl_valorDaParcela";
            this.lbl_valorDaParcela.Size = new System.Drawing.Size(0, 19);
            this.lbl_valorDaParcela.TabIndex = 3;
            this.lbl_valorDaParcela.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_TotalJuros
            // 
            this.lbl_TotalJuros.AutoSize = true;
            this.lbl_TotalJuros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalJuros.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalJuros.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalJuros.Location = new System.Drawing.Point(218, 273);
            this.lbl_TotalJuros.Name = "lbl_TotalJuros";
            this.lbl_TotalJuros.Size = new System.Drawing.Size(0, 19);
            this.lbl_TotalJuros.TabIndex = 4;
            this.lbl_TotalJuros.Click += new System.EventHandler(this.lbl_TotalJuros_Click);
            // 
            // lbl_TotalPago
            // 
            this.lbl_TotalPago.AutoSize = true;
            this.lbl_TotalPago.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TotalPago.Location = new System.Drawing.Point(218, 377);
            this.lbl_TotalPago.Name = "lbl_TotalPago";
            this.lbl_TotalPago.Size = new System.Drawing.Size(0, 19);
            this.lbl_TotalPago.TabIndex = 5;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcular.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calcular.Location = new System.Drawing.Point(218, 200);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(412, 38);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 430);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(218, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor Principal:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(218, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Juros Anual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(218, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Parcelas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_TotalPago);
            this.Controls.Add(this.lbl_TotalJuros);
            this.Controls.Add(this.lbl_valorDaParcela);
            this.Controls.Add(this.txt_Parcelas);
            this.Controls.Add(this.txt_JurosAnual);
            this.Controls.Add(this.txt_ValorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txt_ValorPrincipal;
        private TextBox txt_JurosAnual;
        private TextBox txt_Parcelas;
        private Label lbl_valorDaParcela;
        private Label lbl_TotalJuros;
        private Label lbl_TotalPago;
        private Button calcular;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}