using ReactiveUI;

namespace ListView.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    public List<PersonViewModel> People { get; } =
    [
        new PersonViewModel { Id = 1, Name = "Lucy", Age = 12 },
        new PersonViewModel { Id = 1, Name = "Leo", Age = 14 },
        new PersonViewModel { Id = 1, Name = "Keith", Age = 18 }
    ];
}