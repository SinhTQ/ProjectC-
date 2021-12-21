
namespace ProjectC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtTestCase = new System.Windows.Forms.TextBox();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTestCase = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetMark = new System.Windows.Forms.Button();
            this.lblNoti = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveMark = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvMark = new System.Windows.Forms.DataGridView();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnViewMark = new System.Windows.Forms.Button();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class(folder)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TestCase(folder)";
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(207, 34);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(530, 26);
            this.txtProgram.TabIndex = 2;
            // 
            // txtTestCase
            // 
            this.txtTestCase.Location = new System.Drawing.Point(207, 118);
            this.txtTestCase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTestCase.Name = "txtTestCase";
            this.txtTestCase.Size = new System.Drawing.Size(530, 26);
            this.txtTestCase.TabIndex = 3;
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(772, 34);
            this.btnClass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(92, 29);
            this.btnClass.TabIndex = 4;
            this.btnClass.Text = "Browse";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTestCase
            // 
            this.btnTestCase.Location = new System.Drawing.Point(772, 118);
            this.btnTestCase.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTestCase.Name = "btnTestCase";
            this.btnTestCase.Size = new System.Drawing.Size(92, 29);
            this.btnTestCase.TabIndex = 5;
            this.btnTestCase.Text = "Browse";
            this.btnTestCase.UseVisualStyleBackColor = true;
            this.btnTestCase.Click += new System.EventHandler(this.btnTestCase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1018, 115);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 61);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = " Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetMark
            // 
            this.btnGetMark.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMark.Location = new System.Drawing.Point(1017, 31);
            this.btnGetMark.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGetMark.Name = "btnGetMark";
            this.btnGetMark.Size = new System.Drawing.Size(173, 64);
            this.btnGetMark.TabIndex = 7;
            this.btnGetMark.Text = "     Get Mark";
            this.btnGetMark.UseVisualStyleBackColor = false;
            this.btnGetMark.Click += new System.EventHandler(this.btnGetMark_Click);
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.Location = new System.Drawing.Point(658, 225);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(0, 36);
            this.lblNoti.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTestCase);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.txtTestCase);
            this.panel1.Controls.Add(this.txtProgram);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 174);
            this.panel1.TabIndex = 10;
            // 
            // btnSaveMark
            // 
            this.btnSaveMark.Location = new System.Drawing.Point(994, 225);
            this.btnSaveMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveMark.Name = "btnSaveMark";
            this.btnSaveMark.Size = new System.Drawing.Size(196, 66);
            this.btnSaveMark.TabIndex = 13;
            this.btnSaveMark.Text = "Save To Database";
            this.btnSaveMark.UseVisualStyleBackColor = true;
            this.btnSaveMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvMark
            // 
            this.dgvMark.AllowUserToAddRows = false;
            this.dgvMark.AllowUserToDeleteRows = false;
            this.dgvMark.AllowUserToOrderColumns = true;
            this.dgvMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMark.Location = new System.Drawing.Point(12, 314);
            this.dgvMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMark.Name = "dgvMark";
            this.dgvMark.RowHeadersWidth = 62;
            this.dgvMark.RowTemplate.Height = 28;
            this.dgvMark.Size = new System.Drawing.Size(1179, 385);
            this.dgvMark.TabIndex = 16;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(994, 724);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(195, 58);
            this.btn_Excel.TabIndex = 17;
            this.btn_Excel.Text = "Export To Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2003|*.xls|Excel 2007|*.xlsx";
            // 
            // btnViewMark
            // 
            this.btnViewMark.Location = new System.Drawing.Point(28, 229);
            this.btnViewMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewMark.Name = "btnViewMark";
            this.btnViewMark.Size = new System.Drawing.Size(225, 55);
            this.btnViewMark.TabIndex = 18;
            this.btnViewMark.Text = "View Mark";
            this.btnViewMark.UseVisualStyleBackColor = true;
            this.btnViewMark.Click += new System.EventHandler(this.btnStudentInfor_Click);
            // 
            // cbxClass
            // 
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(287, 245);
            this.cbxClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(155, 28);
            this.cbxClass.TabIndex = 19;
            this.cbxClass.SelectedValueChanged += new System.EventHandler(this.cbxClass_SelectedValueChanged);
            // 
            // pgbLoading
            // 
            this.pgbLoading.Location = new System.Drawing.Point(399, 738);
            this.pgbLoading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(390, 28);
            this.pgbLoading.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 815);
            this.Controls.Add(this.pgbLoading);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.btnViewMark);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.dgvMark);
            this.Controls.Add(this.btnSaveMark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNoti);
            this.Controls.Add(this.btnGetMark);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "PRF192-Average PE exam ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTestCase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetMark;
        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtTestCase;
        private System.Windows.Forms.Button btnSaveMark;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvMark;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnViewMark;
        private System.Windows.Forms.ComboBox cbxClass;
        public System.Windows.Forms.ProgressBar pgbLoading;
    }
}

