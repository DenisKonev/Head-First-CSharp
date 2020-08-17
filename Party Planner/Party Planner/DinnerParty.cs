using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty
    {
        public const decimal CostOfFoodPerPerson = 25.0M;
        private int NumberOfPeople;
        public decimal CostOfBeveargesPerPerson;
        public decimal CostOfDecorations = 0;
        public DinnerParty(int extNumberOfPeople)
        {
            NumberOfPeople = extNumberOfPeople;
        }
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveargesPerPerson = 5.00M;
            else
                CostOfBeveargesPerPerson = 20.00M;
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveargesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }
        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

    }
}
