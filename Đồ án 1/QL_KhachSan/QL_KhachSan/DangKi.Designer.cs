﻿namespace QL_KhachSan
{
    partial class DangKi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCauHoi = new System.Windows.Forms.ComboBox();
            this.txtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.MaskedTextBox();
            this.txtTraLoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.lbTraLoi = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // cbbCauHoi
            // 
            this.cbbCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCauHoi.FormattingEnabled = true;
            this.cbbCauHoi.Items.AddRange(new object[] {
            "Tên ở nhà của bạn ?",
            "Tên vật nuôi nhà bạn ?",
            "Tên ba của bạn ?",
            "Tên mẹ của bạn ?",
            "Ngày kỉ niệm của bạn ?"});
            this.cbbCauHoi.Location = new System.Drawing.Point(138, 166);
            this.cbbCauHoi.Name = "cbbCauHoi";
            this.cbbCauHoi.Size = new System.Drawing.Size(288, 21);
            this.cbbCauHoi.TabIndex = 5;
            this.cbbCauHoi.SelectedIndexChanged += new System.EventHandler(this.cbbCauHoi_SelectedIndexChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(138, 71);
            this.txtSoDT.Mask = "(+84) 0000000000";
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(97, 20);
            this.txtSoDT.TabIndex = 2;
            this.txtSoDT.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Câu hỏi bảo mật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(176, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ĐĂNG KÍ";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(137, 125);
            this.txtCMND.Mask = "000000000";
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(97, 20);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.Tag = "";
            this.txtCMND.ValidatingType = typeof(int);
            this.txtCMND.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCMND_MaskInputRejected);
            // 
            // txtTraLoi
            // 
            this.txtTraLoi.Location = new System.Drawing.Point(138, 212);
            this.txtTraLoi.Multiline = true;
            this.txtTraLoi.Name = "txtTraLoi";
            this.txtTraLoi.Size = new System.Drawing.Size(288, 56);
            this.txtTraLoi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trả lời:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXacNhan.Location = new System.Drawing.Point(324, 270);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(99, 40);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTroLai.Location = new System.Drawing.Point(9, 270);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(99, 40);
            this.btnTroLai.TabIndex = 8;
            this.btnTroLai.Text = "Trờ lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.ForeColor = System.Drawing.Color.Red;
            this.lbSDT.Location = new System.Drawing.Point(241, 76);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(149, 13);
            this.lbSDT.TabIndex = 13;
            this.lbSDT.Text = "Bạn Chưa Nhập Số điện thoại";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.ForeColor = System.Drawing.Color.Red;
            this.lbCMND.Location = new System.Drawing.Point(241, 131);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(118, 13);
            this.lbCMND.TabIndex = 14;
            this.lbCMND.Text = "Bạn Chưa Nhập CMND";
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.ForeColor = System.Drawing.Color.Red;
            this.lbCauHoi.Location = new System.Drawing.Point(135, 150);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(162, 13);
            this.lbCauHoi.TabIndex = 15;
            this.lbCauHoi.Text = "Bạn Chưa Chọn Câu hỏi bảo mật";
            // 
            // lbTraLoi
            // 
            this.lbTraLoi.AutoSize = true;
            this.lbTraLoi.ForeColor = System.Drawing.Color.Red;
            this.lbTraLoi.Location = new System.Drawing.Point(135, 195);
            this.lbTraLoi.Name = "lbTraLoi";
            this.lbTraLoi.Size = new System.Drawing.Size(86, 13);
            this.lbTraLoi.TabIndex = 16;
            this.lbTraLoi.Text = "Bạn Chưa Trả lời";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(138, 100);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(159, 20);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mật Khẩu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lbMatKhau.Location = new System.Drawing.Point(303, 107);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(132, 13);
            this.lbMatKhau.TabIndex = 19;
            this.lbMatKhau.Text = "Bạn Chưa Nhập Mật Khẩu";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.ForeColor = System.Drawing.Color.Red;
            this.lbTen.Location = new System.Drawing.Point(302, 52);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(105, 13);
            this.lbTen.TabIndex = 22;
            this.lbTen.Text = "Bạn Chưa Nhập Tên";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(137, 45);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(159, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tên Khách Hàng";
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 314);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTraLoi);
            this.Controls.Add(this.lbCauHoi);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtTraLoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.cbbCauHoi);
            this.Controls.Add(this.label1);
            this.Name = "DangKi";
            this.Text = "Đăng Kí";
            this.Load += new System.EventHandler(this.DangKi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCauHoi;
        private System.Windows.Forms.MaskedTextBox txtSoDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCMND;
        private System.Windows.Forms.TextBox txtTraLoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.Label lbTraLoi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
    }
}