namespace CaseForJob
{
    partial class WorkerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.amountOfMinutesTextBox = new System.Windows.Forms.TextBox();
            this.imagesPerMinuteLabel = new System.Windows.Forms.Label();
            this.amountOfImagesTextBox = new System.Windows.Forms.TextBox();
            this.amountOfImagesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(59, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Worker name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(197, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 238);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(197, 48);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // amountOfMinutesTextBox
            // 
            this.amountOfMinutesTextBox.Location = new System.Drawing.Point(6, 191);
            this.amountOfMinutesTextBox.Name = "amountOfMinutesTextBox";
            this.amountOfMinutesTextBox.Size = new System.Drawing.Size(197, 22);
            this.amountOfMinutesTextBox.TabIndex = 4;
            // 
            // imagesPerMinuteLabel
            // 
            this.imagesPerMinuteLabel.AutoSize = true;
            this.imagesPerMinuteLabel.Location = new System.Drawing.Point(12, 162);
            this.imagesPerMinuteLabel.Name = "imagesPerMinuteLabel";
            this.imagesPerMinuteLabel.Size = new System.Drawing.Size(181, 16);
            this.imagesPerMinuteLabel.TabIndex = 3;
            this.imagesPerMinuteLabel.Text = "Amount of minutes for images";
            // 
            // amountOfImagesTextBox
            // 
            this.amountOfImagesTextBox.Location = new System.Drawing.Point(6, 124);
            this.amountOfImagesTextBox.Name = "amountOfImagesTextBox";
            this.amountOfImagesTextBox.Size = new System.Drawing.Size(197, 22);
            this.amountOfImagesTextBox.TabIndex = 6;
            // 
            // amountOfImagesLabel
            // 
            this.amountOfImagesLabel.AutoSize = true;
            this.amountOfImagesLabel.Location = new System.Drawing.Point(42, 94);
            this.amountOfImagesLabel.Name = "amountOfImagesLabel";
            this.amountOfImagesLabel.Size = new System.Drawing.Size(114, 16);
            this.amountOfImagesLabel.TabIndex = 5;
            this.amountOfImagesLabel.Text = "Amount of images";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 300);
            this.Controls.Add(this.amountOfImagesTextBox);
            this.Controls.Add(this.amountOfImagesLabel);
            this.Controls.Add(this.amountOfMinutesTextBox);
            this.Controls.Add(this.imagesPerMinuteLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox amountOfMinutesTextBox;
        private System.Windows.Forms.Label imagesPerMinuteLabel;
        private System.Windows.Forms.TextBox amountOfImagesTextBox;
        private System.Windows.Forms.Label amountOfImagesLabel;
    }
}