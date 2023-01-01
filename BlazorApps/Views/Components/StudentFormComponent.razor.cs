// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using BlazorApps.Models.Basic;
using BlazorApps.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace BlazorApps.Views.Components
{
    public partial class StudentFormComponent : ComponentBase
    {
        public TextBoxBase StudentNameTextBox { get; set; }

        public ComponentState State { get; set; }

        protected override void OnInitialized()
        {
            this.State = ComponentState.Content;
        }
    }
}
