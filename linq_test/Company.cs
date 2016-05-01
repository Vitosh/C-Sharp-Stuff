namespace linq_test
{
    class Company
    {
        private string _companyName;
        private string _companyCEO;
        private int _companyProfit;
        private string _companyCountry;

        public Company(string name, string ceo = "No CEO", int profit = 0, string country = "Bulgaria")
        {
            _companyName = name;
            _companyCEO = ceo;
            _companyProfit = profit;
            _companyCountry = country;
        }

        public string name
        {
            get { return _companyName; }
        }

        public int profit
        {
            get {return _companyProfit;}
        }

        public string country 
        {
            get {return _companyCountry;}
        }

        public string ceo
        {
            get
            {
                return _companyCEO;
            }
            set
            {
                _companyCEO = value;
            }
        }

        public override string ToString()
        {
            return string.Format("This company is named {0}. The CEO is {1}. The profit is {2}. It is located in {3}.",
                                this.name, this.ceo, this.profit, this.country);
        }

    }
}
