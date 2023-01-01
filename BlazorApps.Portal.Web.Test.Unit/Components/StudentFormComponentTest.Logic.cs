using BlazorApps.Models.Basic;
using BlazorApps.Views.Components;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlazorApps.Test.Unit.Components
{
    public partial class StudentFormComponentTest
    {
        [Fact]
        public void ShouldInitializeComponent()
        {
            // given . when
            var initializeStudentComponent = new StudentFormComponent();
            
            // then
            initializeStudentComponent.StudentNameTextBox.Should().BeNull();
        }

        [Fact]
        public void ShouldRenderComponent()
        {
            // given
            ComponentState expectedState = ComponentState.Content;

            // when
            _renderedStudentFormComponent = RenderComponent<StudentFormComponent>();

            // then
            _renderedStudentFormComponent.Instance.State
                .Should().Be(expectedState);

            _renderedStudentFormComponent.Instance.StudentNameTextBox
                .Should().NotBeNull();
            _renderedStudentFormComponent.Instance.StudentNameTextBox.Placeholder
                .Should().BeEquivalentTo("Name");
        }
    }
}
