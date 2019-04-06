using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirTicketBookingManagement
{
    public partial class frm_DatVe : Form
    {
        private int tongNguoi = 0;
        private long tongTien = 0;
        private int[] GiaBusinessNguoiLon = { 3000000 };
        private int[] GiaVeBusinessTreEm = { 1500000 };
        private int[] GiaEconomyNguoiLon = { 2000000 };
        private int[] GiaEconomyTreEm = { 800000 };
        public enum Hang
        {
            Business,
            Economy,
        }
        public frm_DatVe()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();

        public void INSERT(string CMND, string TENKH, string DIENTHOAI, string DIACHI)
        {
            string sql = "INSERT INTO KHACHHANG(CMND,TENKH,DIENTHOAI,DIACHI) VALUES (N'" + CMND + "',N'" + TENKH + "',N'" + DIENTHOAI + "',N'" + DIACHI + "')";
            conn.KetNoi();
            SqlCommand cm = new SqlCommand(sql, conn.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            conn.cn.Close();
        }
        private void frm_DatVe_Load(object sender, EventArgs e)
        {
            
            cbFrom.DataSource = conn.ExecuteData("select * from sanbay ");
            cbFrom.DisplayMember = "TenSanBay";
            cbFrom.ValueMember = "MaSanBay";

            btnIn.Enabled = false;

            cbHangVe.Items.Add("Business");
            cbHangVe.Items.Add("Economy");
            cbHangVe.SelectedItem = "Economy";

        }
        

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTo.Text = "";
            cbTo.DataSource = conn.ExecuteData("select * from ChangBay where MASANBAYDI='" + cbFrom.SelectedValue + "' ");
            cbTo.DisplayMember = "TENSANBAY";
            cbTo.ValueMember = "MASANBAYDEN";

        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text != "" && txtTen.Text != "")
            {

                INSERT(txtCMND.Text, txtTen.Text, txtDienThoai.Text, txtDiaChi.Text);
                MessageBox.Show("Đã lưu thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFrom.Text = "";
            cbTo.Text = "";
            TimeKH.Text = "";
            cbHangVe.Text = "";
            cbSoLuong.Text = "";
            txtCMND.Text = "";
            txtTen.Text = "";
            txtNamSinh.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTongTien.Text = "";
            rtbInfo.Text = "";
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số chứng minh nhân dân hoặc số thẻ căn cước công dân");
                txtCMND.Focus();
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa khai báo họ tên");
                txtTen.Focus();
            }
            else if (txtNamSinh.Text == "")
            {
                MessageBox.Show("Bạn chưa khai báo năm sinh");
                txtNamSinh.Focus();
            }
            else if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa khai báo số điện thoại");
                txtDienThoai.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng cung cấp địa chỉ");
                txtDiaChi.Focus();
            }
            else
            {
                int songuoi = int.Parse(cbSoLuong.Text);
                long thanhtien;
                int giave = 0;

                btnIn.Enabled = true;


                float namnhapvao, tuoi;

                int namhientai = 2019;
                namnhapvao = int.Parse(txtNamSinh.Text);

                tuoi = namhientai - namnhapvao;

                txtTuoi.Text = tuoi.ToString();

                if (namnhapvao > namhientai)
                {
                    MessageBox.Show("Năn sinh không hợp lệ");

                }

                if (cbHangVe.SelectedItem == "Business")
                {
                    if (tuoi < 11)
                        giave = GiaVeBusinessTreEm[(int)Hang.Business];
                    else
                        giave = GiaBusinessNguoiLon[(int)Hang.Business];
                }

                if (cbHangVe.SelectedItem == "Economy")
                {
                    if (tuoi < 11)
                        giave = GiaEconomyTreEm[(int)Hang.Business];
                    else
                        giave = GiaEconomyNguoiLon[(int)Hang.Business];
                }

                thanhtien = giave * songuoi;

                txtTongTien.Text = thanhtien.ToString() + " VND";

                tongNguoi++;
                tongTien += thanhtien;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rtbInfo.Text = "\r\n" + "\r\n" + "\r\n" 
                + "Khởi hành từ: " + cbFrom.Text + "\r\n" + "\r\n"
                + "Đến: " + cbTo.Text + "\r\n" + "\r\n"
                + "Ngày khởi hành: " + TimeKH.Text + "\r\n" + "\r\n"
                + "Loại vé: " + cbHangVe.Text + "\r\n" + "\r\n"
                + "Số người: " + cbSoLuong.Text + "\r\n" + "\r\n"
                + "Số CMND: " + txtCMND.Text + "\r\n" + "\r\n"
                + "Họ và tên: " + txtTen.Text + "\r\n" + "\r\n"
                + "Năm sinh: " + txtNamSinh.Text + "\r\n" + "\r\n"
                + "Số điện thoại: " + txtDienThoai.Text + "\r\n" + "\r\n"
                + "Địa chỉ: " + txtDiaChi.Text + "\r\n" + "\r\n" + "\r\n"
                + "Tổng số tiền mà khách hàng " + "(" + txtTen.Text + ")" +" phải thanh toán là: " + txtTongTien.Text + "\r\n" + "\r\n"; 
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
            char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
            char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
            char.IsPunctuation(e.KeyChar))  //Dấu chấm  
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số nguyên.");
            }
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || 
            char.IsSymbol(e.KeyChar) || 
            char.IsWhiteSpace(e.KeyChar) || 
            char.IsPunctuation(e.KeyChar))   
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số nguyên.");
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || 
            char.IsSymbol(e.KeyChar) || 
            char.IsWhiteSpace(e.KeyChar) || 
            char.IsPunctuation(e.KeyChar))   
            {
                e.Handled = true; 
                MessageBox.Show("Vui lòng nhập số nguyên.");
            }
        }       
    }
}
