using SodaMachineLibrary.Logic;
using SodaMachineLibrary.Models;
using SodaMachineLibrary.Tests.Mocks;
using System.Linq;

namespace SodaMachineLibrary.Tests
{
    public class SodaMachineLogicTests
    {
        [Fact]
        public void AddToCointInventory_ShouldWork()
        {
            MockDataAccess da = new MockDataAccess();
            SodaMachineLogic logic = new SodaMachineLogic(da);
            List<CoinModel> coins = new List<CoinModel>
            {
                new CoinModel{Name="Quarter", Amount=0.25M},
                new CoinModel{Name="Quarter", Amount=0.25M},
                new CoinModel{Name="Dime", Amount=0.10M}
            };

            logic.AddToCoinInventory(coins);

            int expected = 6;
            int actual = da.CoinInventory.Where(x => x.Name == "Quarter").Count();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddToSodaInventory_ShouldWork()
        {
            MockDataAccess da = new MockDataAccess();
            SodaMachineLogic logic = new SodaMachineLogic(da);
            List<SodaModel> sodas = new List<SodaModel>
            {
                new SodaModel{Name="Coke", SlotOccupied="1"},
                new SodaModel{Name="Coke", SlotOccupied="1"}
            };

            logic.AddToSodaInventory(sodas);

            int expected = 7;
            int actual = da.SodaInventory.Where(x => x.Name == "Coke").Count();

            Assert.Equal(expected, actual);
        }
    }
}