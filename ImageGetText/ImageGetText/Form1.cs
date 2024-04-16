namespace ImageGetText
{
    public partial class Form1 : Form
    {
        private string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            path = txtPath.Text;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    txtLog.AppendText($"Directorio destino: {path}");
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Error: {ex.Message}");                
            }
        }
    }
}
