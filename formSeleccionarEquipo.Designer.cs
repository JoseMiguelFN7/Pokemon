namespace Pokemon
{
    partial class FormSeleccionarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionarEquipo));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxGIF = new System.Windows.Forms.PictureBox();
            this.pictureBoxTipo1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTipo2 = new System.Windows.Forms.PictureBox();
            this.btnPaginaSiguiente = new System.Windows.Forms.Button();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipo2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(360, 182);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(672, 491);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(9, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxGIF
            // 
            this.pictureBoxGIF.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGIF.Location = new System.Drawing.Point(39, 78);
            this.pictureBoxGIF.Name = "pictureBoxGIF";
            this.pictureBoxGIF.Size = new System.Drawing.Size(267, 259);
            this.pictureBoxGIF.TabIndex = 2;
            this.pictureBoxGIF.TabStop = false;
            // 
            // pictureBoxTipo1
            // 
            this.pictureBoxTipo1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTipo1.Location = new System.Drawing.Point(5, 379);
            this.pictureBoxTipo1.Name = "pictureBoxTipo1";
            this.pictureBoxTipo1.Size = new System.Drawing.Size(320, 72);
            this.pictureBoxTipo1.TabIndex = 1;
            this.pictureBoxTipo1.TabStop = false;
            // 
            // pictureBoxTipo2
            // 
            this.pictureBoxTipo2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTipo2.Location = new System.Drawing.Point(5, 457);
            this.pictureBoxTipo2.Name = "pictureBoxTipo2";
            this.pictureBoxTipo2.Size = new System.Drawing.Size(320, 73);
            this.pictureBoxTipo2.TabIndex = 3;
            this.pictureBoxTipo2.TabStop = false;
            // 
            // btnPaginaSiguiente
            // 
            this.btnPaginaSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaginaSiguiente.Location = new System.Drawing.Point(951, 98);
            this.btnPaginaSiguiente.Name = "btnPaginaSiguiente";
            this.btnPaginaSiguiente.Size = new System.Drawing.Size(66, 50);
            this.btnPaginaSiguiente.TabIndex = 4;
            this.btnPaginaSiguiente.UseVisualStyleBackColor = false;
            this.btnPaginaSiguiente.Click += new System.EventHandler(this.btnPaginaSiguiente_Click);
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnPaginaAnterior.Location = new System.Drawing.Point(343, 98);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(66, 50);
            this.btnPaginaAnterior.TabIndex = 5;
            this.btnPaginaAnterior.UseVisualStyleBackColor = false;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // FormSeleccionarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon.Properties.Resources.Caja_1;
            this.ClientSize = new System.Drawing.Size(1017, 674);
            this.Controls.Add(this.btnPaginaAnterior);
            this.Controls.Add(this.btnPaginaSiguiente);
            this.Controls.Add(this.pictureBoxTipo2);
            this.Controls.Add(this.pictureBoxGIF);
            this.Controls.Add(this.pictureBoxTipo1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSeleccionarEquipo";
            this.Text = "Seleccionar Equipo";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxGIF;
        private System.Windows.Forms.PictureBox pictureBoxTipo1;
        private System.Windows.Forms.PictureBox pictureBoxTipo2;
        private System.Windows.Forms.Button btnPaginaSiguiente;
        private System.Windows.Forms.Button btnPaginaAnterior;
    }
}
