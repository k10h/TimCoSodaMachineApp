using SodaMachineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineLibrary.Logic
{
    public interface ISodaMachineLogic
    {
        List<SodaModel> ListTypesOfSoda();

        decimal MoneyInserted(decimal monetaryAmount); //return total money inserted so far

        decimal GetSodaPrice(); //One price for all sodas

        (SodaModel soda, List<CoinModel> change, string errorMessage) RequestSoda(SodaModel soda); //returns both soda (or null if out of stock or not enough money) and any change

        void IssueFullRefund();

        decimal GetMoneyInsertedTotal();

        void AddToSodaInventory(List<SodaModel> sodas);

        List<SodaModel> GetSodaInventory();

        decimal EmptyMoneyFromMachine();

        List<CoinModel> GetCoinInventory();

        void AddToCoinInventory(List<CoinModel> coins);

        decimal GetCurrentIncome();

        decimal GetTotalIncome();
    }
}
