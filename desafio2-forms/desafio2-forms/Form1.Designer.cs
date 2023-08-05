namespace desafio2_forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLadoX = new System.Windows.Forms.TextBox();
            this.textBoxLadoY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLadoZ = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "lado x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "lado y";
            // 
            // textBoxLadoX
            // 
            this.textBoxLadoX.Location = new System.Drawing.Point(75, 45);
            this.textBoxLadoX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLadoX.Name = "textBoxLadoX";
            this.textBoxLadoX.Size = new System.Drawing.Size(68, 20);
            this.textBoxLadoX.TabIndex = 3;
            // 
            // textBoxLadoY
            // 
            this.textBoxLadoY.Location = new System.Drawing.Point(213, 47);
            this.textBoxLadoY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLadoY.Name = "textBoxLadoY";
            this.textBoxLadoY.Size = new System.Drawing.Size(68, 20);
            this.textBoxLadoY.TabIndex = 4;
            this.textBoxLadoY.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "lado z";
            // 
            // textBoxLadoZ
            // 
            this.textBoxLadoZ.Location = new System.Drawing.Point(352, 47);
            this.textBoxLadoZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLadoZ.Name = "textBoxLadoZ";
            this.textBoxLadoZ.Size = new System.Drawing.Size(68, 20);
            this.textBoxLadoZ.TabIndex = 6;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(195, 157);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(58, 13);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Resultado:";
            this.labelResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(198, 127);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(89, 21);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 202);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxLadoZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLadoY);
            this.Controls.Add(this.textBoxLadoX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLadoX;
        private System.Windows.Forms.TextBox textBoxLadoY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLadoZ;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

