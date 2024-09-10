using System.Security.Policy;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApiButton_Click(object sender, EventArgs e)
    {
        // TODO - push the user validation to the ClassLibrary eventually.

        if (string.IsNullOrWhiteSpace(apiTextBox.Text) == false)
        {
            try
            {
                systemStatusLabel.Text = "Making Call ....";

                await Task.Delay(2000);

                systemStatusLabel.Text = "Ready";

            }
            catch (Exception ex)
            {

                resultsTextBox.Text = $"The application has encountered the following error {ex.Message}";

                systemStatusLabel.Text = "Error";

            } 
        }
        else
        {
            MessageBox.Show("You did not give a valid URL, try again",
                            "Incomplete Url value!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
        }

    }

}
