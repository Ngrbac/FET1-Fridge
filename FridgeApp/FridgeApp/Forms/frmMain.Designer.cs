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
            this.tbQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblFoodItem = new System.Windows.Forms.Label();
            this.cbFoodItem = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvFridgeGrid = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnFoodItems = new System.Windows.Forms.Button();
            this.btnRecipeBook = new System.Windows.Forms.Button();
            this.btnMeasurement = new System.Windows.Forms.Button();
            this.dsFridgeItems = new System.Data.DataSet();
            this.bsFridgeItems = new System.Windows.Forms.BindingSource(this.components);
            this.dtFridgeItems = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.fridgeItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDaysRemaining = new System.Windows.Forms.TextBox();
            this.lblDaysRemaining = new System.Windows.Forms.Label();
            this.dataColumn5 = new System.Data.DataColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysRemainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFridgeItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridgeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFridgeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFridgeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFridgeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFridgeItems
            // 
            this.gbFridgeItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFridgeItems.Controls.Add(this.tbDaysRemaining);
            this.gbFridgeItems.Controls.Add(this.lblDaysRemaining);
            this.gbFridgeItems.Controls.Add(this.tbQty);
            this.gbFridgeItems.Controls.Add(this.lblQty);
            this.gbFridgeItems.Controls.Add(this.lblFoodItem);
            this.gbFridgeItems.Controls.Add(this.cbFoodItem);
            this.gbFridgeItems.Controls.Add(this.btnEdit);
            this.gbFridgeItems.Controls.Add(this.btnDelete);
            this.gbFridgeItems.Controls.Add(this.btnSave);
            this.gbFridgeItems.Controls.Add(this.dgvFridgeGrid);
            this.gbFridgeItems.Controls.Add(this.lblSearch);
            this.gbFridgeItems.Controls.Add(this.tbSearch);
            this.gbFridgeItems.Location = new System.Drawing.Point(307, 12);
            this.gbFridgeItems.Name = "gbFridgeItems";
            this.gbFridgeItems.Size = new System.Drawing.Size(636, 503);
            this.gbFridgeItems.TabIndex = 0;
            this.gbFridgeItems.TabStop = false;
            this.gbFridgeItems.Text = "Fridge items";
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbQty.Location = new System.Drawing.Point(354, 23);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(60, 26);
            this.tbQty.TabIndex = 16;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQty.Location = new System.Drawing.Point(280, 26);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 20);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Quantity:";
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFoodItem.Location = new System.Drawing.Point(12, 26);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(84, 20);
            this.lblFoodItem.TabIndex = 14;
            this.lblFoodItem.Text = "Food item:";
            // 
            // cbFoodItem
            // 
            this.cbFoodItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFoodItem.FormattingEnabled = true;
            this.cbFoodItem.Location = new System.Drawing.Point(102, 23);
            this.cbFoodItem.Name = "cbFoodItem";
            this.cbFoodItem.Size = new System.Drawing.Size(168, 28);
            this.cbFoodItem.TabIndex = 13;
            this.cbFoodItem.SelectedIndexChanged += new System.EventHandler(this.cbFoodItem_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(339, 67);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(501, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(420, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.qtyDataGridViewTextBoxColumn,
            this.measurementDataGridViewTextBoxColumn,
            this.daysRemainingDataGridViewTextBoxColumn,
            this.ID});
            this.dgvFridgeGrid.DataSource = this.fridgeItemsBindingSource;
            this.dgvFridgeGrid.Location = new System.Drawing.Point(6, 151);
            this.dgvFridgeGrid.Name = "dgvFridgeGrid";
            this.dgvFridgeGrid.ReadOnly = true;
            this.dgvFridgeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFridgeGrid.Size = new System.Drawing.Size(624, 346);
            this.dgvFridgeGrid.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(32, 113);
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
            this.tbSearch.Location = new System.Drawing.Point(104, 110);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(528, 26);
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
            // btnRecipeBook
            // 
            this.btnRecipeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecipeBook.Location = new System.Drawing.Point(12, 68);
            this.btnRecipeBook.Name = "btnRecipeBook";
            this.btnRecipeBook.Size = new System.Drawing.Size(277, 37);
            this.btnRecipeBook.TabIndex = 2;
            this.btnRecipeBook.Text = "Recipe Book";
            this.btnRecipeBook.UseVisualStyleBackColor = true;
            this.btnRecipeBook.Click += new System.EventHandler(this.btnRecipeBook_Click);
            // 
            // btnMeasurement
            // 
            this.btnMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMeasurement.Location = new System.Drawing.Point(12, 111);
            this.btnMeasurement.Name = "btnMeasurement";
            this.btnMeasurement.Size = new System.Drawing.Size(277, 37);
            this.btnMeasurement.TabIndex = 3;
            this.btnMeasurement.Text = "Measurements";
            this.btnMeasurement.UseVisualStyleBackColor = true;
            this.btnMeasurement.Click += new System.EventHandler(this.btnMeasurement_Click);
            // 
            // dsFridgeItems
            // 
            this.dsFridgeItems.DataSetName = "NewDataSet";
            this.dsFridgeItems.Tables.AddRange(new System.Data.DataTable[] {
            this.dtFridgeItems});
            // 
            // bsFridgeItems
            // 
            this.bsFridgeItems.DataSource = this.dsFridgeItems;
            this.bsFridgeItems.Position = 0;
            // 
            // dtFridgeItems
            // 
            this.dtFridgeItems.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dtFridgeItems.TableName = "FridgeItems";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Qty";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Measurement";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "DaysRemaining";
            this.dataColumn4.DataType = typeof(int);
            // 
            // fridgeItemsBindingSource
            // 
            this.fridgeItemsBindingSource.DataMember = "FridgeItems";
            this.fridgeItemsBindingSource.DataSource = this.bsFridgeItems;
            // 
            // tbDaysRemaining
            // 
            this.tbDaysRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDaysRemaining.Location = new System.Drawing.Point(547, 23);
            this.tbDaysRemaining.Name = "tbDaysRemaining";
            this.tbDaysRemaining.Size = new System.Drawing.Size(60, 26);
            this.tbDaysRemaining.TabIndex = 18;
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDaysRemaining.Location = new System.Drawing.Point(420, 26);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(125, 20);
            this.lblDaysRemaining.TabIndex = 17;
            this.lblDaysRemaining.Text = "DaysRemaining:";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ID";
            this.dataColumn5.DataType = typeof(long);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measurementDataGridViewTextBoxColumn
            // 
            this.measurementDataGridViewTextBoxColumn.DataPropertyName = "Measurement";
            this.measurementDataGridViewTextBoxColumn.HeaderText = "Measurement";
            this.measurementDataGridViewTextBoxColumn.Name = "measurementDataGridViewTextBoxColumn";
            this.measurementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysRemainingDataGridViewTextBoxColumn
            // 
            this.daysRemainingDataGridViewTextBoxColumn.DataPropertyName = "DaysRemaining";
            this.daysRemainingDataGridViewTextBoxColumn.HeaderText = "DaysRemaining";
            this.daysRemainingDataGridViewTextBoxColumn.Name = "daysRemainingDataGridViewTextBoxColumn";
            this.daysRemainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 527);
            this.Controls.Add(this.btnMeasurement);
            this.Controls.Add(this.btnRecipeBook);
            this.Controls.Add(this.btnFoodItems);
            this.Controls.Add(this.gbFridgeItems);
            this.Name = "frmMain";
            this.Text = "Refrigerator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbFridgeItems.ResumeLayout(false);
            this.gbFridgeItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridgeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFridgeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFridgeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFridgeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFridgeItems;
        private System.Windows.Forms.DataGridView dgvFridgeGrid;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnFoodItems;
        private System.Windows.Forms.Button btnRecipeBook;
        private System.Windows.Forms.Button btnMeasurement;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblFoodItem;
        private System.Windows.Forms.ComboBox cbFoodItem;
        private System.Windows.Forms.BindingSource fridgeItemsBindingSource;
        private System.Windows.Forms.BindingSource bsFridgeItems;
        private System.Data.DataSet dsFridgeItems;
        private System.Data.DataTable dtFridgeItems;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.TextBox tbDaysRemaining;
        private System.Windows.Forms.Label lblDaysRemaining;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysRemainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

