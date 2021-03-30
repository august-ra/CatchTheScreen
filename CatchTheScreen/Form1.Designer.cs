
namespace CatchTheScreen
{
    partial class FishingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FishingForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.scaleTrackBar = new System.Windows.Forms.TrackBar();
            this.incButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.imageForButtons = new System.Windows.Forms.ImageList(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.timeoutComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 395);
            this.mainPanel.TabIndex = 1;
            // 
            // scaleTrackBar
            // 
            this.scaleTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleTrackBar.LargeChange = 1;
            this.scaleTrackBar.Location = new System.Drawing.Point(557, 413);
            this.scaleTrackBar.Maximum = 9;
            this.scaleTrackBar.Name = "scaleTrackBar";
            this.scaleTrackBar.Size = new System.Drawing.Size(200, 45);
            this.scaleTrackBar.TabIndex = 2;
            this.scaleTrackBar.Value = 2;
            this.scaleTrackBar.Scroll += new System.EventHandler(this.scaleTrackBar_Scroll);
            // 
            // incButton
            // 
            this.incButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.incButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.incButton.Location = new System.Drawing.Point(763, 413);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(25, 25);
            this.incButton.TabIndex = 3;
            this.incButton.Text = "+";
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // decButton
            // 
            this.decButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decButton.Location = new System.Drawing.Point(526, 413);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(25, 25);
            this.decButton.TabIndex = 4;
            this.decButton.Text = "−";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // scaleLabel
            // 
            this.scaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scaleLabel.Location = new System.Drawing.Point(468, 413);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(52, 25);
            this.scaleLabel.TabIndex = 5;
            this.scaleLabel.Text = "100%";
            this.scaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ImageIndex = 0;
            this.createButton.ImageList = this.imageForButtons;
            this.createButton.Location = new System.Drawing.Point(12, 413);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(25, 25);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "−";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // imageForButtons
            // 
            this.imageForButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageForButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageForButtons.ImageStream")));
            this.imageForButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageForButtons.Images.SetKeyName(0, "0_create.png");
            this.imageForButtons.Images.SetKeyName(1, "1_open.png");
            this.imageForButtons.Images.SetKeyName(2, "2_save.png");
            this.imageForButtons.Images.SetKeyName(3, "5_cut.png");
            this.imageForButtons.Images.SetKeyName(4, "6_copy.png");
            this.imageForButtons.Images.SetKeyName(5, "7_paste.png");
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openButton.ImageIndex = 1;
            this.openButton.ImageList = this.imageForButtons;
            this.openButton.Location = new System.Drawing.Point(43, 413);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(25, 25);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "−";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ImageIndex = 2;
            this.saveButton.ImageList = this.imageForButtons;
            this.saveButton.Location = new System.Drawing.Point(74, 413);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(25, 25);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "−";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyButton.ImageIndex = 4;
            this.copyButton.ImageList = this.imageForButtons;
            this.copyButton.Location = new System.Drawing.Point(114, 413);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(25, 25);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "−";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pasteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pasteButton.ImageIndex = 5;
            this.pasteButton.ImageList = this.imageForButtons;
            this.pasteButton.Location = new System.Drawing.Point(145, 413);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(25, 25);
            this.pasteButton.TabIndex = 10;
            this.pasteButton.Text = "−";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(199, 419);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(152, 15);
            this.timeoutLabel.TabIndex = 11;
            this.timeoutLabel.Text = "Пауза перед скриншотом:";
            // 
            // timeoutComboBox
            // 
            this.timeoutComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeoutComboBox.FormattingEnabled = true;
            this.timeoutComboBox.Items.AddRange(new object[] {
            "Нет",
            "1 сек.",
            "2 сек.",
            "3 сек.",
            "4 сек.",
            "5 сек."});
            this.timeoutComboBox.Location = new System.Drawing.Point(357, 415);
            this.timeoutComboBox.Name = "timeoutComboBox";
            this.timeoutComboBox.Size = new System.Drawing.Size(88, 23);
            this.timeoutComboBox.TabIndex = 12;
            // 
            // FishingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeoutComboBox);
            this.Controls.Add(this.timeoutLabel);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.scaleTrackBar);
            this.Controls.Add(this.mainPanel);
            this.Name = "FishingForm";
            this.Text = "Обработка скриншота";
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TrackBar scaleTrackBar;
        private System.Windows.Forms.Button incButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ImageList imageForButtons;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.ComboBox timeoutComboBox;
    }
}

