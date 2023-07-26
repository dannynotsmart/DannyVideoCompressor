using System.Diagnostics;
using System.Text;

namespace DannyRocko5976
{
    public partial class MainWindow : Form
    {
        private static readonly Random random = new Random();
        private bool compressing = false;
        private double chosenSize = 0;

        public MainWindow()
        {
            InitializeComponent();
            SetupDragAndDropEventHandlers();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (compressing) {
                e.Cancel = true;
                ShowErrorMessageBox("You are compressing something right now... don't close the app.");
            }
        }
        private void SetupDragAndDropEventHandlers()
        {
            chooseInputVideoButton.DragEnter += (sender, e) => HandleDragEnter(e);
            chooseInputVideoButton.DragDrop += (sender, e) => HandleDragDrop(e, selectedVideoPathTextbox, true);

            chooseOutputFolderButton.DragEnter += (sender, e) => HandleDragEnter(e);
            chooseOutputFolderButton.DragDrop += (sender, e) => HandleDragDrop(e, outputFolderPathTextbox, false);
        }

        private void HandleDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void HandleDragDrop(DragEventArgs e, TextBox targetTextbox, bool isVideoPath)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string filePath = files[0];

                targetTextbox.Text = filePath;

                if (isVideoPath)
                {
                    double fileSizeInMB = GetFileSizeInMB(filePath);

                    if (fileSizeInMB > 8)
                    {
                        originalVideoSizeTextbox.Text = fileSizeInMB.ToString();
                        eightMB.Enabled = fileSizeInMB > 8;
                        twentyfiveMB.Enabled = fileSizeInMB > 25;
                        fiftyMB.Enabled = fileSizeInMB > 50;
                        hundredMB.Enabled = fileSizeInMB > 100;
                    }
                    else
                    {
                        selectedVideoPathTextbox.Clear();
                        originalVideoSizeTextbox.Clear();
                        eightMB.Enabled = twentyfiveMB.Enabled = fiftyMB.Enabled = hundredMB.Enabled = false;
                        eightMB.Checked = twentyfiveMB.Checked = fiftyMB.Checked = hundredMB.Checked = false;
                        ShowErrorMessageBox("Dude... that video is less than 8MB already.");
                    }
                }

