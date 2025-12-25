using System.Windows.Forms;

namespace Tyuiu.BubenkoLG.Sprint7.Project.V5
{
    partial class FormMain_BLG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BLG));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMainButton_BLG = new Panel();
            buttonReset_BLG = new Button();
            groupBoxNameWare_BLG = new GroupBox();
            textBoxSearch_BLG = new TextBox();
            buttonStatistics_BLG = new Button();
            buttonSearch_BLG = new Button();
            buttonHelp_BLG = new Button();
            buttonFunction_BLG = new Button();
            buttonSaveData_BLG = new Button();
            buttonOpenFile_BLG = new Button();
            splitterButton_BLG = new Splitter();
            saveFileDialog_BLG = new SaveFileDialog();
            panelFilterButton_BLG = new Panel();
            groupBoxFilter_BLG = new GroupBox();
            groupBoxQuantity_BLG = new GroupBox();
            buttonFilterByQuantity_BLG = new Button();
            textBoxFilterQuantity_BLG = new TextBox();
            groupBoxFilterPrice_BLG = new GroupBox();
            buttonFilterByPrice_BLG = new Button();
            textBoxFilterPrice_BLG = new TextBox();
            groupBoxDate_BLG = new GroupBox();
            buttonFilterByDate_BLG = new Button();
            dateTimePickerFilter_BLG = new DateTimePicker();
            splitterFilterAndSort_BLG = new Splitter();
            panelSortButton_BLG = new Panel();
            groupBoxSort_BLG = new GroupBox();
            buttonSortByDateDesc_BLG = new Button();
            buttonSortByDateAsc_BLG = new Button();
            buttonSortByPriceDesc_BLG = new Button();
            buttonSortByPriceAsc_BLG = new Button();
            buttonSortByQuantityDesc_BLG = new Button();
            buttonSortByQuantityAsc_BLG = new Button();
            buttonSortByName_BLG = new Button();
            splitterSortAndDataAndChart_BLG = new Splitter();
            panelLabel_BLG = new Panel();
            labelStatus_BLG = new Label();
            splitterDataAndChartAndLabel_BLG = new Splitter();
            splitContainerDataAndChart_BLG = new SplitContainer();
            groupBoxData_BLG = new GroupBox();
            dataGridViewData_BLG = new DataGridView();
            chartFunction_BLG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialog_BLG = new OpenFileDialog();
            toolTipSeeCatalog_BLG = new ToolTip(components);
            toolTipSaveData_BLG = new ToolTip(components);
            toolTipSeeStatistics_BLG = new ToolTip(components);
            toolTipBuildChart_BLG = new ToolTip(components);
            toolTipDataReset_BLG = new ToolTip(components);
            toolTipHelp_BLG = new ToolTip(components);
            panelMainButton_BLG.SuspendLayout();
            groupBoxNameWare_BLG.SuspendLayout();
            panelFilterButton_BLG.SuspendLayout();
            groupBoxFilter_BLG.SuspendLayout();
            groupBoxQuantity_BLG.SuspendLayout();
            groupBoxFilterPrice_BLG.SuspendLayout();
            groupBoxDate_BLG.SuspendLayout();
            panelSortButton_BLG.SuspendLayout();
            groupBoxSort_BLG.SuspendLayout();
            panelLabel_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerDataAndChart_BLG).BeginInit();
            splitContainerDataAndChart_BLG.Panel1.SuspendLayout();
            splitContainerDataAndChart_BLG.Panel2.SuspendLayout();
            splitContainerDataAndChart_BLG.SuspendLayout();
            groupBoxData_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_BLG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BLG).BeginInit();
            SuspendLayout();
            // 
            // panelMainButton_BLG
            // 
            panelMainButton_BLG.Controls.Add(buttonReset_BLG);
            panelMainButton_BLG.Controls.Add(groupBoxNameWare_BLG);
            panelMainButton_BLG.Controls.Add(buttonStatistics_BLG);
            panelMainButton_BLG.Controls.Add(buttonSearch_BLG);
            panelMainButton_BLG.Controls.Add(buttonHelp_BLG);
            panelMainButton_BLG.Controls.Add(buttonFunction_BLG);
            panelMainButton_BLG.Controls.Add(buttonSaveData_BLG);
            panelMainButton_BLG.Controls.Add(buttonOpenFile_BLG);
            panelMainButton_BLG.Controls.Add(splitterButton_BLG);
            panelMainButton_BLG.Dock = DockStyle.Top;
            panelMainButton_BLG.Location = new Point(0, 0);
            panelMainButton_BLG.Name = "panelMainButton_BLG";
            panelMainButton_BLG.Size = new Size(1974, 155);
            panelMainButton_BLG.TabIndex = 0;
            // 
            // buttonReset_BLG
            // 
            buttonReset_BLG.BackColor = SystemColors.ControlLight;
            buttonReset_BLG.Cursor = Cursors.Hand;
            buttonReset_BLG.Enabled = false;
            buttonReset_BLG.Image = (Image)resources.GetObject("buttonReset_BLG.Image");
            buttonReset_BLG.Location = new Point(964, 12);
            buttonReset_BLG.Name = "buttonReset_BLG";
            buttonReset_BLG.Size = new Size(232, 125);
            buttonReset_BLG.TabIndex = 7;
            toolTipDataReset_BLG.SetToolTip(buttonReset_BLG, "Сбросить данные и вернуть исходную таблицу");
            buttonReset_BLG.UseVisualStyleBackColor = false;
            buttonReset_BLG.Click += buttonReset_BLG_Click;
            buttonReset_BLG.MouseEnter += buttonReset_BLG_MouseEnter;
            // 
            // groupBoxNameWare_BLG
            // 
            groupBoxNameWare_BLG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxNameWare_BLG.Controls.Add(textBoxSearch_BLG);
            groupBoxNameWare_BLG.Location = new Point(1226, 33);
            groupBoxNameWare_BLG.Name = "groupBoxNameWare_BLG";
            groupBoxNameWare_BLG.RightToLeft = RightToLeft.No;
            groupBoxNameWare_BLG.Size = new Size(395, 87);
            groupBoxNameWare_BLG.TabIndex = 6;
            groupBoxNameWare_BLG.TabStop = false;
            groupBoxNameWare_BLG.Text = "Название товара";
            // 
            // textBoxSearch_BLG
            // 
            textBoxSearch_BLG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch_BLG.Cursor = Cursors.IBeam;
            textBoxSearch_BLG.Location = new Point(16, 34);
            textBoxSearch_BLG.Name = "textBoxSearch_BLG";
            textBoxSearch_BLG.Size = new Size(367, 39);
            textBoxSearch_BLG.TabIndex = 4;
            // 
            // buttonStatistics_BLG
            // 
            buttonStatistics_BLG.BackColor = SystemColors.ControlLight;
            buttonStatistics_BLG.Cursor = Cursors.Hand;
            buttonStatistics_BLG.Enabled = false;
            buttonStatistics_BLG.Image = (Image)resources.GetObject("buttonStatistics_BLG.Image");
            buttonStatistics_BLG.Location = new Point(488, 12);
            buttonStatistics_BLG.Name = "buttonStatistics_BLG";
            buttonStatistics_BLG.Size = new Size(232, 125);
            buttonStatistics_BLG.TabIndex = 5;
            toolTipSeeStatistics_BLG.SetToolTip(buttonStatistics_BLG, "Составить статистику на основе загруженных данных");
            buttonStatistics_BLG.UseVisualStyleBackColor = false;
            buttonStatistics_BLG.Click += buttonStatistics_BLG_Click;
            buttonStatistics_BLG.MouseEnter += buttonStatistics_BLG_MouseEnter;
            // 
            // buttonSearch_BLG
            // 
            buttonSearch_BLG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_BLG.BackColor = Color.FromArgb(192, 255, 255);
            buttonSearch_BLG.Cursor = Cursors.Hand;
            buttonSearch_BLG.Location = new Point(1627, 55);
            buttonSearch_BLG.Name = "buttonSearch_BLG";
            buttonSearch_BLG.Size = new Size(181, 51);
            buttonSearch_BLG.TabIndex = 0;
            buttonSearch_BLG.Text = "Найти";
            buttonSearch_BLG.UseVisualStyleBackColor = false;
            buttonSearch_BLG.Click += buttonSearch_BLG_Click;
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BLG.BackColor = SystemColors.ControlLight;
            buttonHelp_BLG.Cursor = Cursors.Hand;
            buttonHelp_BLG.Image = (Image)resources.GetObject("buttonHelp_BLG.Image");
            buttonHelp_BLG.Location = new Point(1826, 12);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(136, 125);
            buttonHelp_BLG.TabIndex = 3;
            toolTipHelp_BLG.SetToolTip(buttonHelp_BLG, "Информация о разработчике и программе ");
            buttonHelp_BLG.UseVisualStyleBackColor = false;
            buttonHelp_BLG.Click += ButtonHelp_BLG_Click;
            buttonHelp_BLG.MouseEnter += buttonHelp_BLG_MouseEnter;
            // 
            // buttonFunction_BLG
            // 
            buttonFunction_BLG.BackColor = SystemColors.ControlLight;
            buttonFunction_BLG.Cursor = Cursors.Hand;
            buttonFunction_BLG.Enabled = false;
            buttonFunction_BLG.Image = (Image)resources.GetObject("buttonFunction_BLG.Image");
            buttonFunction_BLG.Location = new Point(726, 12);
            buttonFunction_BLG.Name = "buttonFunction_BLG";
            buttonFunction_BLG.Size = new Size(232, 125);
            buttonFunction_BLG.TabIndex = 3;
            toolTipBuildChart_BLG.SetToolTip(buttonFunction_BLG, "Построить график на основе статистики");
            buttonFunction_BLG.UseVisualStyleBackColor = false;
            buttonFunction_BLG.Click += buttonFunction_BLG_Click;
            buttonFunction_BLG.MouseEnter += buttonFunction_BLG_MouseEnter;
            // 
            // buttonSaveData_BLG
            // 
            buttonSaveData_BLG.BackColor = SystemColors.ControlLight;
            buttonSaveData_BLG.Cursor = Cursors.Hand;
            buttonSaveData_BLG.Enabled = false;
            buttonSaveData_BLG.Image = (Image)resources.GetObject("buttonSaveData_BLG.Image");
            buttonSaveData_BLG.Location = new Point(250, 12);
            buttonSaveData_BLG.Name = "buttonSaveData_BLG";
            buttonSaveData_BLG.Size = new Size(232, 125);
            buttonSaveData_BLG.TabIndex = 2;
            toolTipSaveData_BLG.SetToolTip(buttonSaveData_BLG, "Сохранить таблицу с данными");
            buttonSaveData_BLG.UseVisualStyleBackColor = false;
            buttonSaveData_BLG.Click += buttonSaveData_BLG_Click;
            buttonSaveData_BLG.MouseEnter += buttonSaveData_BLG_MouseEnter;
            // 
            // buttonOpenFile_BLG
            // 
            buttonOpenFile_BLG.BackColor = SystemColors.ControlLight;
            buttonOpenFile_BLG.Cursor = Cursors.Hand;
            buttonOpenFile_BLG.Image = (Image)resources.GetObject("buttonOpenFile_BLG.Image");
            buttonOpenFile_BLG.Location = new Point(12, 12);
            buttonOpenFile_BLG.Name = "buttonOpenFile_BLG";
            buttonOpenFile_BLG.Size = new Size(232, 125);
            buttonOpenFile_BLG.TabIndex = 1;
            toolTipSeeCatalog_BLG.SetToolTip(buttonOpenFile_BLG, "Открыть файл с данными о товарах");
            buttonOpenFile_BLG.UseVisualStyleBackColor = false;
            buttonOpenFile_BLG.EnabledChanged += buttonOpenFile_BLG_Click;
            buttonOpenFile_BLG.Click += buttonOpenFile_BLG_Click;
            buttonOpenFile_BLG.MouseEnter += buttonOpenFile_BLG_MouseEnter;
            // 
            // splitterButton_BLG
            // 
            splitterButton_BLG.Dock = DockStyle.Bottom;
            splitterButton_BLG.Location = new Point(0, 149);
            splitterButton_BLG.Name = "splitterButton_BLG";
            splitterButton_BLG.Size = new Size(1974, 6);
            splitterButton_BLG.TabIndex = 0;
            splitterButton_BLG.TabStop = false;
            // 
            // saveFileDialog_BLG
            // 
            saveFileDialog_BLG.FileName = "OutPutFileData.csv";
            // 
            // panelFilterButton_BLG
            // 
            panelFilterButton_BLG.Controls.Add(groupBoxFilter_BLG);
            panelFilterButton_BLG.Controls.Add(splitterFilterAndSort_BLG);
            panelFilterButton_BLG.Dock = DockStyle.Top;
            panelFilterButton_BLG.Location = new Point(0, 155);
            panelFilterButton_BLG.Name = "panelFilterButton_BLG";
            panelFilterButton_BLG.Size = new Size(1974, 210);
            panelFilterButton_BLG.TabIndex = 1;
            // 
            // groupBoxFilter_BLG
            // 
            groupBoxFilter_BLG.Controls.Add(groupBoxQuantity_BLG);
            groupBoxFilter_BLG.Controls.Add(groupBoxFilterPrice_BLG);
            groupBoxFilter_BLG.Controls.Add(groupBoxDate_BLG);
            groupBoxFilter_BLG.Dock = DockStyle.Fill;
            groupBoxFilter_BLG.Location = new Point(0, 0);
            groupBoxFilter_BLG.Margin = new Padding(0, 3, 3, 3);
            groupBoxFilter_BLG.Name = "groupBoxFilter_BLG";
            groupBoxFilter_BLG.Size = new Size(1974, 204);
            groupBoxFilter_BLG.TabIndex = 1;
            groupBoxFilter_BLG.TabStop = false;
            groupBoxFilter_BLG.Text = "Фильтрация данных";
            // 
            // groupBoxQuantity_BLG
            // 
            groupBoxQuantity_BLG.Controls.Add(buttonFilterByQuantity_BLG);
            groupBoxQuantity_BLG.Controls.Add(textBoxFilterQuantity_BLG);
            groupBoxQuantity_BLG.Location = new Point(643, 38);
            groupBoxQuantity_BLG.Name = "groupBoxQuantity_BLG";
            groupBoxQuantity_BLG.Size = new Size(271, 154);
            groupBoxQuantity_BLG.TabIndex = 3;
            groupBoxQuantity_BLG.TabStop = false;
            groupBoxQuantity_BLG.Text = "Количество от";
            // 
            // buttonFilterByQuantity_BLG
            // 
            buttonFilterByQuantity_BLG.BackColor = Color.FromArgb(192, 255, 255);
            buttonFilterByQuantity_BLG.Cursor = Cursors.Hand;
            buttonFilterByQuantity_BLG.Location = new Point(19, 93);
            buttonFilterByQuantity_BLG.Name = "buttonFilterByQuantity_BLG";
            buttonFilterByQuantity_BLG.Size = new Size(153, 40);
            buttonFilterByQuantity_BLG.TabIndex = 2;
            buttonFilterByQuantity_BLG.Text = "ОК";
            buttonFilterByQuantity_BLG.UseVisualStyleBackColor = false;
            buttonFilterByQuantity_BLG.Click += buttonFilterByQuantity_BLG_Click;
            // 
            // textBoxFilterQuantity_BLG
            // 
            textBoxFilterQuantity_BLG.Cursor = Cursors.IBeam;
            textBoxFilterQuantity_BLG.Location = new Point(19, 48);
            textBoxFilterQuantity_BLG.Name = "textBoxFilterQuantity_BLG";
            textBoxFilterQuantity_BLG.Size = new Size(223, 39);
            textBoxFilterQuantity_BLG.TabIndex = 2;
            // 
            // groupBoxFilterPrice_BLG
            // 
            groupBoxFilterPrice_BLG.Controls.Add(buttonFilterByPrice_BLG);
            groupBoxFilterPrice_BLG.Controls.Add(textBoxFilterPrice_BLG);
            groupBoxFilterPrice_BLG.Location = new Point(356, 38);
            groupBoxFilterPrice_BLG.Name = "groupBoxFilterPrice_BLG";
            groupBoxFilterPrice_BLG.Size = new Size(271, 154);
            groupBoxFilterPrice_BLG.TabIndex = 1;
            groupBoxFilterPrice_BLG.TabStop = false;
            groupBoxFilterPrice_BLG.Text = "Цена от";
            // 
            // buttonFilterByPrice_BLG
            // 
            buttonFilterByPrice_BLG.BackColor = Color.FromArgb(192, 255, 255);
            buttonFilterByPrice_BLG.Cursor = Cursors.Hand;
            buttonFilterByPrice_BLG.Location = new Point(19, 93);
            buttonFilterByPrice_BLG.Name = "buttonFilterByPrice_BLG";
            buttonFilterByPrice_BLG.Size = new Size(153, 40);
            buttonFilterByPrice_BLG.TabIndex = 2;
            buttonFilterByPrice_BLG.Text = "ОК";
            buttonFilterByPrice_BLG.UseVisualStyleBackColor = false;
            buttonFilterByPrice_BLG.Click += buttonFilterByPrice_BLG_Click;
            // 
            // textBoxFilterPrice_BLG
            // 
            textBoxFilterPrice_BLG.Cursor = Cursors.IBeam;
            textBoxFilterPrice_BLG.Location = new Point(19, 48);
            textBoxFilterPrice_BLG.Name = "textBoxFilterPrice_BLG";
            textBoxFilterPrice_BLG.Size = new Size(223, 39);
            textBoxFilterPrice_BLG.TabIndex = 2;
            // 
            // groupBoxDate_BLG
            // 
            groupBoxDate_BLG.Controls.Add(buttonFilterByDate_BLG);
            groupBoxDate_BLG.Controls.Add(dateTimePickerFilter_BLG);
            groupBoxDate_BLG.Location = new Point(12, 38);
            groupBoxDate_BLG.Name = "groupBoxDate_BLG";
            groupBoxDate_BLG.Size = new Size(329, 154);
            groupBoxDate_BLG.TabIndex = 0;
            groupBoxDate_BLG.TabStop = false;
            groupBoxDate_BLG.Text = "Дата";
            // 
            // buttonFilterByDate_BLG
            // 
            buttonFilterByDate_BLG.BackColor = Color.FromArgb(192, 255, 255);
            buttonFilterByDate_BLG.Cursor = Cursors.Hand;
            buttonFilterByDate_BLG.Location = new Point(17, 93);
            buttonFilterByDate_BLG.Name = "buttonFilterByDate_BLG";
            buttonFilterByDate_BLG.Size = new Size(153, 40);
            buttonFilterByDate_BLG.TabIndex = 1;
            buttonFilterByDate_BLG.Text = "ОК";
            buttonFilterByDate_BLG.UseVisualStyleBackColor = false;
            buttonFilterByDate_BLG.Click += buttonFilterByDate_BLG_Click;
            // 
            // dateTimePickerFilter_BLG
            // 
            dateTimePickerFilter_BLG.Cursor = Cursors.Hand;
            dateTimePickerFilter_BLG.Location = new Point(17, 48);
            dateTimePickerFilter_BLG.Name = "dateTimePickerFilter_BLG";
            dateTimePickerFilter_BLG.Size = new Size(294, 39);
            dateTimePickerFilter_BLG.TabIndex = 0;
            // 
            // splitterFilterAndSort_BLG
            // 
            splitterFilterAndSort_BLG.Dock = DockStyle.Bottom;
            splitterFilterAndSort_BLG.Location = new Point(0, 204);
            splitterFilterAndSort_BLG.Name = "splitterFilterAndSort_BLG";
            splitterFilterAndSort_BLG.Size = new Size(1974, 6);
            splitterFilterAndSort_BLG.TabIndex = 0;
            splitterFilterAndSort_BLG.TabStop = false;
            // 
            // panelSortButton_BLG
            // 
            panelSortButton_BLG.Controls.Add(groupBoxSort_BLG);
            panelSortButton_BLG.Controls.Add(splitterSortAndDataAndChart_BLG);
            panelSortButton_BLG.Dock = DockStyle.Top;
            panelSortButton_BLG.Location = new Point(0, 365);
            panelSortButton_BLG.Name = "panelSortButton_BLG";
            panelSortButton_BLG.Size = new Size(1974, 123);
            panelSortButton_BLG.TabIndex = 2;
            // 
            // groupBoxSort_BLG
            // 
            groupBoxSort_BLG.Controls.Add(buttonSortByDateDesc_BLG);
            groupBoxSort_BLG.Controls.Add(buttonSortByDateAsc_BLG);
            groupBoxSort_BLG.Controls.Add(buttonSortByPriceDesc_BLG);
            groupBoxSort_BLG.Controls.Add(buttonSortByPriceAsc_BLG);
            groupBoxSort_BLG.Controls.Add(buttonSortByQuantityDesc_BLG);
            groupBoxSort_BLG.Controls.Add(buttonSortByQuantityAsc_BLG);
            groupBoxSort_BLG.Controls.Add(buttonSortByName_BLG);
            groupBoxSort_BLG.Dock = DockStyle.Fill;
            groupBoxSort_BLG.Location = new Point(0, 0);
            groupBoxSort_BLG.Name = "groupBoxSort_BLG";
            groupBoxSort_BLG.Size = new Size(1974, 117);
            groupBoxSort_BLG.TabIndex = 1;
            groupBoxSort_BLG.TabStop = false;
            groupBoxSort_BLG.Text = "Сортировка данных";
            // 
            // buttonSortByDateDesc_BLG
            // 
            buttonSortByDateDesc_BLG.Cursor = Cursors.Hand;
            buttonSortByDateDesc_BLG.Location = new Point(1452, 38);
            buttonSortByDateDesc_BLG.Name = "buttonSortByDateDesc_BLG";
            buttonSortByDateDesc_BLG.Size = new Size(234, 65);
            buttonSortByDateDesc_BLG.TabIndex = 6;
            buttonSortByDateDesc_BLG.Text = "По дате ↓";
            buttonSortByDateDesc_BLG.UseVisualStyleBackColor = true;
            buttonSortByDateDesc_BLG.Click += buttonSortByDateDesc_BLG_Click;
            // 
            // buttonSortByDateAsc_BLG
            // 
            buttonSortByDateAsc_BLG.Cursor = Cursors.Hand;
            buttonSortByDateAsc_BLG.Location = new Point(1212, 38);
            buttonSortByDateAsc_BLG.Name = "buttonSortByDateAsc_BLG";
            buttonSortByDateAsc_BLG.Size = new Size(234, 65);
            buttonSortByDateAsc_BLG.TabIndex = 5;
            buttonSortByDateAsc_BLG.Text = "По дате ↑";
            buttonSortByDateAsc_BLG.UseVisualStyleBackColor = true;
            buttonSortByDateAsc_BLG.Click += buttonSortByDateAsc_BLG_Click;
            // 
            // buttonSortByPriceDesc_BLG
            // 
            buttonSortByPriceDesc_BLG.Cursor = Cursors.Hand;
            buttonSortByPriceDesc_BLG.Location = new Point(972, 38);
            buttonSortByPriceDesc_BLG.Name = "buttonSortByPriceDesc_BLG";
            buttonSortByPriceDesc_BLG.Size = new Size(234, 65);
            buttonSortByPriceDesc_BLG.TabIndex = 4;
            buttonSortByPriceDesc_BLG.Text = "По цене ↓";
            buttonSortByPriceDesc_BLG.UseVisualStyleBackColor = true;
            buttonSortByPriceDesc_BLG.Click += buttonSortByPriceDesc_BLG_Click;
            // 
            // buttonSortByPriceAsc_BLG
            // 
            buttonSortByPriceAsc_BLG.Cursor = Cursors.Hand;
            buttonSortByPriceAsc_BLG.Location = new Point(732, 38);
            buttonSortByPriceAsc_BLG.Name = "buttonSortByPriceAsc_BLG";
            buttonSortByPriceAsc_BLG.Size = new Size(234, 65);
            buttonSortByPriceAsc_BLG.TabIndex = 3;
            buttonSortByPriceAsc_BLG.Text = "По цене ↑";
            buttonSortByPriceAsc_BLG.UseVisualStyleBackColor = true;
            buttonSortByPriceAsc_BLG.Click += buttonSortByPriceAsc_BLG_Click;
            // 
            // buttonSortByQuantityDesc_BLG
            // 
            buttonSortByQuantityDesc_BLG.Cursor = Cursors.Hand;
            buttonSortByQuantityDesc_BLG.Location = new Point(492, 38);
            buttonSortByQuantityDesc_BLG.Name = "buttonSortByQuantityDesc_BLG";
            buttonSortByQuantityDesc_BLG.Size = new Size(234, 65);
            buttonSortByQuantityDesc_BLG.TabIndex = 2;
            buttonSortByQuantityDesc_BLG.Text = "По количеству ↓";
            buttonSortByQuantityDesc_BLG.UseVisualStyleBackColor = true;
            buttonSortByQuantityDesc_BLG.Click += buttonSortByQuantityDesc_BLG_Click;
            // 
            // buttonSortByQuantityAsc_BLG
            // 
            buttonSortByQuantityAsc_BLG.Cursor = Cursors.Hand;
            buttonSortByQuantityAsc_BLG.Location = new Point(252, 38);
            buttonSortByQuantityAsc_BLG.Name = "buttonSortByQuantityAsc_BLG";
            buttonSortByQuantityAsc_BLG.Size = new Size(234, 65);
            buttonSortByQuantityAsc_BLG.TabIndex = 1;
            buttonSortByQuantityAsc_BLG.Text = "По количеству ↑";
            buttonSortByQuantityAsc_BLG.UseVisualStyleBackColor = true;
            buttonSortByQuantityAsc_BLG.Click += buttonSortByQuantityAsc_BLG_Click;
            // 
            // buttonSortByName_BLG
            // 
            buttonSortByName_BLG.Cursor = Cursors.Hand;
            buttonSortByName_BLG.Location = new Point(12, 38);
            buttonSortByName_BLG.Name = "buttonSortByName_BLG";
            buttonSortByName_BLG.Size = new Size(234, 65);
            buttonSortByName_BLG.TabIndex = 0;
            buttonSortByName_BLG.Text = "По названию (А-Я)";
            buttonSortByName_BLG.UseVisualStyleBackColor = true;
            buttonSortByName_BLG.Click += buttonSortByName_BLG_Click;
            // 
            // splitterSortAndDataAndChart_BLG
            // 
            splitterSortAndDataAndChart_BLG.Dock = DockStyle.Bottom;
            splitterSortAndDataAndChart_BLG.Location = new Point(0, 117);
            splitterSortAndDataAndChart_BLG.Name = "splitterSortAndDataAndChart_BLG";
            splitterSortAndDataAndChart_BLG.Size = new Size(1974, 6);
            splitterSortAndDataAndChart_BLG.TabIndex = 0;
            splitterSortAndDataAndChart_BLG.TabStop = false;
            // 
            // panelLabel_BLG
            // 
            panelLabel_BLG.Controls.Add(labelStatus_BLG);
            panelLabel_BLG.Controls.Add(splitterDataAndChartAndLabel_BLG);
            panelLabel_BLG.Dock = DockStyle.Bottom;
            panelLabel_BLG.Location = new Point(0, 1307);
            panelLabel_BLG.Name = "panelLabel_BLG";
            panelLabel_BLG.Padding = new Padding(3, 0, 0, 10);
            panelLabel_BLG.Size = new Size(1974, 103);
            panelLabel_BLG.TabIndex = 3;
            // 
            // labelStatus_BLG
            // 
            labelStatus_BLG.AutoSize = true;
            labelStatus_BLG.Dock = DockStyle.Fill;
            labelStatus_BLG.Location = new Point(3, 6);
            labelStatus_BLG.Name = "labelStatus_BLG";
            labelStatus_BLG.Size = new Size(210, 32);
            labelStatus_BLG.TabIndex = 1;
            labelStatus_BLG.Text = "Строка состояния";
            // 
            // splitterDataAndChartAndLabel_BLG
            // 
            splitterDataAndChartAndLabel_BLG.Dock = DockStyle.Top;
            splitterDataAndChartAndLabel_BLG.Location = new Point(3, 0);
            splitterDataAndChartAndLabel_BLG.Name = "splitterDataAndChartAndLabel_BLG";
            splitterDataAndChartAndLabel_BLG.Size = new Size(1971, 6);
            splitterDataAndChartAndLabel_BLG.TabIndex = 0;
            splitterDataAndChartAndLabel_BLG.TabStop = false;
            // 
            // splitContainerDataAndChart_BLG
            // 
            splitContainerDataAndChart_BLG.Dock = DockStyle.Fill;
            splitContainerDataAndChart_BLG.Location = new Point(0, 488);
            splitContainerDataAndChart_BLG.Name = "splitContainerDataAndChart_BLG";
            // 
            // splitContainerDataAndChart_BLG.Panel1
            // 
            splitContainerDataAndChart_BLG.Panel1.Controls.Add(groupBoxData_BLG);
            // 
            // splitContainerDataAndChart_BLG.Panel2
            // 
            splitContainerDataAndChart_BLG.Panel2.Controls.Add(chartFunction_BLG);
            splitContainerDataAndChart_BLG.Size = new Size(1974, 819);
            splitContainerDataAndChart_BLG.SplitterDistance = 938;
            splitContainerDataAndChart_BLG.SplitterWidth = 15;
            splitContainerDataAndChart_BLG.TabIndex = 4;
            // 
            // groupBoxData_BLG
            // 
            groupBoxData_BLG.Controls.Add(dataGridViewData_BLG);
            groupBoxData_BLG.Dock = DockStyle.Fill;
            groupBoxData_BLG.Location = new Point(0, 0);
            groupBoxData_BLG.Margin = new Padding(3, 3, 0, 3);
            groupBoxData_BLG.Name = "groupBoxData_BLG";
            groupBoxData_BLG.Padding = new Padding(10);
            groupBoxData_BLG.Size = new Size(938, 819);
            groupBoxData_BLG.TabIndex = 0;
            groupBoxData_BLG.TabStop = false;
            groupBoxData_BLG.Text = "Данные и товаре и поставках";
            // 
            // dataGridViewData_BLG
            // 
            dataGridViewData_BLG.AllowUserToAddRows = false;
            dataGridViewData_BLG.BackgroundColor = SystemColors.ControlLight;
            dataGridViewData_BLG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_BLG.Dock = DockStyle.Fill;
            dataGridViewData_BLG.Location = new Point(10, 42);
            dataGridViewData_BLG.Name = "dataGridViewData_BLG";
            dataGridViewData_BLG.RowHeadersVisible = false;
            dataGridViewData_BLG.RowHeadersWidth = 82;
            dataGridViewData_BLG.Size = new Size(918, 767);
            dataGridViewData_BLG.TabIndex = 0;
            dataGridViewData_BLG.CellEndEdit += dataGridViewData_BLG_CellEndEdit;
            // 
            // chartFunction_BLG
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BLG.ChartAreas.Add(chartArea1);
            chartFunction_BLG.Dock = DockStyle.Fill;
            chartFunction_BLG.Location = new Point(0, 0);
            chartFunction_BLG.Name = "chartFunction_BLG";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunction_BLG.Series.Add(series1);
            chartFunction_BLG.Size = new Size(1021, 819);
            chartFunction_BLG.TabIndex = 0;
            chartFunction_BLG.Text = "chart1";
            // 
            // openFileDialog_BLG
            // 
            openFileDialog_BLG.FileName = "InputFileData.csv";
            // 
            // toolTipSeeCatalog_BLG
            // 
            toolTipSeeCatalog_BLG.IsBalloon = true;
            // 
            // toolTipSaveData_BLG
            // 
            toolTipSaveData_BLG.IsBalloon = true;
            // 
            // toolTipSeeStatistics_BLG
            // 
            toolTipSeeStatistics_BLG.IsBalloon = true;
            // 
            // toolTipBuildChart_BLG
            // 
            toolTipBuildChart_BLG.IsBalloon = true;
            // 
            // toolTipDataReset_BLG
            // 
            toolTipDataReset_BLG.IsBalloon = true;
            // 
            // toolTipHelp_BLG
            // 
            toolTipHelp_BLG.IsBalloon = true;
            // 
            // FormMain_BLG
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 1410);
            Controls.Add(splitContainerDataAndChart_BLG);
            Controls.Add(panelLabel_BLG);
            Controls.Add(panelSortButton_BLG);
            Controls.Add(panelFilterButton_BLG);
            Controls.Add(panelMainButton_BLG);
            MinimumSize = new Size(2000, 1065);
            Name = "FormMain_BLG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая база";
            panelMainButton_BLG.ResumeLayout(false);
            groupBoxNameWare_BLG.ResumeLayout(false);
            groupBoxNameWare_BLG.PerformLayout();
            panelFilterButton_BLG.ResumeLayout(false);
            groupBoxFilter_BLG.ResumeLayout(false);
            groupBoxQuantity_BLG.ResumeLayout(false);
            groupBoxQuantity_BLG.PerformLayout();
            groupBoxFilterPrice_BLG.ResumeLayout(false);
            groupBoxFilterPrice_BLG.PerformLayout();
            groupBoxDate_BLG.ResumeLayout(false);
            panelSortButton_BLG.ResumeLayout(false);
            groupBoxSort_BLG.ResumeLayout(false);
            panelLabel_BLG.ResumeLayout(false);
            panelLabel_BLG.PerformLayout();
            splitContainerDataAndChart_BLG.Panel1.ResumeLayout(false);
            splitContainerDataAndChart_BLG.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerDataAndChart_BLG).EndInit();
            splitContainerDataAndChart_BLG.ResumeLayout(false);
            groupBoxData_BLG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_BLG).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BLG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainButton_BLG;
        private Splitter splitterButton_BLG;
        private Button buttonOpenFile_BLG;
        private Button buttonSaveData_BLG;
        private Button buttonFunction_BLG;
        private Button buttonSearch_BLG;
        private Button buttonHelp_BLG;
        private TextBox textBoxSearch_BLG;
        private SaveFileDialog saveFileDialog_BLG;
        private Button buttonStatistics_BLG;
        private Panel panelFilterButton_BLG;
        private Panel panelSortButton_BLG;
        private Panel panelLabel_BLG;
        private SplitContainer splitContainerDataAndChart_BLG;
        private Splitter splitterFilterAndSort_BLG;
        private Splitter splitterSortAndDataAndChart_BLG;
        private Splitter splitterDataAndChartAndLabel_BLG;
        private GroupBox groupBoxFilter_BLG;
        private GroupBox groupBoxNameWare_BLG;
        private GroupBox groupBoxSort_BLG;
        private Button buttonReset_BLG;
        private Label labelStatus_BLG;
        private GroupBox groupBoxData_BLG;
        private DataGridView dataGridViewData_BLG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BLG;
        private GroupBox groupBoxDate_BLG;
        private Button buttonFilterByDate_BLG;
        private DateTimePicker dateTimePickerFilter_BLG;
        private GroupBox groupBoxFilterPrice_BLG;
        private Button buttonFilterByPrice_BLG;
        private TextBox textBoxFilterPrice_BLG;
        private GroupBox groupBoxQuantity_BLG;
        private Button buttonFilterByQuantity_BLG;
        private TextBox textBoxFilterQuantity_BLG;
        private Button buttonSortByName_BLG;
        private Button buttonSortByQuantityDesc_BLG;
        private Button buttonSortByQuantityAsc_BLG;
        private Button buttonSortByDateAsc_BLG;
        private Button buttonSortByPriceDesc_BLG;
        private Button buttonSortByPriceAsc_BLG;
        private Button buttonSortByDateDesc_BLG;
        private OpenFileDialog openFileDialog_BLG;
        private ToolTip toolTipSeeCatalog_BLG;
        private ToolTip toolTipSaveData_BLG;
        private ToolTip toolTipSeeStatistics_BLG;
        private ToolTip toolTipBuildChart_BLG;
        private ToolTip toolTipDataReset_BLG;
        private ToolTip toolTipHelp_BLG;
    }
}
