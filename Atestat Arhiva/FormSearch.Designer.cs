namespace Atestat_Arhiva
{
    partial class FormSearch
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.rbKeyword = new System.Windows.Forms.RadioButton();
            this.labelSearch = new System.Windows.Forms.Label();
            this.rbSubcateg = new System.Windows.Forms.RadioButton();
            this.rbAnyDate = new System.Windows.Forms.RadioButton();
            this.labelDate = new System.Windows.Forms.Label();
            this.rbSpecificDate = new System.Windows.Forms.RadioButton();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreateDoc = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonAdProb = new System.Windows.Forms.Button();
            this.buttonOpenDoc = new System.Windows.Forms.Button();
            this.buttonAdProbRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(737, 330);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearch.Location = new System.Drawing.Point(12, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(291, 20);
            this.tbSearch.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Gray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSearch.Location = new System.Drawing.Point(636, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(113, 20);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Caută";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // rbKeyword
            // 
            this.rbKeyword.AutoSize = true;
            this.rbKeyword.Checked = true;
            this.rbKeyword.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKeyword.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbKeyword.Location = new System.Drawing.Point(399, 10);
            this.rbKeyword.Name = "rbKeyword";
            this.rbKeyword.Size = new System.Drawing.Size(105, 19);
            this.rbKeyword.TabIndex = 18;
            this.rbKeyword.TabStop = true;
            this.rbKeyword.Text = "cuvinte cheie";
            this.rbKeyword.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelSearch.Location = new System.Drawing.Point(309, 13);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 15);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Caută după:";
            // 
            // rbSubcateg
            // 
            this.rbSubcateg.AutoSize = true;
            this.rbSubcateg.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubcateg.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbSubcateg.Location = new System.Drawing.Point(512, 10);
            this.rbSubcateg.Name = "rbSubcateg";
            this.rbSubcateg.Size = new System.Drawing.Size(102, 19);
            this.rbSubcateg.TabIndex = 21;
            this.rbSubcateg.Text = "subcategorie";
            this.rbSubcateg.UseVisualStyleBackColor = true;
            // 
            // rbAnyDate
            // 
            this.rbAnyDate.AutoSize = true;
            this.rbAnyDate.Checked = true;
            this.rbAnyDate.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnyDate.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbAnyDate.Location = new System.Drawing.Point(34, 44);
            this.rbAnyDate.Name = "rbAnyDate";
            this.rbAnyDate.Size = new System.Drawing.Size(85, 19);
            this.rbAnyDate.TabIndex = 22;
            this.rbAnyDate.TabStop = true;
            this.rbAnyDate.Text = "orice data";
            this.rbAnyDate.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelDate.Location = new System.Drawing.Point(18, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(118, 15);
            this.labelDate.TabIndex = 23;
            this.labelDate.Text = "Doar rezultate din:";
            // 
            // rbSpecificDate
            // 
            this.rbSpecificDate.AutoSize = true;
            this.rbSpecificDate.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpecificDate.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbSpecificDate.Location = new System.Drawing.Point(34, 67);
            this.rbSpecificDate.Name = "rbSpecificDate";
            this.rbSpecificDate.Size = new System.Drawing.Size(14, 13);
            this.rbSpecificDate.TabIndex = 24;
            this.rbSpecificDate.UseVisualStyleBackColor = true;
            this.rbSpecificDate.CheckedChanged += new System.EventHandler(this.rbSpecificDate_CheckedChanged);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.dateTimePicker);
            this.groupBoxDate.Controls.Add(this.labelDate);
            this.groupBoxDate.Controls.Add(this.rbSpecificDate);
            this.groupBoxDate.Controls.Add(this.rbAnyDate);
            this.groupBoxDate.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDate.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxDate.Location = new System.Drawing.Point(19, 372);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(420, 100);
            this.groupBoxDate.TabIndex = 25;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Data adăugării";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(54, 64);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 23);
            this.dateTimePicker.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdProbRandom);
            this.groupBox1.Controls.Add(this.buttonOpenDoc);
            this.groupBox1.Controls.Add(this.buttonAdProb);
            this.groupBox1.Controls.Add(this.buttonCreateDoc);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(445, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Document Word";
            // 
            // buttonCreateDoc
            // 
            this.buttonCreateDoc.BackColor = System.Drawing.Color.Gray;
            this.buttonCreateDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateDoc.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateDoc.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonCreateDoc.Location = new System.Drawing.Point(16, 22);
            this.buttonCreateDoc.Name = "buttonCreateDoc";
            this.buttonCreateDoc.Size = new System.Drawing.Size(64, 64);
            this.buttonCreateDoc.TabIndex = 18;
            this.buttonCreateDoc.Text = "Creează document nou";
            this.buttonCreateDoc.UseVisualStyleBackColor = false;
            this.buttonCreateDoc.Click += new System.EventHandler(this.buttonCreateDoc_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            // 
            // buttonAdProb
            // 
            this.buttonAdProb.BackColor = System.Drawing.Color.Gray;
            this.buttonAdProb.Enabled = false;
            this.buttonAdProb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdProb.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdProb.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdProb.Location = new System.Drawing.Point(86, 22);
            this.buttonAdProb.Name = "buttonAdProb";
            this.buttonAdProb.Size = new System.Drawing.Size(64, 64);
            this.buttonAdProb.TabIndex = 19;
            this.buttonAdProb.Text = "Adaugă problema curentă";
            this.buttonAdProb.UseVisualStyleBackColor = false;
            this.buttonAdProb.Click += new System.EventHandler(this.buttonAdProb_Click);
            // 
            // buttonOpenDoc
            // 
            this.buttonOpenDoc.BackColor = System.Drawing.Color.Gray;
            this.buttonOpenDoc.Enabled = false;
            this.buttonOpenDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenDoc.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenDoc.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonOpenDoc.Location = new System.Drawing.Point(226, 22);
            this.buttonOpenDoc.Name = "buttonOpenDoc";
            this.buttonOpenDoc.Size = new System.Drawing.Size(64, 64);
            this.buttonOpenDoc.TabIndex = 20;
            this.buttonOpenDoc.Text = "Deschide document curent";
            this.buttonOpenDoc.UseVisualStyleBackColor = false;
            this.buttonOpenDoc.Click += new System.EventHandler(this.buttonOpenDoc_Click);
            // 
            // buttonAdProbRandom
            // 
            this.buttonAdProbRandom.BackColor = System.Drawing.Color.Gray;
            this.buttonAdProbRandom.Enabled = false;
            this.buttonAdProbRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdProbRandom.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdProbRandom.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdProbRandom.Location = new System.Drawing.Point(156, 22);
            this.buttonAdProbRandom.Name = "buttonAdProbRandom";
            this.buttonAdProbRandom.Size = new System.Drawing.Size(64, 64);
            this.buttonAdProbRandom.TabIndex = 21;
            this.buttonAdProbRandom.Text = "Adaugă problemă aleatoare";
            this.buttonAdProbRandom.UseVisualStyleBackColor = false;
            this.buttonAdProbRandom.Click += new System.EventHandler(this.buttonAdProbRandom_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(764, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.rbSubcateg);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.rbKeyword);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caută Probleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton rbKeyword;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.RadioButton rbSubcateg;
        private System.Windows.Forms.RadioButton rbAnyDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.RadioButton rbSpecificDate;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateDoc;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonAdProb;
        private System.Windows.Forms.Button buttonOpenDoc;
        private System.Windows.Forms.Button buttonAdProbRandom;
    }
}