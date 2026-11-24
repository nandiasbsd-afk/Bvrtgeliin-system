namespace OyutniiBurtgel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox chkScholarship;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.CheckedListBox clbLesson;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ListBox lstLanguage;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.PictureBox pictureStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TreeView treeDepartment;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupInfo;

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblStudy;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblScholarship;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblLanguage;

        private System.Windows.Forms.Label lblCodeValue;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblAgeValue;
        private System.Windows.Forms.Label lblBirthValue;
        private System.Windows.Forms.Label lblStudyValue;
        private System.Windows.Forms.Label lblDepartmentValue;
        private System.Windows.Forms.Label lblScholarshipValue;
        private System.Windows.Forms.Label lblLessonValue;
        private System.Windows.Forms.Label lblLanguageValue;

        private System.Windows.Forms.ProgressBar progressBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTotal = new Label();
            txtCode = new TextBox();
            txtPhone = new TextBox();
            chkScholarship = new CheckBox();
            rbDay = new RadioButton();
            rbEvening = new RadioButton();
            clbLesson = new CheckedListBox();
            numAge = new NumericUpDown();
            cmbDepartment = new ComboBox();
            lstLanguage = new ListBox();
            dtpBirth = new DateTimePicker();
            pictureStudent = new PictureBox();
            dgvStudent = new DataGridView();
            treeDepartment = new TreeView();
            btnRegister = new Button();
            btnClear = new Button();
            groupInfo = new GroupBox();
            lblCode = new Label();
            lblCodeValue = new Label();
            lblPhone = new Label();
            lblPhoneValue = new Label();
            lblAge = new Label();
            lblAgeValue = new Label();
            lblBirth = new Label();
            lblBirthValue = new Label();
            lblStudy = new Label();
            lblStudyValue = new Label();
            lblDepartment = new Label();
            lblDepartmentValue = new Label();
            lblScholarship = new Label();
            lblScholarshipValue = new Label();
            lblLesson = new Label();
            lblLessonValue = new Label();
            lblLanguage = new Label();
            lblLanguageValue = new Label();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            groupInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(390, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ОЮУТНЫ БҮРТГЭЛ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 590);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 28);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Нийт: 0";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(20, 40);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 31);
            txtCode.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(20, 360);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 31);
            txtPhone.TabIndex = 9;
            // 
            // chkScholarship
            // 
            chkScholarship.AutoSize = true;
            chkScholarship.Location = new Point(20, 75);
            chkScholarship.Name = "chkScholarship";
            chkScholarship.Size = new Size(126, 29);
            chkScholarship.TabIndex = 3;
            chkScholarship.Text = "Тэтгэлэгтэй";
            // 
            // rbDay
            // 
            rbDay.AutoSize = true;
            rbDay.Checked = true;
            rbDay.Location = new Point(20, 105);
            rbDay.Name = "rbDay";
            rbDay.Size = new Size(167, 29);
            rbDay.TabIndex = 4;
            rbDay.TabStop = true;
            rbDay.Text = "Өдрийн сургалт";
            // 
            // rbEvening
            // 
            rbEvening.AutoSize = true;
            rbEvening.Location = new Point(20, 130);
            rbEvening.Name = "rbEvening";
            rbEvening.Size = new Size(158, 29);
            rbEvening.TabIndex = 5;
            rbEvening.Text = "Оройн сургалт";
            // 
            // clbLesson
            // 
            clbLesson.CheckOnClick = true;
            clbLesson.Location = new Point(20, 165);
            clbLesson.Name = "clbLesson";
            clbLesson.Size = new Size(220, 88);
            clbLesson.TabIndex = 6;
            // 
            // numAge
            // 
            numAge.Location = new Point(20, 280);
            numAge.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(220, 31);
            numAge.TabIndex = 7;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.Items.AddRange(new object[] { "Програм хангамж", "Мэдээллийн систем", "Компьютерийн ухаан", "Электроник", "Автоматик" });
            cmbDepartment.Location = new Point(20, 320);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(220, 33);
            cmbDepartment.TabIndex = 8;
            // 
            // lstLanguage
            // 
            lstLanguage.ItemHeight = 25;
            lstLanguage.Location = new Point(270, 85);
            lstLanguage.Name = "lstLanguage";
            lstLanguage.Size = new Size(119, 79);
            lstLanguage.TabIndex = 13;
            lstLanguage.SelectedIndexChanged += lstLanguage_SelectedIndexChanged;
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(20, 400);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(220, 31);
            dtpBirth.TabIndex = 10;
            // 
            // pictureStudent
            // 
            pictureStudent.BackColor = Color.LightGray;
            pictureStudent.BorderStyle = BorderStyle.FixedSingle;
            pictureStudent.Location = new Point(270, 200);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(180, 180);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 14;
            pictureStudent.TabStop = false;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeight = 34;
            dgvStudent.Location = new Point(480, 75);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(490, 115);
            dgvStudent.TabIndex = 15;
            // 
            // treeDepartment
            // 
            treeDepartment.Location = new Point(480, 200);
            treeDepartment.Name = "treeDepartment";
            treeDepartment.Size = new Size(490, 195);
            treeDepartment.TabIndex = 16;
            treeDepartment.AfterSelect += treeDepartment_AfterSelect;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRegister.Location = new Point(20, 450);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 50);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "БҮРТГЭХ";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(850, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 12;
            btnClear.Text = "Цэвэрлэх";
            btnClear.Click += btnClear_Click;
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(lblCode);
            groupInfo.Controls.Add(lblCodeValue);
            groupInfo.Controls.Add(lblPhone);
            groupInfo.Controls.Add(lblPhoneValue);
            groupInfo.Controls.Add(lblAge);
            groupInfo.Controls.Add(lblAgeValue);
            groupInfo.Controls.Add(lblBirth);
            groupInfo.Controls.Add(lblBirthValue);
            groupInfo.Controls.Add(lblStudy);
            groupInfo.Controls.Add(lblStudyValue);
            groupInfo.Controls.Add(lblDepartment);
            groupInfo.Controls.Add(lblDepartmentValue);
            groupInfo.Controls.Add(lblScholarship);
            groupInfo.Controls.Add(lblScholarshipValue);
            groupInfo.Controls.Add(lblLesson);
            groupInfo.Controls.Add(lblLessonValue);
            groupInfo.Controls.Add(lblLanguage);
            groupInfo.Controls.Add(lblLanguageValue);
            groupInfo.Location = new Point(480, 410);
            groupInfo.Name = "groupInfo";
            groupInfo.Size = new Size(490, 204);
            groupInfo.TabIndex = 17;
            groupInfo.TabStop = false;
            groupInfo.Text = "Сонгогдсон оюутны мэдээлэл";
            // 
            // lblCode
            // 
            lblCode.Location = new Point(15, 25);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(100, 23);
            lblCode.TabIndex = 0;
            lblCode.Text = "Код:";
            // 
            // lblCodeValue
            // 
            lblCodeValue.AutoSize = true;
            lblCodeValue.ForeColor = Color.Green;
            lblCodeValue.Location = new Point(90, 25);
            lblCodeValue.Name = "lblCodeValue";
            lblCodeValue.Size = new Size(0, 25);
            lblCodeValue.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(15, 45);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Утас:";
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.AutoSize = true;
            lblPhoneValue.ForeColor = Color.Green;
            lblPhoneValue.Location = new Point(90, 45);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Size = new Size(0, 25);
            lblPhoneValue.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(15, 65);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Нас:";
            // 
            // lblAgeValue
            // 
            lblAgeValue.AutoSize = true;
            lblAgeValue.ForeColor = Color.Green;
            lblAgeValue.Location = new Point(90, 65);
            lblAgeValue.Name = "lblAgeValue";
            lblAgeValue.Size = new Size(0, 25);
            lblAgeValue.TabIndex = 5;
            // 
            // lblBirth
            // 
            lblBirth.Location = new Point(15, 85);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(100, 23);
            lblBirth.TabIndex = 6;
            lblBirth.Text = "Төрсөн өдөр:";
            // 
            // lblBirthValue
            // 
            lblBirthValue.AutoSize = true;
            lblBirthValue.ForeColor = Color.Green;
            lblBirthValue.Location = new Point(110, 85);
            lblBirthValue.Name = "lblBirthValue";
            lblBirthValue.Size = new Size(0, 25);
            lblBirthValue.TabIndex = 7;
            // 
            // lblStudy
            // 
            lblStudy.Location = new Point(15, 105);
            lblStudy.Name = "lblStudy";
            lblStudy.Size = new Size(100, 23);
            lblStudy.TabIndex = 8;
            lblStudy.Text = "Сургалт:";
            // 
            // lblStudyValue
            // 
            lblStudyValue.AutoSize = true;
            lblStudyValue.ForeColor = Color.Green;
            lblStudyValue.Location = new Point(90, 105);
            lblStudyValue.Name = "lblStudyValue";
            lblStudyValue.Size = new Size(0, 25);
            lblStudyValue.TabIndex = 9;
            // 
            // lblDepartment
            // 
            lblDepartment.Location = new Point(15, 125);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(100, 23);
            lblDepartment.TabIndex = 10;
            lblDepartment.Text = "Тэнхим:";
            // 
            // lblDepartmentValue
            // 
            lblDepartmentValue.AutoSize = true;
            lblDepartmentValue.ForeColor = Color.Green;
            lblDepartmentValue.Location = new Point(90, 125);
            lblDepartmentValue.Name = "lblDepartmentValue";
            lblDepartmentValue.Size = new Size(0, 25);
            lblDepartmentValue.TabIndex = 11;
            // 
            // lblScholarship
            // 
            lblScholarship.Location = new Point(15, 145);
            lblScholarship.Name = "lblScholarship";
            lblScholarship.Size = new Size(100, 23);
            lblScholarship.TabIndex = 12;
            lblScholarship.Text = "Тэтгэлэг:";
            // 
            // lblScholarshipValue
            // 
            lblScholarshipValue.AutoSize = true;
            lblScholarshipValue.ForeColor = Color.Green;
            lblScholarshipValue.Location = new Point(90, 145);
            lblScholarshipValue.Name = "lblScholarshipValue";
            lblScholarshipValue.Size = new Size(0, 25);
            lblScholarshipValue.TabIndex = 13;
            // 
            // lblLesson
            // 
            lblLesson.Location = new Point(260, 25);
            lblLesson.Name = "lblLesson";
            lblLesson.Size = new Size(100, 23);
            lblLesson.TabIndex = 14;
            lblLesson.Text = "Хичээл:";
            // 
            // lblLessonValue
            // 
            lblLessonValue.AutoSize = true;
            lblLessonValue.ForeColor = Color.Green;
            lblLessonValue.Location = new Point(325, 25);
            lblLessonValue.Name = "lblLessonValue";
            lblLessonValue.Size = new Size(0, 25);
            lblLessonValue.TabIndex = 15;
            // 
            // lblLanguage
            // 
            lblLanguage.Location = new Point(260, 75);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(100, 23);
            lblLanguage.TabIndex = 16;
            lblLanguage.Text = "Хэл:";
            // 
            // lblLanguageValue
            // 
            lblLanguageValue.AutoSize = true;
            lblLanguageValue.ForeColor = Color.Green;
            lblLanguageValue.Location = new Point(325, 75);
            lblLanguageValue.Name = "lblLanguageValue";
            lblLanguageValue.Size = new Size(0, 25);
            lblLanguageValue.TabIndex = 17;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 620);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(950, 20);
            progressBar.TabIndex = 18;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1050, 700);
            Controls.Add(lblTitle);
            Controls.Add(lblTotal);
            Controls.Add(txtCode);
            Controls.Add(chkScholarship);
            Controls.Add(rbDay);
            Controls.Add(rbEvening);
            Controls.Add(clbLesson);
            Controls.Add(numAge);
            Controls.Add(cmbDepartment);
            Controls.Add(txtPhone);
            Controls.Add(dtpBirth);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(lstLanguage);
            Controls.Add(pictureStudent);
            Controls.Add(dgvStudent);
            Controls.Add(treeDepartment);
            Controls.Add(groupInfo);
            Controls.Add(progressBar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оюутны бүртгэлийн программ";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}