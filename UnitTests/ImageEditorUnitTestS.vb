Imports NUnit.Framework
Imports CaseForJob

Namespace UnitTests

    <TestFixture>
    Public Class ImageEditorTests

        <Test>
        Public Sub CalculateTotalTime_ReturnsCorrectTotalTime()
            ' Готуємо дані до тесту
            Dim totalImages As Integer = 1000
            Dim workers As New List(Of Worker) From {
                New Worker("Worker 1", 1, 2),
                New Worker("Worker 2", 2, 1)
            }
            Dim imageEditor As New ImageEditor(totalImages, workers)

            ' Проводимо сам тест
            Dim totalTime As Double = imageEditor.CalculateTotalTime()

            ' Звіряємо результат з очікуваним
            Assert.AreEqual(2500, totalTime)
        End Sub

        <Test>
        Public Sub CalculateEditedImagesPerWorker_ReturnsCorrectImagesPerWorker()
            ' Готуємо дані до тесту
            Dim totalImages As Integer = 1000
            Dim workers As New List(Of Worker) From {
                New Worker("Worker 1", 1, 2),
                New Worker("Worker 2", 2, 1)
            }
            Dim imageEditor As New ImageEditor(totalImages, workers)

            ' Проводимо сам тест
            Dim editedImagesPerWorker As Dictionary(Of Worker, Double) = imageEditor.CalculateEditedImagesPerWorker(totalImages, workers)

            ' Звіряємо отримані результати
            Assert.AreEqual(200, editedImagesPerWorker(workers(0)))
            Assert.AreEqual(800, editedImagesPerWorker(workers(1)))
        End Sub

    End Class

End Namespace
