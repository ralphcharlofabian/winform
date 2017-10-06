using System;
using System.Net;
using System.Windows.Forms;
using EHRClient.Data.Dto;
using EHRClient.Service;
using RestSharp;

namespace EHRClient
{
    public partial class EditTagForm : Form
    {
        private readonly EHRApiClient _ehrApiClient;
        private readonly TagDto _selectedTag;

        public EditTagForm(EHRApiClient ehrApiClient, TagDto selectedTag)
        {
            _selectedTag = selectedTag;
            _ehrApiClient = ehrApiClient;
            InitializeComponent();

            TextBoxEdit.Text = _selectedTag.Tag;
        }

        private void ButtonCloseEditTag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonEditTag_Click(object sender, EventArgs e)
        {
            var editTagContent = TextBoxEdit.Text;
            var request = new RestRequest("api/Tag/PutPatientTag", Method.PUT)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddBody(new TagDto
            {
                Id = _selectedTag.Id,
                Tag = editTagContent,
                Version = _selectedTag.Version
            });
            var response = _ehrApiClient.Execute<bool>(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }
    }
}
