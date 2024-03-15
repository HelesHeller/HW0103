using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW0103
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            searchButton.Click += SearchButton_Click;
            stopButton.Click += StopButton_Click;

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                directoryComboBox.Items.Add(drive.Name);
            }
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            outputListView.Items.Clear();

            cancellationTokenSource?.Cancel();
            cancellationTokenSource = new CancellationTokenSource();

            string searchMask = fileTextBox.Text.Trim();
            string keyword = keyWordSearchTextBox.Text.Trim();
            string selectedDirectory = directoryComboBox.SelectedItem as string;
            bool searchSubdirectories = subdirectoryCheckBox.Checked;

            if (string.IsNullOrEmpty(selectedDirectory))
            {
                MessageBox.Show("Выберите диск для поиска.");
                return;
            }

            await Task.Run(() => PerformSearch(selectedDirectory, searchMask, keyword, searchSubdirectories, cancellationTokenSource.Token));
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private void PerformSearch(string directory, string searchMask, string keyword, bool searchSubdirectories, CancellationToken cancellationToken)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(directory);
                SearchOption searchOption = searchSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                FileInfo[] files = dirInfo.GetFiles(searchMask, searchOption);

                UpdateSearchResults(files, cancellationToken);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Ошибка доступа: {ex.Message}");
            }
        }

        private async void UpdateSearchResults(FileInfo[] files, CancellationToken cancellationToken)
        {
            foreach (FileInfo file in files)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.FullName);
                item.SubItems.Add(file.Length.ToString());
                item.SubItems.Add(file.CreationTime.ToString());
                outputListView.Items.Add(item);

                await Task.Delay(100);
            }

            Invoke(new Action(() => resultLabel.Text = "Результаты поиска: " + files.Length));
        }
    }
}