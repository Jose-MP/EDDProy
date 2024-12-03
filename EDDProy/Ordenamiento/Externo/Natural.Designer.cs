namespace EDDemo.Ordenamiento.Externo
{
    partial class Natural
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
            this.txtOrdenados = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOrdenados
            // 
            this.txtOrdenados.Enabled = false;
            this.txtOrdenados.Location = new System.Drawing.Point(29, 148);
            this.txtOrdenados.Multiline = true;
            this.txtOrdenados.Name = "txtOrdenados";
            this.txtOrdenados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrdenados.Size = new System.Drawing.Size(545, 233);
            this.txtOrdenados.TabIndex = 11;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(351, 85);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(90, 27);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese los datos (separados por comas):";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(232, 59);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(332, 20);
            this.txtDatos.TabIndex = 8;
            // 
            // Natural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.txtOrdenados);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatos);
            this.Name = "Natural";
            this.Text = "Natural";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrdenados;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
    }
}