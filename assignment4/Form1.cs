using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberFileWriter
{
    public partial class SaveFileDialog : Form
    {
        public SaveFileDialog()
        {
            InitializeComponent();
        }

        public int numberParsing(string num)
        {
            try
            {
                return int.Parse(num);
            }
            catch
            {
                return int.MinValue;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int amount = numberParsing(numInput.Text);
            if (amount <= 0)
            {
                MessageBox.Show("Input should be a Positive Integer.", "Warning");
                return;
            }

            StreamWriter userFile;
            int randomNumber = 0;
            saveFileDialog1.FileName = numInput.Text + "_random_numbers";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";
                if (saveFileDialog1.FileName.EndsWith(".txt"))
                {
                    filePath = saveFileDialog1.FileName;
                }
                else
                {
                    filePath = saveFileDialog1.FileName + ".txt";
                }
                userFile = File.CreateText(filePath);
                Random rand = new Random();

                for(int i = 0; i < amount; i++)
                {
                    randomNumber = rand.Next(100) + 1;
                    userFile.WriteLine(randomNumber);
                }
                userFile.Close();
                MessageBox.Show(amount + " random numbers are written in "+ filePath, "File saved successfully");
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            StreamReader selectedFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resetBtn_Click(sender, e);

                int theNumberOfRand = 0;
                int totalNumbers = 0;
                selectedFile = File.OpenText(openFileDialog1.FileName);

                if (selectedFile.EndOfStream)
                {
                    MessageBox.Show("Selected file is empty. Please select a proper file again.", "Warning");
                    return;
                }
                else if (!openFileDialog1.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Selected file is not a text file. Please select a proper file again.", "Warning");
                    return;
                }

                while (!selectedFile.EndOfStream)
                {
                    string readRand = selectedFile.ReadLine();
                    int readRandInt = numberParsing(readRand);
                    totalNumbers += readRandInt;
                    numbersList.Items.Add(readRand);
                    theNumberOfRand++;

                    if (readRandInt <= 0 || readRandInt > 100)
                    {
                        resetBtn_Click(sender, e);
                        MessageBox.Show("Selected file is not created from Random Number File Writing. Please try to write file first.", "Warning");
                        return;
                    }
                }
                filePath.Text = openFileDialog1.FileName;
                totalNumber.Text = totalNumbers.ToString();
                theNumber.Text = theNumberOfRand.ToString();
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void writingFocused(object sender, EventArgs e)
        {
            //resetBtn_Click(sender, e);
        }

        private void readingFocused(object sender, EventArgs e)
        {
            //numInput.Text = "";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            filePath.Text = "";
            totalNumber.Text = "";
            theNumber.Text = "";
            numbersList.Items.Clear();
        }
    }
}
