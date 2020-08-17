using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner_2_0
{
    class DinnerParty
    {
        public const decimal CostOfFoodPerPerson = 25.0M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculaCostOfDecorations()
        {
            if (FancyDecorations)
                return NumberOfPeople * 15.00M + 50M;
            else
                return NumberOfPeople * 7.50M + 30M;
        }
        private decimal CalculaCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5.00M;
            else
                return 20.00M;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculaCostOfDecorations() + (CalculaCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople;
                if (HealthyOption)
                    totalCost *= .95M;
                return totalCost;
            }
        }
    }
}
