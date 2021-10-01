using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShutDown
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

    public DateTime CurrentDateTime { get; set; } = DateTime.Now;

    void OnClick(object sender, RoutedEventArgs e)
    {
      DateTime? selectedDate = dpicker.SelectedDate ?? DateTime.Now;
      DateTime? selectedTime = tpciker.Value ?? DateTime.Now;
      string date = selectedDate.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
      string time = selectedTime.Value.ToString("HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
      StringBuilder sb = new StringBuilder();
      sb.Append(date);
      sb.Append(" ");
      sb.Append(time);
      string datetime = sb.ToString();
      shutting.CalDiff(datetime);
    }
    void OnClick2(object sender, RoutedEventArgs e)
    {
      shutting.CancelCommand();
    }
  }
}
