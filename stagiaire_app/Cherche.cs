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
    public partial class Cherche : Form
    {
        public Cherche(Form1 form)
        {
            InitializeComponent();
            this.form_stagiares = form;
        }
        Form1 form_stagiares;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in form_stagiares.dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == textBox1.Text)
                {
                    form_stagiares.setItemsValues(form_stagiares.dataGridView1.Rows.IndexOf(row));
                    this.Close();
                }
            }
        }
    }
}
