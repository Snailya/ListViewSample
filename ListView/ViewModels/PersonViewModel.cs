using ReactiveUI;

namespace ListView.ViewModels;

public class PersonViewModel : ReactiveObject
{
    private int _age;
    private string _name = string.Empty;

    public int Id { get; set; }

    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    public int Age
    {
        get => _age;
        set => this.RaiseAndSetIfChanged(ref _age, value);
    }
}