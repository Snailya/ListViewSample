using System.Reactive.Disposables;
using ListView.ViewModels;
using ReactiveUI;

namespace ListView;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new MainWindowViewModel();

        this.WhenActivated(d =>
        {
            this.OneWayBind(ViewModel, vm => vm.People, v => v.PeopleList.ItemsSource).DisposeWith(d);
        });
    }
}