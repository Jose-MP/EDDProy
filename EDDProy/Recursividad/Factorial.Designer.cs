namespace EDDemo
{
    partial class Factorial
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
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tiempoej = new System.Windows.Forms.Label();
            this.comple = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(136, 67);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(116, 20);
            this.TxtNum.TabIndex = 0;
            this.TxtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo de ejecucion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Complejidad:";
            // 
            // tiempoej
            // 
            this.tiempoej.AutoSize = true;
            this.tiempoej.Location = new System.Drawing.Point(190, 228);
            this.tiempoej.Name = "tiempoej";
            this.tiempoej.Size = new System.Drawing.Size(16, 13);
            this.tiempoej.TabIndex = 5;
            this.tiempoej.Text = "...";
            this.tiempoej.Click += new System.EventHandler(this.tiempoej_Click);
            // 
            // comple
            // 
            this.comple.AutoSize = true;
            this.comple.Location = new System.Drawing.Point(430, 226);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(16, 13);
            this.comple.TabIndex = 6;
            this.comple.Text = "...";
            this.comple.Click += new System.EventHandler(this.comple_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(150, 130);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(16, 13);
            this.res.TabIndex = 7;
            this.res.Text = "...";
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(240, 307);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(132, 27);
            this.BtnCalc.TabIndex = 8;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(12, 339);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(88, 29);
            this.BtnReg.TabIndex = 9;
            this.BtnReg.Text = "Regresar";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.res);
            this.Controls.Add(this.comple);
            this.Controls.Add(this.tiempoej);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tiempoej;
        private System.Windows.Forms.Label comple;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnReg;
    }
}