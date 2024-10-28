using System;
using System.Speech.Synthesis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Controls.TextBox;



namespace SpeechTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //输入框 
            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;
        }


        private void pathSelect(object sender, RoutedEventArgs e)
        {
            //路径选择
            //PathBox.

            // 创建FolderBrowserDialog对象
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // 设置对话框的标题
            folderBrowserDialog.Description = "输出路径";

            folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.Desktop;

            // 设置对话框的初始目录
            PathBox.Content = folderBrowserDialog.SelectedPath;

            // 显示对话框并检查用户是否选择了文件夹

            folderBrowserDialog.ShowDialog();

            string directoryPath = folderBrowserDialog.SelectedPath;

            // 在这里处理文件夹路径
            //MessageBox.Show("你选择的文件夹是: " + directoryPath);

            PathBox.Content = directoryPath;
   



        }

        private void OnceOrc_Click(object sender, RoutedEventArgs e)
        {
            //单次转化
            // 创建SpeechSynthesizer对象
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {

                // 设置语音选项（可选）
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                var loc = synth.GetInstalledVoices();



                // 指定保存的文件路径
                string filePath = $"{PathBox.Content}/{InputText.Text}.mp3";

                // 合成并保存语音为WAV文件
                synth.SetOutputToWaveFile(filePath);

                synth.Speak($"{InputText.Text}");
            }
        }

        private void windows_Loaded(object sender, RoutedEventArgs e)
        {
            //窗口加载事件

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            PathBox.Content = desktopPath;
            MessageBox.Show("你选择的文件夹是: " + desktopPath);




        }
    }
}
