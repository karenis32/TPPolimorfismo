namespace TPPolimorfismo
{
    partial class TPPolimorfismo
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
            this.btn_impPropiedades = new System.Windows.Forms.Button();
            this.btn_alimentarLeon = new System.Windows.Forms.Button();
            this.btn_alimentarConejo = new System.Windows.Forms.Button();
            this.btn_alimentarLoro = new System.Windows.Forms.Button();
            this.btn_moverCaballo = new System.Windows.Forms.Button();
            this.btn_moverTorre = new System.Windows.Forms.Button();
            this.bnt_moverPeon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_impPropiedades
            // 
            this.btn_impPropiedades.Location = new System.Drawing.Point(109, 64);
            this.btn_impPropiedades.Name = "btn_impPropiedades";
            this.btn_impPropiedades.Size = new System.Drawing.Size(134, 51);
            this.btn_impPropiedades.TabIndex = 0;
            this.btn_impPropiedades.Text = "Imprimir Propiedades";
            this.btn_impPropiedades.UseVisualStyleBackColor = true;
            this.btn_impPropiedades.Click += new System.EventHandler(this.btn_impPropiedades_Click);
            // 
            // btn_alimentarLeon
            // 
            this.btn_alimentarLeon.Location = new System.Drawing.Point(109, 140);
            this.btn_alimentarLeon.Name = "btn_alimentarLeon";
            this.btn_alimentarLeon.Size = new System.Drawing.Size(134, 57);
            this.btn_alimentarLeon.TabIndex = 1;
            this.btn_alimentarLeon.Text = "Alimentar León";
            this.btn_alimentarLeon.UseVisualStyleBackColor = true;
            this.btn_alimentarLeon.Click += new System.EventHandler(this.btn_alimentarLeon_Click);
            // 
            // btn_alimentarConejo
            // 
            this.btn_alimentarConejo.Location = new System.Drawing.Point(109, 288);
            this.btn_alimentarConejo.Name = "btn_alimentarConejo";
            this.btn_alimentarConejo.Size = new System.Drawing.Size(134, 57);
            this.btn_alimentarConejo.TabIndex = 2;
            this.btn_alimentarConejo.Text = "Alimentar Conejo";
            this.btn_alimentarConejo.UseVisualStyleBackColor = true;
            this.btn_alimentarConejo.Click += new System.EventHandler(this.btn_alimentarConejo_Click);
            // 
            // btn_alimentarLoro
            // 
            this.btn_alimentarLoro.Location = new System.Drawing.Point(109, 213);
            this.btn_alimentarLoro.Name = "btn_alimentarLoro";
            this.btn_alimentarLoro.Size = new System.Drawing.Size(134, 57);
            this.btn_alimentarLoro.TabIndex = 3;
            this.btn_alimentarLoro.Text = "Alimentar Loro";
            this.btn_alimentarLoro.UseVisualStyleBackColor = true;
            this.btn_alimentarLoro.Click += new System.EventHandler(this.btn_alimentarLoro_Click);
            // 
            // btn_moverCaballo
            // 
            this.btn_moverCaballo.Location = new System.Drawing.Point(497, 64);
            this.btn_moverCaballo.Name = "btn_moverCaballo";
            this.btn_moverCaballo.Size = new System.Drawing.Size(134, 51);
            this.btn_moverCaballo.TabIndex = 4;
            this.btn_moverCaballo.Text = "Mover Caballo";
            this.btn_moverCaballo.UseVisualStyleBackColor = true;
            this.btn_moverCaballo.Click += new System.EventHandler(this.btn_moverCaballo_Click);
            // 
            // btn_moverTorre
            // 
            this.btn_moverTorre.Location = new System.Drawing.Point(497, 146);
            this.btn_moverTorre.Name = "btn_moverTorre";
            this.btn_moverTorre.Size = new System.Drawing.Size(134, 51);
            this.btn_moverTorre.TabIndex = 5;
            this.btn_moverTorre.Text = "Mover Torre";
            this.btn_moverTorre.UseVisualStyleBackColor = true;
            this.btn_moverTorre.Click += new System.EventHandler(this.btn_moverTorre_Click);
            // 
            // bnt_moverPeon
            // 
            this.bnt_moverPeon.Location = new System.Drawing.Point(497, 219);
            this.bnt_moverPeon.Name = "bnt_moverPeon";
            this.bnt_moverPeon.Size = new System.Drawing.Size(134, 51);
            this.bnt_moverPeon.TabIndex = 6;
            this.bnt_moverPeon.Text = "Mover Peón";
            this.bnt_moverPeon.UseVisualStyleBackColor = true;
            this.bnt_moverPeon.Click += new System.EventHandler(this.bnt_moverPeon_Click);
            // 
            // TPPolimorfismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_moverPeon);
            this.Controls.Add(this.btn_moverTorre);
            this.Controls.Add(this.btn_moverCaballo);
            this.Controls.Add(this.btn_alimentarLoro);
            this.Controls.Add(this.btn_alimentarConejo);
            this.Controls.Add(this.btn_alimentarLeon);
            this.Controls.Add(this.btn_impPropiedades);
            this.Name = "TPPolimorfismo";
            this.Text = "TPPolimorfismo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_impPropiedades;
        private System.Windows.Forms.Button btn_alimentarLeon;
        private System.Windows.Forms.Button btn_alimentarConejo;
        private System.Windows.Forms.Button btn_alimentarLoro;
        private System.Windows.Forms.Button btn_moverCaballo;
        private System.Windows.Forms.Button btn_moverTorre;
        private System.Windows.Forms.Button bnt_moverPeon;
    }
}