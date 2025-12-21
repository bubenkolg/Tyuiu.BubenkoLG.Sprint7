using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BubenkoLG.Sprint7.Project.V5.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.BubenkoLG.Sprint7.Project.V5
{
    public partial class FormMain_BLG : Form
    {
        private DataService ds;
        private List<Product> currentData;
        private bool isStatisticsMode = false;
        public FormMain_BLG()
        {
            InitializeComponent();
            ds = new DataService();
            currentData = new List<Product>();
            InitializeDataGridView();
            InitializeChart();
            //openFileDialog_BLG.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            //saveFileDialog_BLG.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private void InitializeDataGridView()
        {
            dataGridViewData_BLG.AutoGenerateColumns = false;
            dataGridViewData_BLG.Columns.Clear();

            // Настраиваем колонки DataGridView
            string[] columnNames = {
               "Id", "Name", "StockQuantity", "UnitPrice", "Description",
               "SupplierNumber", "SupplierName", "DeliveryDate", "DeliveryQuantity"};

            string[] headers = {
               "Код товара", "Название товара", "Количество на складе",
               "Стоимость (руб.)", "Описание", "Номер поставщика",
               "ФИО поставщика", "Срок поставки", "Количество в поставке"};

            for (int i = 0; i < columnNames.Length; i++)
            {
                dataGridViewData_BLG.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = columnNames[i],
                    HeaderText = headers[i],
                    DataPropertyName = columnNames[i]
                });
            }
        }

        private void InitializeChart()
        {
            chartFunction_BLG.Series.Clear();
            chartFunction_BLG.Titles.Clear();
            chartFunction_BLG.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartFunction_BLG.ChartAreas.Add(chartArea);

            chartFunction_BLG.Legends.Add(new Legend());
        }

        private void buttonOpenFile_BLG_Click(object sender, EventArgs e)
        {
            // Создаем диалог с правильными настройками
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                Title = "Выберите файл данных",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            // Показываем диалог
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Диагностика перед загрузкой
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Файл не найден: {filePath}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Length == 0)
                {
                    MessageBox.Show("Файл пустой!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Показываем прогресс
                    labelStatus_BLG.Text = "Загрузка файла...";
                    Application.DoEvents(); // Обновляем интерфейс

                    // Загружаем данные
                    currentData = ds.LoadFromFile(filePath);

                    if (currentData.Count == 0)
                    {
                        MessageBox.Show("Файл загружен, но данных не найдено. Проверьте формат файла.",
                            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Привязываем данные к таблице
                    BindDataGridView(currentData);
                    isStatisticsMode = false;

                    // Обновляем статус
                    labelStatus_BLG.Text = $"Загружено {currentData.Count} записей из файла {Path.GetFileName(filePath)}";

                    // Активируем кнопки после успешной загрузки
                    buttonSaveData_BLG.Enabled = true;
                    buttonStatistics_BLG.Enabled = true;
                    buttonFunction_BLG.Enabled = true;
                }
                catch (FormatException fex)
                {
                    MessageBox.Show($"Ошибка формата данных: {fex.Message}\nПроверьте числовые значения и даты.",
                        "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelStatus_BLG.Text = "Ошибка загрузки файла";
                }
                catch (IOException ioex)
                {
                    MessageBox.Show($"Ошибка ввода-вывода: {ioex.Message}\nВозможно файл используется другой программой.",
                        "Ошибка ввода-вывода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelStatus_BLG.Text = "Ошибка доступа к файлу";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неожиданная ошибка: {ex.Message}\n\nДетали:\n{ex.StackTrace}",
                        "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelStatus_BLG.Text = "Критическая ошибка при загрузке";
                }
            }
            else
            {
                labelStatus_BLG.Text = "Загрузка файла отменена";
            }

        }

        private void buttonSearch_BLG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearch_BLG.Text))
            {
                var searchResults = ds.SearchByName(textBoxSearch_BLG.Text);
                BindDataGridView(searchResults);
                labelStatus_BLG.Text = $"Найдено {searchResults.Count} записей";
            }
        }

        private void buttonSortByName_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("name", true);
            BindDataGridView(currentData);
        }

        private void buttonSortByQuantityAsc_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("quantity", true);
            BindDataGridView(currentData);
        }

        private void buttonSortByQuantityDesc_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("quantity", false);
            BindDataGridView(currentData);
        }

        private void buttonSortByPriceAsc_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("price", true);
            BindDataGridView(currentData);
        }

        private void buttonSortByPriceDesc_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("price", false);
            BindDataGridView(currentData);
        }

        private void buttonSortByDateAsc_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("date", true);
            BindDataGridView(currentData);
        }

        private void buttonSortByDateDesc_BLG_Click(object sender, EventArgs e)
        {
            currentData = ds.SortBy("date", false);
            BindDataGridView(currentData);
        }

        private void buttonFilterByDate_BLG_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFilter_BLG.Value != null)
            {
                currentData = ds.FilterBy("date", dateTimePickerFilter_BLG.Value);
                BindDataGridView(currentData);
                labelStatus_BLG.Text = $"Отфильтровано {currentData.Count} записей";
            }
        }

        private void buttonFilterByPrice_BLG_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxFilterPrice_BLG.Text, out decimal price))
            {
                currentData = ds.FilterBy("price", price);
                BindDataGridView(currentData);
                labelStatus_BLG.Text = $"Отфильтровано {currentData.Count} записей";
            }
        }

        private void buttonFilterByQuantity_BLG_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFilterQuantity_BLG.Text, out int quantity))
            {
                currentData = ds.FilterBy("quantity", quantity);
                BindDataGridView(currentData);
                labelStatus_BLG.Text = $"Отфильтровано {currentData.Count} записей";
            }
        }

        private void buttonStatistics_BLG_Click(object sender, EventArgs e)
        {
            if (currentData.Any())
            {
                var stats = ds.GetStatistics();

                // Создаем таблицу для статистики
                DataTable statsTable = new DataTable();
                statsTable.Columns.Add("Показатель", typeof(string));
                statsTable.Columns.Add("Значение", typeof(string));

                statsTable.Rows.Add("Общее количество поставленных товаров", stats.TotalDeliveryQuantity.ToString("N0"));
                statsTable.Rows.Add("Общая сумма поставленных товаров (руб.)", stats.TotalDeliveryValue.ToString("N2"));

                dataGridViewData_BLG.DataSource = statsTable;
                isStatisticsMode = true;
                labelStatus_BLG.Text = "Режим статистики";
                buttonFunction_BLG.Enabled = true; // После загрузки таблицы будет доступна статистика
            }
        }

        /*private void btnQuantityComparison_Click(object sender, EventArgs e)
        {
            if (currentData.Any())
            {
                var quantities = ds.GetQuantityComparison();

                // Строим диаграмму
                chartFunction_BLG.Series.Clear();

                Series series = new Series("Количества");
                series.ChartType = SeriesChartType.Column;

                series.Points.AddXY("Товаров на складе", quantities.TotalStockQuantity);
                series.Points.AddXY("Поставленных товаров", quantities.TotalDeliveryQuantity);

                chartFunction_BLG.Series.Add(series);
                chartFunction_BLG.Titles.Clear();
                chartFunction_BLG.Titles.Add("Сравнение количества товаров");

                chartFunction_BLG.Visible = true;
                labelStatus_BLG.Text = "Построена диаграмма сравнения количеств";
            }
        }*/

        private void buttonSaveData_BLG_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Сохранить данные",
                    FileName = "OutputFileData.csv"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ds.SaveToFile(saveFileDialog.FileName, currentData);
                    MessageBox.Show("Данные успешно сохранены", "Сохранение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelStatus_BLG.Text = $"Данные сохранены в {saveFileDialog.FileName}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFunction_BLG_Click(object sender, EventArgs e)
        {
            if (currentData.Any())
            {
                var quantities = ds.GetQuantityComparison();

                // Строим диаграмму
                chartFunction_BLG.Series.Clear();

                Series series = new Series("Количества");
                series.ChartType = SeriesChartType.Column;

                series.Points.AddXY("Товаров на складе", quantities.TotalStockQuantity);
                series.Points.AddXY("Поставленных товаров", quantities.TotalDeliveryQuantity);

                chartFunction_BLG.Series.Add(series);
                chartFunction_BLG.Titles.Clear();
                chartFunction_BLG.Titles.Add("Сравнение количества товаров");

                chartFunction_BLG.Visible = true;
                labelStatus_BLG.Text = "Построена диаграмма сравнения количеств";
            }
            /*if (currentData.Any())
            {
                BuildPriceChart();
            }*/
        }

        /*private void BuildPriceChart()
        {
            chartFunction_BLG.Series.Clear();
            chartFunction_BLG.Titles.Clear();

            // Сортируем по цене для лучшего отображения
            var sortedData = currentData.OrderBy(p => p.UnitPrice).ToList();

            Series priceSeries = new Series("Стоимость товаров");
            priceSeries.ChartType = SeriesChartType.Line;
            priceSeries.BorderWidth = 3;

            foreach (var product in sortedData)
            {
                priceSeries.Points.AddXY(product.Name, product.UnitPrice);
            }

            chartFunction_BLG.Series.Add(priceSeries);
            chartFunction_BLG.Titles.Add("График стоимости товаров");
            chartFunction_BLG.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartFunction_BLG.ChartAreas[0].AxisX.Interval = 1;

            chartFunction_BLG.Visible = true;
            labelStatus_BLG.Text = "Построен график стоимости товаров";
        }*/

        private void buttonReset_BLG_Click(object sender, EventArgs e)
        {
            // Сбрасываем все фильтры и сортировки
            if (!isStatisticsMode)
            {
                currentData = ds.SortBy("id", true);
                BindDataGridView(currentData);
            }

            textBoxSearch_BLG.Clear();
            textBoxFilterPrice_BLG.Clear();
            textBoxFilterQuantity_BLG.Clear();
            chartFunction_BLG.Visible = false;
            isStatisticsMode = false;
            labelStatus_BLG.Text = "Фильтры сброшены";
        }

        private void BindDataGridView(List<Product> data)
        {
            dataGridViewData_BLG.DataSource = data;
            dataGridViewData_BLG.Refresh();
        }

        // Событие для обновления данных после редактирования
        private void dataGridViewData_BLG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Обновляем текущие данные при редактировании ячеек
            if (dataGridViewData_BLG.DataSource is List<Product>)
            {
                currentData = (List<Product>)dataGridViewData_BLG.DataSource;
            }
        }
        private void ButtonHelp_BLG_Click(object sender, EventArgs e)
        {
            FormAbout_BLG formAbout_BLG = new FormAbout_BLG();
            formAbout_BLG.ShowDialog();
        }
    }
}
