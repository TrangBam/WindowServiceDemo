namespace BuffaloWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = new string[] { $"{textName.Text},{textPort.Text}" };
            File.AppendAllLines(@"D:\Code\WindowsServiceDemo\sockets.txt", lines);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = @"C:\Windows\System32";
            startInfo.FileName = @"C:\Windows\System32\cmd.exe";
            startInfo.Arguments = @"/C D:\BuffaloServiceDemo\WindowsServiceDemo.exe install start";
            //startInfo.Arguments = "echo BinhNguyen";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}