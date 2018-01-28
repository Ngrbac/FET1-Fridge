using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridgeApp
{
    public partial class frmMeasurement : Form
    {
        private Controller controller;
        private Measurement selectedItem;
        public frmMeasurement(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success;
            if (selectedItem != null)
            {
                success = updateAnExistingMeasurement();
                selectedItem = null;
            }
            else
            {
                success = insertNewMeasurement();
            }

            if (!success)
            {
                return;
            }

            populateGrid();           
            tbName.Clear();
            tbShortname.Clear();
        }

        private void populateGrid()
        {
            controller.FillMeasurementGrid(dsMeasurement);
        }

        private bool insertNewMeasurement()
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please write a name!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbShortname.Text))
            {
                MessageBox.Show("Please write a shortname!");
                return false;
            }
            var addCheck = controller.AddMeasurement(tbName.Text, tbShortname.Text);
            return addCheck;
        }

        private bool updateAnExistingMeasurement()
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please write a name!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbShortname.Text))
            {
                MessageBox.Show("Please write a shortname!");
                return false;
            }
            controller.UpdateMeasurement(selectedItem.Name, tbName.Text, tbShortname.Text);
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            selectedItem = controller.GetMeasurement(dgvMeasurement.SelectedRows[0].Cells[0].Value.ToString());
            tbName.Text = selectedItem.Name;
            tbShortname.Text = selectedItem.Shortname;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controller.DeleteMeasurement(dgvMeasurement.SelectedRows[0].Cells[0].Value.ToString());
            populateGrid();
        }

        private void frmMeasurement_Load(object sender, EventArgs e)
        {
            populateGrid();
        }
    }
}
