namespace QLBH.Forms
{
    partial class frmAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalStatistic = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbbFoodCate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFoodPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteCate = new System.Windows.Forms.Button();
            this.btnUpdateCate = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFoodCate = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rBtnStaff = new System.Windows.Forms.RadioButton();
            this.rBtnAdmin = new System.Windows.Forms.RadioButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbDislayNameUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCate)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvStatistic);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 93);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(968, 369);
            this.panel9.TabIndex = 2;
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(968, 369);
            this.dgvStatistic.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTotalStatistic);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 59);
            this.panel2.TabIndex = 1;
            // 
            // lbTotalStatistic
            // 
            this.lbTotalStatistic.AutoSize = true;
            this.lbTotalStatistic.Location = new System.Drawing.Point(756, 21);
            this.lbTotalStatistic.Name = "lbTotalStatistic";
            this.lbTotalStatistic.Size = new System.Drawing.Size(32, 17);
            this.lbTotalStatistic.TabIndex = 1;
            this.lbTotalStatistic.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.cbbStaff);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(776, 10);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(174, 31);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbStaff
            // 
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(540, 10);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(188, 24);
            this.cbbStaff.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày kết thúc";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(132, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(132, 13);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pbFoodImage);
            this.panel8.Controls.Add(this.btnOpenImage);
            this.panel8.Controls.Add(this.btnDeleteFood);
            this.panel8.Controls.Add(this.btnUpdateFood);
            this.panel8.Controls.Add(this.btnAddFood);
            this.panel8.Controls.Add(this.cbbFoodCate);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.tbFoodPrice);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.tbFoodName);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(633, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(338, 518);
            this.panel8.TabIndex = 1;
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.Location = new System.Drawing.Point(136, 260);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(197, 124);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodImage.TabIndex = 10;
            this.pbFoodImage.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(21, 304);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(96, 27);
            this.btnOpenImage.TabIndex = 9;
            this.btnOpenImage.Text = "Thêm ảnh";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(102, 459);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(134, 38);
            this.btnDeleteFood.TabIndex = 8;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(177, 403);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(123, 38);
            this.btnUpdateFood.TabIndex = 7;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(21, 403);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(123, 38);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbbFoodCate
            // 
            this.cbbFoodCate.FormattingEnabled = true;
            this.cbbFoodCate.Location = new System.Drawing.Point(21, 220);
            this.cbbFoodCate.Name = "cbbFoodCate";
            this.cbbFoodCate.Size = new System.Drawing.Size(236, 24);
            this.cbbFoodCate.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Danh mục";
            // 
            // tbFoodPrice
            // 
            this.tbFoodPrice.Location = new System.Drawing.Point(21, 131);
            this.tbFoodPrice.Name = "tbFoodPrice";
            this.tbFoodPrice.Size = new System.Drawing.Size(236, 22);
            this.tbFoodPrice.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giá";
            // 
            // tbFoodName
            // 
            this.tbFoodName.Location = new System.Drawing.Point(21, 56);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(236, 22);
            this.tbFoodName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên món";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvFood);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(630, 518);
            this.panel7.TabIndex = 0;
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFood.Location = new System.Drawing.Point(0, 0);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(630, 518);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(974, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh Mục";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteCate);
            this.panel4.Controls.Add(this.btnUpdateCate);
            this.panel4.Controls.Add(this.btnAddCate);
            this.panel4.Controls.Add(this.tbCateName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(654, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 518);
            this.panel4.TabIndex = 1;
            // 
            // btnDeleteCate
            // 
            this.btnDeleteCate.Location = new System.Drawing.Point(97, 277);
            this.btnDeleteCate.Name = "btnDeleteCate";
            this.btnDeleteCate.Size = new System.Drawing.Size(134, 38);
            this.btnDeleteCate.TabIndex = 4;
            this.btnDeleteCate.Text = "Xóa";
            this.btnDeleteCate.UseVisualStyleBackColor = true;
            this.btnDeleteCate.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnUpdateCate
            // 
            this.btnUpdateCate.Location = new System.Drawing.Point(175, 186);
            this.btnUpdateCate.Name = "btnUpdateCate";
            this.btnUpdateCate.Size = new System.Drawing.Size(123, 38);
            this.btnUpdateCate.TabIndex = 3;
            this.btnUpdateCate.Text = "Sửa";
            this.btnUpdateCate.UseVisualStyleBackColor = true;
            this.btnUpdateCate.Click += new System.EventHandler(this.btnUpdateCate_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(25, 186);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(123, 38);
            this.btnAddCate.TabIndex = 2;
            this.btnAddCate.Text = "Thêm";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // tbCateName
            // 
            this.tbCateName.Location = new System.Drawing.Point(21, 115);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(277, 22);
            this.tbCateName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên danh mục";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvFoodCate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 518);
            this.panel3.TabIndex = 0;
            // 
            // dgvFoodCate
            // 
            this.dgvFoodCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodCate.Location = new System.Drawing.Point(0, 0);
            this.dgvFoodCate.Name = "dgvFoodCate";
            this.dgvFoodCate.RowHeadersWidth = 51;
            this.dgvFoodCate.RowTemplate.Height = 24;
            this.dgvFoodCate.Size = new System.Drawing.Size(651, 518);
            this.dgvFoodCate.TabIndex = 0;
            this.dgvFoodCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodCate_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(974, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rBtnStaff);
            this.panel6.Controls.Add(this.rBtnAdmin);
            this.panel6.Controls.Add(this.tbPassword);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.tbUsername);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.btnDeleteUser);
            this.panel6.Controls.Add(this.btnUpdateUser);
            this.panel6.Controls.Add(this.btnAddUser);
            this.panel6.Controls.Add(this.tbDislayNameUser);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(648, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 518);
            this.panel6.TabIndex = 1;
            // 
            // rBtnStaff
            // 
            this.rBtnStaff.AutoSize = true;
            this.rBtnStaff.Location = new System.Drawing.Point(180, 296);
            this.rBtnStaff.Name = "rBtnStaff";
            this.rBtnStaff.Size = new System.Drawing.Size(58, 21);
            this.rBtnStaff.TabIndex = 15;
            this.rBtnStaff.TabStop = true;
            this.rBtnStaff.Text = "Staff";
            this.rBtnStaff.UseVisualStyleBackColor = true;
            // 
            // rBtnAdmin
            // 
            this.rBtnAdmin.AutoSize = true;
            this.rBtnAdmin.Location = new System.Drawing.Point(30, 296);
            this.rBtnAdmin.Name = "rBtnAdmin";
            this.rBtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.rBtnAdmin.TabIndex = 14;
            this.rBtnAdmin.TabStop = true;
            this.rBtnAdmin.Text = "Admin";
            this.rBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(14, 236);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(277, 22);
            this.tbPassword.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mật khẩu";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(14, 148);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(277, 22);
            this.tbUsername.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên đăng nhập";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(102, 458);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(134, 38);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(180, 367);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(123, 38);
            this.btnUpdateUser.TabIndex = 8;
            this.btnUpdateUser.Text = "Sửa";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(30, 367);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(123, 38);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbDislayNameUser
            // 
            this.tbDislayNameUser.Location = new System.Drawing.Point(14, 62);
            this.tbDislayNameUser.Name = "tbDislayNameUser";
            this.tbDislayNameUser.Size = new System.Drawing.Size(277, 22);
            this.tbDislayNameUser.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên hiển thị";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvUser);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(645, 518);
            this.panel5.TabIndex = 0;
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(645, 518);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCate)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteCate;
        private System.Windows.Forms.Button btnUpdateCate;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.TextBox tbCateName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvFoodCate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbDislayNameUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.RadioButton rBtnStaff;
        private System.Windows.Forms.RadioButton rBtnAdmin;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFoodPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbFoodCate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbFoodImage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalStatistic;
    }
}