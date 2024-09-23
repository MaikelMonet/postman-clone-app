using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess apiAccess = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();

        actionDropDownList.SelectedItem = "GET";

    }

    private async void callApiButton_Click(object sender, EventArgs e)
    {
        if (UrlCheck() == false)
        {
            return;
        }

        CheckSelectedActionIsValid(out HttpAction selectedAction);

        await MakeApiCall(selectedAction);

        systemStatusLabel.BackColor = Color.White;

    }

    private async Task MakeApiCall(HttpAction selectedAction)
    {
        try
        {
            systemStatusLabel.Text = "Making Call ....";
            systemStatusLabel.BackColor = Color.Blue;

            outputTextBox.Text = await apiAccess.CallApiAsync(apiTextBox.Text, bodyTextBox.Text, selectedAction);

            callData.SelectedTab = outputTab;

            outputTab.Focus();

            systemStatusLabel.Text = "Ready";

        }
        catch (Exception ex)
        {

            outputTextBox.Text = $"The application has encountered the following error {ex.Message}";

            systemStatusLabel.Text = "Error";
            systemStatusLabel.BackColor = Color.Red;

        }
    }

    private void CheckSelectedActionIsValid(out HttpAction selectedAction)
    {
        if (Enum.TryParse(actionDropDownList.SelectedItem!.ToString(), out selectedAction) == false)
        {
            systemStatusLabel.Text = "Invalid HTTP Verb";
            systemStatusLabel.BackColor = Color.Red;
            return;
        }
    }

    private bool UrlCheck()
    {
        bool output = true;

        if (apiAccess.IsUrlValid(apiTextBox.Text) == false)
        {

            systemStatusLabel.Text = "Invalid URL";
            systemStatusLabel.BackColor = Color.Yellow;

            MessageBox.Show("You did not give a valid URL, try again",
                               "Invalid Url value!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Asterisk);


            output =  false;
        }

        return output;
    }
}
