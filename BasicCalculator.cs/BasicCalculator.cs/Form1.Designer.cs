namespace BasicCalculator.cs
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
            this.Numero1Label = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2Label = new System.Windows.Forms.Label();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SubtrairButton = new System.Windows.Forms.Button();
            this.SomarButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.DividirButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.RespostaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero1Label
            // 
            this.Numero1Label.AutoSize = true;
            this.Numero1Label.Location = new System.Drawing.Point(53, 51);
            this.Numero1Label.Name = "Numero1Label";
            this.Numero1Label.Size = new System.Drawing.Size(78, 20);
            this.Numero1Label.TabIndex = 0;
            this.Numero1Label.Text = "Número 1";
            this.Numero1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(164, 51);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(121, 26);
            this.Numero1TextBox.TabIndex = 1;
            this.Numero1TextBox.TextChanged += new System.EventHandler(this.Numero1TextBox_TextChanged);
            // 
            // Numero2Label
            // 
            this.Numero2Label.AutoSize = true;
            this.Numero2Label.Location = new System.Drawing.Point(53, 101);
            this.Numero2Label.Name = "Numero2Label";
            this.Numero2Label.Size = new System.Drawing.Size(78, 20);
            this.Numero2Label.TabIndex = 2;
            this.Numero2Label.Text = "Numero 2";
            this.Numero2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(164, 101);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(121, 26);
            this.Numero2TextBox.TabIndex = 3;
            // 
            // SubtrairButton
            // 
            this.SubtrairButton.Location = new System.Drawing.Point(181, 244);
            this.SubtrairButton.Name = "SubtrairButton";
            this.SubtrairButton.Size = new System.Drawing.Size(121, 54);
            this.SubtrairButton.TabIndex = 4;
            this.SubtrairButton.Text = "Subtrair";
            this.SubtrairButton.UseVisualStyleBackColor = true;
            this.SubtrairButton.Click += new System.EventHandler(this.SubtrairButton_Click);
            // 
            // SomarButton
            // 
            this.SomarButton.Location = new System.Drawing.Point(36, 244);
            this.SomarButton.Name = "SomarButton";
            this.SomarButton.Size = new System.Drawing.Size(110, 54);
            this.SomarButton.TabIndex = 5;
            this.SomarButton.Text = "Somar";
            this.SomarButton.UseVisualStyleBackColor = true;
            this.SomarButton.Click += new System.EventHandler(this.SomarButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Location = new System.Drawing.Point(351, 244);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(108, 54);
            this.MultiplicarButton.TabIndex = 6;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // DividirButton
            // 
            this.DividirButton.Location = new System.Drawing.Point(513, 244);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(103, 54);
            this.DividirButton.TabIndex = 7;
            this.DividirButton.Text = "Dividir";
            this.DividirButton.UseVisualStyleBackColor = true;
            this.DividirButton.Click += new System.EventHandler(this.DividirButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(66, 390);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total";
            // 
            // RespostaLabel
            // 
            this.RespostaLabel.AutoSize = true;
            this.RespostaLabel.Location = new System.Drawing.Point(160, 390);
            this.RespostaLabel.Name = "RespostaLabel";
            this.RespostaLabel.Size = new System.Drawing.Size(18, 20);
            this.RespostaLabel.TabIndex = 9;
            this.RespostaLabel.Text = "0";
            this.RespostaLabel.Click += new System.EventHandler(this.RespostaLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RespostaLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DividirButton);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.SomarButton);
            this.Controls.Add(this.SubtrairButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero2Label);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.Numero1Label);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1Label;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label Numero2Label;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button SubtrairButton;
        private System.Windows.Forms.Button SomarButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button DividirButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label RespostaLabel;
    }
}

