using DizzleDashBoard.Models;
using DizzleDashBoard.Services;
using System.Diagnostics;

namespace DizzleDashBoard;

public partial class OverviewPage : ContentPage
{
    ApiService _service;
	List<Hospital> Hospitals;

	public OverviewPage()
    {
        InitializeComponent();
        _service = new ApiService();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        MokeData();

        //Hospitals = await _service.GetTasksAsync(Constants.RestUrlOverview);

        HospitalListView.ItemsSource = Hospitals;

        Debug.WriteLine(Hospitals.Count);
    }

    public void MokeData()
    {
        Hospitals = new List<Hospital>
        {
            new Hospital { amountOfPatients = 21, departmentCapacity = 29, departmentName = "", governmentHospital = "", governmentHospitalId = 0, hospital = "Hospital1", id = 0, reportedOn = "0001-01-01T00:00:00" },
            new Hospital { amountOfPatients = 21, departmentCapacity = 29, departmentName = "", governmentHospital = "", governmentHospitalId = 0, hospital = "Hospital2", id = 0, reportedOn = "0001-01-01T00:00:00" },
        };
    }

}