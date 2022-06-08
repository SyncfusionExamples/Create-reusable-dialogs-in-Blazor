using System;
using Microsoft.AspNetCore.Components;

namespace Blazor_Dialog_Service.Components
{
    public class DialogService
    {
        public event Action<DialogOptions> DialogInstance;

        public void Open(DialogOptions options)
        {
            // Invoke DialogComponent to update and show the dialog with options
            this.DialogInstance.Invoke(options);
        }
    }
}