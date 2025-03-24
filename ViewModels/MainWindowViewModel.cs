using System;
using System.Collections.ObjectModel;
using Avalonia.Media;
using ReactiveUI.SourceGenerators;
using TabStripTest.Models;

namespace TabStripTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [Reactive]
    public partial ObservableCollection<ServiceHealthHistory>? History { get; set; }
    
    [Reactive]
    public partial ServiceHealthHistory? SelectedHistoryItem { get; set; }

    public MainWindowViewModel()
    {
        History =
        [
            new() { Status = Brushes.Red, Time = DateTime.Now },
            new() { Status = Brushes.Green, Time = DateTime.Now },
            new() { Status = Brushes.Orange, Time = DateTime.Now },
            new() { Status = Brushes.Red, Time = DateTime.Now },
            new() { Status = Brushes.Orange, Time = DateTime.Now }
        ];
    }
}
