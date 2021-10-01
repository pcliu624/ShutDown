using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShutDown
{
  internal class shutting
  {

    public static void CalDiff(string datetime)
    {
      DateTime dt = DateTime.Parse(datetime);
      DateTime now = DateTime.Now;
      if (dt.CompareTo(now) < 0)
      {
        _ = MessageBox.Show("Input time must greater than now", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);

      }
      else
      {
        TimeSpan dif = dt - now;
        double diff = Math.Round(dif.TotalSeconds);
        ShutDownCommand(diff);
      }
    }
    public static void ShutDownCommand(double diff)
    {
      try
      {
        string cmd = $"shutdown -s -t {diff}";
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        process.Start();
        process.StandardInput.WriteLine("cd\\");
        process.StandardInput.WriteLine(cmd);
        process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        process.Close();
        _ = MessageBox.Show("cancel");
      }
      catch (Exception ex)
      {
        _ = MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }
      
    }
    public static void CancelCommand()
    {
      try
      {
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        process.Start();
        process.StandardInput.WriteLine("cd\\");
        process.StandardInput.WriteLine("shutdown -A");
        process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        process.Close();
        _ = MessageBox.Show("cancel");
      }
      catch (Exception ex)
      {
        _ = MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }
    }
  }
}
