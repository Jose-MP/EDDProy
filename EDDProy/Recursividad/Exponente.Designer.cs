namespace EDDemo
{
    partial class Exponente
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
            this.res = new System.Windows.Forms.Label();
            this.comple = new System.Windows.Forms.Label();
            this.tiempoej = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExpo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(31, 310);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(88, 29);
            this.BtnReg.TabIndex = 19;
            this.BtnReg.Text = "Regresar";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(212, 275);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(132, 27);
            this.BtnCalc.TabIndex = 18;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(169, 101);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(16, 13);
            this.res.TabIndex = 17;
            this.res.Text = "...";
            // 
            // comple
            // 
            this.comple.AutoSize = true;
            this.comple.Location = new System.Drawing.Point(449, 197);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(16, 13);
            this.comple.TabIndex = 16;
            this.comple.Text = "...";
            // 
            // tiempoej
            // 
            this.tiempoej.AutoSize = true;
            this.tiempoej.Location = new System.Drawing.Point(209, 199);
            this.tiempoej.Name = "tiempoej";
            this.tiempoej.Size = new System.Drawing.Size(16, 13);
            this.tiempoej.TabIndex = 15;
            this.tiempoej.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Complejidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tiempo de ejecucion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resultado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero:";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(172, 38);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(116, 20);
            this.TxtNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Exponente:";
            // 
            // TxtExpo
            // 
            this.TxtExpo.Location = new System.Drawing.Point(172, 64);
            this.TxtExpo.Name = "TxtExpo";
            this.TxtExpo.Size = new System.Drawing.Size(116, 20);
            this.TxtExpo.TabIndex = 20;
            // 
            // Exponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtExpo);
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
            this.Name = "Exponente";
            this.Text = "Exponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label comple;
        private System.Windows.Forms.Label tiempoej;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExpo;
    }
}