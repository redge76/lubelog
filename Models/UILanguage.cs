using AspNetCore;

namespace CarCareTracker.Models
{
    public class UILanguage
    {
        //Metadata
        public string LanguageName { get; set; } = "English(United States)";
        //Tabs
        public string Garage { get; set; } = "Garage";
        public string Settings { get; set; } = "Settings";
        public string ServiceRecords { get; set; } = "Service Records";
        public string Repairs { get; set; } = "Repairs";
        public string Upgrades { get; set; } = "Upgrades";
        public string Fuel { get; set; } = "Fuel";
        public string Odometer { get; set; } = "Odometer";
        public string Taxes { get; set; } = "Taxes";
        public string Notes { get; set; } = "Notes";
        public string Reminders { get; set; } = "Reminders";
        public string Supplies { get; set; } = "Supplies";
        public string Planner { get; set; } = "Planner";
        //Shared
        public string Cancel { get; set; } = "Cancel";
        //Home Page
        public string AddNewVehicle { get; set; } = "Add New Vehicle";
        public string Year { get; set; } = "Year";
        public string YearConstraint { get; set; } = "Year(must be after 1900)";
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        public string LicensePlate { get; set; } = "License Plate";
        public string ElectricVehicle { get; set; } = "Electric Vehicle";
        public string PictureUpload { get; set; } = "Upload a picture(optional)";
    }
}
