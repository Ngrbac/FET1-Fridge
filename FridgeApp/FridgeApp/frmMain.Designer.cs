namespace FridgeApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFridgeItems = new System.Windows.Forms.GroupBox();
            this.btnAddFridgeItem = new System.Windows.Forms.Button();
            this.dgvFridgeGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fridgeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsFridgeData = new System.Windows.Forms.BindingSource(this.components);
            this.dsFridgeGrid = new System.Data.DataSet();
            this.dtFridgeData = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnFoodItems = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbFridgeItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridgeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFridgeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFridgeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFridgeData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFridgeItems
            // 
            this.gbFridgeItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFridgeItems.Controls.Add(this.btnAddFridgeItem);
            this.gbFridgeItems.Controls.Add(this.dgvFridgeGrid);
            this.gbFridgeItems.Controls.Add(this.lblSearch);
            this.gbFridgeItems.Controls.Add(this.tbSearch);
            this.gbFridgeItems.Location = new System.Drawing.Point(307, 12);
            this.gbFridgeItems.Name = "gbFridgeItems";
            this.gbFridgeItems.Size = new System.Drawing.Size(578, 503);
            this.gbFridgeItems.TabIndex = 0;
            this.gbFridgeItems.TabStop = false;
            this.gbFridgeItems.Text = "Fridge items";
            // 
            // btnAddFridgeItem
            // 
            this.btnAddFridgeItem.Location = new System.Drawing.Point(23, 28);
            this.btnAddFridgeItem.Name = "btnAddFridgeItem";
            this.btnAddFridgeItem.Size = new System.Drawing.Size(92, 26);
            this.btnAddFridgeItem.TabIndex = 3;
            this.btnAddFridgeItem.Text = "Add";
            this.btnAddFridgeItem.UseVisualStyleBackColor = true;
            this.btnAddFridgeItem.Click += new System.EventHandler(this.btnAddFridgeItem_Click);
            // 
            // dgvFridgeGrid
            // 
            this.dgvFridgeGrid.AllowUserToAddRows = false;
            this.dgvFridgeGrid.AllowUserToDeleteRows = false;
            this.dgvFridgeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFridgeGrid.AutoGenerateColumns = false;
            this.dgvFridgeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFridgeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.daysLeftDataGridViewTextBoxColumn});
            this.dgvFridgeGrid.DataSource = this.fridgeDataBindingSource;
            this.dgvFridgeGrid.Location = new System.Drawing.Point(6, 74);
            this.dgvFridgeGrid.Name = "dgvFridgeGrid";
            this.dgvFridgeGrid.ReadOnly = true;
            this.dgvFridgeGrid.Size = new System.Drawing.Size(566, 423);
            this.dgvFridgeGrid.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Measure";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysLeftDataGridViewTextBoxColumn
            // 
            this.daysLeftDataGridViewTextBoxColumn.DataPropertyName = "DaysLeft";
            this.daysLeftDataGridViewTextBoxColumn.HeaderText = "DaysLeft";
            this.daysLeftDataGridViewTextBoxColumn.Name = "daysLeftDataGridViewTextBoxColumn";
            this.daysLeftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fridgeDataBindingSource
            // 
            this.fridgeDataBindingSource.DataMember = "FridgeData";
            this.fridgeDataBindingSource.DataSource = this.bsFridgeData;
            // 
            // bsFridgeData
            // 
            this.bsFridgeData.DataSource = this.dsFridgeGrid;
            this.bsFridgeData.Position = 0;
            // 
            // dsFridgeGrid
            // 
            this.dsFridgeGrid.DataSetName = "NewDataSet";
            this.dsFridgeGrid.Tables.AddRange(new System.Data.DataTable[] {
            this.dtFridgeData});
            // 
            // dtFridgeData
            // 
            this.dtFridgeData.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dtFridgeData.TableName = "FridgeData";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Quantity";
            this.dataColumn2.DataType = typeof(decimal);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Measure";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Days left";
            this.dataColumn4.ColumnName = "DaysLeft";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(121, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearch.Location = new System.Drawing.Point(191, 27);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(381, 26);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // btnFoodItems
            // 
            this.btnFoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFoodItems.Location = new System.Drawing.Point(12, 25);
            this.btnFoodItems.Name = "btnFoodItems";
            this.btnFoodItems.Size = new System.Drawing.Size(277, 37);
            this.btnFoodItems.TabIndex = 1;
            this.btnFoodItems.Text = "Food items";
            this.btnFoodItems.UseVisualStyleBackColor = true;
            this.btnFoodItems.Click += new System.EventHandler(this.btnFoodItems_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 527);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFoodItems);
            this.Controls.Add(this.gbFridgeItems);
            this.Name = "frmMain";
            this.Text = "Refrigerator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbFridgeItems.ResumeLayout(false);
            this.gbFridgeItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridgeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFridgeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFridgeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFridgeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFridgeItems;
        private System.Windows.Forms.DataGridView dgvFridgeGrid;
        private System.Data.DataSet dsFridgeGrid;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fridgeDataBindingSource;
        private System.Windows.Forms.BindingSource bsFridgeData;
        private System.Data.DataTable dtFridgeData;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Button btnAddFridgeItem;
        private System.Windows.Forms.Button btnFoodItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

