using System.Security.Policy;

namespace TKSRandomFakeEmailGenerator
{
    public partial class FormRandomEmailGenerator : Form
    {
        public FormRandomEmailGenerator()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Get number of email to be generated
            var count = (Int16)numEmailCount.Value;

            // Generate random emails
            var emailList = EmailGenerator.Generate(count);

            // Update textbox (txtGeneratedEmails) content with cleaned/generated emails
            txtGeneratedEmails.Lines = emailList.ToArray();
        }

        private void linkCopyEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if textbox has text before copying
            if (txtGeneratedEmails.Text != "")
            {
                // Remove empty lines and lines with just whitespace
                var lines = txtGeneratedEmails.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                // Total number of generated emails
                var count = lines.Length;

                // Update textbox (txtGeneratedEmails) content with cleaned/generated emails
                txtGeneratedEmails.Lines = lines;

                // Copy cleaned text to clipboard
                Clipboard.SetText(string.Join(Environment.NewLine, lines));

                // Show success message: Email(s) copied successfully!
                MessageBox.Show($"{count} email(s) copied successfully!");
            }
            
        }

        private void txtGeneratedEmails_TextChanged(object sender, EventArgs e)
        {
            // Remove empty lines and lines with just whitespace
            var lines = txtGeneratedEmails.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            // Total number of generated emails
            var count = lines.Length;

            //Show/Hide "Copy Emails" link/label dynamically if there is any email 
            linkCopyEmail.Visible = count > 0;
        }
    }
}
