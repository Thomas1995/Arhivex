namespace Atestat_Arhiva
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fișierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.căutareProblemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.cbSubcategory = new System.Windows.Forms.ComboBox();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbEnunt = new System.Windows.Forms.RichTextBox();
            this.tbRezolvare = new System.Windows.Forms.RichTextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbCuvinteCheie = new System.Windows.Forms.TextBox();
            this.buttonAddProb = new System.Windows.Forms.Button();
            this.buttonModifProb = new System.Windows.Forms.Button();
            this.buttonDelProb = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.buttonAttachImg = new System.Windows.Forms.Button();
            this.openFileDialogAttachImage = new System.Windows.Forms.OpenFileDialog();
            this.pbAttachment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelCredit = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fișierToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fișierToolStripMenuItem
            // 
            this.fișierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.căutareProblemeToolStripMenuItem,
            this.toolStripSeparator1,
            this.ieșireToolStripMenuItem});
            this.fișierToolStripMenuItem.Image = global::Atestat_Arhiva.Properties.Resources.ico_file;
            this.fișierToolStripMenuItem.Name = "fișierToolStripMenuItem";
            this.fișierToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fișierToolStripMenuItem.Text = "Fișier";
            // 
            // căutareProblemeToolStripMenuItem
            // 
            this.căutareProblemeToolStripMenuItem.Image = global::Atestat_Arhiva.Properties.Resources.ico_search;
            this.căutareProblemeToolStripMenuItem.Name = "căutareProblemeToolStripMenuItem";
            this.căutareProblemeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.căutareProblemeToolStripMenuItem.Text = "Căutare probleme";
            this.căutareProblemeToolStripMenuItem.Click += new System.EventHandler(this.căutareProblemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.Image = global::Atestat_Arhiva.Properties.Resources.ico_exit;
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriiToolStripMenuItem});
            this.editareToolStripMenuItem.Image = global::Atestat_Arhiva.Properties.Resources.ico_edit;
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Image = global::Atestat_Arhiva.Properties.Resources.icon_category;
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Atestat_Arhiva.Properties.Resources.ico_help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Ajutor";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(52, 188);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(167, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.TextChanged += new System.EventHandler(this.SubcategoryInitialize);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblCategory.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblCategory.Location = new System.Drawing.Point(85, 152);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 23);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Categorie";
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblSubcategory.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategory.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblSubcategory.Location = new System.Drawing.Point(70, 239);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(129, 23);
            this.lblSubcategory.TabIndex = 4;
            this.lblSubcategory.Text = "Subcategorie";
            // 
            // cbSubcategory
            // 
            this.cbSubcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubcategory.FormattingEnabled = true;
            this.cbSubcategory.Location = new System.Drawing.Point(52, 276);
            this.cbSubcategory.Name = "cbSubcategory";
            this.cbSubcategory.Size = new System.Drawing.Size(167, 21);
            this.cbSubcategory.TabIndex = 5;
            this.cbSubcategory.TextChanged += new System.EventHandler(this.cbSubcategory_TextChanged);
            // 
            // tbTitlu
            // 
            this.tbTitlu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTitlu.Location = new System.Drawing.Point(320, 57);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(175, 20);
            this.tbTitlu.TabIndex = 7;
            this.tbTitlu.Text = "Titlul problemei (optional)";
            this.tbTitlu.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbTitlu.Leave += new System.EventHandler(this.tbTitlu_Leave);
            // 
            // tbEnunt
            // 
            this.tbEnunt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbEnunt.Location = new System.Drawing.Point(291, 88);
            this.tbEnunt.Name = "tbEnunt";
            this.tbEnunt.Size = new System.Drawing.Size(492, 155);
            this.tbEnunt.TabIndex = 8;
            this.tbEnunt.Text = "Textul problemei - maximum 2000 caractere";
            this.tbEnunt.Enter += new System.EventHandler(this.richTextBox_Enter);
            this.tbEnunt.Leave += new System.EventHandler(this.tbEnunt_Leave);
            // 
            // tbRezolvare
            // 
            this.tbRezolvare.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbRezolvare.Location = new System.Drawing.Point(291, 253);
            this.tbRezolvare.Name = "tbRezolvare";
            this.tbRezolvare.Size = new System.Drawing.Size(492, 155);
            this.tbRezolvare.TabIndex = 9;
            this.tbRezolvare.Text = "Rezolvare (optional) - maximum 2000 caractere";
            this.tbRezolvare.Enter += new System.EventHandler(this.richTextBox_Enter);
            this.tbRezolvare.Leave += new System.EventHandler(this.tbRezolvare_Leave);
            // 
            // tbAutor
            // 
            this.tbAutor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbAutor.Location = new System.Drawing.Point(626, 57);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(131, 20);
            this.tbAutor.TabIndex = 10;
            this.tbAutor.Text = "Nume autor (optional)";
            this.tbAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAutor.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbAutor.Leave += new System.EventHandler(this.tbAutor_Leave);
            // 
            // tbCuvinteCheie
            // 
            this.tbCuvinteCheie.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbCuvinteCheie.Location = new System.Drawing.Point(291, 441);
            this.tbCuvinteCheie.Name = "tbCuvinteCheie";
            this.tbCuvinteCheie.Size = new System.Drawing.Size(492, 20);
            this.tbCuvinteCheie.TabIndex = 11;
            this.tbCuvinteCheie.Text = "Cuvinte cheie (exemplu: matematica, backtraking, euler)";
            this.tbCuvinteCheie.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbCuvinteCheie.Leave += new System.EventHandler(this.tbCuvinteCheie_Leave);
            // 
            // buttonAddProb
            // 
            this.buttonAddProb.BackColor = System.Drawing.Color.Gray;
            this.buttonAddProb.Enabled = false;
            this.buttonAddProb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddProb.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProb.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddProb.Location = new System.Drawing.Point(24, 401);
            this.buttonAddProb.Name = "buttonAddProb";
            this.buttonAddProb.Size = new System.Drawing.Size(90, 60);
            this.buttonAddProb.TabIndex = 12;
            this.buttonAddProb.Text = "Adaugă problemă";
            this.buttonAddProb.UseVisualStyleBackColor = false;
            this.buttonAddProb.Click += new System.EventHandler(this.buttonAddProb_Click);
            // 
            // buttonModifProb
            // 
            this.buttonModifProb.BackColor = System.Drawing.Color.Gray;
            this.buttonModifProb.Enabled = false;
            this.buttonModifProb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifProb.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifProb.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonModifProb.Location = new System.Drawing.Point(151, 401);
            this.buttonModifProb.Name = "buttonModifProb";
            this.buttonModifProb.Size = new System.Drawing.Size(90, 60);
            this.buttonModifProb.TabIndex = 13;
            this.buttonModifProb.Text = "Modificare problemă";
            this.buttonModifProb.UseVisualStyleBackColor = false;
            this.buttonModifProb.Click += new System.EventHandler(this.buttonModifProb_Click);
            // 
            // buttonDelProb
            // 
            this.buttonDelProb.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelProb.Enabled = false;
            this.buttonDelProb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelProb.Font = new System.Drawing.Font("Arial Black", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelProb.ForeColor = System.Drawing.Color.Black;
            this.buttonDelProb.Location = new System.Drawing.Point(763, 57);
            this.buttonDelProb.Name = "buttonDelProb";
            this.buttonDelProb.Size = new System.Drawing.Size(20, 20);
            this.buttonDelProb.TabIndex = 14;
            this.buttonDelProb.Text = "X";
            this.buttonDelProb.UseVisualStyleBackColor = false;
            this.buttonDelProb.Click += new System.EventHandler(this.buttonDelProb_Click);
            // 
            // tbID
            // 
            this.tbID.ForeColor = System.Drawing.Color.Black;
            this.tbID.Location = new System.Drawing.Point(291, 57);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(23, 20);
            this.tbID.TabIndex = 15;
            this.tbID.Text = "0";
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // buttonAttachImg
            // 
            this.buttonAttachImg.BackColor = System.Drawing.Color.Gray;
            this.buttonAttachImg.Enabled = false;
            this.buttonAttachImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttachImg.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachImg.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAttachImg.Location = new System.Drawing.Point(313, 415);
            this.buttonAttachImg.Name = "buttonAttachImg";
            this.buttonAttachImg.Size = new System.Drawing.Size(113, 20);
            this.buttonAttachImg.TabIndex = 16;
            this.buttonAttachImg.Text = "Atașează imagine";
            this.buttonAttachImg.UseVisualStyleBackColor = false;
            this.buttonAttachImg.Click += new System.EventHandler(this.buttonAttachImg_Click);
            // 
            // openFileDialogAttachImage
            // 
            this.openFileDialogAttachImage.Filter = "Image Files|*.png;";
            // 
            // pbAttachment
            // 
            this.pbAttachment.BackColor = System.Drawing.Color.LightSlateGray;
            this.pbAttachment.Image = global::Atestat_Arhiva.Properties.Resources.ico_attach;
            this.pbAttachment.Location = new System.Drawing.Point(431, 414);
            this.pbAttachment.Name = "pbAttachment";
            this.pbAttachment.Size = new System.Drawing.Size(28, 25);
            this.pbAttachment.TabIndex = 17;
            this.pbAttachment.TabStop = false;
            this.pbAttachment.Visible = false;
            this.pbAttachment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAttachment_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(274, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 435);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pbCategory
            // 
            this.pbCategory.BackColor = System.Drawing.Color.LightSlateGray;
            this.pbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCategory.Location = new System.Drawing.Point(12, 43);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(242, 435);
            this.pbCategory.TabIndex = 2;
            this.pbCategory.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Gray;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonReset.Location = new System.Drawing.Point(651, 415);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 20);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "Resetează";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelCredit.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelCredit.Location = new System.Drawing.Point(19, 51);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(95, 15);
            this.labelCredit.TabIndex = 19;
            this.labelCredit.Text = "© Thomas Suditu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(811, 490);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.pbAttachment);
            this.Controls.Add(this.buttonAttachImg);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.buttonDelProb);
            this.Controls.Add(this.buttonModifProb);
            this.Controls.Add(this.buttonAddProb);
            this.Controls.Add(this.tbCuvinteCheie);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbRezolvare);
            this.Controls.Add(this.tbEnunt);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbSubcategory);
            this.Controls.Add(this.lblSubcategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.pbCategory);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arhivex";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubcategory;
        private System.Windows.Forms.ComboBox cbSubcategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.RichTextBox tbEnunt;
        private System.Windows.Forms.RichTextBox tbRezolvare;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbCuvinteCheie;
        private System.Windows.Forms.ToolStripMenuItem fișierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddProb;
        private System.Windows.Forms.Button buttonModifProb;
        private System.Windows.Forms.Button buttonDelProb;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonAttachImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogAttachImage;
        private System.Windows.Forms.PictureBox pbAttachment;
        private System.Windows.Forms.ToolStripMenuItem căutareProblemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelCredit;
    }
}

