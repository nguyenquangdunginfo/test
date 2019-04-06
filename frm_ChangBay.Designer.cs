namespace AirTicketBookingManagement
{
    partial class frm_ChangBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MACHANGBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChangBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSanBayDi = new System.Windows.Forms.ComboBox();
            this.cbSanBayDen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACHANGBAY,
            this.MASANBAYDI,
            this.MASANBAYDEN});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 188);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // MACHANGBAY
            // 
            this.MACHANGBAY.DataPropertyName = "MACHANGBAY";
            this.MACHANGBAY.HeaderText = "Mã Chặng Bay";
            this.MACHANGBAY.Name = "MACHANGBAY";
            this.MACHANGBAY.Width = 150;
            // 
            // MASANBAYDI
            // 
            this.MASANBAYDI.DataPropertyName = "MASANBAYDI";
            this.MASANBAYDI.HeaderText = "Mã Sân Bay Đi";
            this.MASANBAYDI.Name = "MASANBAYDI";
            this.MASANBAYDI.Width = 200;
            // 
            // MASANBAYDEN
            // 
            this.MASANBAYDEN.DataPropertyName = "MASANBAYDEN";
            this.MASANBAYDEN.HeaderText = "Mã Sân Bay Đến";
            this.MASANBAYDEN.Name = "MASANBAYDEN";
            this.MASANBAYDEN.Width = 200;
            // 
            // txtMaChangBay
            // 
            this.txtMaChangBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaChangBay.Location = new System.Drawing.Point(179, 35);
            this.txtMaChangBay.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaChangBay.Name = "txtMaChangBay";
            this.txtMaChangBay.ReadOnly = true;
            this.txtMaChangBay.Size = new System.Drawing.Size(173, 23);
            this.txtMaChangBay.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Sân bay đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Chặng Bay";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 111);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 73);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(361, 35);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSanBayDi
            // 
            this.cbSanBayDi.FormattingEnabled = true;
            this.cbSanBayDi.Location = new System.Drawing.Point(180, 73);
            this.cbSanBayDi.Margin = new System.Windows.Forms.Padding(4);
            this.cbSanBayDi.Name = "cbSanBayDi";
            this.cbSanBayDi.Size = new System.Drawing.Size(173, 25);
            this.cbSanBayDi.TabIndex = 18;
            this.cbSanBayDi.SelectedIndexChanged += new System.EventHandler(this.cbSanBayDen_SelectedIndexChanged);
            // 
            // cbSanBayDen
            // 
            this.cbSanBayDen.FormattingEnabled = true;
            this.cbSanBayDen.Location = new System.Drawing.Point(180, 111);
            this.cbSanBayDen.Margin = new System.Windows.Forms.Padding(4);
            this.cbSanBayDen.Name = "cbSanBayDen";
            this.cbSanBayDen.Size = new System.Drawing.Size(173, 25);
            this.cbSanBayDen.TabIndex = 19;
            this.cbSanBayDen.SelectedIndexChanged += new System.EventHandler(this.cbSanBayDi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên Sân Bay điến";
            // 
            // frm_ChangBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSanBayDen);
            this.Controls.Add(this.cbSanBayDi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaChangBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ChangBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chặng bay";
            this.Load += new System.EventHandler(this.frm_ChangBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaChangBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbSanBayDi;
        private System.Windows.Forms.ComboBox cbSanBayDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHANGBAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDEN;
    }
}