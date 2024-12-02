namespace EDDemo
{
    partial class Hanoi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
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
            this.BtnCalc.Location = new System.Drawing.Point(238, 304);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(132, 27);
            this.BtnCalc.TabIndex = 28;
            this.BtnCalc.Text = "Empezar";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // comple
            // 
            this.comple.AutoSize = true;
            this.comple.Location = new System.Drawing.Point(460, 282);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(16, 13);
            this.comple.TabIndex = 26;
            this.comple.Text = "...";
            // 
            // tiempoej
            // 
            this.tiempoej.AutoSize = true;
            this.tiempoej.Location = new System.Drawing.Point(196, 282);
            this.tiempoej.Name = "tiempoej";
            this.tiempoej.Size = new System.Drawing.Size(16, 13);
            this.tiempoej.TabIndex = 25;
            this.tiempoej.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Complejidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tiempo de ejecucion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pasos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero de discos:";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(255, 46);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(39, 20);
            this.TxtNum.TabIndex = 20;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(12, 116);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.res.Size = new System.Drawing.Size(594, 128);
            this.res.TabIndex = 30;
            // 
            // Hanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.res);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.comple);
            this.Controls.Add(this.tiempoej);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum);
            this.Name = "Hanoi";
            this.Text = "Hanoi";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox res;
    }
}