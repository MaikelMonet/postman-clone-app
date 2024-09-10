using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess apiAccess = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApiButton_Click(object sender, EventArgs e)
    {
        if (apiAccess.IsUrlValid(apiTextBox.Text))
        {

            systemStatusLabel.Text = "Invalid URL";

            MessageBox.Show("You did not give a valid URL, try again",
                               "incorrect Url value!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Asterisk);


            return;
        }
        

        try
        {
            systemStatusLabel.Text = "Making Call ....";


            resultsTextBox.Text = await apiAccess.CallApiAsync(apiTextBox.Text);

            systemStatusLabel.Text = "Ready";

        }
        catch (Exception ex)
        {

            resultsTextBox.Text = $"The application has encountered the following error {ex.Message}";

            systemStatusLabel.Text = "Error";

        }



    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
        resultsTextBox.Text = "";
    }
}
