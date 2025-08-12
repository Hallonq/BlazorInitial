using BethanysPieShopHRM.Shared.Domain;
using BlazorInitial.Services;

namespace BlazorInitial.Components.Pages;
public partial class EmployeeOverview
{
    public List<Employee> Employees { get; set; } = default!;
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(500);
        Employees = MockDataService.Employees;
    }
}
