namespace EDDemo
{
    partial class Fibonacci
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
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.comple = new System.Windows.Forms.Label();
            this.tiempoej = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(12, 339);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(88, 29);
            this.BtnReg.TabIndex = 29;
            this.BtnReg.Text = "Regresar";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(218, 293);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(132, 27);
            this.BtnCalc.TabIndex = 28;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // comple
            // 
            this.comple.AutoSize = true;
            this.comple.Location = new System.Drawing.Point(433, 211);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(16, 13);
            this.comple.TabIndex = 26;
            this.comple.Text = "...";
            // 
            // tiempoej
            // 
            this.tiempoej.AutoSize = true;
            this.tiempoej.Location = new System.Drawing.Point(193, 213);
            this.tiempoej.Name = "tiempoej";
            this.tiempoej.Size = new System.Drawing.Size(16, 13);
            this.tiempoej.TabIndex = 25;
            this.tiempoej.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Complejidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tiempo de ejecucion: ";
            // 
            // rex
            // 
            this.rex.AutoSize = true;
            this.rex.Location = new System.Drawing.Point(12, 103);
            this.rex.Name = "rex";
            this.rex.Size = new System.Drawing.Size(61, 13);
            this.rex.TabIndex = 22;
            this.rex.Text = "Resultado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero:";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(65, 40);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(116, 20);
            this.TxtNum.TabIndex = 20;
            // 
            // rez
            // 
            this.rez.Enabled = false;
            this.rez.Location = new System.Drawing.Point(15, 119);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(561, 89);
            this.rez.TabIndex = 30;
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.comple);
            this.Controls.Add(this.tiempoej);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label comple;
        private System.Windows.Forms.Label tiempoej;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox rez;
    }
}