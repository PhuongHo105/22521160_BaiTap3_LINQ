namespace LINQ
{
    public partial class fMain : Form
    {
        List<SanPham> ds;
        public fMain()
        {
            InitializeComponent();
            ds = new List<SanPham>();
            dgv_SanPham1.DataSource = new List<SanPham>();
            dgv_SanPham2.DataSource = new List <SanPham>();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (tb_MaSP.Text == string.Empty || tb_TenSP.Text == string.Empty || tb_SL.Text == string.Empty
                || tb_Price.Text == string.Empty || tb_Origin.Text == string.Empty)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin về sản phẩm.", "Cảnh báo");
            else
            {
                int sl, dongia;
                if (!(int.TryParse(tb_SL.Text, out sl) && int.TryParse(tb_Price.Text, out dongia)))
                    MessageBox.Show("Số lượng và đơn giá phải là số nguyên không âm.", "Cảnh báo");
                else
                {
                    if (ds.Exists(sp => sp.MaSP == tb_MaSP.Text))
                    {
                        if (MessageBox.Show("Bạn có muốn cập nhật thông tin của sản phẩm " +
                            tb_MaSP.Text + " không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var sp = ds.Find(sp => sp.MaSP == tb_MaSP.Text);
                            if (sp != null)
                            {
                                sp.TenSP = tb_TenSP.Text;
                                sp.SL = int.Parse(tb_SL.Text);
                                sp.DonGia = int.Parse(tb_Price.Text);
                                sp.XuatXu = tb_Origin.Text;
                                sp.NgayHetHan = dtp_NgayHetHan.Value;
                            }
                            dgv_SanPham2.DataSource = new List<SanPham>();
                            dgv_SanPham2.DataSource = ds;
                            MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        ds.Add(new SanPham(tb_MaSP.Text, tb_TenSP.Text, sl, dongia, tb_Origin.Text, dtp_NgayHetHan.Value));
                        dgv_SanPham2.DataSource = new List<SanPham>();
                        dgv_SanPham2.DataSource = ds;
                        ClearInfo();
                        MessageBox.Show("Thêm sản phẩm mới thành công", "Thông báo");
                    }
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (tb_MaSP.Text != string.Empty)
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm " +
                            tb_MaSP.Text + " khỏi kho không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = ds.FindIndex(sp => sp.MaSP == tb_MaSP.Text);
                    if (index != -1)
                    {
                        ds.RemoveAt(index);
                        dgv_SanPham2.DataSource = new List<SanPham>();
                        dgv_SanPham2.DataSource = ds;
                        MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo");
                        ClearInfo();
                    }
                }
            }
        }

        private void dgv_SanPham2_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_SanPham2.SelectedRows.Count > 0)
            {
                int index = dgv_SanPham2.SelectedRows[0].Index;
                SanPham sp = ds[index];
                tb_MaSP.Text = sp.MaSP;
                tb_TenSP.Text = sp.TenSP;
                tb_SL.Text = sp.SL.ToString();
                tb_Price.Text = sp.DonGia.ToString();
                tb_Origin.Text = sp.XuatXu;
                dtp_NgayHetHan.Value = sp.NgayHetHan;
            }
        }
        private void ClearInfo()
        {
            tb_MaSP.Text = string.Empty;
            tb_TenSP.Text = string.Empty;
            tb_SL.Text = string.Empty;
            tb_Price.Text = string.Empty;
            tb_Origin.Text = string.Empty;
            dtp_NgayHetHan.Value = DateTime.Today;
        }

        private void bt_DeleteAll_Click(object sender, EventArgs e)
        {
            ds.RemoveAll(sp => true);
            dgv_SanPham2.DataSource = new List<SanPham>();
            dgv_SanPham1.DataSource = new List<SanPham>();
            MessageBox.Show("Xóa tất cả sản phẩm trong kho thành công.", "Thông báo");
        }

        private void bt_DeleteAllOutOfDate_Click(object sender, EventArgs e)
        {
            ds.RemoveAll(sp => sp.NgayHetHan < DateTime.Now);
            dgv_SanPham2.DataSource = new List<SanPham>();
            dgv_SanPham2.DataSource = ds;
            MessageBox.Show("Xóa tất cả sản phẩm hết hạn thành công.", "Thông báo");
        }

        private void bt_CheckOutOfDate_Click(object sender, EventArgs e)
        {
            if (ds.Exists(sp => sp.NgayHetHan <= DateTime.Now))
                MessageBox.Show("Hiện tại trong kho đang có sản phẩm quá hạn", "Thông báo");
            else
                MessageBox.Show("Hiện tại trong kho không có sản phẩm quá hạn", "Thông báo");
        }

        private void bt_DeleteByOrigin_Click(object sender, EventArgs e)
        {
            if (tb_DeleteByOrigin.Text != string.Empty)
            {
                if (ds.Exists(sp => sp.XuatXu == tb_DeleteByOrigin.Text))
                {
                    ds.RemoveAll(sp => sp.XuatXu == tb_DeleteByOrigin.Text);
                    dgv_SanPham2.DataSource = new List<SanPham>();
                    dgv_SanPham2.DataSource = ds;
                    MessageBox.Show("Xóa thành công các sản phẩm có xuất xứ từ " +
                        tb_DeleteByOrigin.Text, "Thông báo");
                }
                else
                    MessageBox.Show("Không có sản phẩm nào có xuất xứ từ " +
                        tb_DeleteByOrigin.Text, "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập xuất xứ cần xóa sản phẩm.", "Thông báo");
            }
        }

        private void bt_SelectMaxPrice_Click(object sender, EventArgs e)
        {
            List<SanPham> max = new List<SanPham>();
            max.Add(ds.OrderByDescending(sp => sp.DonGia).FirstOrDefault());
            dgv_SanPham1.DataSource = new List<SanPham>();
            dgv_SanPham1.DataSource = max;
        }

        private void bt_SelectOutOfDate_Click(object sender, EventArgs e)
        {
            List<SanPham> ds1 = ds.FindAll(sp => sp.NgayHetHan < DateTime.Now);
            dgv_SanPham1.DataSource = new List<SanPham>();
            dgv_SanPham1.DataSource = ds1;
        }

        private void bt_SelectFromaTob_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (!(int.TryParse(tb_a.Text, out a) && int.TryParse(tb_b.Text, out b)))
            {
                MessageBox.Show("a và b phải là số");
            }
            else
            {
                List<SanPham> ds1 = ds.FindAll(sp => sp.DonGia <= b && sp.DonGia >= a);
                dgv_SanPham1.DataSource = new List<SanPham>();
                dgv_SanPham1.DataSource = ds1;
            }
        }

        private void bt_SelectFromJapan_Click(object sender, EventArgs e)
        {
            List<SanPham> nb = new List<SanPham>();
            nb.Add(ds.FindAll(sp => sp.XuatXu == "Nhật Bản").FirstOrDefault());
            dgv_SanPham1.DataSource = new List<SanPham>();
            dgv_SanPham1.DataSource = nb;
        }
    }
}
