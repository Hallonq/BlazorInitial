using BethanysPieShopHRM.Shared.Domain;
using BlazorInitial.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorInitial.Components.Pages;
public partial class EmployeeDetail
{
    [Parameter]
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = new Employee();

    protected override void OnInitialized()
    {
        Employee = MockDataService.Employees.Single(x => x.EmployeeId == EmployeeId);
    }

    private void ChangeHolidayState()
    {
        Employee.IsOnHoliday = !Employee.IsOnHoliday;
    }
}
