using _166303_projekt_zpo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _166303_projekt_zpo
{
    public partial class AddMediaForm : Form
    {
        public MediaItem CreatedItem { get; private set; }
        public AddMediaForm()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            int year = (int)numYear.Value;
            double rating = (double)numRating.Value;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Wprowadź tytuł.");
                return;
            }

            string type = comboType.SelectedItem?.ToString();
            if (type == "Movie")
                CreatedItem = new Movie { Title = title, Year = year, Rating = rating };
            else if (type == "Series")
                CreatedItem = new Series { Title = title, Year = year, Rating = rating };
            else
            {
                MessageBox.Show("Wybierz typ.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
