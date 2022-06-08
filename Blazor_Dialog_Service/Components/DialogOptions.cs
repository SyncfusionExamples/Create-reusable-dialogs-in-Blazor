using Microsoft.AspNetCore.Components;

namespace Blazor_Dialog_Service.Components
{
    public class DialogOptions
    {
        public string Header { get; set; }
        public RenderFragment Content { get; set; }
        public RenderFragment FooterTemplate { get; set; }
        public bool IsModal { get; set; } = true;
        public bool ShowCloseIcon { get; set; } = false;
    }
}