namespace EDDemo
{
    partial class Pilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pilas));
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNodo = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ComboPosi = new System.Windows.Forms.ComboBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(12, 410);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(88, 28);
            this.BtnRegresar.TabIndex = 0;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar nodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posicion (opcional):";
            // 
            // TxtNodo
            // 
            this.TxtNodo.Location = new System.Drawing.Point(114, 41);
            this.TxtNodo.Name = "TxtNodo";
            this.TxtNodo.Size = new System.Drawing.Size(185, 20);
            this.TxtNodo.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(62, 349);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(124, 29);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Push";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(216, 349);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(124, 29);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Pop";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ComboPosi
            // 
            this.ComboPosi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPosi.FormattingEnabled = true;
            this.ComboPosi.Items.AddRange(new object[] {
            "Inicio",
            "Final"});
            this.ComboPosi.Location = new System.Drawing.Point(138, 77);
            this.ComboPosi.Name = "ComboPosi";
            this.ComboPosi.Size = new System.Drawing.Size(117, 21);
            this.ComboPosi.TabIndex = 8;
            this.ComboPosi.SelectedIndexChanged += new System.EventHandler(this.ComboPosi_SelectedIndexChanged);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(337, 41);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(293, 290);
            this.lstPila.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(51, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 168);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(363, 349);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(124, 29);
            this.BtnMostrar.TabIndex = 29;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(506, 350);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 28);
            this.BtnBuscar.TabIndex = 30;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Pilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.ComboPosi);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtNodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "Pilas";
            this.Text = "Pilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNodo;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ComboBox ComboPosi;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}