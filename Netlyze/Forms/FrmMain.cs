using System.Text.RegularExpressions;

namespace Netlyze.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();  
        }

        #region Variables
        int firstIndex = 0;
        int lastIndex = 0;
        string fileContent;
        List<string> fileContentList = new();
        List<string> projectNameList = new();
        #endregion

        #region Events
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            fileContent = OpenFileDialog();

            fileContentList = ParsesFileContent(fileContent, fileContentList);

            projectNameList = GetsProjectName(fileContentList, projectNameList);

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

        private List<string> ParsesFileContent(string fileContent, List<string> fileContentList)
        {
            for (int i = 0; i < Regex.Matches(fileContent, "EndProject").Count; i++)
            {
                firstIndex = fileContent.IndexOf("Project", lastIndex);
                lastIndex = fileContent.IndexOf("EndProject", firstIndex);

                string projectString = fileContent[firstIndex..lastIndex];

                fileContentList.Add(projectString.ToString());
            }

            firstIndex = 0; lastIndex = 0;

            return fileContentList;
        }

        private List<string> GetsProjectName(List<string> fileContentList, List<string> projectNameList)
        {
            foreach (var item in fileContentList)
            {
                firstIndex = item.IndexOf("= \"") + 3;
                lastIndex = item.IndexOf("\", \"");

                string projectString = item[firstIndex..lastIndex];

                projectNameList.Add(projectString.ToString());
            }

            firstIndex = 0; lastIndex = 0;

            return projectNameList;
        }
        #endregion

    }
}
