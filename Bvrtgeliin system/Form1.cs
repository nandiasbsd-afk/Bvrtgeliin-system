using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OyutniiBurtgel
{
    public partial class Form1 : Form
    {
        // =====================================================
        // ОЮУТНЫ CLASS
        // =====================================================

        [Serializable]
        public class Student
        {
            public string Code { get; set; }
            public string Phone { get; set; }
            public int Age { get; set; }
            public DateTime BirthDate { get; set; }

            public string Study { get; set; }
            public string Department { get; set; }

            public bool Scholarship { get; set; }

            public string Lessons { get; set; }
            public string Language { get; set; }

            public string ImagePath { get; set; }
        }


        // =====================================================
        // ОЮУТНЫ ЖАГСААЛТ
        // =====================================================

        private List<Student> students =
            new List<Student>();


        // =====================================================
        // ФАЙЛЫН ЗАМ
        // =====================================================

        private string dataFile =
            Path.Combine(
                Application.StartupPath,
                "students.xml"
            );

        private string imageFolder =
            Path.Combine(
                Application.StartupPath,
                "StudentImages"
            );


        // =====================================================
        // СОНГОСОН ЗУРАГ
        // =====================================================

        private string selectedImagePath = "";


        // =====================================================
        // FORM
        // =====================================================

        public Form1()
        {
            InitializeComponent();


            // Зургийн хавтас үүсгэнэ
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(
                    imageFolder
                );
            }


            // Компонентууд
            LoadData();

            SetupDataGridView();

            CreateExtraControls();


            // Өмнө хадгалсан оюутнууд
            LoadStudents();


            // Хүснэгтэд харуулах
            ShowAllStudents();


            // Тоо
            UpdateStudentCount();
        }


        // =====================================================
        // НЭМЭЛТ CONTROL-УУД
        // =====================================================

        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnChangeImage;
        private Button btnSelectImage;


        private void CreateExtraControls()
        {
            // =================================================
            // ЗУРАГ СОНГОХ
            // =================================================

            btnSelectImage =
                new Button();

            btnSelectImage.Name =
                "btnSelectImage";

            btnSelectImage.Text =
                "Зураг сонгох";

            btnSelectImage.Location =
                new Point(270, 420);

            btnSelectImage.Size =
                new Size(180, 40);

            btnSelectImage.BackColor =
                Color.LightBlue;

            btnSelectImage.Click +=
                btnSelectImage_Click;

            Controls.Add(
                btnSelectImage
            );


            // =================================================
            // ЗУРАГ СОЛИХ
            // =================================================

            btnChangeImage =
                new Button();

            btnChangeImage.Name =
                "btnChangeImage";

            btnChangeImage.Text =
                "Зураг солих";

            btnChangeImage.Location =
                new Point(270, 465);

            btnChangeImage.Size =
                new Size(180, 40);

            btnChangeImage.BackColor =
                Color.LightYellow;

            btnChangeImage.Click +=
                btnChangeImage_Click;

            Controls.Add(
                btnChangeImage
            );


            // =================================================
            // ХАЙЛТ
            // =================================================

            txtSearch =
                new TextBox();

            txtSearch.Name =
                "txtSearch";

            txtSearch.Location =
                new Point(480, 20);

            txtSearch.Size =
                new Size(250, 27);

            txtSearch.TextChanged +=
                txtSearch_TextChanged;

            Controls.Add(
                txtSearch
            );


            // =================================================
            // УСТГАХ
            // =================================================

            btnDelete =
                new Button();

            btnDelete.Name =
                "btnDelete";

            btnDelete.Text =
                "УСТГАХ";

            btnDelete.Location =
                new Point(740, 20);

            btnDelete.Size =
                new Size(100, 35);

            btnDelete.BackColor =
                Color.LightCoral;

            btnDelete.Click +=
                btnDelete_Click;

            Controls.Add(
                btnDelete
            );


            // Дээр нь гаргах
            btnSelectImage.BringToFront();
            btnChangeImage.BringToFront();
            txtSearch.BringToFront();
            btnDelete.BringToFront();
        }


        // =====================================================
        // COMBOBOX, LISTBOX, TREEVIEW
        // =====================================================

        private void LoadData()
        {
            // =================================================
            // ХЭЛ
            // =================================================

            lstLanguage.Items.Clear();

            lstLanguage.Items.Add("Монгол");
            lstLanguage.Items.Add("Англи");
            lstLanguage.Items.Add("Орос");
            lstLanguage.Items.Add("Хятад");
            lstLanguage.Items.Add("Япон");
            lstLanguage.Items.Add("Солонгос");


            // =================================================
            // ТЭНХИМ / МЭРГЭЖИЛ
            // =================================================

            cmbDepartment.Items.Clear();

            cmbDepartment.Items.Add(
                "Мэдээллийн технологи"
            );

            cmbDepartment.Items.Add(
                "Программ хангамж"
            );

            cmbDepartment.Items.Add(
                "Компьютерийн ухаан"
            );

            cmbDepartment.Items.Add(
                "Мэдээллийн систем"
            );


            // =================================================
            // НАС
            // =================================================

            numAge.Minimum = 16;

            numAge.Maximum = 60;

            numAge.Value = 18;


            // =================================================
            // СУРГАЛТ
            // =================================================

            rbDay.Checked = true;


            // =================================================
            // ХИЧЭЭЛ
            // =================================================

            clbLesson.Items.Clear();

            clbLesson.Items.Add(
                "Программчлал"
            );

            clbLesson.Items.Add(
                "Өгөгдлийн бүтэц"
            );

            clbLesson.Items.Add(
                "Алгоритм"
            );

            clbLesson.Items.Add(
                "Өгөгдлийн сан"
            );

            clbLesson.Items.Add(
                "Сүлжээ"
            );


            // =================================================
            // TREEVIEW
            // =================================================

            treeDepartment.Nodes.Clear();


            TreeNode computer =
                treeDepartment.Nodes.Add(
                    "Компьютерийн ухаан"
                );

            computer.Nodes.Add(
                "Мэдээллийн технологи"
            );

            computer.Nodes.Add(
                "Программ хангамж"
            );

            computer.Nodes.Add(
                "Компьютерийн ухаан"
            );


            TreeNode science =
                treeDepartment.Nodes.Add(
                    "Байгалийн ухааны сургууль"
                );

            science.Nodes.Add(
                "Математик"
            );

            science.Nodes.Add(
                "Физик"
            );


            treeDepartment.ExpandAll();
        }


        // =====================================================
        // DATAGRIDVIEW
        // =====================================================

        private void SetupDataGridView()
        {
            dgvStudent.Columns.Clear();


            dgvStudent.Columns.Add(
                "Code",
                "Оюутны код"
            );


            dgvStudent.Columns.Add(
                "Phone",
                "Утас"
            );


            dgvStudent.Columns.Add(
                "Age",
                "Нас"
            );


            dgvStudent.AllowUserToAddRows =
                false;

            dgvStudent.AllowUserToDeleteRows =
                false;

            dgvStudent.ReadOnly =
                true;

            dgvStudent.MultiSelect =
                false;

            dgvStudent.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvStudent.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


        // =====================================================
        // ЗУРАГ СОНГОХ
        // =====================================================

        private void btnSelectImage_Click(
            object sender,
            EventArgs e)
        {
            OpenFileDialog dialog =
                new OpenFileDialog();


            dialog.Title =
                "Оюутны зураг сонгох";


            dialog.Filter =
                "Зургийн файл|*.jpg;*.jpeg;*.png;*.bmp";


            dialog.Multiselect =
                false;


            if (
                dialog.ShowDialog()
                ==
                DialogResult.OK
            )
            {
                selectedImagePath =
                    dialog.FileName;


                ShowImage(
                    selectedImagePath
                );
            }
        }


        // =====================================================
        // ЗУРАГ ХАРУУЛАХ
        // =====================================================

        private void ShowImage(
            string path)
        {
            if (
                string.IsNullOrEmpty(path)
            )
            {
                return;
            }


            if (
                !File.Exists(path)
            )
            {
                return;
            }


            try
            {
                if (
                    pictureStudent.Image
                    != null
                )
                {
                    pictureStudent.Image.Dispose();

                    pictureStudent.Image =
                        null;
                }


                using (
                    FileStream fs =
                    new FileStream(
                        path,
                        FileMode.Open,
                        FileAccess.Read
                    )
                )
                {
                    using (
                        Image temp =
                        Image.FromStream(fs)
                    )
                    {
                        pictureStudent.Image =
                            new Bitmap(temp);
                    }
                }


                pictureStudent.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show(
                    "Зургийг нээж чадсангүй!"
                );
            }
        }


        // =====================================================
        // ОЮУТАН ХАДГАЛАХ
        // =====================================================

        private void SaveStudents()
        {
            try
            {
                XmlSerializer serializer =
                    new XmlSerializer(
                        typeof(List<Student>)
                    );


                using (
                    FileStream fs =
                    new FileStream(
                        dataFile,
                        FileMode.Create
                    )
                )
                {
                    serializer.Serialize(
                        fs,
                        students
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Мэдээлэл хадгалахад алдаа гарлаа!\n\n"
                    + ex.Message
                );
            }
        }


        // =====================================================
        // ОЮУТАН УНШИХ
        // =====================================================

        private void LoadStudents()
        {
            if (
                !File.Exists(dataFile)
            )
            {
                return;
            }


            try
            {
                XmlSerializer serializer =
                    new XmlSerializer(
                        typeof(List<Student>)
                    );


                using (
                    FileStream fs =
                    new FileStream(
                        dataFile,
                        FileMode.Open
                    )
                )
                {
                    students =
                        (List<Student>)
                        serializer.Deserialize(
                            fs
                        );
                }
            }
            catch
            {
                students =
                    new List<Student>();
            }
        }


        // =====================================================
        // БҮХ ОЮУТАН ХАРУУЛАХ
        // =====================================================

        private void ShowAllStudents()
        {
            dgvStudent.Rows.Clear();


            foreach (
                Student s
                in students
            )
            {
                int row =
                    dgvStudent.Rows.Add(
                        s.Code,
                        s.Phone,
                        s.Age
                    );


                // Student объектыг мөрөнд хадгална
                dgvStudent
                    .Rows[row]
                    .Tag = s;
            }


            UpdateStudentCount();
        }


        // =====================================================
        // НИЙТ ОЮУТНЫ ТОО
        // =====================================================

        private void UpdateStudentCount()
        {
            lblTotal.Text =
                "Нийт: " +
                students.Count;
        }


        // =====================================================
        // БҮРТГЭХ
        // =====================================================

        private void btnRegister_Click(
            object sender,
            EventArgs e)
        {
            // =================================================
            // КОД
            // =================================================

            if (
                txtCode.Text.Trim()
                == ""
            )
            {
                MessageBox.Show(
                    "Оюутны код оруулна уу!"
                );

                txtCode.Focus();

                return;
            }


            // =================================================
            // УТАС
            // =================================================

            if (
                txtPhone.Text.Trim()
                == ""
            )
            {
                MessageBox.Show(
                    "Утасны дугаар оруулна уу!"
                );

                txtPhone.Focus();

                return;
            }


            // =================================================
            // КОД ДАВХАРДАХ
            // =================================================

            foreach (
                Student oldStudent
                in students
            )
            {
                if (
                    oldStudent.Code.Equals(
                        txtCode.Text.Trim(),
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                {
                    MessageBox.Show(
                        "Энэ оюутны код бүртгэлтэй байна!"
                    );

                    return;
                }
            }


            // =================================================
            // СУРГАЛТ
            // =================================================

            string study;


            if (rbDay.Checked)
            {
                study =
                    "Өдрийн";
            }
            else
            {
                study =
                    "Оройн";
            }


            // =================================================
            // ХИЧЭЭЛ
            // =================================================

            string lessons = "";


            foreach (
                object item
                in clbLesson.CheckedItems
            )
            {
                if (
                    lessons != ""
                )
                {
                    lessons +=
                        ", ";
                }


                lessons +=
                    item.ToString();
            }


            if (
                lessons == ""
            )
            {
                lessons =
                    "Сонгоогүй";
            }


            // =================================================
            // ХЭЛ
            // =================================================

            string language = "";


            if (
                lstLanguage.SelectedItem
                != null
            )
            {
                language =
                    lstLanguage
                    .SelectedItem
                    .ToString();
            }


            // =================================================
            // STUDENT ҮҮСГЭХ
            // =================================================

            Student s =
                new Student();


            s.Code =
                txtCode.Text.Trim();


            s.Phone =
                txtPhone.Text.Trim();


            s.Age =
                (int)numAge.Value;


            s.BirthDate =
                dtpBirth.Value;


            s.Study =
                study;


            s.Department =
                cmbDepartment.Text;


            s.Scholarship =
                chkScholarship.Checked;


            s.Lessons =
                lessons;


            s.Language =
                language;


            // =================================================
            // ЗУРАГ ХАДГАЛАХ
            // =================================================

            if (
                !string.IsNullOrEmpty(
                    selectedImagePath
                )
                &&
                File.Exists(
                    selectedImagePath
                )
            )
            {
                try
                {
                    string extension =
                        Path.GetExtension(
                            selectedImagePath
                        );


                    string fileName =
                        s.Code.Replace(
                            " ",
                            "_"
                        )
                        +
                        "_"
                        +
                        DateTime.Now.ToString(
                            "yyyyMMddHHmmssfff"
                        )
                        +
                        extension;


                    string destination =
                        Path.Combine(
                            imageFolder,
                            fileName
                        );


                    File.Copy(
                        selectedImagePath,
                        destination,
                        true
                    );


                    s.ImagePath =
                        destination;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Зураг хадгалахад алдаа гарлаа!\n\n"
                        + ex.Message
                    );

                    return;
                }
            }


            // =================================================
            // ЖАГСААЛТАД НЭМЭХ
            // =================================================

            students.Add(s);


            // =================================================
            // ФАЙЛД ХАДГАЛАХ
            // =================================================

            SaveStudents();


            // =================================================
            // ХҮСНЭГТ ШИНЭЧЛЭХ
            // =================================================

            ShowAllStudents();


            // =================================================
            // МЭДЭЭЛЭЛ ХАРУУЛАХ
            // =================================================

            ShowStudentInfo(s);


            // =================================================
            // ЗУРАГ ХАРУУЛАХ
            // =================================================

            if (
                !string.IsNullOrEmpty(
                    s.ImagePath
                )
            )
            {
                ShowImage(
                    s.ImagePath
                );
            }


            // Progress
            progressBar.Value =
                100;


            MessageBox.Show(
                "Оюутан амжилттай бүртгэгдлээ!",
                "Амжилт",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =====================================================
        // ОЮУТАН СОНГОХ
        // =====================================================

        private void dgvStudent_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (
                e.RowIndex < 0
            )
            {
                return;
            }


            DataGridViewRow row =
                dgvStudent.Rows[
                    e.RowIndex
                ];


            Student s =
                row.Tag as Student;


            if (s == null)
            {
                return;
            }


            // Код
            txtCode.Text =
                s.Code;


            // Утас
            txtPhone.Text =
                s.Phone;


            // Нас
            numAge.Value =
                s.Age;


            // Төрсөн өдөр
            dtpBirth.Value =
                s.BirthDate;


            // Сургалт
            if (
                s.Study ==
                "Өдрийн"
            )
            {
                rbDay.Checked =
                    true;
            }
            else
            {
                rbEvening.Checked =
                    true;
            }


            // Тэтгэлэг
            chkScholarship.Checked =
                s.Scholarship;


            // Тэнхим
            cmbDepartment.Text =
                s.Department;


            // Хэл
            lstLanguage.SelectedItem =
                s.Language;


            // =================================================
            // ХИЧЭЭЛ
            // =================================================

            for (
                int i = 0;
                i < clbLesson.Items.Count;
                i++
            )
            {
                clbLesson.SetItemChecked(
                    i,
                    false
                );
            }


            string[] lessons =
                s.Lessons.Split(',');


            for (
                int i = 0;
                i < clbLesson.Items.Count;
                i++
            )
            {
                foreach (
                    string lesson
                    in lessons
                )
                {
                    if (
                        clbLesson.Items[i]
                        .ToString()
                        .Trim()
                        ==
                        lesson.Trim()
                    )
                    {
                        clbLesson.SetItemChecked(
                            i,
                            true
                        );
                    }
                }
            }


            // =================================================
            // ЗУРАГ
            // =================================================

            selectedImagePath =
                s.ImagePath;


            if (
                !string.IsNullOrEmpty(
                    s.ImagePath
                )
                &&
                File.Exists(
                    s.ImagePath
                )
            )
            {
                ShowImage(
                    s.ImagePath
                );
            }


            // Доод мэдээлэл
            ShowStudentInfo(s);
        }


        // =====================================================
        // ДООД МЭДЭЭЛЭЛ
        // =====================================================

        private void ShowStudentInfo(
            Student s)
        {
            lblCodeValue.Text =
                s.Code;


            lblPhoneValue.Text =
                s.Phone;


            lblAgeValue.Text =
                s.Age.ToString();


            lblBirthValue.Text =
                s.BirthDate.ToString(
                    "yyyy-MM-dd"
                );


            lblStudyValue.Text =
                s.Study;


            lblDepartmentValue.Text =
                s.Department;


            lblScholarshipValue.Text =
                s.Scholarship
                ? "Тийм"
                : "Үгүй";


            lblLessonValue.Text =
                s.Lessons;


            lblLanguageValue.Text =
                s.Language;
        }


        // =====================================================
        // ХАЙЛТ
        // =====================================================

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            string search =
                txtSearch.Text
                .Trim()
                .ToLower();


            dgvStudent.Rows.Clear();


            foreach (
                Student s
                in students
            )
            {
                bool found =
                    s.Code
                    .ToLower()
                    .Contains(search)

                    ||

                    s.Phone
                    .ToLower()
                    .Contains(search)

                    ||

                    s.Age
                    .ToString()
                    .Contains(search)

                    ||

                    s.Department
                    .ToLower()
                    .Contains(search)

                    ||

                    s.Study
                    .ToLower()
                    .Contains(search);


                if (found)
                {
                    int row =
                        dgvStudent.Rows.Add(
                            s.Code,
                            s.Phone,
                            s.Age
                        );


                    dgvStudent
                        .Rows[row]
                        .Tag = s;
                }
            }
        }


        // =====================================================
        // УСТГАХ
        // =====================================================

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (
                dgvStudent.CurrentRow
                == null
            )
            {
                MessageBox.Show(
                    "Устгах оюутнаа сонгоно уу!"
                );

                return;
            }


            Student s =
                dgvStudent
                .CurrentRow
                .Tag as Student;


            if (s == null)
            {
                return;
            }


            DialogResult result =
                MessageBox.Show(
                    s.Code +
                    " кодтой оюутныг устгах уу?",
                    "Баталгаажуулах",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


            if (
                result ==
                DialogResult.Yes
            )
            {
                // Жагсаалтаас устгах
                students.Remove(s);


                // XML шинэчлэх
                SaveStudents();


                // Зураг устгах
                if (
                    !string.IsNullOrEmpty(
                        s.ImagePath
                    )
                    &&
                    File.Exists(
                        s.ImagePath
                    )
                )
                {
                    try
                    {
                        File.Delete(
                            s.ImagePath
                        );
                    }
                    catch
                    {
                    }
                }


                // Хүснэгт шинэчлэх
                ShowAllStudents();


                // Форм цэвэрлэх
                ClearInputs();


                MessageBox.Show(
                    "Оюутан амжилттай устгагдлаа!",
                    "Амжилт",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        // =====================================================
        // ЗУРАГ СОЛИХ
        // =====================================================

        private void btnChangeImage_Click(
            object sender,
            EventArgs e)
        {
            if (
                dgvStudent.CurrentRow
                == null
            )
            {
                MessageBox.Show(
                    "Зургийг нь солих оюутнаа сонгоно уу!"
                );

                return;
            }


            Student s =
                dgvStudent
                .CurrentRow
                .Tag as Student;


            if (s == null)
            {
                return;
            }


            OpenFileDialog dialog =
                new OpenFileDialog();


            dialog.Title =
                "Шинэ зураг сонгох";


            dialog.Filter =
                "Зургийн файл|*.jpg;*.jpeg;*.png;*.bmp";


            if (
                dialog.ShowDialog()
                != DialogResult.OK
            )
            {
                return;
            }


            try
            {
                // Хуучин зам
                string oldImage =
                    s.ImagePath;


                // Шинэ зураг
                string extension =
                    Path.GetExtension(
                        dialog.FileName
                    );


                string fileName =
                    s.Code.Replace(
                        " ",
                        "_"
                    )
                    +
                    "_NEW_"
                    +
                    DateTime.Now.ToString(
                        "yyyyMMddHHmmssfff"
                    )
                    +
                    extension;


                string newPath =
                    Path.Combine(
                        imageFolder,
                        fileName
                    );


                File.Copy(
                    dialog.FileName,
                    newPath,
                    true
                );


                // Student-д шинэ зам
                s.ImagePath =
                    newPath;


                // XML хадгалах
                SaveStudents();


                // Зураг харуулах
                ShowImage(
                    newPath
                );


                // Хуучин зураг устгах
                if (
                    !string.IsNullOrEmpty(
                        oldImage
                    )
                    &&
                    File.Exists(
                        oldImage
                    )
                    &&
                    oldImage != newPath
                )
                {
                    try
                    {
                        File.Delete(
                            oldImage
                        );
                    }
                    catch
                    {
                    }
                }


                MessageBox.Show(
                    "Зураг амжилттай солигдлоо!",
                    "Амжилт",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Зураг солих үед алдаа гарлаа!\n\n"
                    + ex.Message
                );
            }
        }


        // =====================================================
        // ЦЭВЭРЛЭХ
        // =====================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearInputs();
        }


        private void ClearInputs()
        {
            txtCode.Clear();

            txtPhone.Clear();


            numAge.Value =
                18;


            dtpBirth.Value =
                DateTime.Now;


            chkScholarship.Checked =
                false;


            rbDay.Checked =
                true;


            rbEvening.Checked =
                false;


            cmbDepartment.SelectedIndex =
                -1;


            lstLanguage.SelectedIndex =
                -1;


            // Хичээлүүд
            for (
                int i = 0;
                i < clbLesson.Items.Count;
                i++
            )
            {
                clbLesson.SetItemChecked(
                    i,
                    false
                );
            }


            // Зураг
            selectedImagePath =
                "";


            if (
                pictureStudent.Image
                != null
            )
            {
                pictureStudent.Image.Dispose();

                pictureStudent.Image =
                    null;
            }


            // Доод мэдээлэл
            lblCodeValue.Text = "";
            lblPhoneValue.Text = "";
            lblAgeValue.Text = "";
            lblBirthValue.Text = "";
            lblStudyValue.Text = "";
            lblDepartmentValue.Text = "";
            lblScholarshipValue.Text = "";
            lblLessonValue.Text = "";
            lblLanguageValue.Text = "";


            // Хүснэгт сонголт
            dgvStudent.ClearSelection();


            // Progress
            progressBar.Value =
                0;
        }


        // =====================================================
        // ХЭЛ СОНГОХ
        // =====================================================

        private void lstLanguage_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (
                lstLanguage.SelectedItem
                != null
            )
            {
                lblLanguageValue.Text =
                    lstLanguage
                    .SelectedItem
                    .ToString();
            }
        }


        // =====================================================
        // TREEVIEW
        // =====================================================

        private void treeDepartment_AfterSelect(
            object sender,
            TreeViewEventArgs e)
        {
            if (
                e.Node.Parent
                != null
            )
            {
                cmbDepartment.Text =
                    e.Node.Text;
            }
        }


        // =====================================================
        // FORM ХААГДАХАД ХАДГАЛНА
        // =====================================================

        protected override void OnFormClosing(
            FormClosingEventArgs e)
        {
            SaveStudents();

            base.OnFormClosing(e);
        }
    }
}