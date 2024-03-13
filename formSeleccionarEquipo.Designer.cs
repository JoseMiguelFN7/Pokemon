namespace Pokemon
{
    partial class formSeleccionarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSeleccionarEquipo));
            this.listBoxPokemonDisponibles = new System.Windows.Forms.ListBox();
            this.listBoxEquipoPokemon = new System.Windows.Forms.ListBox();
            this.buttonAgregarPokemon = new System.Windows.Forms.Button();
            this.buttonEliminarPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPokemonDisponibles
            // 
            this.listBoxPokemonDisponibles.FormattingEnabled = true;
            this.listBoxPokemonDisponibles.Location = new System.Drawing.Point(12, 12);
            this.listBoxPokemonDisponibles.Name = "listBoxPokemonDisponibles";
            this.listBoxPokemonDisponibles.Size = new System.Drawing.Size(120, 238);
            this.listBoxPokemonDisponibles.TabIndex = 0;
            // 
            // listBoxEquipoPokemon
            // 
            this.listBoxEquipoPokemon.FormattingEnabled = true;
            this.listBoxEquipoPokemon.Location = new System.Drawing.Point(274, 12);
            this.listBoxEquipoPokemon.Name = "listBoxEquipoPokemon";
            this.listBoxEquipoPokemon.Size = new System.Drawing.Size(120, 238);
            this.listBoxEquipoPokemon.TabIndex = 1;
            // 
            // buttonAgregarPokemon
            // 
            this.buttonAgregarPokemon.Location = new System.Drawing.Point(148, 94);
            this.buttonAgregarPokemon.Name = "buttonAgregarPokemon";
            this.buttonAgregarPokemon.Size = new System.Drawing.Size(120, 23);
            this.buttonAgregarPokemon.TabIndex = 2;
            this.buttonAgregarPokemon.Text = "Agregar Pokémon";
            this.buttonAgregarPokemon.UseVisualStyleBackColor = true;
            this.buttonAgregarPokemon.Click += new System.EventHandler(this.buttonAgregarPokemon_Click);
            // 
            // buttonEliminarPokemon
            // 
            this.buttonEliminarPokemon.Location = new System.Drawing.Point(148, 150);
            this.buttonEliminarPokemon.Name = "buttonEliminarPokemon";
            this.buttonEliminarPokemon.Size = new System.Drawing.Size(120, 23);
            this.buttonEliminarPokemon.TabIndex = 3;
            this.buttonEliminarPokemon.Text = "Eliminar Pokémon";
            this.buttonEliminarPokemon.UseVisualStyleBackColor = true;
            this.buttonEliminarPokemon.Click += new System.EventHandler(this.buttonEliminarPokemon_Click);
            // 
            // formSeleccionarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 262);
            this.Controls.Add(this.buttonEliminarPokemon);
            this.Controls.Add(this.buttonAgregarPokemon);
            this.Controls.Add(this.listBoxEquipoPokemon);
            this.Controls.Add(this.listBoxPokemonDisponibles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSeleccionarEquipo";
            this.Text = "Seleccionar Equipo Pokémon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPokemonDisponibles;
        private System.Windows.Forms.ListBox listBoxEquipoPokemon;
        private System.Windows.Forms.Button buttonAgregarPokemon;
        private System.Windows.Forms.Button buttonEliminarPokemon;
    }
}
