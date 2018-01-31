namespace FridgeApp
{
    partial class frmFoodItems
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
            this.dgvFoodItems = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFoodItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsFoodItems = new System.Windows.Forms.BindingSource(this.components);
            this.dsFoodItems = new System.Data.DataSet();
            this.tblFoodItems = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbExpiresIn = new System.Windows.Forms.TextBox();
            this.cbMeasure = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoodItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFoodItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoodItems
            // 
            this.dgvFoodItems.AllowUserToAddRows = false;
            this.dgvFoodItems.AllowUserToDeleteRows = false;
            this.dgvFoodItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodItems.AutoGenerateColumns = false;
            this.dgvFoodItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.expiresInDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn});
            this.dgvFoodItems.DataSource = this.tblFoodItemsBindingSource;
            this.dgvFoodItems.Location = new System.Drawing.Point(12, 137);
            this.dgvFoodItems.MultiSelect = false;
            this.dgvFoodItems.Name = "dgvFoodItems";
            this.dgvFoodItems.ReadOnly = true;
            this.dgvFoodItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodItems.Size = new System.Drawing.Size(596, 322);
            this.dgvFoodItems.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiresInDataGridViewTextBoxColumn
            // 
            this.expiresInDataGridViewTextBoxColumn.DataPropertyName = "ExpiresIn";
            this.expiresInDataGridViewTextBoxColumn.HeaderText = "ExpiresIn";
            this.expiresInDataGridViewTextBoxColumn.Name = "expiresInDataGridViewTextBoxColumn";
            this.expiresInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Measure";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblFoodItemsBindingSource
            // 
            this.tblFoodItemsBindingSource.DataMember = "tblFoodItems";
            this.tblFoodItemsBindingSource.DataSource = this.bsFoodItems;
            // 
            // bsFoodItems
            // 
            this.bsFoodItems.DataSource = this.dsFoodItems;
            this.bsFoodItems.Position = 0;
            // 
            // dsFoodItems
            // 
            this.dsFoodItems.DataSetName = "NewDataSet";
            this.dsFoodItems.Tables.AddRange(new System.Data.DataTable[] {
            this.tblFoodItems});
            // 
            // tblFoodItems
            // 
            this.tblFoodItems.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.tblFoodItems.TableName = "tblFoodItems";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Name";
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ExpiresIn";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Measure";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(12, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(353, 26);
            this.tbName.TabIndex = 1;
            // 
            // tbExpiresIn
            // 
            this.tbExpiresIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbExpiresIn.Location = new System.Drawing.Point(371, 33);
            this.tbExpiresIn.Name = "tbExpiresIn";
            this.tbExpiresIn.Size = new System.Drawing.Size(110, 26);
            this.tbExpiresIn.TabIndex = 2;
            // 
            // cbMeasure
            // 
            this.cbMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMeasure.FormattingEnabled = true;
            this.cbMeasure.Location = new System.Drawing.Point(487, 33);
            this.cbMeasure.Name = "cbMeasure";
            this.cbMeasure.Size = new System.Drawing.Size(121, 28);
            this.cbMeasure.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(9, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpiry.Location = new System.Drawing.Point(368, 13);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(69, 17);
            this.lblExpiry.TabIndex = 5;
            this.lblExpiry.Text = "Expires in";
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMeasure.Location = new System.Drawing.Point(484, 11);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(63, 17);
            this.lblMeasure.TabIndex = 6;
            this.lblMeasure.Text = "Measure";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(452, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(533, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(371, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmFoodItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 471);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMeasure);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbMeasure);
            this.Controls.Add(this.tbExpiresIn);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvFoodItems);
            this.Name = "frmFoodItems";
            this.Text = "Food item";
            this.Load += new System.EventHandler(this.frmFoodItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoodItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFoodItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoodItems;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbExpiresIn;
        private System.Windows.Forms.ComboBox cbMeasure;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource tblFoodItemsBindingSource;
        private System.Windows.Forms.BindingSource bsFoodItems;
        private System.Data.DataSet dsFoodItems;
        private System.Data.DataTable tblFoodItems;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
    }
}