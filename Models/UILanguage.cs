namespace CarCareTracker.Models
{
    public class UILanguage
    {
        //Metadata
        public string LanguageId { get; set; } = "en-US";
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
        public string YearPlaceholder { get; set; } = "Year(must be after 1900)";
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        public string LicensePlate { get; set; } = "License Plate";
        public string ElectricVehicle { get; set; } = "Electric Vehicle";
        public string PictureUpload { get; set; } = "Upload a picture(optional)";
        //Settings Page
        public string DarkMode { get; set; } = "Dark Mode";
        public string EnableCsvImports { get; set; } = "Enable CSV Imports";
        public string UseImperialCalculation { get; set; } = "Use Imperial Calculation for Fuel Economy Calculations(MPG)";
        public string UseImperialCalculationDescription { get; set; } = "This Will Also Change Units to Miles and Gallons";
        public string UseUKCalculation { get; set; } = "Use UK MPG Calculation";
        public string UseUKCalculationDescription { get; set; } = "Input Gas Consumption in Liters, it will be converted to UK Gals for MPG Calculation";
        public string UseDescending { get; set; } = "Sort lists in Descending Order(Newest to Oldest)";
        public string ReplaceZeroCost { get; set; } = "Replace $0.00 Costs with ---";
        public string UseThreeDecimals { get; set; } = "Use Three Decimals For Fuel Cost";
        public string AutoRefreshLapsedReminders { get; set; } = "Auto Refresh Lapsed Recurring Reminders";
        public string AutoInsertOdometerRecords { get; set; } = "Auto Insert Odometer Records";
        public string AutoInsertOdometerRecordsDescription { get; set; } = "Only when Adding Service/Repair/Upgrade/Fuel Record or Completing a Plan";
        public string EnableAuthentication { get; set; } = "Enable Authentication";
        public string VisibleTabs { get; set; } = "Visible Tabs";
        public string DefaultTab { get; set; } = "Default Tab";
        public string Backups { get; set; } = "Backups";
        public string MakeBackup { get; set; } = "Make";
        public string RestoreBackup { get; set; } = "Restore";
        public string About { get; set; } = "About";
    }
}
