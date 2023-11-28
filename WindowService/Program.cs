using Topshelf;
using WindowsServiceDemo;

var lastLine = File.ReadLines(@"D:\Code\WindowsServiceDemo\sockets.txt").Last();
var socketName = lastLine.Split(",")[0];
var socketPort = lastLine.Split(",")[1];
var exitCode = HostFactory.Run(x =>
{
    x.Service<BuffaloService>(s =>
    {
        s.ConstructUsing(buf => new BuffaloService());
        s.WhenStarted(buf => buf.Start());
        s.WhenStopped(buf => buf.Stop());
    });
    x.RunAsLocalService();
    x.SetServiceName($"{socketName}-{socketPort}");
    x.SetDisplayName("Buffalo Service");
    x.SetDescription("Buffalo windows service");
});

int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
Environment.ExitCode = exitCodeValue;

