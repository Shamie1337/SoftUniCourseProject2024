using Microsoft.AspNetCore.Mvc;

namespace SoftUniCourseProject2024.Components
{
    public class MainMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }

    }
}
