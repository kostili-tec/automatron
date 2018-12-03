using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string hr, html, span, span2, cmbNum, textMounth; 
        private void Form1_Load(object sender, EventArgs e)
        {          
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listBoxWrite.SelectedItem == null || listBoxWrite.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBoxWrite.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBoxWrite.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBoxWrite.SelectedItem;

            // Removing removable element
            listBoxWrite.Items.Remove(selected);
            // Insert it in new position
            listBoxWrite.Items.Insert(newIndex, selected);
            // Restore selection
            listBoxWrite.SetSelected(newIndex, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirect.Text = folderBrowserDialog1.SelectedPath;
            }
        }

       
        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBoxWrite.Items.Clear();
            listBoxFiles.Items.Clear();
        }

        private void UpClick_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] monthArray = new string[13] { "", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                                                    "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxStart.Text = textBoxStart.Text.Substring(0, textBoxStart.Text.Length - 0);
                textBoxDirect.Text = textBoxDirect.Text.Substring(0, textBoxDirect.Text.Length - 0);
            }
            else
            {
                textBoxStart.Text = textBoxStart.Text.Substring(0, textBoxStart.Text.Length - 2);
                textBoxDirect.Text = textBoxDirect.Text.Substring(0, textBoxDirect.Text.Length - 2);
            }
            
            textBoxStart.Text += comboBox1.SelectedItem.ToString();
            textBoxDirect.Text += comboBox1.SelectedItem.ToString();
            textBoxMounth.Text = monthArray[comboBox1.SelectedIndex];
        }

        private void DownClick_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void button2_Click(object sender, EventArgs e)              //сохранялка
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(myStream);
                    for (int i = 0; i < listBoxWrite.Items.Count; i++)
                    {
                        listBoxWrite.SelectedIndex = i;
                        sw.WriteLine(listBoxWrite.SelectedItem.ToString());
                    }
                    sw.Close();
                    myStream.Close();
                }
            }          
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();

            hr = textBoxHR.Text;
            html = textBoxStart.Text;
            span = textBoxName.Text;
            span2 = textBoxFinish.Text;
            cmbNum = comboBox1.SelectedItem.ToString();
            textMounth = textBoxMounth.Text;



            string path = textBoxDirect.Text;
            
            DirectoryInfo di = new DirectoryInfo(textBoxDirect.Text);

            try
            {

                foreach (var fi in di.GetFiles("*.pdf"))            //вывод списка файлов в каталоге
                {
                    listBoxFiles.Items.Add(fi.Name);
                }
            }

            catch (DirectoryNotFoundException fi)
            {
                MessageBox.Show("Такого пути нет!");
            }
            
            string[] s, nameOf;
            string[] nameOfCut;

            char[] Del = { '0' };

            s = new string[listBoxFiles.Items.Count];
            nameOf = new string[listBoxFiles.Items.Count];
            nameOfCut = new string[listBoxFiles.Items.Count];
            for (int i = 0; i < listBoxFiles.Items.Count; i++)  // добавление списка файлов в массив
            {
                s[i] = listBoxFiles.Items[i].ToString();
                nameOf[i] = s[i].Substring(0, s[i].Length - 4);
                nameOfCut[i] = nameOf[i].TrimStart(Del);
            }
                       
            for (int i = 0; i < s.Length; i++)
            {
                listBoxWrite.Items.Add(hr + html + "/" + s[i] +  span + nameOfCut[i] + " " + textMounth + span2);
            }
                      
            }
                            
                    
        }
    }

