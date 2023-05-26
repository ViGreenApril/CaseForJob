using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaseForJob
{
    public partial class MainForm : Form
    {
        private List<Worker> workers;
        public MainForm()
        {
            InitializeComponent();
            workers = new List<Worker>();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            using (WorkerForm workerForm = new WorkerForm())
            {
                DialogResult result = workerForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Worker newWorker = workerForm.GetWorker();
                    if (newWorker != null)
                    {
                        workers.Add(newWorker);
                        workersDataGridView.Rows.Add(newWorker.Name, newWorker.AmountOfImages, newWorker.AmountOfMinutes);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create a new worker", "Error");
                    }
                    
                    
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalImages = Convert.ToInt32(amountOfImagesTextBox.Text);

                // Перевіряємо ввід
                if (totalImages <= 0)
                {
                    throw new ArgumentException("Total images must be a positive number.");
                }

                ImageEditor imageEditor = new ImageEditor(totalImages, workers);
                double totalTime = imageEditor.CalculateTotalTime();
                TotalTimeTextBox.Text = Convert.ToString(totalTime);
                Dictionary<Worker, double> editedImagesPerWorker = imageEditor.CalculateEditedImagesPerWorker(totalImages, workers);

                // Виконуємо ітерацію по існуючим працівникам і оновлюємо значення imagePerWorker
                for (int i = 0; i < workers.Count; i++)
                {
                    var worker = workers[i];
                    double imagePerWorker = editedImagesPerWorker[worker];
                    workersDataGridView.Rows[i].Cells["imagePerWorker"].Value = imagePerWorker;
                }

                MessageBox.Show($"Total time required: {totalTime} minutes", "Calculation Result");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number of images.", "Error");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong:\n{ex.Message}", "Error");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            workersDataGridView.Rows.Clear();
            workers.Clear();
            TotalTimeTextBox.Clear();
            amountOfImagesTextBox.Clear();
        }
    }
}
