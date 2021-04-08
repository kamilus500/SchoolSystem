
namespace SchoolSystem.Forms.Teachers
{
    partial class TeachersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dataGridTeachers = new System.Windows.Forms.DataGridView();
            this.schoolDataSet = new SchoolSystem.Entities.SchoolDataSet();
            this.showTeachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.show_TeachersTableAdapter = new SchoolSystem.Entities.SchoolDataSetTableAdapters.Show_TeachersTableAdapter();
            this.numerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przedmiotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTeachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridTeachers, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditStudent);
            this.panel1.Controls.Add(this.btnRemoveStudent);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStudent.Image")));
            this.btnEditStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditStudent.Location = new System.Drawing.Point(210, 0);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(105, 44);
            this.btnEditStudent.TabIndex = 4;
            this.btnEditStudent.Text = "Edytuj";
            this.btnEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudent.Image")));
            this.btnRemoveStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveStudent.Location = new System.Drawing.Point(105, 0);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(105, 44);
            this.btnRemoveStudent.TabIndex = 3;
            this.btnRemoveStudent.Text = "Usuń";
            this.btnRemoveStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(105, 44);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Dodaj";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dataGridTeachers
            // 
            this.dataGridTeachers.AllowUserToAddRows = false;
            this.dataGridTeachers.AllowUserToDeleteRows = false;
            this.dataGridTeachers.AutoGenerateColumns = false;
            this.dataGridTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.przedmiotDataGridViewTextBoxColumn});
            this.dataGridTeachers.DataSource = this.showTeachersBindingSource;
            this.dataGridTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTeachers.Location = new System.Drawing.Point(3, 53);
            this.dataGridTeachers.MultiSelect = false;
            this.dataGridTeachers.Name = "dataGridTeachers";
            this.dataGridTeachers.ReadOnly = true;
            this.dataGridTeachers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeachers.Size = new System.Drawing.Size(980, 390);
            this.dataGridTeachers.TabIndex = 1;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showTeachersBindingSource
            // 
            this.showTeachersBindingSource.DataMember = "Show_Teachers";
            this.showTeachersBindingSource.DataSource = this.schoolDataSet;
            // 
            // show_TeachersTableAdapter
            // 
            this.show_TeachersTableAdapter.ClearBeforeFill = true;
            // 
            // numerDataGridViewTextBoxColumn
            // 
            this.numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            this.numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            this.numerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // przedmiotDataGridViewTextBoxColumn
            // 
            this.przedmiotDataGridViewTextBoxColumn.DataPropertyName = "Przedmiot";
            this.przedmiotDataGridViewTextBoxColumn.HeaderText = "Przedmiot";
            this.przedmiotDataGridViewTextBoxColumn.Name = "przedmiotDataGridViewTextBoxColumn";
            this.przedmiotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeachersForm";
            this.Text = "Nauczyciele";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeachersForm_FormClosed);
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTeachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.DataGridView dataGridTeachers;
        private Entities.SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource showTeachersBindingSource;
        private Entities.SchoolDataSetTableAdapters.Show_TeachersTableAdapter show_TeachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przedmiotDataGridViewTextBoxColumn;
    }
}