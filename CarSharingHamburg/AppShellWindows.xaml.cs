﻿using CarSharingHamburg.Views;

namespace CarSharingHamburg;

public partial class AppShellWindows : Shell
{
    public AppShellWindows()
    {
        InitializeComponent();
        
        Routing.RegisterRoute($"{nameof(KundenPage)}", typeof(KundenPage));
        Routing.RegisterRoute($"{nameof(NewKundePage)}", typeof(NewKundePage));
        Routing.RegisterRoute($"{nameof(KundenDetailsPage)}", typeof(KundenDetailsPage));

        Routing.RegisterRoute(nameof(AutoPage), typeof(AutoPage));
        Routing.RegisterRoute(nameof(AutoDetailsPage), typeof(AutoDetailsPage));
        Routing.RegisterRoute(nameof(NewAutoPage), typeof(NewAutoPage));
        
    }
}
