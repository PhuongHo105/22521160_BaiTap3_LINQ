namespace LINQ
{
    partial class fMain
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
            groupBox1 = new GroupBox();
            bt_Delete = new Button();
            bt_Save = new Button();
            dtp_NgayHetHan = new DateTimePicker();
            tb_Origin = new TextBox();
            tb_Price = new TextBox();
            tb_SL = new TextBox();
            tb_TenSP = new TextBox();
            tb_MaSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            bt_SelectMaxPrice = new Button();
            dgv_SanPham1 = new DataGridView();
            groupBox3 = new GroupBox();
            dgv_SanPham2 = new DataGridView();
            groupBox4 = new GroupBox();
            bt_SelectFromJapan = new Button();
            bt_SelectOutOfDate = new Button();
            bt_SelectFromaTob = new Button();
            bt_DeleteByOrigin = new Button();
            bt_CheckOutOfDate = new Button();
            bt_DeleteAll = new Button();
            bt_DeleteAllOutOfDate = new Button();
            tb_DeleteByOrigin = new TextBox();
            tb_a = new TextBox();
            tb_b = new TextBox();
            cMaSP = new DataGridViewTextBoxColumn();
            cTenSP = new DataGridViewTextBoxColumn();
            cSL = new DataGridViewTextBoxColumn();
            cXuatXu = new DataGridViewTextBoxColumn();
            cDonGia = new DataGridViewTextBoxColumn();
            cNgayHetHan = new DataGridViewTextBoxColumn();
            c_MaSP = new DataGridViewTextBoxColumn();
            c_TenSP = new DataGridViewTextBoxColumn();
            c_SL = new DataGridViewTextBoxColumn();
            c_DonGia = new DataGridViewTextBoxColumn();
            c_XuatXu = new DataGridViewTextBoxColumn();
            c_NgayHetHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham2).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_Delete);
            groupBox1.Controls.Add(bt_Save);
            groupBox1.Controls.Add(dtp_NgayHetHan);
            groupBox1.Controls.Add(tb_Origin);
            groupBox1.Controls.Add(tb_Price);
            groupBox1.Controls.Add(tb_SL);
            groupBox1.Controls.Add(tb_TenSP);
            groupBox1.Controls.Add(tb_MaSP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // bt_Delete
            // 
            bt_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Delete.Location = new Point(282, 265);
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Size = new Size(88, 35);
            bt_Delete.TabIndex = 13;
            bt_Delete.Text = "Xóa SP";
            bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Save
            // 
            bt_Save.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Save.Location = new Point(163, 265);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(88, 35);
            bt_Save.TabIndex = 12;
            bt_Save.Text = "Lưu SP";
            bt_Save.UseVisualStyleBackColor = true;
            // 
            // dtp_NgayHetHan
            // 
            dtp_NgayHetHan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_NgayHetHan.Location = new Point(144, 207);
            dtp_NgayHetHan.Name = "dtp_NgayHetHan";
            dtp_NgayHetHan.Size = new Size(226, 29);
            dtp_NgayHetHan.TabIndex = 11;
            // 
            // tb_Origin
            // 
            tb_Origin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Origin.Location = new Point(144, 170);
            tb_Origin.Name = "tb_Origin";
            tb_Origin.Size = new Size(226, 29);
            tb_Origin.TabIndex = 10;
            // 
            // tb_Price
            // 
            tb_Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Price.Location = new Point(144, 133);
            tb_Price.Name = "tb_Price";
            tb_Price.Size = new Size(226, 29);
            tb_Price.TabIndex = 9;
            // 
            // tb_SL
            // 
            tb_SL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_SL.Location = new Point(144, 96);
            tb_SL.Name = "tb_SL";
            tb_SL.Size = new Size(226, 29);
            tb_SL.TabIndex = 8;
            // 
            // tb_TenSP
            // 
            tb_TenSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_TenSP.Location = new Point(144, 59);
            tb_TenSP.Name = "tb_TenSP";
            tb_TenSP.Size = new Size(226, 29);
            tb_TenSP.TabIndex = 7;
            // 
            // tb_MaSP
            // 
            tb_MaSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_MaSP.Location = new Point(144, 22);
            tb_MaSP.Name = "tb_MaSP";
            tb_MaSP.Size = new Size(226, 29);
            tb_MaSP.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 215);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 5;
            label6.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 178);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 4;
            label5.Text = "Xuất xứ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 141);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 104);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên SP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã SP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_b);
            groupBox2.Controls.Add(tb_a);
            groupBox2.Controls.Add(bt_SelectFromaTob);
            groupBox2.Controls.Add(bt_SelectOutOfDate);
            groupBox2.Controls.Add(bt_SelectFromJapan);
            groupBox2.Controls.Add(bt_SelectMaxPrice);
            groupBox2.Controls.Add(dgv_SanPham1);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(408, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // bt_SelectMaxPrice
            // 
            bt_SelectMaxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_SelectMaxPrice.Location = new Point(0, 35);
            bt_SelectMaxPrice.Name = "bt_SelectMaxPrice";
            bt_SelectMaxPrice.Size = new Size(103, 53);
            bt_SelectMaxPrice.TabIndex = 1;
            bt_SelectMaxPrice.Text = "1 SP có đơn giá cao nhất";
            bt_SelectMaxPrice.UseVisualStyleBackColor = true;
            // 
            // dgv_SanPham1
            // 
            dgv_SanPham1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham1.Columns.AddRange(new DataGridViewColumn[] { cMaSP, cTenSP, cSL, cXuatXu, cDonGia, cNgayHetHan });
            dgv_SanPham1.Location = new Point(2, 111);
            dgv_SanPham1.Name = "dgv_SanPham1";
            dgv_SanPham1.Size = new Size(548, 211);
            dgv_SanPham1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_SanPham2);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(9, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(955, 296);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // dgv_SanPham2
            // 
            dgv_SanPham2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham2.Columns.AddRange(new DataGridViewColumn[] { c_MaSP, c_TenSP, c_SL, c_DonGia, c_XuatXu, c_NgayHetHan });
            dgv_SanPham2.Location = new Point(6, 26);
            dgv_SanPham2.Name = "dgv_SanPham2";
            dgv_SanPham2.Size = new Size(674, 264);
            dgv_SanPham2.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb_DeleteByOrigin);
            groupBox4.Controls.Add(bt_DeleteAllOutOfDate);
            groupBox4.Controls.Add(bt_DeleteAll);
            groupBox4.Controls.Add(bt_CheckOutOfDate);
            groupBox4.Controls.Add(bt_DeleteByOrigin);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(686, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(263, 268);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chọn thao tác";
            // 
            // bt_SelectFromJapan
            // 
            bt_SelectFromJapan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_SelectFromJapan.Location = new Point(109, 35);
            bt_SelectFromJapan.Name = "bt_SelectFromJapan";
            bt_SelectFromJapan.Size = new Size(91, 53);
            bt_SelectFromJapan.TabIndex = 2;
            bt_SelectFromJapan.Text = "1 SP từ Nhật Bản";
            bt_SelectFromJapan.UseVisualStyleBackColor = true;
            // 
            // bt_SelectOutOfDate
            // 
            bt_SelectOutOfDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_SelectOutOfDate.Location = new Point(206, 35);
            bt_SelectOutOfDate.Name = "bt_SelectOutOfDate";
            bt_SelectOutOfDate.Size = new Size(106, 53);
            bt_SelectOutOfDate.TabIndex = 3;
            bt_SelectOutOfDate.Text = "Xuất toàn bộ SP quá hạn";
            bt_SelectOutOfDate.UseVisualStyleBackColor = true;
            // 
            // bt_SelectFromaTob
            // 
            bt_SelectFromaTob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_SelectFromaTob.Location = new Point(316, 35);
            bt_SelectFromaTob.Name = "bt_SelectFromaTob";
            bt_SelectFromaTob.Size = new Size(120, 53);
            bt_SelectFromaTob.TabIndex = 4;
            bt_SelectFromaTob.Text = "Xuất các SP có đơn giá [a...b]";
            bt_SelectFromaTob.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteByOrigin
            // 
            bt_DeleteByOrigin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_DeleteByOrigin.Location = new Point(6, 40);
            bt_DeleteByOrigin.Name = "bt_DeleteByOrigin";
            bt_DeleteByOrigin.Size = new Size(118, 53);
            bt_DeleteByOrigin.TabIndex = 5;
            bt_DeleteByOrigin.Text = "Xóa SP theo xuất xứ bất kì";
            bt_DeleteByOrigin.UseVisualStyleBackColor = true;
            // 
            // bt_CheckOutOfDate
            // 
            bt_CheckOutOfDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_CheckOutOfDate.Location = new Point(6, 124);
            bt_CheckOutOfDate.Name = "bt_CheckOutOfDate";
            bt_CheckOutOfDate.Size = new Size(251, 53);
            bt_CheckOutOfDate.TabIndex = 6;
            bt_CheckOutOfDate.Text = "Kiểm tra kho có SP quá hạn hay không?";
            bt_CheckOutOfDate.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteAll
            // 
            bt_DeleteAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_DeleteAll.Location = new Point(6, 209);
            bt_DeleteAll.Name = "bt_DeleteAll";
            bt_DeleteAll.Size = new Size(118, 53);
            bt_DeleteAll.TabIndex = 7;
            bt_DeleteAll.Text = "Xóa toàn bộ SP trong kho";
            bt_DeleteAll.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteAllOutOfDate
            // 
            bt_DeleteAllOutOfDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_DeleteAllOutOfDate.Location = new Point(130, 209);
            bt_DeleteAllOutOfDate.Name = "bt_DeleteAllOutOfDate";
            bt_DeleteAllOutOfDate.Size = new Size(127, 53);
            bt_DeleteAllOutOfDate.TabIndex = 8;
            bt_DeleteAllOutOfDate.Text = "Xóa toàn bộ SP quá hạn";
            bt_DeleteAllOutOfDate.UseVisualStyleBackColor = true;
            // 
            // tb_DeleteByOrigin
            // 
            tb_DeleteByOrigin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_DeleteByOrigin.Location = new Point(130, 40);
            tb_DeleteByOrigin.Multiline = true;
            tb_DeleteByOrigin.Name = "tb_DeleteByOrigin";
            tb_DeleteByOrigin.Size = new Size(127, 53);
            tb_DeleteByOrigin.TabIndex = 9;
            // 
            // tb_a
            // 
            tb_a.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_a.Location = new Point(442, 35);
            tb_a.Multiline = true;
            tb_a.Name = "tb_a";
            tb_a.Size = new Size(51, 53);
            tb_a.TabIndex = 10;
            // 
            // tb_b
            // 
            tb_b.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_b.Location = new Point(499, 35);
            tb_b.Multiline = true;
            tb_b.Name = "tb_b";
            tb_b.Size = new Size(51, 53);
            tb_b.TabIndex = 11;
            // 
            // cMaSP
            // 
            cMaSP.HeaderText = "Mã SP";
            cMaSP.Name = "cMaSP";
            cMaSP.Width = 75;
            // 
            // cTenSP
            // 
            cTenSP.HeaderText = "Tên SP";
            cTenSP.Name = "cTenSP";
            cTenSP.Width = 150;
            // 
            // cSL
            // 
            cSL.HeaderText = "Số lượng";
            cSL.Name = "cSL";
            cSL.Width = 50;
            // 
            // cXuatXu
            // 
            cXuatXu.HeaderText = "Xuất xứ";
            cXuatXu.Name = "cXuatXu";
            cXuatXu.Width = 75;
            // 
            // cDonGia
            // 
            cDonGia.HeaderText = "Đơn giá";
            cDonGia.Name = "cDonGia";
            cDonGia.Width = 75;
            // 
            // cNgayHetHan
            // 
            cNgayHetHan.HeaderText = "Ngày hết hạn";
            cNgayHetHan.Name = "cNgayHetHan";
            cNgayHetHan.Width = 75;
            // 
            // c_MaSP
            // 
            c_MaSP.HeaderText = "Mã SP";
            c_MaSP.Name = "c_MaSP";
            c_MaSP.Width = 75;
            // 
            // c_TenSP
            // 
            c_TenSP.HeaderText = "Tên SP";
            c_TenSP.Name = "c_TenSP";
            c_TenSP.Width = 175;
            // 
            // c_SL
            // 
            c_SL.HeaderText = "Số lượng";
            c_SL.Name = "c_SL";
            c_SL.Width = 75;
            // 
            // c_DonGia
            // 
            c_DonGia.HeaderText = "Đơn giá";
            c_DonGia.Name = "c_DonGia";
            c_DonGia.Width = 90;
            // 
            // c_XuatXu
            // 
            c_XuatXu.HeaderText = "Xuất xứ";
            c_XuatXu.Name = "c_XuatXu";
            c_XuatXu.Width = 90;
            // 
            // c_NgayHetHan
            // 
            c_NgayHetHan.HeaderText = "Ngày hết hạn";
            c_NgayHetHan.Name = "c_NgayHetHan";
            c_NgayHetHan.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 651);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "LINQ to OBJECT - Quản lý sản phẩm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private DataGridView dgv_SanPham1;
        private DataGridView dgv_SanPham2;
        private GroupBox groupBox4;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox tb_SL;
        private TextBox tb_TenSP;
        private TextBox tb_MaSP;
        private Label label6;
        private DateTimePicker dtp_NgayHetHan;
        private TextBox tb_Origin;
        private TextBox tb_Price;
        private Button bt_Delete;
        private Button bt_Save;
        private Button bt_SelectMaxPrice;
        private Button bt_SelectFromaTob;
        private Button bt_SelectOutOfDate;
        private Button bt_SelectFromJapan;
        private TextBox tb_b;
        private TextBox tb_a;
        private TextBox tb_DeleteByOrigin;
        private Button bt_DeleteAllOutOfDate;
        private Button bt_DeleteAll;
        private Button bt_CheckOutOfDate;
        private Button bt_DeleteByOrigin;
        private DataGridViewTextBoxColumn cMaSP;
        private DataGridViewTextBoxColumn cTenSP;
        private DataGridViewTextBoxColumn cSL;
        private DataGridViewTextBoxColumn cXuatXu;
        private DataGridViewTextBoxColumn cDonGia;
        private DataGridViewTextBoxColumn cNgayHetHan;
        private DataGridViewTextBoxColumn c_MaSP;
        private DataGridViewTextBoxColumn c_TenSP;
        private DataGridViewTextBoxColumn c_SL;
        private DataGridViewTextBoxColumn c_DonGia;
        private DataGridViewTextBoxColumn c_XuatXu;
        private DataGridViewTextBoxColumn c_NgayHetHan;
    }
}
