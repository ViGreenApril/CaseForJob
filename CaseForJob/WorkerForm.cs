using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseForJob
{
    public partial class WorkerForm : Form
    {
        private Worker newWorker;
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;

                // Validate input
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                int amountOfImages = Convert.ToInt32(amountOfImagesTextBox.Text);
                int amountOfMinutes = Convert.ToInt32(amountOfMinutesTextBox.Text);

                // Validate input
                if (amountOfImages <= 0 || amountOfMinutes <= 0)
                {
                    throw new ArgumentException("Amount of images and amount of minutes must be positive numbers.");
                }

                newWorker = new Worker(name, amountOfImages, amountOfMinutes);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers for amount of images and amount of minutes.", "Error");
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


        public Worker GetWorker()
        {
            return newWorker;
        }
    }
}
