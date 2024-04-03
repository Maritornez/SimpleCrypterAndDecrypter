using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace InfoSecLab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Encrypt(object sender, RoutedEventArgs e)
        {
            if (textBoxKey.Text != null && textBoxKey.Text != "")
            {
                OpenFileDialog openInputFileDialog = new();
                openInputFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openInputFileDialog.ShowDialog() == true)
                {
                    string text = System.IO.File.ReadAllText(openInputFileDialog.FileName);
                    string key = textBoxKey.Text;
                    string encryptedText = "";

                    // Шифрование по модифицированному алгоритму Цезаря
                    // К коду каждого символа строки исходного файла прибавляется код очередного символа ключа
                    // От кода каждого символа получившейся строки вычитается порядковый номер этого символа в строке
                    // В выходной файл символы зашифрованной строки записываются в обратном порядке
                    for (int i = 0; i < text.Length; i++)
                    {
                        char encryptedChar = (char)(text[i] + key[i % key.Length] - i);
                        encryptedText += encryptedChar;
                    }

                    SaveFileDialog saveOutputFileDialog = new();
                    saveOutputFileDialog.FileName = "Encrypted";
                    saveOutputFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveOutputFileDialog.ShowDialog() == true)
                    {
                        File.WriteAllText(saveOutputFileDialog.FileName, new string(encryptedText.Reverse().ToArray()));
                    }
                }
            }
            else
            {
                MessageBox.Show("Ключ не введен.");
            }
        }

        private void Button_Click_Decrypt(object sender, RoutedEventArgs e)
        {
            if (textBoxKey.Text != null && textBoxKey.Text != "")
            {
                OpenFileDialog openInputFileDialog = new();
                openInputFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                // Открытие диалога открытия файла и проверка, был ли файл выбран
                if (openInputFileDialog.ShowDialog() == true)
                {
                    string encryptedReversedText = System.IO.File.ReadAllText(openInputFileDialog.FileName);
                    string encryptedText = new string(encryptedReversedText.Reverse().ToArray());
                    string key = textBoxKey.Text;
                    string decryptedText = "";

                    // Расшифровка
                    for (int i = 0; i < encryptedText.Length; i++)
                    {
                        char decryptedChar = (char)(encryptedText[i] - key[i % key.Length] + i);
                        decryptedText += decryptedChar;
                    }
                    SaveFileDialog saveOutputFileDialog = new();
                    saveOutputFileDialog.FileName = "Decrypted";
                    saveOutputFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    // Открытие диалога сохранения файла и проверка, был ли файл выбран
                    if (saveOutputFileDialog.ShowDialog() == true)
                    {
                        File.WriteAllText(saveOutputFileDialog.FileName, decryptedText);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ключ не введен.");
            }
        }
    }
}
