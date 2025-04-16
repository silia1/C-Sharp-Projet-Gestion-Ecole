namespace Gestion_Ecole
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            t_nom = new TextBox();
            t_prenom = new TextBox();
            t_ville = new TextBox();
            t_specialite = new TextBox();
            b_Ajouter = new Button();
            DataEleve = new DataGridView();
            b_Rechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)DataEleve).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(479, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 54);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(479, 131);
            label2.Name = "label2";
            label2.Size = new Size(171, 54);
            label2.TabIndex = 0;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(479, 207);
            label3.Name = "label3";
            label3.Size = new Size(105, 54);
            label3.TabIndex = 0;
            label3.Text = "Ville";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(479, 287);
            label4.Name = "label4";
            label4.Size = new Size(204, 54);
            label4.TabIndex = 0;
            label4.Text = "Spécialité";
            // 
            // t_nom
            // 
            t_nom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            t_nom.Location = new Point(728, 57);
            t_nom.Name = "t_nom";
            t_nom.Size = new Size(615, 61);
            t_nom.TabIndex = 1;
            // 
            // t_prenom
            // 
            t_prenom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            t_prenom.Location = new Point(728, 131);
            t_prenom.Name = "t_prenom";
            t_prenom.Size = new Size(615, 61);
            t_prenom.TabIndex = 2;
            // 
            // t_ville
            // 
            t_ville.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            t_ville.Location = new Point(728, 207);
            t_ville.Name = "t_ville";
            t_ville.Size = new Size(615, 61);
            t_ville.TabIndex = 3;
            // 
            // t_specialite
            // 
            t_specialite.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            t_specialite.Location = new Point(728, 287);
            t_specialite.Name = "t_specialite";
            t_specialite.Size = new Size(615, 61);
            t_specialite.TabIndex = 4;
            // 
            // b_Ajouter
            // 
            b_Ajouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Ajouter.Location = new Point(1529, 74);
            b_Ajouter.Name = "b_Ajouter";
            b_Ajouter.Size = new Size(188, 58);
            b_Ajouter.TabIndex = 5;
            b_Ajouter.Text = "Ajouter";
            b_Ajouter.UseVisualStyleBackColor = true;
            b_Ajouter.Click += b_Ajouter_Click;
            // 
            // DataEleve
            // 
            DataEleve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataEleve.Location = new Point(316, 421);
            DataEleve.Name = "DataEleve";
            DataEleve.RowHeadersWidth = 102;
            DataEleve.Size = new Size(1452, 589);
            DataEleve.TabIndex = 6;
            // 
            // b_Rechercher
            // 
            b_Rechercher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Rechercher.Location = new Point(1542, 169);
            b_Rechercher.Name = "b_Rechercher";
            b_Rechercher.Size = new Size(267, 78);
            b_Rechercher.TabIndex = 7;
            b_Rechercher.Text = "Rechercher";
            b_Rechercher.UseVisualStyleBackColor = true;
            b_Rechercher.Click += b_Rechercher_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2541, 1196);
            Controls.Add(b_Rechercher);
            Controls.Add(DataEleve);
            Controls.Add(b_Ajouter);
            Controls.Add(t_specialite);
            Controls.Add(t_ville);
            Controls.Add(t_prenom);
            Controls.Add(t_nom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataEleve).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox t_nom;
        private TextBox t_prenom;
        private TextBox t_ville;
        private TextBox t_specialite;
        private Button b_Ajouter;
        private DataGridView DataEleve;
        private Button b_Rechercher;
    }
}
