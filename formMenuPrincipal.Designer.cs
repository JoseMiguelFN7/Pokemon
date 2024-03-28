namespace Pokemon
{
    partial class formMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuPrincipal));
            this.fondoprincipal = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.PictureBox();
            this.labelpartida = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Label();
            this.inferior = new System.Windows.Forms.Label();
            this.pokemon = new System.Windows.Forms.Label();
            this.unimar = new System.Windows.Forms.PictureBox();
            this.picpokemon = new System.Windows.Forms.PictureBox();
            this.labpartida = new System.Windows.Forms.Label();
            this.labeltorneo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fondoprincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unimar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // fondoprincipal
            // 
            this.fondoprincipal.Image = ((System.Drawing.Image)(resources.GetObject("fondoprincipal.Image")));
            this.fondoprincipal.Location = new System.Drawing.Point(-4, 0);
            this.fondoprincipal.Name = "fondoprincipal";
            this.fondoprincipal.Size = new System.Drawing.Size(816, 458);
            this.fondoprincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fondoprincipal.TabIndex = 0;
            this.fondoprincipal.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Image = ((System.Drawing.Image)(resources.GetObject("titulo.Image")));
            this.titulo.Location = new System.Drawing.Point(-2, 48);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(466, 170);
            this.titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titulo.TabIndex = 1;
            this.titulo.TabStop = false;
            // 
            // labelpartida
            // 
            this.labelpartida.AutoSize = true;
            this.labelpartida.BackColor = System.Drawing.Color.Gold;
            this.labelpartida.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpartida.ForeColor = System.Drawing.Color.Black;
            this.labelpartida.Location = new System.Drawing.Point(115, 271);
            this.labelpartida.Name = "labelpartida";
            this.labelpartida.Size = new System.Drawing.Size(0, 33);
            this.labelpartida.TabIndex = 2;
            this.labelpartida.MouseEnter += new System.EventHandler(this.labelpartida_MouseEnter);
            this.labelpartida.MouseLeave += new System.EventHandler(this.labelpartida_MouseLeave);
            // 
            // salir
            // 
            this.salir.AutoSize = true;
            this.salir.BackColor = System.Drawing.Color.Navy;
            this.salir.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.Gold;
            this.salir.Location = new System.Drawing.Point(120, 348);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(231, 33);
            this.salir.TabIndex = 5;
            this.salir.Text = "SALIR DEL JUEGO";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            this.salir.MouseEnter += new System.EventHandler(this.salir_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.salir_MouseLeave);
            // 
            // inferior
            // 
            this.inferior.AutoSize = true;
            this.inferior.BackColor = System.Drawing.Color.LightGray;
            this.inferior.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inferior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inferior.Location = new System.Drawing.Point(596, 409);
            this.inferior.Name = "inferior";
            this.inferior.Size = new System.Drawing.Size(175, 12);
            this.inferior.TabIndex = 6;
            this.inferior.Text = "2024 PRODUCTIONS inc.";
            // 
            // pokemon
            // 
            this.pokemon.AutoSize = true;
            this.pokemon.BackColor = System.Drawing.Color.LightGray;
            this.pokemon.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokemon.Location = new System.Drawing.Point(607, 429);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(153, 12);
            this.pokemon.TabIndex = 7;
            this.pokemon.Text = "POKEMON RELOADED";
            // 
            // unimar
            // 
            this.unimar.Image = ((System.Drawing.Image)(resources.GetObject("unimar.Image")));
            this.unimar.Location = new System.Drawing.Point(725, 12);
            this.unimar.Name = "unimar";
            this.unimar.Size = new System.Drawing.Size(73, 63);
            this.unimar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unimar.TabIndex = 8;
            this.unimar.TabStop = false;
            // 
            // picpokemon
            // 
            this.picpokemon.BackColor = System.Drawing.Color.Transparent;
            this.picpokemon.Image = ((System.Drawing.Image)(resources.GetObject("picpokemon.Image")));
            this.picpokemon.Location = new System.Drawing.Point(437, 108);
            this.picpokemon.Name = "picpokemon";
            this.picpokemon.Size = new System.Drawing.Size(427, 285);
            this.picpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpokemon.TabIndex = 11;
            this.picpokemon.TabStop = false;
            // 
            // labpartida
            // 
            this.labpartida.AutoSize = true;
            this.labpartida.BackColor = System.Drawing.Color.Navy;
            this.labpartida.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpartida.ForeColor = System.Drawing.Color.Gold;
            this.labpartida.Location = new System.Drawing.Point(121, 271);
            this.labpartida.Name = "labpartida";
            this.labpartida.Size = new System.Drawing.Size(224, 33);
            this.labpartida.TabIndex = 12;
            this.labpartida.Text = "NUEVA PARTIDA";
            this.labpartida.Click += new System.EventHandler(this.labpartida_Click);
            this.labpartida.MouseEnter += new System.EventHandler(this.labpartida_MouseEnter);
            this.labpartida.MouseLeave += new System.EventHandler(this.labpartida_MouseLeave);
            // 
            // labeltorneo
            // 
            this.labeltorneo.AutoSize = true;
            this.labeltorneo.BackColor = System.Drawing.Color.Navy;
            this.labeltorneo.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltorneo.ForeColor = System.Drawing.Color.Gold;
            this.labeltorneo.Location = new System.Drawing.Point(166, 309);
            this.labeltorneo.Name = "labeltorneo";
            this.labeltorneo.Size = new System.Drawing.Size(120, 33);
            this.labeltorneo.TabIndex = 13;
            this.labeltorneo.Text = "TORNEO";
            this.labeltorneo.Click += new System.EventHandler(this.labeltorneo_Click);
            this.labeltorneo.MouseEnter += new System.EventHandler(this.labeltorneo_MouseEnter);
            this.labeltorneo.MouseLeave += new System.EventHandler(this.labeltorneo_MouseLeave);
            // 
            // formMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.labeltorneo);
            this.Controls.Add(this.labpartida);
            this.Controls.Add(this.picpokemon);
            this.Controls.Add(this.unimar);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.inferior);
            this.Controls.Add(this.labelpartida);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.fondoprincipal);
            this.Name = "formMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fondoprincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unimar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fondoprincipal;
        private System.Windows.Forms.PictureBox titulo;
        private System.Windows.Forms.Label labelpartida;
        private System.Windows.Forms.Label salir;
        private System.Windows.Forms.Label inferior;
        private System.Windows.Forms.Label pokemon;
        private System.Windows.Forms.PictureBox unimar;
        private System.Windows.Forms.PictureBox picpokemon;
        private System.Windows.Forms.Label labpartida;
        private System.Windows.Forms.Label labeltorneo;
    }
}