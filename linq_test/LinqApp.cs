using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_test
{
    class LinqApp
    {
        static void Main()
        {
            Company c1 = new Company("VitoshAcademy", "Vitosh", 10, "Bulgaria");
            Company c2 = new Company("HereComesTheCode", "Vitosh", 12, "Russia");
            Company c3 = new Company("SomeBadCompany", "Vitosh", 14, "Germany");
            Company c4 = new Company("SomeBadCompany2", "Creepy", 16, "Germany");
            Company c5 = new Company("SomeBadCompany3", "Creepy");
            Company c6 = new Company("SomeBadCompany4", "Vitosh");

            List<Company> companies = new List<Company> { c1, c2, c3, c4, c5, c6 };

            var bulgarian_companies = from my_company in companies
                                      where my_company.country == "Bulgaria"
                                      select my_company;
            Console.WriteLine("Bulgarian companies only:");
            foreach (var company in bulgarian_companies)
            {
                Console.WriteLine(company.ToString());
            }

            Console.WriteLine("\nCompanies with a positive profit :");
            var companies_with_profit = from my_company in companies
                                        where my_company.profit > 0
                                        select my_company;

            foreach (var company in companies_with_profit)
            {
                Console.WriteLine(company.ToString());
            }
        }
    }
}