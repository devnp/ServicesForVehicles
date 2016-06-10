namespace VehiclesController
{
    public class Auto : Vehicle
    {
        public Auto(VehiclesData vehicleDataInput)
            : base(vehicleDataInput)
        { }

        protected override void CheckTiresPressure()
        {
            this.ServicesLogs.Add("We have more axles here.");
        }
    }
}
