namespace ExamenUnidad2
{
    partial class ListasMenu
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnSimples = new System.Windows.Forms.Button();
            this.BtnDobles = new System.Windows.Forms.Button();
            this.BtnCircu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(12, 410);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(88, 28);
            this.BtnRegresar.TabIndex = 2;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnSimples
            // 
            this.BtnSimples.Location = new System.Drawing.Point(110, 178);
            this.BtnSimples.Name = "BtnSimples";
            this.BtnSimples.Size = new System.Drawing.Size(146, 43);
            this.BtnSimples.TabIndex = 3;
            this.BtnSimples.Text = "Simples";
            this.BtnSimples.UseVisualStyleBackColor = true;
            this.BtnSimples.Click += new System.EventHandler(this.BtnSimples_Click);
            // 
            // BtnDobles
            // 
            this.BtnDobles.Location = new System.Drawing.Point(499, 178);
            this.BtnDobles.Name = "BtnDobles";
            this.BtnDobles.Size = new System.Drawing.Size(146, 43);
            this.BtnDobles.TabIndex = 4;
            this.BtnDobles.Text = "Dobles";
            this.BtnDobles.UseVisualStyleBackColor = true;
            this.BtnDobles.Click += new System.EventHandler(this.BtnDobles_Click);
            // 
            // BtnCircu
            // 
            this.BtnCircu.Location = new System.Drawing.Point(306, 302);
            this.BtnCircu.Name = "BtnCircu";
            this.BtnCircu.Size = new System.Drawing.Size(146, 43);
            this.BtnCircu.TabIndex = 5;
            this.BtnCircu.Text = "Circulares";
            this.BtnCircu.UseVisualStyleBackColor = true;
            this.BtnCircu.Click += new System.EventHandler(this.BtnCircu_Click);
            // 
            // ListasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCircu);
            this.Controls.Add(this.BtnDobles);
            this.Controls.Add(this.BtnSimples);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "ListasMenu";
            this.Text = "ListasMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnSimples;
        private System.Windows.Forms.Button BtnDobles;
        private System.Windows.Forms.Button BtnCircu;
    }
}