namespace EDDemo
{
    partial class Busqueda
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
            this.comple = new System.Windows.Forms.Label();
            this.tiempoej = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.res = new System.Windows.Forms.Label();
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
            // comple
            // 
            this.comple.AutoSize = true;
            this.comple.Location = new System.Drawing.Point(381, 274);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(16, 13);
            this.comple.TabIndex = 26;
            this.comple.Text = "...";
            // 
            // tiempoej
            // 
            this.tiempoej.AutoSize = true;
            this.tiempoej.Location = new System.Drawing.Point(143, 274);
            this.tiempoej.Name = "tiempoej";
            this.tiempoej.Size = new System.Drawing.Size(16, 13);
            this.tiempoej.TabIndex = 25;
            this.tiempoej.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Complejidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tiempo de ejecucion: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero a buscar (0-100):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(166, 39);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(41, 20);
            this.TxtNum.TabIndex = 20;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(193, 304);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 30;
            this.BtnAgregar.Text = "Buscar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "0.- 0",
            "1.- 2",
            "2.- 4",
            "3.- 6",
            "4.- 8",
            "5.- 10",
            "6.- 12",
            "7.- 14",
            "8.- 16",
            "9.- 18",
            "10.- 20",
            "11.- 22",
            "12.- 24",
            "13.- 26",
            "14.- 28",
            "15.- 30",
            "16.- 32",
            "17.- 34",
            "18.- 36",
            "19.- 38",
            "20.- 40 ",
            "21.- 42",
            "22.- 44",
            "23.- 46",
            "24.- 48",
            "25.- 50",
            "26.- 52",
            "27.- 54",
            "28.- 56",
            "29.- 58",
            "30.- 60",
            "31.- 62",
            "32.- 64",
            "33.- 66",
            "34.- 68",
            "35.- 70",
            "36.- 72",
            "37.- 74",
            "38.- 76",
            "39.- 78",
            "40.- 80",
            "41.- 82",
            "42.- 84",
            "43.- 86",
            "44.- 88",
            "45.- 90",
            "46.- 92",
            "47.- 94",
            "48.- 96",
            "49.- 98",
            "50.- 100"});
            this.listBox1.Location = new System.Drawing.Point(42, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 147);
            this.listBox1.TabIndex = 31;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(39, 219);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(160, 13);
            this.res.TabIndex = 32;
            this.res.Text = "El numero esta en la posicion: ...";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.res);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.comple);
            this.Controls.Add(this.tiempoej);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Label comple;
        private System.Windows.Forms.Label tiempoej;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label res;
    }
}