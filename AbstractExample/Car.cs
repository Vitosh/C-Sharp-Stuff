namespace AbstractExample
{
    public abstract class Car
    {
        public int year { get; set; }
        protected Car(int yearOfProduction)
        {
            this.year = yearOfProduction;
        }
        public string ProducedIn()
        {
            return string.Format("Produced in {0}.",this.year);
        }
        public abstract string StartEngine();
        public abstract string StopEngine();
        public string YearsNeededToDrive()
        {
            return "You should be 18 years to drive it!";
        }
    }
}
