using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stagiaire_app
{
    public partial class Form1 : Form
    {
        //variables
        int current_row = 0;
        public int inscription_num = 0;
        List<Stagiare> stagiares;
        //functions
        public void setDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stagiares;
        }
        public void setItemsValues(int rowIndex)
        {
            txtId.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtNom.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrenom.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            dtpBirth.Value = DateTime.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            txtMoyenne.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }
        public Stagiare GetStagiare()
        {
            Stagiare stagiare = new Stagiare(int.Parse(txtId.Text), txtNom.Text, txtPrenom.Text, dtpBirth.Value, double.Parse(txtMoyenne.Text));
            return stagiare;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                stagiares.Add(GetStagiare());
                MessageBox.Show("L'insertion Succefully", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void Form1_Load(object sender, EventArgs e)
       {
            stagiares = new List<Stagiare>()
            {
                new Stagiare{ Num = 1, Nom = "Essaadani", Prenom = "Younes", DateBirth = DateTime.Parse("02-02-2003"), Moyenne=15 },
                new Stagiare{ Num = 2, Nom = "Essaadani", Prenom = "Khalid", DateBirth = DateTime.Parse("10-08-1989"), Moyenne=17 },
                new Stagiare{ Num = 3, Nom = "Hamri", Prenom = "Said", DateBirth = DateTime.Parse("06-02-2003"), Moyenne=16},
            };
            setDataGridView();
       }

        private void button2_Click(object sender, EventArgs e)
        {
            stagiares.RemoveAt(dataGridView1.CurrentRow.Index);
            setDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stagiares[current_row] = GetStagiare();
            setDataGridView();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
                        
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setItemsValues(dataGridView1.CurrentRow.Index);
            this.current_row = int.Parse(dataGridView1.CurrentRow.Index.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cherche cherche_form = new Cherche(this);
            cherche_form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
