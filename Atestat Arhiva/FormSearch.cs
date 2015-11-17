using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;
using System.Diagnostics;
using System.IO;

namespace Atestat_Arhiva
{
    public partial class FormSearch : Form
    {
        Form1 mainForm;

        public FormSearch(Form1 form)
        {
            mainForm = form;

            InitializeComponent();

            dataGridView.ReadOnly = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            DataGridViewColumn aux;

            DataGridViewColumn columnID = new DataGridViewColumn();
            aux = columnID;
            aux.CellTemplate = new DataGridViewTextBoxCell();
            aux.HeaderText = "ID";
            dataGridView.Columns.Add(aux);

            DataGridViewColumn columnTitle = new DataGridViewColumn();
            aux = columnTitle;
            aux.CellTemplate = new DataGridViewTextBoxCell();
            aux.HeaderText = "Titlu";
            dataGridView.Columns.Add(aux);

            DataGridViewColumn columnCategory = new DataGridViewColumn();
            aux = columnCategory;
            aux.CellTemplate = new DataGridViewTextBoxCell();
            aux.HeaderText = "Categorie";
            dataGridView.Columns.Add(aux);

            DataGridViewColumn columnSubcategory = new DataGridViewColumn();
            aux = columnSubcategory;
            aux.CellTemplate = new DataGridViewTextBoxCell();
            aux.HeaderText = "Subcategorie";
            dataGridView.Columns.Add(aux);

            DataGridViewColumn columnKeywords = new DataGridViewColumn();
            aux = columnKeywords;
            aux.CellTemplate = new DataGridViewTextBoxCell();
            aux.HeaderText = "Cuvinte cheie";
            dataGridView.Columns.Add(aux);

            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[4].Width = 344;

            string field = "";

            if (rbKeyword.Checked == true) field = "cuv_cheie";
            if (rbSubcateg.Checked == true) field = "Subcategorie.denumire";

            string condition = field + " LIKE '%" + tbSearch.Text + "%'";
            if (rbSpecificDate.Checked == true) condition += " AND data_add = '" + dateTimePicker.Value.ToString("MM/dd/yyyy") +"'";

            List<List<string>> retProblem = DataBase.Query("SELECT IDpb, Problema.denumire, cuv_cheie, Problema.IDsubcat FROM Subcategorie, Problema WHERE Problema.IDsubcat = Subcategorie.IDsubcat AND " + condition);

            for (int i = 0; i < retProblem.Count; ++i)
            {
                string[] array = new string[5];

                array[0] = retProblem[i][0];
                array[1] = retProblem[i][1];
                array[4] = retProblem[i][2];

                List<List<string>> ret1 = DataBase.Query("SELECT denumire, IDcat FROM Subcategorie WHERE IDsubcat = " + retProblem[i][3]);
                List<List<string>> ret2 = DataBase.Query("SELECT denumire, IDcat FROM Categorie WHERE IDcat = " + ret1[0][1]);

                array[2] = ret2[0][0];
                array[3] = ret1[0][0];

                dataGridView.Rows.Add(array);
            }
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            if (ID == 0) return;

            string category = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[2].Value);
            string subcategory = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[3].Value);
            mainForm.viewProb(ID, category, subcategory);
            mainForm.Select();
        }

        private void rbSpecificDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = rbSpecificDate.Checked;
        }

        string filename;
        DocX doc;
        int problemIndex;

        private void buttonCreateDoc_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                filename = saveFileDialog.FileName;
                doc = DocX.Create(filename);

                buttonAdProb.Enabled = true;
                buttonAdProbRandom.Enabled = true;
                buttonOpenDoc.Enabled = true;

                Paragraph paragraph = doc.InsertParagraph("Test");
                paragraph.Alignment = Alignment.center;
                doc.InsertParagraph(Environment.NewLine);
                doc.Save();

                problemIndex = 0;

                MessageBox.Show("Document creat cu succes!");
            }
        }

        private void buttonAdProb_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;

            int ID = Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value);
            if (ID == 0)
            {
                MessageBox.Show("Selectați o problemă!");
                return;
            }

            AddProblem(ID);
        }

        Random rand = new Random();
        private void buttonAdProbRandom_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;

            int randomRow = rand.Next(0, dataGridView.Rows.Count-1);
            int ID = Convert.ToInt32(dataGridView.Rows[randomRow].Cells[0].Value);

            AddProblem(ID);
        }

        private void AddProblem(int ID)
        {
            ++problemIndex;

            List<List<string>> ret = DataBase.Query("SELECT enunt FROM Problema WHERE IDpb = " + ID);
            Paragraph paragraph = doc.InsertParagraph(problemIndex + ") " + ret[0][0]);
            paragraph.Alignment = Alignment.both;
            doc.InsertParagraph(Environment.NewLine);

            string imageFile = Application.StartupPath + "\\Imagini\\" + ID + ".png";
            if(File.Exists(imageFile) == true)
            {
                MemoryStream ms = new MemoryStream();
                System.Drawing.Image myImg = System.Drawing.Image.FromFile(imageFile);
                myImg.Save(ms,myImg.RawFormat);
                ms.Seek(0, SeekOrigin.Begin);

                Novacode.Image img = doc.AddImage(ms);
                Picture picture = img.CreatePicture();

                paragraph.InsertPicture(picture, paragraph.Text.Length);
            }

            doc.Save();

            MessageBox.Show("Problemă adăugată cu succes!");
        }

        private void buttonOpenDoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenție! Nu uitați să închideți documentul înainte de a-l modifica din aplicație!");
            Process.Start(filename);
        }
    }
}
