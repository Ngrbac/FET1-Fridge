namespace FridgeApp
{
    partial class frmAddFridgeItem
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
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbFoodItem = new System.Windows.Forms.ComboBox();
            this.lblFoodItem = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbQuantity.Location = new System.Drawing.Point(138, 55);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(188, 26);
            this.tbQuantity.TabIndex = 1;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            this.tbQuantity.Leave += new System.EventHandler(this.tbQuantity_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(24, 58);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // cbFoodItem
            // 
            this.cbFoodItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFoodItem.FormattingEnabled = true;
            this.cbFoodItem.Location = new System.Drawing.Point(138, 21);
            this.cbFoodItem.Name = "cbFoodItem";
            this.cbFoodItem.Size = new System.Drawing.Size(188, 28);
            this.cbFoodItem.TabIndex = 0;
            this.cbFoodItem.SelectedIndexChanged += new System.EventHandler(this.cbFoodItem_SelectedIndexChanged);
            // 
            // lblFoodItem
            // 
            this.lblFoodItem.AutoSize = true;
            this.lblFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFoodItem.Location = new System.Drawing.Point(24, 24);
            this.lblFoodItem.Name = "lblFoodItem";
            this.lblFoodItem.Size = new System.Drawing.Size(80, 20);
            this.lblFoodItem.TabIndex = 3;
            this.lblFoodItem.Text = "Food item";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(166, 101);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(77, 31);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Add";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(249, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddFridgeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 142);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblFoodItem);
            this.Controls.Add(this.cbFoodItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddFridgeItem";
            this.Text = "Adding Item";
            this.Load += new System.EventHandler(this.frmAddFridgeItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbFoodItem;
        private System.Windows.Forms.Label lblFoodItem;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}