namespace TextToSpeechConverter
{
    partial class frmTextToSpeech
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            label = new Label();
            cmbLanguage = new ComboBox();
            label2 = new Label();
            rtbTextPreview = new RichTextBox();
            label3 = new Label();
            txtMp3Path = new TextBox();
            btnConvert = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnPlay = new Button();
            btnSave = new Button();
            lblStatus = new Label();
            btnStop = new Button();
            btnPause = new Button();
            lblCharacters = new Label();
            lblWords = new Label();
            lblLines = new Label();
            lblDuration = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            rtbSpeechOutput = new RichTextBox();
            btnClear = new Button();
            btnSaveTranscript = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Text File";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(27, 47);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(249, 23);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(293, 47);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(27, 88);
            label.Name = "label";
            label.Size = new Size(59, 15);
            label.TabIndex = 3;
            label.Text = "Language";
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "English", "Nepali", "Japanese" });
            cmbLanguage.Location = new Point(27, 106);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(121, 23);
            cmbLanguage.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 152);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "File Contents";
            // 
            // rtbTextPreview
            // 
            rtbTextPreview.Location = new Point(27, 152);
            rtbTextPreview.Name = "rtbTextPreview";
            rtbTextPreview.Size = new Size(408, 250);
            rtbTextPreview.TabIndex = 6;
            rtbTextPreview.Text = "";
            rtbTextPreview.TextChanged += rtbTextPreview_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 447);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 7;
            label3.Text = "Generated Audio";
            // 
            // txtMp3Path
            // 
            txtMp3Path.Location = new Point(27, 465);
            txtMp3Path.Name = "txtMp3Path";
            txtMp3Path.ReadOnly = true;
            txtMp3Path.Size = new Size(163, 23);
            txtMp3Path.TabIndex = 8;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(27, 494);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(121, 23);
            btnConvert.TabIndex = 9;
            btnConvert.Text = "Convert To MP3";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(170, 494);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 11;
            btnPlay.Text = "Play Audio";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(452, 494);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save MP3";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(27, 548);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Ready";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(263, 494);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 14;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(360, 494);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 15;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // lblCharacters
            // 
            lblCharacters.AutoSize = true;
            lblCharacters.Location = new Point(28, 423);
            lblCharacters.Name = "lblCharacters";
            lblCharacters.Size = new Size(75, 15);
            lblCharacters.TabIndex = 16;
            lblCharacters.Text = "Characters: 0\n";
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Location = new Point(137, 423);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(53, 15);
            lblWords.TabIndex = 17;
            lblWords.Text = "Words: 0\n";
            // 
            // lblLines
            // 
            lblLines.AutoSize = true;
            lblLines.Location = new Point(246, 423);
            lblLines.Name = "lblLines";
            lblLines.Size = new Size(46, 15);
            lblLines.TabIndex = 18;
            lblLines.Text = "Lines: 0\n";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(350, 423);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(85, 15);
            lblDuration.TabIndex = 19;
            lblDuration.Text = "Duration: 0 sec";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 29);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 20;
            label4.Text = "Speech Recognition\n";
            // 
            // button1
            // 
            button1.Location = new Point(537, 64);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 21;
            button1.Text = "🎤 Start Listening";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 106);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 22;
            button2.Text = "\U0001f6d1 Stop Listening\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 176);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 23;
            label5.Text = "Recognized Text\n";
            // 
            // rtbSpeechOutput
            // 
            rtbSpeechOutput.Location = new Point(537, 204);
            rtbSpeechOutput.Name = "rtbSpeechOutput";
            rtbSpeechOutput.Size = new Size(494, 240);
            rtbSpeechOutput.TabIndex = 24;
            rtbSpeechOutput.Text = "";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(745, 64);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 23);
            btnClear.TabIndex = 25;
            btnClear.Text = "\U0001f9f9 Clear Text";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSaveTranscript
            // 
            btnSaveTranscript.Location = new Point(745, 105);
            btnSaveTranscript.Name = "btnSaveTranscript";
            btnSaveTranscript.Size = new Size(111, 23);
            btnSaveTranscript.TabIndex = 26;
            btnSaveTranscript.Text = "💾 Save Transcript";
            btnSaveTranscript.UseVisualStyleBackColor = true;
            btnSaveTranscript.Click += btnSaveTranscript_Click;
            // 
            // frmTextToSpeech
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(btnSaveTranscript);
            Controls.Add(btnClear);
            Controls.Add(rtbSpeechOutput);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(lblDuration);
            Controls.Add(lblLines);
            Controls.Add(lblWords);
            Controls.Add(lblCharacters);
            Controls.Add(btnPause);
            Controls.Add(btnStop);
            Controls.Add(lblStatus);
            Controls.Add(btnSave);
            Controls.Add(btnPlay);
            Controls.Add(btnConvert);
            Controls.Add(txtMp3Path);
            Controls.Add(label3);
            Controls.Add(rtbTextPreview);
            Controls.Add(label2);
            Controls.Add(cmbLanguage);
            Controls.Add(label);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Name = "frmTextToSpeech";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text To Speech Converter";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private Label label;
        private ComboBox cmbLanguage;
        private Label label2;
        private RichTextBox rtbTextPreview;
        private Label label3;
        private TextBox txtMp3Path;
        private Button btnConvert;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnPlay;
        private Button btnSave;
        private Label lblStatus;
        private Button btnStop;
        private Button btnPause;
        private Label lblCharacters;
        private Label lblWords;
        private Label lblLines;
        private Label lblDuration;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private RichTextBox rtbSpeechOutput;
        private Button btnClear;
        private Button btnSaveTranscript;
    }
}
