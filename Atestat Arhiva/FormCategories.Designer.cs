namespace Atestat_Arhiva
{
    partial class FormCategories
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.tbAdaugaCat = new System.Windows.Forms.TextBox();
            this.buttonAdaugaCat = new System.Windows.Forms.Button();
            this.buttonStergeCat = new System.Windows.Forms.Button();
            this.buttonStergeSubcat = new System.Windows.Forms.Button();
            this.buttonAdaugaSubcat = new System.Windows.Forms.Button();
            this.tbAdaugaSubcat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.LightSlateGray;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.treeView.Location = new System.Drawing.Point(12, 81);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(264, 314);
            this.treeView.TabIndex = 0;
            // 
            // tbAdaugaCat
            // 
            this.tbAdaugaCat.Location = new System.Drawing.Point(9, 15);
            this.tbAdaugaCat.Name = "tbAdaugaCat";
            this.tbAdaugaCat.Size = new System.Drawing.Size(110, 20);
            this.tbAdaugaCat.TabIndex = 1;
            // 
            // buttonAdaugaCat
            // 
            this.buttonAdaugaCat.BackColor = System.Drawing.Color.Gray;
            this.buttonAdaugaCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdaugaCat.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaCat.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdaugaCat.Location = new System.Drawing.Point(125, 15);
            this.buttonAdaugaCat.Name = "buttonAdaugaCat";
            this.buttonAdaugaCat.Size = new System.Drawing.Size(117, 20);
            this.buttonAdaugaCat.TabIndex = 17;
            this.buttonAdaugaCat.Text = "Adaugă categorie";
            this.buttonAdaugaCat.UseVisualStyleBackColor = false;
            this.buttonAdaugaCat.Click += new System.EventHandler(this.buttonAdaugaCat_Click);
            // 
            // buttonStergeCat
            // 
            this.buttonStergeCat.BackColor = System.Drawing.Color.Gray;
            this.buttonStergeCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStergeCat.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeCat.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonStergeCat.Location = new System.Drawing.Point(248, 15);
            this.buttonStergeCat.Name = "buttonStergeCat";
            this.buttonStergeCat.Size = new System.Drawing.Size(117, 20);
            this.buttonStergeCat.TabIndex = 18;
            this.buttonStergeCat.Text = "Șterge categorie";
            this.buttonStergeCat.UseVisualStyleBackColor = false;
            this.buttonStergeCat.Click += new System.EventHandler(this.buttonStergeCat_Click);
            // 
            // buttonStergeSubcat
            // 
            this.buttonStergeSubcat.BackColor = System.Drawing.Color.Gray;
            this.buttonStergeSubcat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStergeSubcat.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeSubcat.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonStergeSubcat.Location = new System.Drawing.Point(248, 46);
            this.buttonStergeSubcat.Name = "buttonStergeSubcat";
            this.buttonStergeSubcat.Size = new System.Drawing.Size(117, 20);
            this.buttonStergeSubcat.TabIndex = 21;
            this.buttonStergeSubcat.Text = "Șterge subcategorie";
            this.buttonStergeSubcat.UseVisualStyleBackColor = false;
            this.buttonStergeSubcat.Click += new System.EventHandler(this.buttonStergeSubcat_Click);
            // 
            // buttonAdaugaSubcat
            // 
            this.buttonAdaugaSubcat.BackColor = System.Drawing.Color.Gray;
            this.buttonAdaugaSubcat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdaugaSubcat.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaSubcat.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdaugaSubcat.Location = new System.Drawing.Point(125, 46);
            this.buttonAdaugaSubcat.Name = "buttonAdaugaSubcat";
            this.buttonAdaugaSubcat.Size = new System.Drawing.Size(117, 20);
            this.buttonAdaugaSubcat.TabIndex = 20;
            this.buttonAdaugaSubcat.Text = "Adaugă subcategorie";
            this.buttonAdaugaSubcat.UseVisualStyleBackColor = false;
            this.buttonAdaugaSubcat.Click += new System.EventHandler(this.buttonAdaugaSubcat_Click);
            // 
            // tbAdaugaSubcat
            // 
            this.tbAdaugaSubcat.Location = new System.Drawing.Point(9, 46);
            this.tbAdaugaSubcat.Name = "tbAdaugaSubcat";
            this.tbAdaugaSubcat.Size = new System.Drawing.Size(110, 20);
            this.tbAdaugaSubcat.TabIndex = 19;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(371, 403);
            this.Controls.Add(this.buttonStergeSubcat);
            this.Controls.Add(this.buttonAdaugaSubcat);
            this.Controls.Add(this.tbAdaugaSubcat);
            this.Controls.Add(this.buttonStergeCat);
            this.Controls.Add(this.buttonAdaugaCat);
            this.Controls.Add(this.tbAdaugaCat);
            this.Controls.Add(this.treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editare Categorii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCategories_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCategories_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox tbAdaugaCat;
        private System.Windows.Forms.Button buttonAdaugaCat;
        private System.Windows.Forms.Button buttonStergeCat;
        private System.Windows.Forms.Button buttonStergeSubcat;
        private System.Windows.Forms.Button buttonAdaugaSubcat;
        private System.Windows.Forms.TextBox tbAdaugaSubcat;

    }
}