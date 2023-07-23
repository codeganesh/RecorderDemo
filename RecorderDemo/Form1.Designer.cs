
namespace RecorderDemo
{
    partial class Form1
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
            PlaybackDeviceComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            RecordingDeviceComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            RecordButton = new System.Windows.Forms.Button();
            StopButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // PlaybackDeviceComboBox
            // 
            PlaybackDeviceComboBox.FormattingEnabled = true;
            PlaybackDeviceComboBox.Location = new System.Drawing.Point(269, 211);
            PlaybackDeviceComboBox.Name = "PlaybackDeviceComboBox";
            PlaybackDeviceComboBox.Size = new System.Drawing.Size(397, 28);
            PlaybackDeviceComboBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(81, 214);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 20);
            label2.TabIndex = 6;
            label2.Text = "Playback Device";
            // 
            // RecordingDeviceComboBox
            // 
            RecordingDeviceComboBox.FormattingEnabled = true;
            RecordingDeviceComboBox.Location = new System.Drawing.Point(269, 124);
            RecordingDeviceComboBox.Name = "RecordingDeviceComboBox";
            RecordingDeviceComboBox.Size = new System.Drawing.Size(397, 28);
            RecordingDeviceComboBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(71, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 20);
            label1.TabIndex = 4;
            label1.Text = "Recording Device";
            // 
            // RecordButton
            // 
            RecordButton.Location = new System.Drawing.Point(269, 328);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new System.Drawing.Size(107, 44);
            RecordButton.TabIndex = 8;
            RecordButton.Text = "Record";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += RecordButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new System.Drawing.Point(425, 328);
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size(107, 44);
            StopButton.TabIndex = 9;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(StopButton);
            Controls.Add(RecordButton);
            Controls.Add(PlaybackDeviceComboBox);
            Controls.Add(label2);
            Controls.Add(RecordingDeviceComboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Recorder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox PlaybackDeviceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RecordingDeviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button StopButton;
    }
}

