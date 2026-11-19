using System.Diagnostics;
using System.Text;
using WMPLib;

namespace TextToSpeechConverter
{
    public partial class frmTextToSpeech : Form
    {
        public frmTextToSpeech()
        {
            InitializeComponent();
        }

        private void GenerateSpeech()
        {
            ProcessStartInfo startInfo =
                new ProcessStartInfo();

            startInfo.FileName =
                "python";

            startInfo.Arguments =
                $"PythonScripts\\text_to_speech.py " +
                $"\"{txtFilePath.Text}\" " +
                $"\"{cmbLanguage.Text}\"";

            startInfo.UseShellExecute = false;

            startInfo.RedirectStandardOutput = true;

            startInfo.RedirectStandardError = true;

            startInfo.CreateNoWindow = true;


            using Process process =
                Process.Start(startInfo);

            string output =
                process.StandardOutput.ReadToEnd();

            string error =
                process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show(output);
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            GenerateSpeech();

            txtMp3Path.Text =
                Path.Combine(
                    Application.StartupPath,
                    "speech.mp3");

            PlayAudio();

            lblStatus.Text =
                "MP3 Generated Successfully";
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Filter =
                "Text Files (*.txt)|*.txt";

            if (dialog.ShowDialog()
               == DialogResult.OK)
            {
                txtFilePath.Text =
                    dialog.FileName;

                rtbTextPreview.Text =
                    File.ReadAllText(
                        dialog.FileName);

                rtbTextPreview.Text = File.ReadAllText(dialog.FileName);

                AnalyzeText();

                lblStatus.Text =
                    "File Loaded Successfully";
            }
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Audio Player Coming Soon"
            );
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Save Feature Coming Soon"
            );
        }
        private readonly WindowsMediaPlayer player =
    new WindowsMediaPlayer();

        private void PlayAudio()
        {
            string mp3Path =
                Path.Combine(
                    Application.StartupPath,
                    "speech.mp3");

            if (!File.Exists(mp3Path))
            {
                MessageBox.Show(
                    "MP3 file not found."
                );
                return;
            }

            player.URL = mp3Path;

            player.controls.play();

            lblStatus.Text =
                "Playing audio...";
        }

        private void btnPlay_Click(
    object sender,
    EventArgs e)
        {
            PlayAudio();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();

            lblStatus.Text =
                "Audio stopped.";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();

            lblStatus.Text =
                "Audio paused.";
        }

        private void AnalyzeText()
        {
            string text =
                rtbTextPreview.Text;

            int characterCount =
                text.Length;

            int wordCount =
                text.Split(
                    new[]
                    {
                ' ',
                '\n',
                '\r',
                '\t'
                    },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Length;

            int lineCount =
                rtbTextPreview.Lines.Length;

            double estimatedMinutes =
                wordCount / 150.0;

            double estimatedSeconds =
                estimatedMinutes * 60;

            lblCharacters.Text =
                $"Characters: {characterCount}";

            lblWords.Text =
                $"Words: {wordCount}";

            lblLines.Text =
                $"Lines: {lineCount}";

            lblDuration.Text =
                $"Duration: {estimatedSeconds:F0} sec";
        }

        private void rtbTextPreview_TextChanged(object sender, EventArgs e)
        {
            AnalyzeText();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text =
                "Listening...";

            StartRecognition();

            lblStatus.Text =
                "Recognition Complete";
        }

        private Process speechProcess;


        private void StartRecognition()
        {
            ProcessStartInfo psi = new();

            psi.FileName = "python";

            psi.Arguments =
                "PythonScripts\\live_speech.py";

            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;

            // IMPORTANT: Enable UTF-8 communication
            psi.StandardOutputEncoding = Encoding.UTF8;
            psi.StandardErrorEncoding = Encoding.UTF8;

            using Process process = new();

            process.StartInfo = psi;
            process.Start();

            // Read both streams concurrently
            Task<string> outputTask =
                process.StandardOutput.ReadToEndAsync();

            Task<string> errorTask =
                process.StandardError.ReadToEndAsync();

            process.WaitForExit();

            string output = outputTask.GetAwaiter().GetResult();
            string error = errorTask.GetAwaiter().GetResult();

            if (process.ExitCode != 0)
            {
                MessageBox.Show(error, "Python Error");
                return;
            }

            string recognizedText = "";

            int startIndex = output.IndexOf("RESULT_START");

            if (startIndex >= 0)
            {
                recognizedText = output.Substring(
                    startIndex + "RESULT_START".Length
                ).Trim();
            }

            rtbSpeechOutput.Text = recognizedText;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            speechProcess?.Kill();
            lblStatus.Text = "Stopped";
        }

        private void btnSaveTranscript_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog =
                new SaveFileDialog();

            dialog.Filter =
                "Text File (*.txt)|*.txt";

            dialog.FileName =
                $"Transcript_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (dialog.ShowDialog()
                == DialogResult.OK)
            {
                File.WriteAllText(
    dialog.FileName,
    rtbSpeechOutput.Text,
    Encoding.UTF8
);
            }
        }

    }
}
