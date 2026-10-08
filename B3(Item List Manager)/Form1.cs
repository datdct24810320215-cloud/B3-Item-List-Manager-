using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace B3_Item_List_Manager_
{
    public partial class Form1 : Form
    {
        private readonly List<Item> _items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
            cmbUnit.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cmbUnit.SelectedIndex = 0;
            lvItems.FullRowSelect = true;
            lvItems.View = View.Details;
            lvItems.Columns.Clear();
            lvItems.Columns.Add("Mã VT", 100);
            lvItems.Columns.Add("Tên VT", 220);
            lvItems.Columns.Add("Đơn vị tính", 80);
            lvItems.Columns.Add("Đơn giá", 100, HorizontalAlignment.Right);
            lvItems.SelectedIndexChanged += LvItems_SelectedIndexChanged;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string code, out string name, out string unit, out decimal price))
                return;

            if (_items.Exists(x => string.Equals(x.Code, code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new Item { Code = code, Name = name, Unit = unit, Price = price };
            _items.Add(item);
            RefreshListView();
            ClearInput();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(out string code, out string name, out string unit, out decimal price))
                return;

            var selected = lvItems.SelectedItems[0];
            var originalCode = selected.SubItems[0].Text;

            if (!string.Equals(originalCode, code, StringComparison.OrdinalIgnoreCase)
                && _items.Exists(x => string.Equals(x.Code, code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư mới đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _items.Find(x => string.Equals(x.Code, originalCode, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.Code = code;
                item.Name = name;
                item.Unit = unit;
                item.Price = price;
                RefreshListView();
                ClearInput();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            var code = lvItems.SelectedItems[0].SubItems[0].Text;
            _items.RemoveAll(x => string.Equals(x.Code, code, StringComparison.OrdinalIgnoreCase));
            RefreshListView();
            ClearInput();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;
            _items.Clear();
            RefreshListView();
            ClearInput();
        }

        private void LvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count == 0) return;
            var it = lvItems.SelectedItems[0];
            txtCode.Text = it.SubItems[0].Text;
            txtName.Text = it.SubItems[1].Text;
            cmbUnit.Text = it.SubItems[2].Text;
            txtPrice.Text = it.SubItems[3].Text;
        }

        private void RefreshListView()
        {
            lvItems.Items.Clear();
            foreach (var it in _items)
            {
                var lvi = new ListViewItem(it.Code);
                lvi.SubItems.Add(it.Name);
                lvi.SubItems.Add(it.Unit);
                lvi.SubItems.Add(it.Price.ToString("N2", CultureInfo.InvariantCulture));
                lvItems.Items.Add(lvi);
            }
        }

        private void ClearInput()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            cmbUnit.SelectedIndex = 0;
            txtCode.Focus();
            lvItems.SelectedItems.Clear();
        }

        private bool ValidateInput(out string code, out string name, out string unit, out decimal price)
        {
            code = txtCode.Text.Trim();
            name = txtName.Text.Trim();
            unit = cmbUnit.Text.Trim();
            price = 0m;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã vật tư không được rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên vật tư không được rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out price) || price < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            return true;
        }
    }

    internal class Item
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
    }
}
