using ProjectC.Entity;
using ProjectC.ProcessHandling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.folderBrowserDialog2.SelectedPath = Application.ExecutablePath;
            this.folderBrowserDialog1.SelectedPath = Application.ExecutablePath;
            cbxClass.Enabled = false;
            btnSaveMark.Enabled = false;
        }
         

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvMark, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = workbook.Sheets["Sheet1"] as Microsoft.Office.Interop.Excel.Worksheet;
                worksheet.Name = "Mark subject C";

                // export header
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Export successful.!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "INSERT INTO [dbo].[Diem]([StudentID],[Mark],[Note]) Values ";
                int r = dgvMark.RowCount;
                int c = dgvMark.ColumnCount;
                for (int i = 0; i < r; i++)
                {
                    sql += "(";
                    for (int j = 0; j < c; j++)
                    {
                        if (j != 1 && j != 2)
                        {
                            sql = sql + "'" + dgvMark.Rows[i].Cells[j].Value.ToString() + "',";

                            if (j == c - 1)
                            {
                                sql = sql.TrimEnd(sql[sql.Length - 1]);
                            }
                        }
                    }
                    sql += "),";
                    if (i == r - 1)
                    {
                        sql = sql.TrimEnd(sql[sql.Length - 1]);
                    }
                }
                DAO.ExecuteSQL(sql);
                MessageBox.Show("Save to database successfully!!");
                btnSaveMark.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnStudentInfor_Click(object sender, EventArgs e)
        {
            cbxClass.Enabled = true;
            cbxClass.DataSource = DAO.getAllClass();
            cbxClass.DisplayMember = "ClassName";
            cbxClass.ValueMember = "ClassName";
            string className = cbxClass.SelectedValue.ToString();
            Console.WriteLine(className);
            dgvMark.DataSource = null;
            dgvMark.DataSource = DAO.getAllMark(className);
        }

        private void cbxClass_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvMark.DataSource = null;
            dgvMark.DataSource = DAO.getAllMark(cbxClass.SelectedValue.ToString());
        }

        private void btnGetMark_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = new List<Student>();
                btnSaveMark.Enabled = true;

                string className = this.txtProgram.Text.Substring(this.txtProgram.Text.LastIndexOf("\\") + 1);

                foreach (DataRow data in DAO.getAllStudentByClass(className).Rows)
                {
                    Student s = new Student();
                    s.StuId = data["StudentID"].ToString();
                    s.FullName = data["StudentName"].ToString();
                    s.ClassN = data["ClassName"].ToString();
                    s.TotalMark = 0;
                    s.Note = "";
                    students.Add(s);
                }

                string[] classFol = Directory.GetDirectories(this.txtProgram.Text);
                pgbLoading.Minimum = 0;
                pgbLoading.Maximum = students.Count;
                // pgbLoading.Value = load;
                for (int j = 0; j < students.Count; j++)
                {
                    int c = 0;
                    for (int i = 0; i < classFol.Length; i++)
                    {
                        string filePath = classFol[i];
                        string[] name = (filePath.Substring(filePath.LastIndexOf("\\") + 1)).Split('_');
                        string stuId1 = name[0];
                        int paperNo = Convert.ToInt32(name[2]);


                        if (students[j].StuId.Equals(stuId1))
                        {

                            GradeHandle.StudentMark(filePath, this.txtTestCase.Text, paperNo, students[j]);
                            c++;

                            // load++;
                        }


                    }
                    if (c == 0)
                        students[j].Note = "Student did not submit exam";

                    pgbLoading.Value += 1;
                }
                pgbLoading.Value = 0;

                //   GradeHandle.loadStudent(this.txtProgram.Text, this.txtTestCase.Text, students, ref load);

                dgvMark.DataSource = students;
                students = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog2.ShowDialog() != DialogResult.Cancel)
                this.txtProgram.Text = this.folderBrowserDialog2.SelectedPath;
        }

        private void btnTestCase_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                this.txtTestCase.Text = this.folderBrowserDialog1.SelectedPath;
        }
    }
}

