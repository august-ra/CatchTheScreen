
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
            this.createbutton = new System.Windows.Forms.Button();
            this.imageForButtons = new System.Windows.Forms.ImageList(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // createbutton
            // 
            this.createbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createbutton.ImageIndex = 0;
            this.createbutton.ImageList = this.imageForButtons;
            this.createbutton.Location = new System.Drawing.Point(12, 413);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(25, 25);
            this.createbutton.TabIndex = 6;
            this.createbutton.Text = "−";
            this.createbutton.UseVisualStyleBackColor = true;
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
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageForButtons;
            this.button3.Location = new System.Drawing.Point(74, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "−";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.imageForButtons;
            this.button4.Location = new System.Drawing.Point(105, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "−";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FishingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.createbutton);
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
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.ImageList imageForButtons;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

