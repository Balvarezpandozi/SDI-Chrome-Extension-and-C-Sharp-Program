using Newtonsoft.Json;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace get_selector_app
{
    public partial class GetSelectorMainForm : Form
    {
        public GetSelectorMainForm()
        {
            InitializeComponent();
            namesListBox.Items.Clear();
        }

        private void addName(string name)
        {
            namesListBox.BeginUpdate();
            namesListBox.Items.Add(name);
            namesListBox.EndUpdate();
        }

        private async void getNameButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            feedbackLabel.Text = "Making name request...";
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:3000/api/getName");
                if (response.IsSuccessStatusCode)
                {
                    string namesJson = await response.Content.ReadAsStringAsync();
                    var namesObj = JsonConvert.DeserializeObject<NameObject>(namesJson);
                    addName(namesObj.Name);
                    feedbackLabel.Text = "Name successfully retrieved.";
                }
            } 
            catch (Exception)
            {
                feedbackLabel.Text = "Something went wrong, try checking that the API is turned ON";
            }
        }
    }
}