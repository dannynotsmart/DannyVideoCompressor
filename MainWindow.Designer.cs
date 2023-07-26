namespace DannyRocko5976
{
    partial class MainWindow
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
            this.chooseInputVideoLabel = new System.Windows.Forms.Label();
            this.chooseInputVideoButton = new System.Windows.Forms.Button();
            this.chooseOutputFolderButton = new System.Windows.Forms.Button();
            this.chooseOutputFolderLabel = new System.Windows.Forms.Label();
            this.selectedInputVideoPathLabel = new System.Windows.Forms.Label();
            this.originalSizeLabel = new System.Windows.Forms.Label();
            this.outputFolderPathLabel = new System.Windows.Forms.Label();
            this.selectedVideoPathTextbox = new System.Windows.Forms.TextBox();
            this.originalVideoSizeTextbox = new System.Windows.Forms.TextBox();
            this.outputFolderPathTextbox = new System.Windows.Forms.TextBox();
            this.compressedSizeLabel = new System.Windows.Forms.Label();
            this.eightMB = new System.Windows.Forms.RadioButton();
            this.twentyfiveMB = new System.Windows.Forms.RadioButton();
            this.fiftyMB = new System.Windows.Forms.RadioButton();
            this.hundredMB = new System.Windows.Forms.RadioButton();
            this.compressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseInputVideoLabel
            // 
            this.chooseInputVideoLabel.AutoSize = true;
            this.chooseInputVideoLabel.Location = new System.Drawing.Point(12, 13);
            this.chooseInputVideoLabel.Name = "chooseInputVideoLabel";
            this.chooseInputVideoLabel.Size = new System.Drawing.Size(200, 28);
            this.chooseInputVideoLabel.TabIndex = 0;
            this.chooseInputVideoLabel.Text = "Choose Input Video:";
            // 
            // chooseInputVideoButton
            // 
            this.chooseInputVideoButton.AllowDrop = true;
            this.chooseInputVideoButton.Location = new System.Drawing.Point(239, 9);
            this.chooseInputVideoButton.Name = "chooseInputVideoButton";
            this.chooseInputVideoButton.Size = new System.Drawing.Size(321, 37);
            this.chooseInputVideoButton.TabIndex = 1;
            this.chooseInputVideoButton.Text = "CHOOSE";
            this.chooseInputVideoButton.UseVisualStyleBackColor = true;
            this.chooseInputVideoButton.Click += new System.EventHandler(this.chooseInputVideoButton_Click);
            // 
            // chooseOutputFolderButton
            // 
            this.chooseOutputFolderButton.AllowDrop = true;
            this.chooseOutputFolderButton.Location = new System.Drawing.Point(239, 59);
            this.chooseOutputFolderButton.Name = "chooseOutputFolderButton";
            this.chooseOutputFolderButton.Size = new System.Drawing.Size(321, 37);
            this.chooseOutputFolderButton.TabIndex = 3;
            this.chooseOutputFolderButton.Text = "CHOOSE";
            this.chooseOutputFolderButton.UseVisualStyleBackColor = true;
            this.chooseOutputFolderButton.Click += new System.EventHandler(this.chooseOutputFolderButton_Click);
            // 
            // chooseOutputFolderLabel
            // 
            this.chooseOutputFolderLabel.AutoSize = true;
            this.chooseOutputFolderLabel.Location = new System.Drawing.Point(12, 63);
            this.chooseOutputFolderLabel.Name = "chooseOutputFolderLabel";
            this.chooseOutputFolderLabel.Size = new System.Drawing.Size(221, 28);
            this.chooseOutputFolderLabel.TabIndex = 4;
            this.chooseOutputFolderLabel.Text = "Choose Output Folder:";
            // 
            // selectedInputVideoPathLabel
            // 
            this.selectedInputVideoPathLabel.AutoSize = true;
            this.selectedInputVideoPathLabel.Location = new System.Drawing.Point(12, 116);
            this.selectedInputVideoPathLabel.Name = "selectedInputVideoPathLabel";
            this.selectedInputVideoPathLabel.Size = new System.Drawing.Size(205, 28);
            this.selectedInputVideoPathLabel.TabIndex = 5;
            this.selectedInputVideoPathLabel.Text = "Selected Video Path:";
            // 
            // originalSizeLabel
            // 
            this.originalSizeLabel.AutoSize = true;
            this.originalSizeLabel.Location = new System.Drawing.Point(12, 154);
            this.originalSizeLabel.Name = "originalSizeLabel";
            this.originalSizeLabel.Size = new System.Drawing.Size(272, 28);
            this.originalSizeLabel.TabIndex = 6;
            this.originalSizeLabel.Text = "Original Video Size (in MB):";
            // 
            // outputFolderPathLabel
            // 
            this.outputFolderPathLabel.AutoSize = true;
            this.outputFolderPathLabel.Location = new System.Drawing.Point(12, 192);
            this.outputFolderPathLabel.Name = "outputFolderPathLabel";
            this.outputFolderPathLabel.Size = new System.Drawing.Size(194, 28);
            this.outputFolderPathLabel.TabIndex = 7;
            this.outputFolderPathLabel.Text = "Output Folder Path:";
            // 
            // selectedVideoPathTextbox
            // 
            this.selectedVideoPathTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.selectedVideoPathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedVideoPathTextbox.Location = new System.Drawing.Point(239, 116);
            this.selectedVideoPathTextbox.Name = "selectedVideoPathTextbox";
            this.selectedVideoPathTextbox.ReadOnly = true;
            this.selectedVideoPathTextbox.Size = new System.Drawing.Size(321, 28);
            this.selectedVideoPathTextbox.TabIndex = 8;
            this.selectedVideoPathTextbox.WordWrap = false;
            // 
            // originalVideoSizeTextbox
            // 
            this.originalVideoSizeTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.originalVideoSizeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.originalVideoSizeTextbox.Location = new System.Drawing.Point(290, 154);
            this.originalVideoSizeTextbox.Name = "originalVideoSizeTextbox";
            this.originalVideoSizeTextbox.ReadOnly = true;
            this.originalVideoSizeTextbox.Size = new System.Drawing.Size(270, 28);
            this.originalVideoSizeTextbox.TabIndex = 9;
            this.originalVideoSizeTextbox.WordWrap = false;
            // 
            // outputFolderPathTextbox
            // 
            this.outputFolderPathTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.outputFolderPathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputFolderPathTextbox.Location = new System.Drawing.Point(212, 192);
            this.outputFolderPathTextbox.Name = "outputFolderPathTextbox";
            this.outputFolderPathTextbox.ReadOnly = true;
            this.outputFolderPathTextbox.Size = new System.Drawing.Size(348, 28);
            this.outputFolderPathTextbox.TabIndex = 10;
            this.outputFolderPathTextbox.WordWrap = false;
            // 
            // compressedSizeLabel
            // 
            this.compressedSizeLabel.AutoSize = true;
            this.compressedSizeLabel.Location = new System.Drawing.Point(12, 242);
            this.compressedSizeLabel.Name = "compressedSizeLabel";
            this.compressedSizeLabel.Size = new System.Drawing.Size(179, 28);
            this.compressedSizeLabel.TabIndex = 11;
            this.compressedSizeLabel.Text = "Compressed Size:";
            // 
            // eightMB
            // 
            this.eightMB.AutoSize = true;
            this.eightMB.Enabled = false;
            this.eightMB.Location = new System.Drawing.Point(197, 238);
            this.eightMB.Name = "eightMB";
            this.eightMB.Size = new System.Drawing.Size(76, 32);
            this.eightMB.TabIndex = 12;
            this.eightMB.TabStop = true;
            this.eightMB.Text = "8MB";
            this.eightMB.UseVisualStyleBackColor = true;
            this.eightMB.CheckedChanged += new System.EventHandler(this.eightMB_CheckedChanged);
            // 
            // twentyfiveMB
            // 
            this.twentyfiveMB.AutoSize = true;
            this.twentyfiveMB.Enabled = false;
            this.twentyfiveMB.Location = new System.Drawing.Point(279, 238);
            this.twentyfiveMB.Name = "twentyfiveMB";
            this.twentyfiveMB.Size = new System.Drawing.Size(88, 32);
            this.twentyfiveMB.TabIndex = 13;
            this.twentyfiveMB.TabStop = true;
            this.twentyfiveMB.Text = "25MB";
            this.twentyfiveMB.UseVisualStyleBackColor = true;
            this.twentyfiveMB.CheckedChanged += new System.EventHandler(this.twentyfiveMB_CheckedChanged);
            // 
            // fiftyMB
            // 
            this.fiftyMB.AutoSize = true;
            this.fiftyMB.Enabled = false;
            this.fiftyMB.Location = new System.Drawing.Point(373, 238);
            this.fiftyMB.Name = "fiftyMB";
            this.fiftyMB.Size = new System.Drawing.Size(88, 32);
            this.fiftyMB.TabIndex = 14;
            this.fiftyMB.TabStop = true;
            this.fiftyMB.Text = "50MB";
            this.fiftyMB.UseVisualStyleBackColor = true;
            this.fiftyMB.CheckedChanged += new System.EventHandler(this.fiftyMB_CheckedChanged);
            // 
            // hundredMB
            // 
            this.hundredMB.AutoSize = true;
            this.hundredMB.Enabled = false;
            this.hundredMB.Location = new System.Drawing.Point(467, 238);
            this.hundredMB.Name = "hundredMB";
            this.hundredMB.Size = new System.Drawing.Size(97, 32);
            this.hundredMB.TabIndex = 16;
            this.hundredMB.TabStop = true;
            this.hundredMB.Text = "100MB";
            this.hundredMB.UseVisualStyleBackColor = true;
            this.hundredMB.CheckedChanged += new System.EventHandler(this.hundredMB_CheckedChanged);
            // 
            // compressButton
            // 
            this.compressButton.Enabled = false;
            this.compressButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compressButton.Location = new System.Drawing.Point(12, 293);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(552, 108);
            this.compressButton.TabIndex = 17;
            this.compressButton.Text = "Compress Video";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 418);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.hundredMB);
            this.Controls.Add(this.fiftyMB);
            this.Controls.Add(this.twentyfiveMB);
            this.Controls.Add(this.eightMB);
            this.Controls.Add(this.compressedSizeLabel);
            this.Controls.Add(this.outputFolderPathTextbox);
            this.Controls.Add(this.originalVideoSizeTextbox);
            this.Controls.Add(this.selectedVideoPathTextbox);
            this.Controls.Add(this.outputFolderPathLabel);
            this.Controls.Add(this.originalSizeLabel);
            this.Controls.Add(this.selectedInputVideoPathLabel);
            this.Controls.Add(this.chooseOutputFolderLabel);
            this.Controls.Add(this.chooseOutputFolderButton);
            this.Controls.Add(this.chooseInputVideoButton);
            this.Controls.Add(this.chooseInputVideoLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Video Compressor LOL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label chooseInputVideoLabel;
        private Button chooseInputVideoButton;
        private Button chooseOutputFolderButton;
        private Label chooseOutputFolderLabel;
        private Label selectedInputVideoPathLabel;
        private Label originalSizeLabel;
        private Label outputFolderPathLabel;
        private TextBox selectedVideoPathTextbox;
        private TextBox originalVideoSizeTextbox;
        private TextBox outputFolderPathTextbox;
        private Label compressedSizeLabel;
        private RadioButton eightMB;
        private RadioButton twentyfiveMB;
        private RadioButton fiftyMB;
        private RadioButton hundredMB;
        private Button compressButton;
    }
}