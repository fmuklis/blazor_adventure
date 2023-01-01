using BlazorApps.Models.Basic;
using Microsoft.AspNetCore.Components;

namespace BlazorApps.Views.Components.Basics
{
    public partial class BasicComponent : ComponentBase
    {
        [Parameter]
        public ComponentState state { get; set; }
        
        [Parameter]
        public RenderFragment loading { get; set; }
        
        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public RenderFragment Error { get; set;}

        public RenderFragment GetFragment()
        {
            return state switch
            {
                ComponentState.Loading => loading,
                ComponentState.Content => Content,
                _ => Error
            };
        }
    }
}