                canICompressNowLOL();
            }
        }

        private double GetFileSizeInMB(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                return (double)fileInfo.Length / (1024 * 1024);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }

        private void chooseInputVideoButton_Click(object sender, EventArgs e)
        {
            string videoFilePath = GetFilePathWithDialog("Video files (*.mp4;*.avi;*.mkv;*.wmv)|*.mp4;*.avi;*.mkv;*.wmv|All files (*.*)|*.*");
            if (!string.IsNullOrEmpty(videoFilePath))
            {
                double fileSizeInMB = GetFileSizeInMB(videoFilePath);

                selectedVideoPathTextbox.Text = videoFilePath;
                originalVideoSizeTextbox.Text = fileSizeInMB.ToString();

                eightMB.Enabled = fileSizeInMB > 8;
                twentyfiveMB.Enabled = fileSizeInMB > 25;
                fiftyMB.Enabled = fileSizeInMB > 50;
                hundredMB.Enabled = fileSizeInMB > 100;

                canICompressNowLOL();
            }
            else
            {
                selectedVideoPathTextbox.Clear();
                originalVideoSizeTextbox.Clear();
                eightMB.Enabled = twentyfiveMB.Enabled = fiftyMB.Enabled = hundredMB.Enabled = false;
                eightMB.Checked = twentyfiveMB.Checked = fiftyMB.Checked = hundredMB.Checked = false;
            }
        }

        private void chooseOutputFolderButton_Click(object sender, EventArgs e)
        {
            string selectedFolderPath = GetFolderPathWithDialog();
            if (!string.IsNullOrEmpty(selectedFolderPath))
                outputFolderPathTextbox.Text = selectedFolderPath;

            canICompressNowLOL();
        }

        private string GetFilePathWithDialog(string filter = null)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = filter ?? "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
            }
        }

        private string GetFolderPathWithDialog()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder LOL!";
                folderBrowserDialog.ShowNewFolderButton = false;

                return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : null;
            }
        }

        private void eightMB_CheckedChanged(object sender, EventArgs e) => UpdateChosenSize(8);

        private void twentyfiveMB_CheckedChanged(object sender, EventArgs e) => UpdateChosenSize(25);

        private void fiftyMB_CheckedChanged(object sender, EventArgs e) => UpdateChosenSize(50);

        private void hundredMB_CheckedChanged(object sender, EventArgs e) => UpdateChosenSize(100);

        private void UpdateChosenSize(double size)
        {
            chosenSize = size;
            canICompressNowLOL();
        }

        private bool IsFfmpegInPath()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = "-version",
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();
                process.WaitForExit();

                return process.ExitCode == 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            if (!IsFfmpegInPath())
            {
                ShowErrorMessageBox("FFmpeg is not in Path. Install FFmpeg by following this link: https://phoenixnap.com/kb/ffmpeg-windows");
                return;
            }

            bool status = canICompressNowLOL();
            if (!status)
            {
                ShowErrorMessageBox("For some reason, you can't compress just yet! Check something!");
                return;
            }

            if (chosenSize == 0)
            {
                ShowErrorMessageBox("Dude your chosen compression size is 0 MB HOW?!");
                return;
            }

            if (compressing)
            {
                ShowErrorMessageBox("Dude you already are compressing something right now WAIT!");
                return;
            }

            compressing = true;
            compressButton.Enabled = false;
            compressButton.Text = "Compressing!";

            string inputFilePath = selectedVideoPathTextbox.Text;
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFilePath);
            string outputFilePath = $"{outputFolderPathTextbox.Text}\\{fileNameWithoutExtension}_compressed_to_{chosenSize}mb_LOL{random.Next(1, 101)}.mp4";
            long desiredFileSizeInBytes = (long)chosenSize * 1024 * 1024;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CompressVideoToDesiredFileSize(inputFilePath, outputFilePath, desiredFileSizeInBytes);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            compressing = false;
            compressButton.Text = "Compress Video";

            canICompressNowLOL();

            double fileSizeInMB = GetFileSizeInMB(outputFilePath);
            Process.Start("explorer.exe", Path.GetDirectoryName(outputFilePath));
            ShowSuccessMessageBox($"I think the compression is complete... The new file is: {outputFilePath}.\nEstimated new filesize is: {fileSizeInMB}MB LOL! Compression took: {elapsedTime.TotalSeconds} seconds.");
        }

        private void CompressVideoToDesiredFileSize(string inputFilePath, string outputFilePath, long desiredFileSizeInBytes)
        {
            try
            {
                string ffmpegArgs = $"-i \"{inputFilePath}\" -c:v libx264 -crf 23 -preset medium -vf scale=1280:-2 -c:a aac -b:a 128k \"{outputFilePath}\"";
                RunFFmpegProcess(ffmpegArgs);

                long compressedFileSize = new FileInfo(outputFilePath).Length;

                while (compressedFileSize > desiredFileSizeInBytes)
                {
                    string lowerCRFArgs = $"-i \"{outputFilePath}\" -c:v libx264 -crf 18 -preset medium -vf scale=1280:-2 -c:a aac -b:a 128k \"{outputFilePath}\"";
                    RunFFmpegProcess(lowerCRFArgs);

                    compressedFileSize = new FileInfo(outputFilePath).Length;
                }
            }
            catch (Exception ex)
            {
                // ShowErrorMessageBox("Error during video compression: " + ex.Message);
                Console.WriteLine("Error during video compression: " + ex.Message);
            }
        }

        private void RunFFmpegProcess(string args)
        {
            using Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = args,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            StringBuilder outputBuilder = new StringBuilder();
            StringBuilder errorBuilder = new StringBuilder();

            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    outputBuilder.AppendLine(e.Data);
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    errorBuilder.AppendLine(e.Data);
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            string output = outputBuilder.ToString();
            string error = errorBuilder.ToString();

            if (!string.IsNullOrEmpty(error))
            {
                // ShowErrorMessageBox("Error during video compression: " + error);
                throw new InvalidOperationException("Error during video compression: " + error);
            }
        }

        private void ShowErrorMessageBox(string text)
        {
            MessageBox.Show(text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessageBox(string text) {
            MessageBox.Show(text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool canICompressNowLOL()
        {
            bool canCompress = !compressing && !string.IsNullOrEmpty(selectedVideoPathTextbox.Text) &&
                               !string.IsNullOrEmpty(outputFolderPathTextbox.Text) &&
                               (eightMB.Checked || twentyfiveMB.Checked || fiftyMB.Checked || hundredMB.Checked);

            compressButton.Enabled = canCompress;
            return canCompress;
        }
    }
}