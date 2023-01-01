using Microsoft.AspNetCore.Components;

namespace BlazorApps.Views.Bases
{
    public partial class TextBoxBase
    {
        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Placeholder { get; set; }
        public void SetValue(string value) => Value = value;
    }
}
