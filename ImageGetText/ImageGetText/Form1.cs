using Microsoft.VisualBasic.Logging;
using Tesseract;

namespace ImageGetText
{
    public partial class Form1 : Form
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };
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
                    GetFiles(path);

                    txtLog.AppendText(Environment.NewLine);
                    Log("*** Proceso Finalizado ***");
                }
                else
                {
                    Log($"No se encuentra el directorio: {path}");
                }
            }
            catch (Exception ex)
            {
                Log($"Error: {ex.Message}");                
            }
        }

        public void GetFiles(string path)
        {
            try
            {
                string[] listFiles = Directory.GetFiles(path);

                txtLog.AppendText(Environment.NewLine);
                Log($"Leyendo directorio: {path}");
                txtLog.AppendText(Environment.NewLine);
                Log($"{listFiles.Length} archivos encontrados");
                txtLog.AppendText(Environment.NewLine);

                foreach (var item in listFiles)
                {
                    if (ImageExtensions.Contains(Path.GetExtension(item).ToUpperInvariant()))
                    {
                        Log($"Procesando archivo: {item}");
                        ProcessFile(item);
                    }
                }

                string[] carpetas = Directory.GetDirectories(path);
                foreach (var carpeta in carpetas)
                {
                    GetFiles(carpeta);
                }
            }
            catch (Exception ex)
            {
                Log($"Error: {ex.Message}");
            }
        }

        public void ProcessFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var engine = new TesseractEngine($"./tessdata", "eng");
                    var image = Pix.LoadFromFile(filePath);
                    var page = engine.Process(image);

                    var text = page.GetText();

                    if (File.Exists($"{filePath}.txt"))
                    {
                        File.Delete($"{filePath}.txt");
                    }

                    File.WriteAllText($"{filePath}.txt", text);
                }
            }
            catch (Exception ex)
            {
                Log($"Error: {ex.Message}");
            }
        }

        public void Log(string message)
        {
            Invoke(new MethodInvoker(() =>
            {

                string vTexto = DateTime.Now + " -> " + message + Environment.NewLine;
                if (txtLog.Text.Length == 0)
                    txtLog.Text = vTexto;
                else
                    txtLog.AppendText(vTexto);

                txtLog.ScrollToCaret();
                Application.DoEvents();
            }));

        }

    }
}
