namespace ArmandoLeite.Desktop.UI
{
    partial class Menu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizar = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.CustomizableEdges = customizableEdges5;
            this.btnVisualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVisualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVisualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVisualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(336, 151);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.btnVisualizar.Size = new System.Drawing.Size(109, 48);
            this.btnVisualizar.TabIndex = 16;
            this.btnVisualizar.Text = "Visualizar Conteúdo";
            this.btnVisualizar.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.CustomizableEdges = customizableEdges7;
            this.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(336, 227);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.btnAdicionar.Size = new System.Drawing.Size(109, 48);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar Conteúdo";
            this.btnAdicionar.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btnVisualizar;
        private Guna.UI2.WinForms.Guna2TileButton btnAdicionar;
    }
}