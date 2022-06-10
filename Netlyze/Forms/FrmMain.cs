using BLL;
using BLL.Interfaces;

namespace Netlyze.Forms
{
    public partial class FrmMain : Form
    {
        //private readonly IBLLOpenFile _busOpenFile;

        public FrmMain()
        {
            //_busOpenFile = new BLLOpenFile();

            InitializeComponent();  
        }

        #region Events
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog();

            //_busOpenFile.Lalalala();
        }

        private void ButtonParameters_Click(object sender, EventArgs e)
        {
            FrmParameters FrmParameters = new();
            FrmParameters.Show();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            FrmAbout FrmAbout = new();
            FrmAbout.Show();
        }
        #endregion

        #region Accessory Methods
        private void OpenFileDialog()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
        #endregion


    }
}
