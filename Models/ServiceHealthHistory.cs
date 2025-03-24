using System;
using Avalonia.Media;

namespace TabStripTest.Models;

public class ServiceHealthHistory
{
    public required IImmutableSolidColorBrush Status { get; set; }
    
    public DateTime Time { get; set; }
}
