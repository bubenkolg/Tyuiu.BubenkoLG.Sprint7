using System.Globalization;
using System.IO;
using System.Text;

namespace Tyuiu.BubenkoLG.Sprint7.Project.V5.Lib
//Ввод, редактирование, поиск, сортировка, фильтрация, сохранения в файл(ы), чтение из фала(лов) данных.
//Реализовать элементы статистики (количество, сумма, среднее, min, max и т.д.).
//График (гистограмма / функция / диаграмм).
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryQuantity { get; set; }
    }
    public class DataService
    {
        private List<Product> products;

        public DataService()
        {
            products = new List<Product>();
        }

        public List<Product> LoadFromFile(string filePath)
        {
            products.Clear();

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.Default))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values.Length >= 10)
                        {
                            var product = new Product
                            {
                                Id = int.Parse(values[0]),
                                Name = values[1],
                                StockQuantity = int.Parse(values[3]),
                                UnitPrice = decimal.Parse(values[4]),
                                Description = values[5],
                                SupplierNumber = values[6],
                                SupplierName = values[7],
                                DeliveryDate = DateTime.ParseExact(values[8], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                                DeliveryQuantity = int.Parse(values[9])
                            };

                            products.Add(product);
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке файла: {ex.Message}");
            }
        }
        
        public void SaveToFile(string filePath, List<Product> data)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, false))
                {
                    // Записываем заголовок
                    writer.WriteLine("Код товара;Название товара;Количество на складе;Стоимость за единицу/кг товара/руб.;Описание товара;Номер поставщика;ФИО поставщика;Срок поставки;Количество товаров в поставке");

                    // Записываем данные
                    foreach (var product in data)
                    {
                        writer.WriteLine($"{product.Id};{product.Name};{product.Name};{product.StockQuantity};{product.UnitPrice};{product.Description};{product.SupplierNumber};{product.SupplierName};{product.DeliveryDate:dd.MM.yyyy};{product.DeliveryQuantity}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении файла: {ex.Message}");
            }
        }

        public List<Product> SearchByName(string name)
        {
            return products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<Product> SortBy(string sortBy, bool ascending = true)
        {
            switch (sortBy)
            {
                case "name":
                    return ascending ?
                        products.OrderBy(p => p.Name).ToList() :
                        products.OrderByDescending(p => p.Name).ToList();

                case "quantity":
                    return ascending ?
                        products.OrderBy(p => p.StockQuantity).ToList() :
                        products.OrderByDescending(p => p.StockQuantity).ToList();

                case "price":
                    return ascending ?
                        products.OrderBy(p => p.UnitPrice).ToList() :
                        products.OrderByDescending(p => p.UnitPrice).ToList();

                case "date":
                    return ascending ?
                        products.OrderBy(p => p.DeliveryDate).ToList() :
                        products.OrderByDescending(p => p.DeliveryDate).ToList();

                default:
                    return products;
            }
        }

        public List<Product> FilterBy(string filterBy, object value)
        {
            switch (filterBy)
            {
                case "date":
                    if (value is DateTime date)
                    {
                        return products.Where(p => p.DeliveryDate.Date == date.Date).ToList();
                    }
                    break;

                case "price":
                    if (value is decimal price)
                    {
                        return products.Where(p => p.UnitPrice >= price).ToList();
                    }
                    break;

                case "quantity":
                    if (value is int quantity)
                    {
                        return products.Where(p => p.StockQuantity >= quantity).ToList();
                    }
                    break;
            }

            return products;
        }

        public (int TotalDeliveryQuantity, decimal TotalDeliveryValue) GetStatistics()
        {
            int totalDeliveryQuantity = products.Sum(p => p.DeliveryQuantity);
            decimal totalDeliveryValue = products.Sum(p => p.DeliveryQuantity * p.UnitPrice);

            return (totalDeliveryQuantity, totalDeliveryValue);
        }

        public (int TotalStockQuantity, int TotalDeliveryQuantity) GetQuantityComparison()
        {
            int totalStockQuantity = products.Sum(p => p.StockQuantity);
            int totalDeliveryQuantity = products.Sum(p => p.DeliveryQuantity);

            return (totalStockQuantity, totalDeliveryQuantity);
        }
    }
}
