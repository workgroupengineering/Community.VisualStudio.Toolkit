﻿using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace TestExtension
{
    [Command(PackageGuids.guidTestExtensionPackageCmdSetString, PackageIds.ThemeWindowCommandId)]
    internal sealed class ThemeWindowCommand : BaseCommand<ThemeWindowCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await ThemeWindow.ShowAsync();
        }
    }
}
