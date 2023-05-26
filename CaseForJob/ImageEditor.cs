using CaseForJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseForJob
{
    public class ImageEditor
    {
        public int TotalImages { get; set; }
        public List<Worker> Workers { get; set; }

        public ImageEditor(int totalImages, List<Worker> workers)
        {
            this.TotalImages = totalImages;
            this.Workers = workers;
        }

        public void AddWorker(Worker worker)
        {
            Workers.Add(worker);
        }

        public double CalculateTotalTime()
        {
            double totalTime = 0;
            foreach (var worker in Workers)
            {
                double workerTime = (double)TotalImages * (worker.AmountOfMinutes / worker.AmountOfImages);
                totalTime += workerTime;
            }
            return totalTime;
        }

        public Dictionary<Worker, double> CalculateEditedImagesPerWorker(double totalImages, List<Worker> workers)
        {
            Dictionary<Worker, double> editedImagesPerWorker = new Dictionary<Worker, double>();
            double totalImagesMade = 0;

            // Обчислюємо загальну кількість зображень зроблених усіма працівниками
            foreach (var worker in workers)
            {
                double imagesMade = worker.AmountOfImages / worker.AmountOfMinutes;
                totalImagesMade += imagesMade;
            }

            // Розраховуємо кількість зображень зроблених кожним працівником виходячи з пропорції
            foreach (var worker in workers)
            {
                double proportion = (worker.AmountOfImages / worker.AmountOfMinutes) / totalImagesMade;
                double imagesPerWorker = Math.Floor(proportion * totalImages);
                editedImagesPerWorker.Add(worker, imagesPerWorker);
            }

            return editedImagesPerWorker;
        }
    }
}