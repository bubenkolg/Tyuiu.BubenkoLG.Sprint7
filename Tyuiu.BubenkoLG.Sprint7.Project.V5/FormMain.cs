using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
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
            openFileDialog_BLG.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_BLG.Filter = "Значения разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private void InitializeDataGridView()
        {
            dataGridViewData_BLG.AutoGenerateColumns = false;
            dataGridViewData_BLG.Columns.Clear();

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
            DialogResult result = openFileDialog_BLG.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog_BLG.FileName;
                labelStatus_BLG.Text = "Загрузка файла...";
                Application.DoEvents();

                currentData = ds.LoadFromFile(filePath);
                BindDataGridView(currentData);
                isStatisticsMode = false;
                labelStatus_BLG.Text = $"Загружено {currentData.Count} записей из файла {Path.GetFileName(filePath)}";

                buttonSaveData_BLG.Enabled = true;
                buttonStatistics_BLG.Enabled = true;
                buttonFunction_BLG.Enabled = true;
                buttonReset_BLG.Enabled = true;
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
            if (decimal.TryParse(textBoxFilterPrice_BLG.Text, out decimal price))  //
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

                dataGridViewData_BLG.Columns.Clear();
                dataGridViewData_BLG.AutoGenerateColumns = true;

                DataTable statsTable = new DataTable();
                statsTable.Columns.Add("Показатель", typeof(string));
                statsTable.Columns.Add("Значение", typeof(string));

                statsTable.Rows.Add("Общее количество поставленных товаров", stats.TotalDeliveryQuantity.ToString("N0")); //
                statsTable.Rows.Add("Общая сумма поставленных товаров (руб.)", stats.TotalDeliveryValue.ToString("N2"));

                dataGridViewData_BLG.DataSource = statsTable;

                isStatisticsMode = true;
                labelStatus_BLG.Text = "Режим статистики";
                buttonFunction_BLG.Enabled = true;
            }
        }
        private void buttonFunction_BLG_Click(object sender, EventArgs e)
        {
            if (currentData.Any())
            {
                BuildPriceChart();
            }
        }
        public void SaveDataGridViewToFile(string filePath, DataGridView dataGridView)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    writer.Write(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.Columns.Count - 1)
                        writer.Write(";");
                }
                writer.WriteLine();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)  //
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            var cellValue = row.Cells[i].Value?.ToString() ?? "";  //
                            writer.Write(cellValue);

                            if (i < dataGridView.Columns.Count - 1)
                                writer.Write(";");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
        private void buttonSaveData_BLG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Сохранить данные",
                FileName = "OutPutFileData.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveDataGridViewToFile(saveFileDialog.FileName, dataGridViewData_BLG);
                MessageBox.Show("Данные успешно сохранены", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelStatus_BLG.Text = $"Данные сохранены в {saveFileDialog.FileName}";
            }
        }
        private void BuildPriceChart()
        {
            chartFunction_BLG.Series.Clear();
            chartFunction_BLG.Titles.Clear();

            var sortedData = currentData.OrderBy(p => p.UnitPrice).ToList();

            Series priceSeries = new Series("Стоимость товаров");
            priceSeries.ChartType = SeriesChartType.Pie;
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

        }
        private void buttonReset_BLG_Click(object sender, EventArgs e)
        {
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
            
            string filePath = openFileDialog_BLG.FileName;
            BindDataGridView(currentData);
            currentData = ds.LoadFromFile(filePath);
            labelStatus_BLG.Text = $"Загружено {currentData.Count} записей из файла {Path.GetFileName(filePath)}";
        }

        private void BindDataGridView(List<Product> data)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("StockQuantity", typeof(int));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("SupplierNumber", typeof(string));
            dt.Columns.Add("SupplierName", typeof(string));
            dt.Columns.Add("DeliveryDate", typeof(DateTime));
            dt.Columns.Add("DeliveryQuantity", typeof(int));

            foreach (var product in data)
            {
                dt.Rows.Add(
                    product.Id,
                    product.Name,
                    product.StockQuantity,
                    product.UnitPrice,
                    product.Description,
                    product.SupplierNumber,
                    product.SupplierName,
                    product.DeliveryDate,
                    product.DeliveryQuantity
                );
            }

            dataGridViewData_BLG.DataSource = dt;
            dataGridViewData_BLG.Refresh();
        }
        private void dataGridViewData_BLG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
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
        private void buttonOpenFile_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipSeeCatalog_BLG.ToolTipTitle = "Показать каталог";
        }
        private void buttonSaveData_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipSaveData_BLG.ToolTipTitle = "Сохранить";
        }
        private void buttonStatistics_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipSeeStatistics_BLG.ToolTipTitle = "Составить статистику";
        }
        private void buttonFunction_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipBuildChart_BLG.ToolTipTitle = "Построить диаграмму";
        }
        private void buttonReset_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipDataReset_BLG.ToolTipTitle = "Сброс";
        }
        private void buttonHelp_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_BLG.ToolTipTitle = "Справка";
        }
    }
}
