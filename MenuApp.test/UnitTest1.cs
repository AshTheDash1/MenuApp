using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MenuApp.test
{
    public class UnitTest1
    {
        [Fact]
        public void MenuAppTest()
        {
            List<MenuItem> MenuItems = new List<MenuItem>
            {
                new MenuItem {Name = "Jotos Fingers", Cost = 3.99, Type = "Appetizer", ItemNumber = 0},
                new MenuItem {Name = "Turkey", Cost = 7.99, Type = "Wraps", ItemNumber = 136},
            };
            double result = MenuItems.Sum(x => x.Cost);
            Assert.Equal(11.98, result);
        }
    }
}
