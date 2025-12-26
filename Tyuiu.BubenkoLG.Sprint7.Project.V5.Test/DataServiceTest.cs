using Tyuiu.BubenkoLG.Sprint7.Project.V5.Lib;
namespace Tyuiu.BubenkoLG.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint7\Tyuiu.BubenkoLG.Sprint7.Project.V5\bin\Debug\net8.0-windows\InputFileData.csv";
            List<Product> res = ds.LoadFromFile(path);
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void ValidSearchByName()
        {
            DataService ds = new DataService();
            List<Product> res = ds.SearchByName("Бананы");
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void ValidSortBy()
        {
            DataService ds = new DataService();
            List<Product> res_asc = ds.SortBy("price", true);
            Assert.IsNotNull(res_asc);
            List<Product> res_desc = ds.SortBy("price", false);
            Assert.IsNotNull(res_desc);
        }
    }
}
