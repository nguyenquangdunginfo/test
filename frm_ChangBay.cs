using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirTicketBookingManagement
{
    public partial class frm_ChangBay : Form
    {
        public frm_ChangBay()
        {
            InitializeComponent();
        }

       
        Connection x = new Connection();
        private void frm_ChangBay_Load(object sender, EventArgs e)
        {
            cbSanBayDi.DataSource = x.ExecuteData("select * from sanbay ");
            cbSanBayDi.DisplayMember = "TenSanBay";
            cbSanBayDi.ValueMember = "MaSanBay";
            cbSanBayDen.DataSource = x.ExecuteData("select * from sanbay");
            cbSanBayDen.DisplayMember = "TenSanBay";
            cbSanBayDen.ValueMember = "MaSanBay";
            txtMaChangBay.Text = "";
            dataGridView1.DataSource = x.ExecuteData("select * from ChangBay ");
        }
        string st1 = "";
        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaChangBay.Text = cbSanBayDi.SelectedValue + "-";
            st1 = cbSanBayDi.SelectedValue.ToString();
        }     

        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaChangBay.Text = st1+ "-" + cbSanBayDen.SelectedValue; ;
        }
        public void INSERT(string MACHANGBAY, string MASANBAYDI, string MASANBAYDEN)
        {
            string sql = "INSERT INTO CHANGBAY(MACHANGBAY,MASANBAYDI,MASANBAYDEN) VALUES (N'" + MACHANGBAY + "',N'" + MASANBAYDI + "',N'" + MASANBAYDEN + "')";
            x.KetNoi();
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
        public void UPDATE(string MACHANGBAY, string MASANBAYDI, string MASANBAYDEN)
        {
            this.x.KetNoi();
            string sql = "UPDATE CHANGBAY SET [MACHANGBAY]=" + MACHANGBAY + ",[MASANBAYDI]=" + MASANBAYDI + ",[MASANBAYDEN]=" + MASANBAYDEN + " WHERE [MACHANGBAY]=N'" + MACHANGBAY + "'";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }
  
        public void Delete(string MACHANGBAY)
        {
            this.x.KetNoi();
            string sql = "DELETE FROM CHANGBAY WHERE [MACHANGBAY]=N'" + MACHANGBAY + "'";
            SqlCommand cm = new SqlCommand(sql, x.cn);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            x.cn.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            txtMaChangBay.Text = dataGridView1.CurrentRow.Cells["MACHANGBAY"].Value.ToString();
            cbSanBayDen.Text = dataGridView1.CurrentRow.Cells["MASANBAYDEN"].Value.ToString();
            cbSanBayDi.Text= dataGridView1.CurrentRow.Cells["MASANBAYDI"].Value.ToString();
      
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                INSERT(txtMaChangBay.Text, cbSanBayDi.SelectedValue.ToString(), cbSanBayDen.SelectedValue.ToString());
                dataGridView1.DataSource = x.ExecuteData("select * from CHANGBAY ");
                MessageBox.Show("Đã thêm thành công", "Thông báo");
                txtMaChangBay.Clear();
                cbSanBayDi.Text = "";
                cbSanBayDen.Text = "";
            }
            catch (Exception d) { MessageBox.Show("Thêm thất bại \n" + d.Message, "Thông báo"); }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaChangBay.Text != "" )
                {
                    UPDATE(txtMaChangBay.Text, cbSanBayDi.SelectedValue.ToString(), cbSanBayDen.SelectedValue.ToString());
                    dataGridView1.DataSource = x.ExecuteData("select * from ChangBay ");
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo");
                }
            }
            catch (Exception d) { MessageBox.Show("Thêm thất bại \n" + d.Message, "Thông báo"); }


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaChangBay.Text != "")
            {
                Delete(txtMaChangBay.Text);
                dataGridView1.DataSource = x.ExecuteData("select * from CHANGBAY ");
                MessageBox.Show("Đã xóa chặng bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
