namespace FridgeApp
{
    partial class frmMeasurement
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblShortname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbShortname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dgvMeasurement = new System.Windows.Forms.DataGridView();
            this.measurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsMeasurement = new System.Windows.Forms.BindingSource(this.components);
            this.dsMeasurement = new System.Data.DataSet();
            this.Measurement = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Measurement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(34, 78);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(196, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(115, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblShortname
            // 
            this.lblShortname.AutoSize = true;
            this.lblShortname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShortname.Location = new System.Drawing.Point(193, 7);
            this.lblShortname.Name = "lblShortname";
            this.lblShortname.Size = new System.Drawing.Size(77, 17);
            this.lblShortname.TabIndex = 15;
            this.lblShortname.Text = "Shortname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(9, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // tbShortname
            // 
            this.tbShortname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbShortname.Location = new System.Drawing.Point(196, 27);
            this.tbShortname.Name = "tbShortname";
            this.tbShortname.Size = new System.Drawing.Size(75, 26);
            this.tbShortname.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(12, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 26);
            this.tbName.TabIndex = 11;
            // 
            // dgvMeasurement
            // 
            this.dgvMeasurement.AllowUserToAddRows = false;
            this.dgvMeasurement.AllowUserToDeleteRows = false;
            this.dgvMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeasurement.AutoGenerateColumns = false;
            this.dgvMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.shortnameDataGridViewTextBoxColumn});
            this.dgvMeasurement.DataSource = this.measurementBindingSource;
            this.dgvMeasurement.Location = new System.Drawing.Point(12, 131);
            this.dgvMeasurement.MultiSelect = false;
            this.dgvMeasurement.Name = "dgvMeasurement";
            this.dgvMeasurement.ReadOnly = true;
            this.dgvMeasurement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasurement.Size = new System.Drawing.Size(258, 184);
            this.dgvMeasurement.TabIndex = 10;
            // 
            // measurementBindingSource
            // 
            this.measurementBindingSource.DataMember = "Measurement";
            this.measurementBindingSource.DataSource = this.bsMeasurement;
            // 
            // bsMeasurement
            // 
            this.bsMeasurement.DataSource = this.dsMeasurement;
            this.bsMeasurement.Position = 0;
            // 
            // dsMeasurement
            // 
            this.dsMeasurement.DataSetName = "NewDataSet";
            this.dsMeasurement.Tables.AddRange(new System.Data.DataTable[] {
            this.Measurement});
            // 
            // Measurement
            // 
            this.Measurement.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.Measurement.TableName = "Measurement";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Shortname";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortnameDataGridViewTextBoxColumn
            // 
            this.shortnameDataGridViewTextBoxColumn.DataPropertyName = "Shortname";
            this.shortnameDataGridViewTextBoxColumn.HeaderText = "Shortname";
            this.shortnameDataGridViewTextBoxColumn.Name = "shortnameDataGridViewTextBoxColumn";
            this.shortnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortnameDataGridViewTextBoxColumn.Width = 60;
            // 
            // frmMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 327);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblShortname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbShortname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvMeasurement);
            this.Name = "frmMeasurement";
            this.Text = "frmMeasurement";
            this.Load += new System.EventHandler(this.frmMeasurement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Measurement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblShortname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbShortname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView dgvMeasurement;
        private System.Windows.Forms.BindingSource measurementBindingSource;
        private System.Windows.Forms.BindingSource bsMeasurement;
        private System.Data.DataSet dsMeasurement;
        private System.Data.DataTable Measurement;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortnameDataGridViewTextBoxColumn;
    }
}