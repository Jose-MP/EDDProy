
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnSuc = new System.Windows.Forms.Button();
            this.btnRecorrerN = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.btnNodos = new System.Windows.Forms.Button();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblHojas = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBinario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(11, 444);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(716, 162);
            this.txtArbol.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(12, 113);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 30;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(214, 215);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(16, 13);
            this.lblRecorridoPreOrden.TabIndex = 29;
            this.lblRecorridoPreOrden.Text = "...";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(214, 241);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(16, 13);
            this.lblRecorridoInOrden.TabIndex = 28;
            this.lblRecorridoInOrden.Text = "...";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(154, 215);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 27;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(154, 241);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblInOrden.TabIndex = 26;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(214, 265);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(16, 13);
            this.lblRecorridoPostOrden.TabIndex = 25;
            this.lblRecorridoPostOrden.Text = "...";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(152, 265);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 24;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 69);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 23;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(11, 149);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(75, 23);
            this.btnCrearArbol.TabIndex = 22;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(20, 36);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 21;
            this.lblDatos.Text = "Dato :";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(11, 237);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(125, 23);
            this.btnRecorrer.TabIndex = 20;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(101, 149);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(75, 23);
            this.btnGrafica.TabIndex = 19;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(101, 113);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Podar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(133, 31);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(56, 31);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 16;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(192, 113);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(125, 23);
            this.btnPre.TabIndex = 31;
            this.btnPre.Text = "Eliminar Predecesor";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnSuc
            // 
            this.btnSuc.Location = new System.Drawing.Point(192, 149);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(125, 23);
            this.btnSuc.TabIndex = 32;
            this.btnSuc.Text = "Eliminar Sucesor";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.btnSuc_Click);
            // 
            // btnRecorrerN
            // 
            this.btnRecorrerN.Location = new System.Drawing.Point(11, 294);
            this.btnRecorrerN.Name = "btnRecorrerN";
            this.btnRecorrerN.Size = new System.Drawing.Size(125, 23);
            this.btnRecorrerN.TabIndex = 33;
            this.btnRecorrerN.Text = "Recorrer por niveles";
            this.btnRecorrerN.UseVisualStyleBackColor = true;
            this.btnRecorrerN.Click += new System.EventHandler(this.btnRecorrerN_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(11, 372);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(125, 23);
            this.btnAltura.TabIndex = 34;
            this.btnAltura.Text = "Obtener la altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.Location = new System.Drawing.Point(11, 407);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(125, 23);
            this.btnHojas.TabIndex = 35;
            this.btnHojas.Text = "Cantidad de hojas";
            this.btnHojas.UseVisualStyleBackColor = true;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // btnNodos
            // 
            this.btnNodos.Location = new System.Drawing.Point(11, 332);
            this.btnNodos.Name = "btnNodos";
            this.btnNodos.Size = new System.Drawing.Size(125, 23);
            this.btnNodos.TabIndex = 36;
            this.btnNodos.Text = "Cantidad de nodos";
            this.btnNodos.UseVisualStyleBackColor = true;
            this.btnNodos.Click += new System.EventHandler(this.btnNodos_Click);
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.Location = new System.Drawing.Point(214, 299);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(16, 13);
            this.lblNiveles.TabIndex = 37;
            this.lblNiveles.Text = "...";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(152, 372);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(16, 13);
            this.lblAltura.TabIndex = 38;
            this.lblAltura.Text = "...";
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Location = new System.Drawing.Point(152, 412);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(16, 13);
            this.lblHojas.TabIndex = 39;
            this.lblHojas.Text = "...";
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.Location = new System.Drawing.Point(152, 337);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(16, 13);
            this.lblNodos.TabIndex = 40;
            this.lblNodos.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Recorrido:";
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(351, 113);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(91, 23);
            this.btnBinario.TabIndex = 42;
            this.btnBinario.Text = "Tipo de arbol";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Binario:";
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(397, 154);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(16, 13);
            this.lblBinario.TabIndex = 44;
            this.lblBinario.Text = "...";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 617);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.btnNodos);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnRecorrerN);
            this.Controls.Add(this.btnSuc);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.txtArbol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnSuc;
        private System.Windows.Forms.Button btnRecorrerN;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Button btnNodos;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblHojas;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBinario;
    }
}