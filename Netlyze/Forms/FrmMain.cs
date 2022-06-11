using BLL;
using BLL.Interfaces;
using System.Text.RegularExpressions;

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
            string fileContent;
            List<string> projectList = new();

            fileContent = OpenFileDialog();

            projectList = ParsesFileContents(fileContent);

            GetsProjectNames(projectList);



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
        private string OpenFileDialog()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.InitialDirectory = "c:\\Users\\mathe\\source\\repos";
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

            return fileContent;

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private List<string> ParsesFileContents(string fileContent)
        {
            int initialIndex;
            int finalIndex = 0;
            int counter = Regex.Matches(fileContent, "EndProject").Count;

            List<string> projectList = new();

            for (int i = 0; i < counter; i++)
            {
                initialIndex = fileContent.IndexOf("Project", finalIndex);
                finalIndex = fileContent.IndexOf("EndProject", initialIndex);

                string projectString = fileContent[initialIndex..finalIndex];

                projectList.Add(projectString.ToString());
            }

            return projectList;
        }

        private void GetsProjectNames(List<string> projectList)
        {
            projectList.Sort();
        }
        #endregion


    }
}
