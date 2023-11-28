using System.Timers;

namespace WindowsServiceDemo
{
    public class BuffaloService
    {
        private readonly System.Timers.Timer _timer;
        public BuffaloService() 
        {
            _timer = new System.Timers.Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerEplapsed;
        }

        private void TimerEplapsed(object? sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"D:\Buffalo.txt", lines);
        }

        public void Start() 
        {
            _timer.Start();
        }

        public void Stop() 
        {
            _timer.Stop();
        }
    }
}
