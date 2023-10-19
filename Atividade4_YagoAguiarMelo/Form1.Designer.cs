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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ValorPrincipal = new System.Windows.Forms.TextBox();
            this.txt_JurosAnual = new System.Windows.Forms.TextBox();
            this.txt_Parcelas = new System.Windows.Forms.TextBox();
            this.lbl_valorDaParcela = new System.Windows.Forms.Label();
            this.lbl_TotalJuros = new System.Windows.Forms.Label();
            this.lbl_TotalPago = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.txt_ValorPrincipal.Location = new System.Drawing.Point(278, 85);
            this.txt_ValorPrincipal.Name = "txt_ValorPrincipal";
            this.txt_ValorPrincipal.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorPrincipal.TabIndex = 0;
            // 
            // txt_JurosAnual
            // 
            this.txt_JurosAnual.Location = new System.Drawing.Point(278, 141);
            this.txt_JurosAnual.Name = "txt_JurosAnual";
            this.txt_JurosAnual.Size = new System.Drawing.Size(100, 23);
            this.txt_JurosAnual.TabIndex = 1;
            // 
            // txt_Parcelas
            // 
            this.txt_Parcelas.Location = new System.Drawing.Point(278, 191);
            this.txt_Parcelas.Name = "txt_Parcelas";
            this.txt_Parcelas.Size = new System.Drawing.Size(100, 23);
            this.txt_Parcelas.TabIndex = 2;
            // 
            // lbl_valorDaParcela
            // 
            this.lbl_valorDaParcela.AutoSize = true;
            this.lbl_valorDaParcela.Location = new System.Drawing.Point(615, 74);
            this.lbl_valorDaParcela.Name = "lbl_valorDaParcela";
            this.lbl_valorDaParcela.Size = new System.Drawing.Size(0, 15);
            this.lbl_valorDaParcela.TabIndex = 3;
            this.lbl_valorDaParcela.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_TotalJuros
            // 
            this.lbl_TotalJuros.AutoSize = true;
            this.lbl_TotalJuros.Location = new System.Drawing.Point(615, 149);
            this.lbl_TotalJuros.Name = "lbl_TotalJuros";
            this.lbl_TotalJuros.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalJuros.TabIndex = 4;
            // 
            // lbl_TotalPago
            // 
            this.lbl_TotalPago.AutoSize = true;
            this.lbl_TotalPago.Location = new System.Drawing.Point(615, 220);
            this.lbl_TotalPago.Name = "lbl_TotalPago";
            this.lbl_TotalPago.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalPago.TabIndex = 5;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(250, 253);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(159, 38);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 529);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.lbl_TotalPago);
            this.Controls.Add(this.lbl_TotalJuros);
            this.Controls.Add(this.lbl_valorDaParcela);
            this.Controls.Add(this.txt_Parcelas);
            this.Controls.Add(this.txt_JurosAnual);
            this.Controls.Add(this.txt_ValorPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}