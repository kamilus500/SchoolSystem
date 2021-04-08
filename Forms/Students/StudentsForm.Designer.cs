
namespace SchoolSystem.Forms
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.studentsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.showStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new SchoolSystem.Entities.SchoolDataSet();
            this.showStudentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.show_StudentsTableAdapter = new SchoolSystem.Entities.SchoolDataSetTableAdapters.Show_StudentsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsLayout
            // 
            this.studentsLayout.ColumnCount = 1;
            this.studentsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsLayout.Controls.Add(this.panel1, 0, 0);
            this.studentsLayout.Controls.Add(this.dataGridStudents, 0, 1);
            this.studentsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsLayout.Location = new System.Drawing.Point(0, 0);
            this.studentsLayout.Name = "studentsLayout";
            this.studentsLayout.RowCount = 2;
            this.studentsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.studentsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.studentsLayout.Size = new System.Drawing.Size(986, 446);
            this.studentsLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btnRemoveStudent);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 44);
            this.panel2.TabIndex = 4;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStudent.Image")));
            this.btnEditStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditStudent.Location = new System.Drawing.Point(0, 0);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(105, 44);
            this.btnEditStudent.TabIndex = 0;
            this.btnEditStudent.Text = "Edytuj";
            this.btnEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(220, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 44);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudent.Image")));
            this.btnRemoveStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveStudent.Location = new System.Drawing.Point(115, 0);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(105, 44);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Usuń";
            this.btnRemoveStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(105, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 44);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(105, 44);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Dodaj";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.AllowUserToDeleteRows = false;
            this.dataGridStudents.AutoGenerateColumns = false;
            this.dataGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataUrodzeniaDataGridViewTextBoxColumn});
            this.dataGridStudents.DataSource = this.showStudentsBindingSource1;
            this.dataGridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStudents.Location = new System.Drawing.Point(3, 53);
            this.dataGridStudents.MultiSelect = false;
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.ReadOnly = true;
            this.dataGridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudents.Size = new System.Drawing.Size(980, 390);
            this.dataGridStudents.TabIndex = 1;
            // 
            // showStudentsBindingSource
            // 
            this.showStudentsBindingSource.DataMember = "Show_Students";
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showStudentsBindingSource1
            // 
            this.showStudentsBindingSource1.DataMember = "Show_Students";
            this.showStudentsBindingSource1.DataSource = this.schoolDataSet;
            // 
            // show_StudentsTableAdapter
            // 
            this.show_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numer indeksu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numer indeksu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Imie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "Data urodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "Data urodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 446);
            this.Controls.Add(this.studentsLayout);
            this.Name = "StudentsForm";
            this.Text = "Studenci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.studentsLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel studentsLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridStudents;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnAddStudent;
       

        private System.Windows.Forms.BindingSource showStudentsBindingSource;

        private Entities.SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource showStudentsBindingSource1;
        private Entities.SchoolDataSetTableAdapters.Show_StudentsTableAdapter show_StudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
    }
}