
namespace Aula05DS03._10
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.buttonMostrarB = new System.Windows.Forms.Button();
            this.listBoxValorB = new System.Windows.Forms.ListBox();
            this.labelValorB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.buttonMostrar2 = new System.Windows.Forms.Button();
            this.buttonMostrar1 = new System.Windows.Forms.Button();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.buttonMostrarA = new System.Windows.Forms.Button();
            this.listBoxValorA = new System.Windows.Forms.ListBox();
            this.labelValorA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.numericUpDownB);
            this.panel1.Controls.Add(this.buttonMostrarB);
            this.panel1.Controls.Add(this.listBoxValorB);
            this.panel1.Controls.Add(this.labelValorB);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(383, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 203);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(118, 16);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownB.TabIndex = 7;
            // 
            // buttonMostrarB
            // 
            this.buttonMostrarB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMostrarB.Location = new System.Drawing.Point(286, 11);
            this.buttonMostrarB.Name = "buttonMostrarB";
            this.buttonMostrarB.Size = new System.Drawing.Size(91, 29);
            this.buttonMostrarB.TabIndex = 5;
            this.buttonMostrarB.Text = "Mostrar";
            this.buttonMostrarB.UseVisualStyleBackColor = true;
            this.buttonMostrarB.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxValorB
            // 
            this.listBoxValorB.FormattingEnabled = true;
            this.listBoxValorB.Location = new System.Drawing.Point(5, 52);
            this.listBoxValorB.Name = "listBoxValorB";
            this.listBoxValorB.Size = new System.Drawing.Size(400, 134);
            this.listBoxValorB.TabIndex = 3;
            // 
            // labelValorB
            // 
            this.labelValorB.AutoSize = true;
            this.labelValorB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelValorB.Location = new System.Drawing.Point(3, 18);
            this.labelValorB.Name = "labelValorB";
            this.labelValorB.Size = new System.Drawing.Size(113, 15);
            this.labelValorB.TabIndex = 1;
            this.labelValorB.Text = "Escolha um Valor:";
            this.labelValorB.Click += new System.EventHandler(this.labelValorB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.numericUpDownValor);
            this.panel2.Controls.Add(this.buttonMostrar2);
            this.panel2.Controls.Add(this.buttonMostrar1);
            this.panel2.Controls.Add(this.listBoxNumeros);
            this.panel2.Controls.Add(this.labelValor);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 426);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDownValor
            // 
            this.numericUpDownValor.Location = new System.Drawing.Point(175, 16);
            this.numericUpDownValor.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownValor.Name = "numericUpDownValor";
            this.numericUpDownValor.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownValor.TabIndex = 4;
            this.numericUpDownValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonMostrar2
            // 
            this.buttonMostrar2.Location = new System.Drawing.Point(189, 54);
            this.buttonMostrar2.Name = "buttonMostrar2";
            this.buttonMostrar2.Size = new System.Drawing.Size(75, 41);
            this.buttonMostrar2.TabIndex = 3;
            this.buttonMostrar2.Text = "Mostrar 2";
            this.buttonMostrar2.UseVisualStyleBackColor = true;
            this.buttonMostrar2.Click += new System.EventHandler(this.buttonMostrar2_Click);
            // 
            // buttonMostrar1
            // 
            this.buttonMostrar1.Location = new System.Drawing.Point(43, 54);
            this.buttonMostrar1.Name = "buttonMostrar1";
            this.buttonMostrar1.Size = new System.Drawing.Size(73, 41);
            this.buttonMostrar1.TabIndex = 2;
            this.buttonMostrar1.Text = "Mostrar 1";
            this.buttonMostrar1.UseVisualStyleBackColor = true;
            this.buttonMostrar1.Click += new System.EventHandler(this.buttonMostrar1_Click);
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(43, 118);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(144, 290);
            this.listBoxNumeros.TabIndex = 1;
            this.listBoxNumeros.SelectedIndexChanged += new System.EventHandler(this.listBoxNumeros_SelectedIndexChanged);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(53, 16);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(110, 15);
            this.labelValor.TabIndex = 0;
            this.labelValor.Text = "Escolha um valor:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.numericUpDownA);
            this.panel3.Controls.Add(this.buttonMostrarA);
            this.panel3.Controls.Add(this.listBoxValorA);
            this.panel3.Controls.Add(this.labelValorA);
            this.panel3.Location = new System.Drawing.Point(382, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 216);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(118, 23);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownA.TabIndex = 6;
            // 
            // buttonMostrarA
            // 
            this.buttonMostrarA.Location = new System.Drawing.Point(280, 12);
            this.buttonMostrarA.Name = "buttonMostrarA";
            this.buttonMostrarA.Size = new System.Drawing.Size(98, 32);
            this.buttonMostrarA.TabIndex = 4;
            this.buttonMostrarA.Text = "Mostrar";
            this.buttonMostrarA.UseVisualStyleBackColor = true;
            this.buttonMostrarA.Click += new System.EventHandler(this.buttonMostrarA_Click);
            // 
            // listBoxValorA
            // 
            this.listBoxValorA.FormattingEnabled = true;
            this.listBoxValorA.Location = new System.Drawing.Point(5, 55);
            this.listBoxValorA.Name = "listBoxValorA";
            this.listBoxValorA.Size = new System.Drawing.Size(400, 147);
            this.listBoxValorA.TabIndex = 2;
            // 
            // labelValorA
            // 
            this.labelValorA.AutoSize = true;
            this.labelValorA.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorA.Location = new System.Drawing.Point(3, 24);
            this.labelValorA.Name = "labelValorA";
            this.labelValorA.Size = new System.Drawing.Size(113, 15);
            this.labelValorA.TabIndex = 0;
            this.labelValorA.Text = "Escolha um Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(281, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "André de Sousa Neves e Joyce Rufino Pereira";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Estrutura de Repetição";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownValor;
        private System.Windows.Forms.Button buttonMostrar2;
        private System.Windows.Forms.Button buttonMostrar1;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Button buttonMostrarB;
        private System.Windows.Forms.ListBox listBoxValorB;
        private System.Windows.Forms.Label labelValorB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Button buttonMostrarA;
        private System.Windows.Forms.ListBox listBoxValorA;
        private System.Windows.Forms.Label labelValorA;
    }
}

