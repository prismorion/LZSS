using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LZSS
{
    public partial class Form1 : Form
    {
        private Stopwatch timer1 = new Stopwatch();
        private Stopwatch timer2 = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            boxWindowSize.SelectedIndex = 6;
            boxBufferSize.SelectedIndex = 4;
        }

        private void compressPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void compressPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length > 0)
                {
                    path2Compress.Text = files[0];                    
                    GetInformation4C(files[0]);
                }
            }
        }

        private void path2Compress_TextChanged(object sender, EventArgs e)
        {
            string filePath = path2Compress.Text;
            GetInformation4C(filePath);
        }

        private void path2Decompress_TextChanged(object sender, EventArgs e)
        {
            string filePath = path2Decompress.Text;
            GetInformation4D(filePath);
        }

        private void decompressPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void decompressPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length > 0)
                {
                    path2Decompress.Text = files[0];
                    GetInformation4D(files[0]);
                }
            }
        }

        private static double CalculateEntropy(byte[] data)
        {
            Dictionary<byte, int> frequencyMap = new Dictionary<byte, int>();

            foreach (byte b in data)
            {
                if (frequencyMap.ContainsKey(b))
                    frequencyMap[b]++;
                else
                    frequencyMap[b] = 1;
            }

            double entropy = 0.0;

            foreach (var entry in frequencyMap)
            {
                double probability = (double)entry.Value / data.Length;
                entropy -= probability * Math.Log(probability, 2);
            }

            double maxEntropy = Math.Log(256, 2);
            double normalizedEntropy = entropy / maxEntropy;

            return normalizedEntropy;
        }

        private void GetInformation4C(string filePath)
        {
            if (File.Exists(filePath))
            {
                long fileSize = new FileInfo(filePath).Length;
                labelSizeC.Text = $"{fileSize:N0} байт";

                double fileEntropy = CalculateEntropy(File.ReadAllBytes(filePath));
                labelEntropyC.Text = fileEntropy.ToString("F2");

                buttonCompress.Enabled = true;
            }
            else
            {
                labelSizeC.Text = "Н/Д";
                labelEntropyC.Text = "Н/Д";

                buttonCompress.Enabled = false;
            }
        }

        private void GetInformation4D(string filePath)
        {
            if (File.Exists(filePath))
            {
                byte[] file = File.ReadAllBytes(filePath);

                long fileSize = new FileInfo(filePath).Length;
                labelSizeD.Text = $"{fileSize:N0} байт";

                double fileEntropy = CalculateEntropy(file);
                labelEntropyD.Text = fileEntropy.ToString("F2");

                string fileExtension = Path.GetExtension(filePath);
                if (fileExtension.Equals(".lzss", StringComparison.OrdinalIgnoreCase))
                {
                    BitReader bitReader = new BitReader(file);

                    int windowSize = bitReader.Read(10);
                    labelWindowSize.Text = windowSize.ToString();

                    int bufferSize = bitReader.Read(10);
                    labelBufferSize.Text = bufferSize.ToString();

                    buttonDecompress.Enabled = true;
                }
                else
                {
                    labelWindowSize.Text = "Н/Д";
                    labelBufferSize.Text = "Н/Д";

                    buttonDecompress.Enabled = false;
                }
            }
            else
            {
                labelSizeD.Text = "Н/Д";
                labelEntropyD.Text = "Н/Д";
                labelWindowSize.Text = "Н/Д";
                labelBufferSize.Text = "Н/Д";

                buttonDecompress.Enabled = false;
            }
        }

        private void buttonCompress_Click(object sender, EventArgs e)
        {            
            if (boxWindowSize.Text != "" && boxBufferSize.Text != "" && labelEntropyC.Text != "Н/Д")
            {
                bool flag;
                if (Convert.ToDouble(labelEntropyC.Text) < 0.8d)
                {
                    flag = true;
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Энтропия файла: {Convert.ToDouble(labelEntropyC.Text)}\nСжатие может быть неэффективно!\nПродолжить?",
                        "Предупреждение", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                        flag = true;
                    else
                        flag = false;
                }

                if (flag)
                {
                    timer1.Reset();
                    timer2.Reset();

                    timer1.Start();

                    string inputFileName = path2Compress.Text;
                    string outputFileName = GetUniqueFileName4Compress(inputFileName);

                    int windowSize = int.Parse(boxWindowSize.Text);
                    int bufferSize = int.Parse(boxBufferSize.Text);

                    byte[] file = File.ReadAllBytes(inputFileName);

                    timer2.Start();
                    byte[] fileCompress = LZSS.Compress(windowSize, bufferSize, file);
                    timer2.Stop();

                    File.WriteAllBytes(outputFileName, fileCompress);

                    timer1.Stop();

                    double compressionRatio = Math.Round((double)file.Length / fileCompress.Length, 3);

                    double elapsedSeconds1 = Math.Round(timer1.Elapsed.TotalSeconds, 2);
                    double elapsedSeconds2 = Math.Round(timer2.Elapsed.TotalSeconds, 2);

                    MessageBox.Show($"Сила сжатия:   {compressionRatio}\nВремя сжатия: {elapsedSeconds2} с\nОбщее время: {elapsedSeconds1} с", "Сжатие", MessageBoxButtons.OK);
                }
            }
        }

        private string GetUniqueFileName4Compress(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            string fileExtension = Path.GetExtension(filePath);

            string compressedFilePath = Path.Combine(directory, $"{fileNameWithoutExtension}{fileExtension}.lzss");

            int counter = 1;
            while (File.Exists(compressedFilePath))
            {
                compressedFilePath = Path.Combine(directory, $"{fileNameWithoutExtension} ({counter}){fileExtension}.lzss");
                counter++;
            }

            return compressedFilePath;
        }

        private void buttonDecompress_Click(object sender, EventArgs e)
        {
            timer1.Reset();
            timer2.Reset();

            timer1.Start();

            string inputFileName = path2Decompress.Text;
            string outputFileName = GetUniqueFileName4Decompress(inputFileName);

            timer2.Start();
            byte[] fileDecompress = LZSS.Decompress(File.ReadAllBytes(inputFileName));
            timer2.Stop();

            File.WriteAllBytes(outputFileName, fileDecompress);
            timer1.Stop();

            double elapsedSeconds1 = Math.Round(timer1.Elapsed.TotalSeconds, 2);
            double elapsedSeconds2 = Math.Round(timer2.Elapsed.TotalSeconds, 2);

            MessageBox.Show($"Время распаковки: {elapsedSeconds2} с\nОбщее время:          {elapsedSeconds1} с", "Распаковка", MessageBoxButtons.OK);         
        }

        private string GetUniqueFileName4Decompress(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExtensionLZSS = Path.GetFileNameWithoutExtension(filePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileNameWithoutExtensionLZSS);
            string fileExtension = Path.GetExtension(fileNameWithoutExtensionLZSS);

            string compressedFilePath = Path.Combine(directory, $"{fileNameWithoutExtension}{fileExtension}");

            int counter = 1;
            while (File.Exists(compressedFilePath))
            {
                compressedFilePath = Path.Combine(directory, $"{fileNameWithoutExtension} ({counter}){fileExtension}");
                counter++;
            }

            return compressedFilePath;
        }
    }
}
