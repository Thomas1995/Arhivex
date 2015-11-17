using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Atestat_Arhiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CategoryInitialize();
        }


        // INITIALIZARI

        public void CategoryInitialize()
        {
            cbCategory.Items.Clear();

            List<List<string>> ret = DataBase.Query("SELECT denumire FROM Categorie;");
            for (int i = 0; i < ret.Count; ++i) cbCategory.Items.Add(ret[i][0]);

            if (ret.Count > 0) cbCategory.SelectedIndex = 0;
            else cbCategory.Text = "";
        }

        private void SubcategoryInitialize(object sender, EventArgs e)
        {
            cbSubcategory.Items.Clear();
            string category = ((ComboBox)sender).Text;

            List<List<string>> ret = DataBase.Query("SELECT Subcategorie.denumire FROM Subcategorie, Categorie WHERE Subcategorie.IDcat = Categorie.IDcat AND Categorie.denumire = \'" + category + "\';");
            for (int i = 0; i < ret.Count; ++i) cbSubcategory.Items.Add(ret[i][0]);

            if(ret.Count > 0) cbSubcategory.SelectedIndex = 0;
            else cbSubcategory.Text = "";
        }


        // ADAUGARE PROBLEMA

        private void buttonAddProb_Click(object sender, EventArgs e)
        {
            if (tbEnunt.ForeColor != Color.Black || tbEnunt.Text == "")
            {
                MessageBox.Show("Enunțul problemei nu e completat!", "Date incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbCuvinteCheie.ForeColor != Color.Black || tbCuvinteCheie.Text == "")
            {
                MessageBox.Show("Cuvintele cheie sunt obligatorii!", "Date incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int IDsubcat = DataBase.GetValue("SELECT IDsubcat FROM Subcategorie WHERE denumire = '" + cbSubcategory.Text + "';");
            int IDpb = DataBase.GetValue("SELECT max(IDpb) FROM Problema;") + 1;

            if (tbAutor.ForeColor != Color.Black) tbAutor.Text = "";
            if (tbTitlu.ForeColor != Color.Black) tbTitlu.Text = "";
            if (tbRezolvare.ForeColor != Color.Black) tbRezolvare.Text = "";

            string query = "INSERT INTO Problema VALUES("
                + IDpb + "," + IDsubcat + ",'" + tbTitlu.Text
                + "','" + tbCuvinteCheie.Text + "','" + tbEnunt.Text
                + "','" + tbRezolvare.Text + "','" + tbAutor.Text + "','"
                + DateTime.Now.ToString("MM/dd/yyyy") + "');";

            DataBase.NonQuery(query);

            MessageBox.Show("Problemă adăugată cu succes!");
            tbID.Text = IDpb + "";

            if (attachedImage != null)
            {
                attachedImage.Save(Application.StartupPath + "\\Imagini\\" + tbID.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        // MODIFICARE PROBLEMA

        private void buttonModifProb_Click(object sender, EventArgs e)
        {
            if (tbEnunt.ForeColor != Color.Black || tbEnunt.Text == "")
            {
                MessageBox.Show("Enunțul problemei nu e completat!", "Date incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbCuvinteCheie.ForeColor != Color.Black || tbCuvinteCheie.Text == "")
            {
                MessageBox.Show("Cuvintele cheie sunt obligatorii!", "Date incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbAutor.ForeColor != Color.Black) tbAutor.Text = "";
            if (tbTitlu.ForeColor != Color.Black) tbTitlu.Text = "";
            if (tbRezolvare.ForeColor != Color.Black) tbRezolvare.Text = "";

            int IDsubcat = DataBase.GetValue("SELECT IDsubcat FROM Subcategorie WHERE denumire = '" + cbSubcategory.Text + "';");

            string query = "UPDATE Problema SET IDsubcat = " + IDsubcat + ", denumire = '" 
                + tbTitlu.Text + "', cuv_cheie = '" + tbCuvinteCheie.Text + "', enunt = '" 
                + tbEnunt.Text + "', rezolvare = '" + tbRezolvare.Text + "', autor = '" 
                + tbAutor.Text + "' WHERE IDpb = " + tbID.Text + ";";

            DataBase.NonQuery(query);

            MessageBox.Show("Problemă modificată cu succes!");

            if (attachedImage != null)
            {
                string path = Application.StartupPath + "\\Imagini\\" + tbID.Text + ".png";
                if(!File.Exists(path)) attachedImage.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            }
        }


        // STERGERE PROBLEMA

        private void buttonDelProb_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Într-adevăr doriți să ștergeți această problemă?","",MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            string query = "DELETE FROM Problema WHERE IDpb = " + tbID.Text + ";";
            DataBase.NonQuery(query);

            MessageBox.Show("Problemă eliminată cu succes!");
        }


        // ATASEAZA IMAGINE

        Image attachedImage = null;
        private void buttonAttachImg_Click(object sender, EventArgs e)
        {
            if(openFileDialogAttachImage.ShowDialog() == DialogResult.OK)
            {
                attachedImage = new Bitmap(openFileDialogAttachImage.FileName);

                if(attachedImage.Height > 500)
                {
                    float auxf = attachedImage.Width / (attachedImage.Height / 500.0f);
                    attachedImage = new Bitmap(attachedImage, new Size((int)auxf, 500));
                }
                if (attachedImage.Width > 500)
                {
                    float auxf = attachedImage.Height / (attachedImage.Width / 500.0f);
                    attachedImage = new Bitmap(attachedImage, new Size(500, (int)auxf));
                }

                pbAttachment.Visible = true;
            }
        }

        private void pbAttachment_MouseClick(object sender, MouseEventArgs e)
        {
            FormImageView form = new FormImageView(attachedImage);
            form.ShowDialog();
        }


        // VIZUALIZARE PROBLEMA

        public void viewProb(int ID, string category, string subcategory)
        {
            List<List<string>> ret = DataBase.Query("SELECT * FROM Problema WHERE IDpb = " + ID);
            tbID.Text = ret[0][0];
            tbTitlu.Text = ret[0][2];
            tbCuvinteCheie.Text = ret[0][3];
            tbEnunt.Text = ret[0][4];
            tbRezolvare.Text = ret[0][5];
            tbAutor.Text = ret[0][6];

            tbID.ForeColor = Color.Black;
            tbTitlu.ForeColor = Color.Black;
            tbCuvinteCheie.ForeColor = Color.Black;
            tbEnunt.ForeColor = Color.Black;
            tbRezolvare.ForeColor = Color.Black;
            tbAutor.ForeColor = Color.Black;

            cbCategory.Text = category;
            cbSubcategory.Text = subcategory;

            string imageFile = Application.StartupPath + "\\Imagini\\" + ID + ".png";
            if (File.Exists(imageFile) == true)
            {
                attachedImage = Image.FromFile(imageFile);
                pbAttachment.Visible = true;
            }
            else
            {
                pbAttachment.Visible = false;
                attachedImage = null;
            }
        }


        // RESETARE

        private void buttonReset_Click(object sender, EventArgs e)
        {
            tbAutor.Text = "";
            tbCuvinteCheie.Text = "";
            tbEnunt.Text = "";
            tbRezolvare.Text = "";
            tbTitlu.Text = "";
            tbID.Text = "0";
            pbAttachment.Visible = false;
            attachedImage = null;
        }


        // ACCESIBILITATE BUTOANE

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if(tbID.Text == "0")
            {
                buttonDelProb.Enabled = false;
                buttonModifProb.Enabled = false;
                attachedImage = null;
            }
            else
            {
                buttonDelProb.Enabled = true;
                buttonModifProb.Enabled = true;
            }
        }

        private void cbSubcategory_TextChanged(object sender, EventArgs e)
        {
            if(cbSubcategory.Text == "")
            {
                buttonAddProb.Enabled = false;
                buttonAttachImg.Enabled = false;
            }
            else
            {
                buttonAddProb.Enabled = true;
                buttonAttachImg.Enabled = true;
            }
        }


        // MODIFICARE TEXTBOX

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox crtTextBox = ((TextBox)sender);

            if (crtTextBox.ForeColor != Color.Black)
            {
                crtTextBox.Text = "";
                crtTextBox.ForeColor = Color.Black;
            }
        }

        private void richTextBox_Enter(object sender, EventArgs e)
        {
            RichTextBox crtTextBox = ((RichTextBox)sender);

            if (crtTextBox.ForeColor != Color.Black)
            {
                crtTextBox.Text = "";
                crtTextBox.ForeColor = Color.Black;
            }
        }

        private void tbCuvinteCheie_Leave(object sender, EventArgs e)
        {
            TextBox crtTextBox = ((TextBox)sender); 
            if (crtTextBox.Text == "")
            {
                crtTextBox.Text = "Cuvinte cheie (exemplu: matematica, backtraking, euler)";
                crtTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void tbTitlu_Leave(object sender, EventArgs e)
        {
            TextBox crtTextBox = ((TextBox)sender);
            if (crtTextBox.Text == "")
            {
                crtTextBox.Text = "Titlul problemei (optional)";
                crtTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void tbAutor_Leave(object sender, EventArgs e)
        {
            TextBox crtTextBox = ((TextBox)sender);
            if (crtTextBox.Text == "")
            {
                crtTextBox.Text = "Nume autor (optional)";
                crtTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void tbRezolvare_Leave(object sender, EventArgs e)
        {
            RichTextBox crtTextBox = ((RichTextBox)sender);
            if (crtTextBox.Text == "")
            {
                crtTextBox.Text = "Rezolvare (optional) - maximum 2000 caractere";
                crtTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void tbEnunt_Leave(object sender, EventArgs e)
        {
            RichTextBox crtTextBox = ((RichTextBox)sender);
            if (crtTextBox.Text == "")
            {
                crtTextBox.Text = "Textul problemei - maximum 2000 caractere";
                crtTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }


        // ACTIUNI MENU

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCategories(this).ShowDialog();
        }

        private void căutareProblemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSearch(this).Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHelp().ShowDialog();
        }
    }
}
