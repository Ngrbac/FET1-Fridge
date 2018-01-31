namespace FridgeApp
{
    partial class frmRecipeBook
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
            this.gbRecipes = new System.Windows.Forms.GroupBox();
            this.lblCookTime = new System.Windows.Forms.Label();
            this.tbCookTime = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsRecipes = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecipes = new System.Data.DataSet();
            this.Recipes = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.lblFoodItem = new System.Windows.Forms.Label();
            this.cbFoodItem = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.Measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsIngredients = new System.Windows.Forms.BindingSource(this.components);
            this.dsIngredients = new System.Data.DataSet();
            this.Ingredients = new System.Data.DataTable();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recipes)).BeginInit();
            this.gbIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRecipes
            // 
            this.gbRecipes.Controls.Add(this.lblCookTime);
            this.gbRecipes.Controls.Add(this.tbCookTime);
            this.gbRecipes.Controls.Add(this.lblDescription);
            this.gbRecipes.Controls.Add(this.tbDescription);
            this.gbRecipes.Controls.Add(this.lblName);
            this.gbRecipes.Controls.Add(this.tbName);
            this.gbRecipes.Controls.Add(this.btnEditRecipe);
            this.gbRecipes.Controls.Add(this.btnDeleteRecipe);
            this.gbRecipes.Controls.Add(this.btnSaveRecipe);
            this.gbRecipes.Controls.Add(this.dgvRecipes);
            this.gbRecipes.Location = new System.Drawing.Point(12, 12);
            this.gbRecipes.Name = "gbRecipes";
            this.gbRecipes.Size = new System.Drawing.Size(471, 604);
            this.gbRecipes.TabIndex = 0;
            this.gbRecipes.TabStop = false;
            this.gbRecipes.Text = "Recipes";
            // 
            // lblCookTime
            // 
            this.lblCookTime.AutoSize = true;
            this.lblCookTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCookTime.Location = new System.Drawing.Point(310, 16);
            this.lblCookTime.Name = "lblCookTime";
            this.lblCookTime.Size = new System.Drawing.Size(71, 17);
            this.lblCookTime.TabIndex = 18;
            this.lblCookTime.Text = "CookTime";
            // 
            // tbCookTime
            // 
            this.tbCookTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCookTime.Location = new System.Drawing.Point(313, 36);
            this.tbCookTime.Name = "tbCookTime";
            this.tbCookTime.Size = new System.Drawing.Size(149, 26);
            this.tbCookTime.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(6, 65);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDescription.Location = new System.Drawing.Point(9, 85);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(453, 26);
            this.tbDescription.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(9, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 26);
            this.tbName.TabIndex = 13;
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditRecipe.Location = new System.Drawing.Point(225, 117);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(75, 33);
            this.btnEditRecipe.TabIndex = 12;
            this.btnEditRecipe.Text = "Edit";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteRecipe.Location = new System.Drawing.Point(387, 117);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteRecipe.TabIndex = 11;
            this.btnDeleteRecipe.Text = "Delete";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveRecipe.Location = new System.Drawing.Point(306, 117);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(75, 33);
            this.btnSaveRecipe.TabIndex = 10;
            this.btnSaveRecipe.Text = "Save";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            this.btnSaveRecipe.Click += new System.EventHandler(this.btnSaveRecipe_Click);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.AutoGenerateColumns = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ID,
            this.cookTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvRecipes.DataSource = this.recipesBindingSource;
            this.dgvRecipes.Location = new System.Drawing.Point(6, 156);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(459, 442);
            this.dgvRecipes.TabIndex = 0;
            this.dgvRecipes.SelectionChanged += new System.EventHandler(this.DgvRecipes_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // cookTimeDataGridViewTextBoxColumn
            // 
            this.cookTimeDataGridViewTextBoxColumn.DataPropertyName = "CookTime";
            this.cookTimeDataGridViewTextBoxColumn.HeaderText = "CookTime";
            this.cookTimeDataGridViewTextBoxColumn.Name = "cookTimeDataGridViewTextBoxColumn";
            this.cookTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.bsRecipes;
            // 
            // bsRecipes
            // 
            this.bsRecipes.DataSource = this.dsRecipes;
            this.bsRecipes.Position = 0;
            // 
            // dsRecipes
            // 
            this.dsRecipes.DataSetName = "NewDataSet";
            this.dsRecipes.Tables.AddRange(new System.Data.DataTable[] {
            this.Recipes});
            // 
            // Recipes
            // 
            this.Recipes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn6});
            this.Recipes.TableName = "Recipes";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "CookTime";
            this.dataColumn2.DataType = typeof(long);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Description";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "ID";
            this.dataColumn6.DataType = typeof(long);
            // 
            // gbIngredients
            // 
            this.gbIngredients.Controls.Add(this.btnEditIngredient);
            this.gbIngredients.Controls.Add(this.btnDeleteIngredient);
            this.gbIngredients.Controls.Add(this.btnSaveIngredient);
            this.gbIngredients.Controls.Add(this.lblFoodItem);
            this.gbIngredients.Controls.Add(this.cbFoodItem);
            this.gbIngredients.Controls.Add(this.lblQuantity);
            this.gbIngredients.Controls.Add(this.tbQuantity);
            this.gbIngredients.Controls.Add(this.dgvIngredients);
            this.gbIngredients.Location = new System.Drawing.Point(489, 12);
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.Size = new System.Drawing.Size(381, 604);
            this.gbIngredients.TabIndex = 1;
            this.gbIngredients.TabStop = false;
            this.gbIngredients.Text = "Ingredients";
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditIngredient.Location = new System.Drawing.Point(142, 117);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(75, 33);
            this.btnEditIngredient.TabIndex = 25;
            this.btnEditIngredient.Text = "Edit";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteIngredient.Location = new System.Drawing.Point(304, 117);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteIngredient.TabIndex = 24;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveIngredient.Location = new System.Drawing.Point(223, 117);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(75, 33);
            this.btnSaveIngredient.TabIndex = 23;
            this.btnSaveIngredient.Text = "Save";
            this.btnSaveIngredient.UseVisualStyleBackColor = true;
            this.btnSaveIngredient.Click += new System.EventHandler(this.btnSaveIngredient_Click);
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFoodItem.Location = new System.Drawing.Point(3, 16);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(66, 17);
            this.lblFoodItem.TabIndex = 22;
            this.lblFoodItem.Text = "FoodItem";
            // 
            // cbFoodItem
            // 
            this.cbFoodItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFoodItem.FormattingEnabled = true;
            this.cbFoodItem.Location = new System.Drawing.Point(6, 36);
            this.cbFoodItem.Name = "cbFoodItem";
            this.cbFoodItem.Size = new System.Drawing.Size(190, 28);
            this.cbFoodItem.TabIndex = 21;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(199, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 20;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbQuantity.Location = new System.Drawing.Point(202, 36);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(173, 26);
            this.tbQuantity.TabIndex = 19;
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.AutoGenerateColumns = false;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientID,
            this.ingredientDataGridViewTextBoxColumn,
            this.Measure,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvIngredients.DataSource = this.ingredientsBindingSource1;
            this.dgvIngredients.Location = new System.Drawing.Point(6, 156);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredients.Size = new System.Drawing.Size(369, 442);
            this.dgvIngredients.TabIndex = 0;
            // 
            // Measure
            // 
            this.Measure.DataPropertyName = "Measure";
            this.Measure.HeaderText = "Measure";
            this.Measure.Name = "Measure";
            this.Measure.ReadOnly = true;
            // 
            // IngredientID
            // 
            this.IngredientID.DataPropertyName = "ID";
            this.IngredientID.HeaderText = "ID";
            this.IngredientID.Name = "IngredientID";
            this.IngredientID.ReadOnly = true;
            this.IngredientID.Visible = false;
            // 
            // ingredientsBindingSource1
            // 
            this.ingredientsBindingSource1.DataMember = "Ingredients";
            this.ingredientsBindingSource1.DataSource = this.bsIngredients;
            // 
            // bsIngredients
            // 
            this.bsIngredients.DataSource = this.dsIngredients;
            this.bsIngredients.Position = 0;
            // 
            // dsIngredients
            // 
            this.dsIngredients.DataSetName = "NewDataSet";
            this.dsIngredients.Tables.AddRange(new System.Data.DataTable[] {
            this.Ingredients});
            // 
            // Ingredients
            // 
            this.Ingredients.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn7,
            this.dataColumn8});
            this.Ingredients.TableName = "Ingredients";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Ingredient";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Quantity";
            this.dataColumn5.DataType = typeof(decimal);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Measure";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "ID";
            this.dataColumn8.DataType = typeof(long);
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.bsIngredients;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientDataGridViewTextBoxColumn
            // 
            this.ingredientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
            this.ingredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmRecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 628);
            this.Controls.Add(this.gbIngredients);
            this.Controls.Add(this.gbRecipes);
            this.Name = "frmRecipeBook";
            this.Text = "RecipeBook";
            this.Load += new System.EventHandler(this.frmRecipeBook_Load);
            this.gbRecipes.ResumeLayout(false);
            this.gbRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recipes)).EndInit();
            this.gbIngredients.ResumeLayout(false);
            this.gbIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRecipes;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnSaveRecipe;
        private System.Windows.Forms.Label lblCookTime;
        private System.Windows.Forms.TextBox tbCookTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Label lblFoodItem;
        private System.Windows.Forms.ComboBox cbFoodItem;
        private System.Data.DataSet dsRecipes;
        private System.Data.DataSet dsIngredients;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private System.Windows.Forms.BindingSource bsRecipes;
        private System.Data.DataTable Recipes;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private System.Windows.Forms.BindingSource bsIngredients;
        private System.Data.DataTable Ingredients;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.Button btnSaveIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientID;
        private System.Windows.Forms.BindingSource ingredientsBindingSource1;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}