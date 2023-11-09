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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddConteudo = new Guna.UI2.WinForms.Guna2GradientButton();
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
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisualizar.BorderRadius = 20;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.btnVisualizar.CustomizableEdges = customizableEdges1;
            this.btnVisualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVisualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVisualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisualizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVisualizar.FillColor = System.Drawing.Color.Lime;
            this.btnVisualizar.FillColor2 = System.Drawing.Color.LimeGreen;
            this.btnVisualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizar.ForeColor = System.Drawing.Color.Black;
            this.btnVisualizar.Location = new System.Drawing.Point(336, 159);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnVisualizar.Size = new System.Drawing.Size(109, 48);
            this.btnVisualizar.TabIndex = 19;
            this.btnVisualizar.Text = "Visualizar Conteúdo";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnAddConteudo
            // 
            this.btnAddConteudo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddConteudo.BorderRadius = 20;
            this.btnAddConteudo.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.btnAddConteudo.CustomizableEdges = customizableEdges3;
            this.btnAddConteudo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddConteudo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddConteudo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddConteudo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddConteudo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddConteudo.FillColor = System.Drawing.Color.Lime;
            this.btnAddConteudo.FillColor2 = System.Drawing.Color.LimeGreen;
            this.btnAddConteudo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddConteudo.ForeColor = System.Drawing.Color.Black;
            this.btnAddConteudo.Location = new System.Drawing.Point(336, 232);
            this.btnAddConteudo.Name = "btnAddConteudo";
            this.btnAddConteudo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnAddConteudo.Size = new System.Drawing.Size(109, 48);
            this.btnAddConteudo.TabIndex = 20;
            this.btnAddConteudo.Text = "Adicionar Conteúdo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddConteudo);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnVisualizar;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddConteudo;
    }
}