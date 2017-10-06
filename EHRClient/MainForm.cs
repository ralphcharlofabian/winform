using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Windows.Forms;
using EHRClient.Data.Dto;
using EHRClient.Service;
using RestSharp;

namespace EHRClient
{
    public partial class MainForm : Form
    {
        private readonly IAuthApiClient _authApiClient;
        private readonly EHRApiClient _ehrApiClient;
        private TagDto _selectedTag;

        public MainForm(IAuthApiClient authApiClient, EHRApiClient ehrApiClient)
        {
            _authApiClient = authApiClient;
            _ehrApiClient = ehrApiClient;
            InitializeComponent();
            TextBoxEHRUrl.Text = ConfigurationManager.AppSettings["EHRUrlApi"];
            TextBoxUrl.Text = ConfigurationManager.AppSettings["AuthUrlApi"];
            TextBoxClientId.Text = ConfigurationManager.AppSettings["AuthClientId"];
            TextBoxClientSecret.Text = ConfigurationManager.AppSettings["AuthClientSecret"];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var authToken = _authApiClient.GetToken();

            if (authToken == null)
            {
                MessageBox.Show(@"Invalid client id or client secret.");
                return;
            }

            TextBoxToken.Text = authToken.AccessToken;
            TextBoxRefreshToken.Text = authToken.RefreshToken;
            ButtonAdd.Enabled = true;
            ButtonDelete.Enabled = true;
            ButtonEdit.Enabled = true;
            ButtonGet.Enabled = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddTagForm openAddForm = new AddTagForm(_ehrApiClient);
            var result = openAddForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ButtonGet_Click(sender, e);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (_selectedTag == null)
            {
                MessageBox.Show(@"Please select a Tag.");
                return;
            }

            EditTagForm openEditForm = new EditTagForm(_ehrApiClient, _selectedTag);
            var result = openEditForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ButtonGet_Click(sender, e);
            }
        }

        private void ButtonGet_Click(object sender, EventArgs e)
        {   
            var request = new RestRequest("/api/Tag/GetPatientTags", Method.GET);
            
            var response = _ehrApiClient.Execute<List<TagDto>>(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(@"The application encountered an error: " + response.Content);
                return;
            }
            
            DataGridViewTags.Rows.Clear();
            response.Data.ForEach(tag =>
            {
                DataGridViewTags.Rows.Add(tag.Id, tag.Tag, tag.Version);
            });

            DataGridViewTags.Enabled = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (_selectedTag == null)
            {
                MessageBox.Show(@"Please select a Tag.");
                return;
            }

            var result = MessageBox.Show(@"Are you sure you want to delete this tag?", "", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;

            var request = new RestRequest(string.Format("/api/Tag/DeletePatientTag?id={0}", _selectedTag.Id), Method.DELETE);

            var response = _ehrApiClient.Execute<bool>(request);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    ButtonGet_Click(sender, e);
                    break;
                case HttpStatusCode.BadRequest:
                    MessageBox.Show(response.Content);
                    break;
            }
        }

        private void DataGridViewTags_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewTags.SelectedRows)
            {
                if (row.Cells["Id"].Value == null)
                {
                    _selectedTag = null;
                    return;
                }

                _selectedTag = new TagDto
                {
                    Id = (int) row.Cells["Id"].Value,
                    Tag = (string) row.Cells["Tag"].Value,
                    Version = (int) row.Cells["Version"].Value
                };
            }
        }
    }
}
