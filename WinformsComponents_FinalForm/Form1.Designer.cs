namespace WinformsComponents_FinalForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.targedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visibleButton = new System.Windows.Forms.Button();
            this.OptionsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.enabledButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targedButton
            // 
            this.targedButton.AccessibleName = "targedButton";
            this.targedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.targedButton.Location = new System.Drawing.Point(1, 0);
            this.targedButton.Name = "targedButton";
            this.targedButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.targedButton.Size = new System.Drawing.Size(100, 100);
            this.targedButton.TabIndex = 0;
            this.targedButton.Text = "Target \r\nX = 0 \r\nY = 0";
            this.targedButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.enabledButton);
            this.groupBox1.Controls.Add(this.visibleButton);
            this.groupBox1.Controls.Add(this.OptionsBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(572, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // visibleButton
            // 
            this.visibleButton.Location = new System.Drawing.Point(33, 140);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(140, 30);
            this.visibleButton.TabIndex = 1;
            this.visibleButton.Text = "Visible = True";
            this.visibleButton.UseVisualStyleBackColor = true;
            this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
            // 
            // OptionsBox
            // 
            this.OptionsBox.FormattingEnabled = true;
            this.OptionsBox.Items.AddRange(new object[] {
            "FixedSingle",
            "Fixed3D",
            "FixedDialog",
            "Sizable",
            "FixedToolWindow",
            "SizableToolWindow",
            "None"});
            this.OptionsBox.Location = new System.Drawing.Point(33, 45);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(140, 23);
            this.OptionsBox.TabIndex = 0;
            this.OptionsBox.SelectedIndexChanged += new System.EventHandler(this.OptionsBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(119, 16);
            this.formSizeLabel.TabIndex = 3;
            this.formSizeLabel.Text = "Form Size: 800 600";
            // 
            // enabledButton
            // 
            this.enabledButton.Location = new System.Drawing.Point(33, 208);
            this.enabledButton.Name = "enabledButton";
            this.enabledButton.Size = new System.Drawing.Size(140, 30);
            this.enabledButton.TabIndex = 2;
            this.enabledButton.Text = "Enabled = True";
            this.enabledButton.UseVisualStyleBackColor = true;
            this.enabledButton.Click += new System.EventHandler(this.enabledButton_Click);
            // 
            // MainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targedButton);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label formSizeLabel;
        private System.Windows.Forms.ComboBox OptionsBox;
        private System.Windows.Forms.Button visibleButton;
        private System.Windows.Forms.Button enabledButton;
    }
}

