namespace CaseForJob
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
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfImages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePerWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.amountOfImagesLabel = new System.Windows.Forms.Label();
            this.amountOfImagesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TotalTimeTextBox = new System.Windows.Forms.TextBox();
            this.TotalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerName,
            this.amountOfImages,
            this.amountOfMinutes,
            this.imagePerWorker});
            this.workersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.workersDataGridView.Location = new System.Drawing.Point(0, 209);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.RowHeadersWidth = 51;
            this.workersDataGridView.RowTemplate.Height = 24;
            this.workersDataGridView.Size = new System.Drawing.Size(765, 241);
            this.workersDataGridView.TabIndex = 0;
            // 
            // workerName
            // 
            this.workerName.HeaderText = "Worker name";
            this.workerName.MinimumWidth = 6;
            this.workerName.Name = "workerName";
            this.workerName.ReadOnly = true;
            this.workerName.Width = 125;
            // 
            // amountOfImages
            // 
            this.amountOfImages.HeaderText = "Amount of Images";
            this.amountOfImages.MinimumWidth = 6;
            this.amountOfImages.Name = "amountOfImages";
            this.amountOfImages.ReadOnly = true;
            this.amountOfImages.Width = 125;
            // 
            // amountOfMinutes
            // 
            this.amountOfMinutes.HeaderText = "Amount of minutes";
            this.amountOfMinutes.MinimumWidth = 6;
            this.amountOfMinutes.Name = "amountOfMinutes";
            this.amountOfMinutes.ReadOnly = true;
            this.amountOfMinutes.Width = 125;
            // 
            // imagePerWorker
            // 
            this.imagePerWorker.HeaderText = "Image Per Worker";
            this.imagePerWorker.MinimumWidth = 6;
            this.imagePerWorker.Name = "imagePerWorker";
            this.imagePerWorker.ReadOnly = true;
            this.imagePerWorker.Width = 125;
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(12, 129);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(115, 35);
            this.addWorkerButton.TabIndex = 1;
            this.addWorkerButton.Text = "Add Worker";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // amountOfImagesLabel
            // 
            this.amountOfImagesLabel.AutoSize = true;
            this.amountOfImagesLabel.Location = new System.Drawing.Point(12, 24);
            this.amountOfImagesLabel.Name = "amountOfImagesLabel";
            this.amountOfImagesLabel.Size = new System.Drawing.Size(147, 16);
            this.amountOfImagesLabel.TabIndex = 2;
            this.amountOfImagesLabel.Text = "Total amount of images";
            // 
            // amountOfImagesTextBox
            // 
            this.amountOfImagesTextBox.Location = new System.Drawing.Point(12, 60);
            this.amountOfImagesTextBox.Name = "amountOfImagesTextBox";
            this.amountOfImagesTextBox.Size = new System.Drawing.Size(147, 22);
            this.amountOfImagesTextBox.TabIndex = 3;
            this.amountOfImagesTextBox.Text = "1000";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(160, 129);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 35);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(317, 129);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(115, 35);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TotalTimeTextBox
            // 
            this.TotalTimeTextBox.Location = new System.Drawing.Point(222, 60);
            this.TotalTimeTextBox.Name = "TotalTimeTextBox";
            this.TotalTimeTextBox.Size = new System.Drawing.Size(147, 22);
            this.TotalTimeTextBox.TabIndex = 6;
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(222, 24);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(148, 16);
            this.TotalTime.TabIndex = 7;
            this.TotalTime.Text = "Total amount of Minutes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.TotalTimeTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountOfImagesTextBox);
            this.Controls.Add(this.amountOfImagesLabel);
            this.Controls.Add(this.addWorkerButton);
            this.Controls.Add(this.workersDataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.Button addWorkerButton;
        private System.Windows.Forms.Label amountOfImagesLabel;
        private System.Windows.Forms.TextBox amountOfImagesTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePerWorker;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox TotalTimeTextBox;
        private System.Windows.Forms.Label TotalTime;
    }
}

