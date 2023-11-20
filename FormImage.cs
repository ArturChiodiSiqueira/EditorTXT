using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTXT
{
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "rich image png|*.png|jpg|*.jpg|ico|*.ico|todos|*.*";

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + " - " + file.Name;

                    Gerenciador.FolderPath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    // objeto responsavel por ler o arquvo
                    StreamReader stream = null;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);

                        picBox.ImageLocation = dialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de arquivo não suportado.\n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
