using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Arhiva
{
    public partial class FormCategories : Form
    {
        Form1 mainForm;

        public FormCategories(Form1 form)
        {
            mainForm = form;

            InitializeComponent();

            InitializeTreeView();
        }

        void InitializeTreeView()
        {
            treeView.Nodes.Clear();

            List<List<string>> retCategory = DataBase.Query("SELECT denumire, IDcat FROM Categorie;");

            TreeNode[] nodeCategory = new TreeNode[retCategory.Count];
            TreeNode[][] nodeSubcategory = new TreeNode[retCategory.Count][];

            for (int i = 0; i < retCategory.Count; ++i)
            {
                List<List<string>> retSubcategory = DataBase.Query("SELECT denumire FROM Subcategorie WHERE IDcat = " + retCategory[i][1]);
                nodeSubcategory[i] = new TreeNode[retSubcategory.Count];

                for (int j = 0; j < retSubcategory.Count; ++j)
                {
                    nodeSubcategory[i][j] = new TreeNode(retSubcategory[j][0]);
                }

                nodeCategory[i] = new TreeNode(retCategory[i][0], nodeSubcategory[i]);
                treeView.Nodes.Add(nodeCategory[i]);
            }
        }

        private void buttonAdaugaCat_Click(object sender, EventArgs e)
        {
            DataBase.NonQuery("INSERT INTO Categorie VALUES(" + (DataBase.GetValue("SELECT max(IDcat) FROM Categorie")+1) + ",'" + tbAdaugaCat.Text + "');");

            InitializeTreeView();
        }

        private void buttonStergeCat_Click(object sender, EventArgs e)
        {
            int isSelected = DataBase.GetValue("SELECT count(*) FROM Categorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");
            if(isSelected == 0)
            {
                MessageBox.Show("Trebuie selectata o categorie!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<List<string>> ret = DataBase.Query("SELECT IDcat FROM Categorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");

            int categoryNumber;
            if (ret.Count == 0) categoryNumber = 0;
            else categoryNumber = Convert.ToInt32(ret[0][0]);

            int canDelete = DataBase.GetValue("SELECT count(*) FROM Subcategorie WHERE IDcat = " + categoryNumber);

            if (canDelete == 0)
            {
                DataBase.NonQuery("DELETE FROM Categorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");
                InitializeTreeView();
            }
            else
            {
                MessageBox.Show("Categoria nu poate fi ștearsă pentru că ea conține subcategorii!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdaugaSubcat_Click(object sender, EventArgs e)
        {
            List<List<string>> ret = DataBase.Query("SELECT IDcat FROM Categorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");

            int categoryNumber;
            if (ret.Count == 0) categoryNumber = 0;
            else categoryNumber = Convert.ToInt32(ret[0][0]);

            if(categoryNumber == 0)
            {
                MessageBox.Show("Trebuie selectata o categorie!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataBase.NonQuery("INSERT INTO Subcategorie VALUES(" + (DataBase.GetValue("SELECT max(IDsubcat) FROM Subcategorie") + 1) + ","+ categoryNumber + ",'" + tbAdaugaSubcat.Text + "');");

            InitializeTreeView();
        }

        private void buttonStergeSubcat_Click(object sender, EventArgs e)
        {
            int isSelected = DataBase.GetValue("SELECT count(*) FROM Subcategorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");
            if (isSelected == 0)
            {
                MessageBox.Show("Trebuie selectata o subcategorie!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<List<string>> ret = DataBase.Query("SELECT IDsubcat FROM Subcategorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");

            int subcategoryNumber;
            if (ret.Count == 0) subcategoryNumber = 0;
            else subcategoryNumber = Convert.ToInt32(ret[0][0]);

            int canDelete = DataBase.GetValue("SELECT count(*) FROM Problema WHERE IDsubcat = " + subcategoryNumber);

            if (canDelete == 0)
            {
                DataBase.NonQuery("DELETE FROM Subcategorie WHERE denumire = '" + treeView.SelectedNode.Text + "';");
                InitializeTreeView();
            }
            else
            {
                MessageBox.Show("Subcategoria nu poate fi ștearsă pentru că ea conține probleme!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCategories_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Brushes.PaleTurquoise), 5, 72, this.Width - 20, 72);
        }

        private void FormCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.CategoryInitialize();
        }
    }
}
