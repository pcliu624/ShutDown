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
      string formatted = selectedDate.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

    }
    void OnClick2(object sender, RoutedEventArgs e)
    {

    }
  }
}
