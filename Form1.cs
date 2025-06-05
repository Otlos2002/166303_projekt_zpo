using _166303_projekt_zpo.Config;
using _166303_projekt_zpo.Data;
using _166303_projekt_zpo.Models;
using _166303_projekt_zpo.Services;

namespace _166303_projekt_zpo
{
    public partial class Form1 : Form
    {
        private CatalogManager _manager = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshList()
        {
            listBoxMedia.DataSource = null;
            listBoxMedia.DataSource = _manager.Items;
            listBoxMedia.DisplayMember = "Title";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new AddMediaForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _manager.AddItem(addForm.CreatedItem);
                RefreshList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxMedia.SelectedItem is MediaItem item)
            {
                _manager.RemoveItem(item);
                RefreshList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CatalogSerializer.SaveToFile(_manager.Items, AppConfig.Instance.DataFilePath);
            MessageBox.Show("Zapisano do pliku.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _manager.Items.Clear();
            _manager.Items.AddRange(CatalogSerializer.LoadFromFile(AppConfig.Instance.DataFilePath));
            RefreshList();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            var top = _manager.TopRated().ToList();
            listBoxMedia.DataSource = null;
            listBoxMedia.DataSource = top;
            listBoxMedia.DisplayMember = "Title";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = _manager.SearchByTitle(txtSearch.Text).ToList();
            listBoxMedia.DataSource = null;
            listBoxMedia.DataSource = result;
            listBoxMedia.DisplayMember = "Title";
        }
    }
}
