using System;
using System.Net;
using System.Windows.Forms;
using EHRClient.Data.Dto;
using EHRClient.Service;
using RestSharp;

namespace EHRClient
{
    public partial class AddTagForm : Form
    {
        private readonly EHRApiClient _ehrApiClient;

        public AddTagForm(EHRApiClient ehrApiClient)
        {
            _ehrApiClient = ehrApiClient;
            InitializeComponent();
        }

        private void ButtonCloseAddTag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddTag_Click(object sender, EventArgs e)
        {
            var addTagContent = TextBoxAdd.Text;
            var request = new RestRequest("api/Tag/PostPatientTag?tag=" + addTagContent, Method.POST);
             var response =_ehrApiClient.Execute<TagDto>(request);

             if (response.StatusCode == HttpStatusCode.Created)
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
