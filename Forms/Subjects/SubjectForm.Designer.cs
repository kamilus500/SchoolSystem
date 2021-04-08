
namespace SchoolSystem.Forms.Subjects
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.schoolDataSet = new SchoolSystem.Entities.SchoolDataSet();
            this.showSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.show_SubjectsTableAdapter = new SchoolSystem.Entities.SchoolDataSetTableAdapters.Show_SubjectsTableAdapter();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieNauczycielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoNauczycielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSubjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridSubjects, 0, 1);
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
            this.panel1.Controls.Add(this.btnRemoveSubject);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnAddSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.Image")));
            this.btnAddSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSubject.Location = new System.Drawing.Point(0, 0);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(105, 44);
            this.btnAddSubject.TabIndex = 1;
            this.btnAddSubject.Text = "Dodaj";
            this.btnAddSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(105, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 44);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSubject.Image")));
            this.btnRemoveSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveSubject.Location = new System.Drawing.Point(115, 0);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(105, 44);
            this.btnRemoveSubject.TabIndex = 3;
            this.btnRemoveSubject.Text = "Usuń";
            this.btnRemoveSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.AllowUserToAddRows = false;
            this.dataGridSubjects.AllowUserToDeleteRows = false;
            this.dataGridSubjects.AutoGenerateColumns = false;
            this.dataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.imieNauczycielaDataGridViewTextBoxColumn,
            this.nazwiskoNauczycielaDataGridViewTextBoxColumn});
            this.dataGridSubjects.DataSource = this.showSubjectsBindingSource;
            this.dataGridSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSubjects.Location = new System.Drawing.Point(3, 53);
            this.dataGridSubjects.MultiSelect = false;
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.ReadOnly = true;
            this.dataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSubjects.Size = new System.Drawing.Size(980, 390);
            this.dataGridSubjects.TabIndex = 1;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showSubjectsBindingSource
            // 
            this.showSubjectsBindingSource.DataMember = "Show_Subjects";
            this.showSubjectsBindingSource.DataSource = this.schoolDataSet;
            // 
            // show_SubjectsTableAdapter
            // 
            this.show_SubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieNauczycielaDataGridViewTextBoxColumn
            // 
            this.imieNauczycielaDataGridViewTextBoxColumn.DataPropertyName = "Imie nauczyciela";
            this.imieNauczycielaDataGridViewTextBoxColumn.HeaderText = "Imie nauczyciela";
            this.imieNauczycielaDataGridViewTextBoxColumn.Name = "imieNauczycielaDataGridViewTextBoxColumn";
            this.imieNauczycielaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoNauczycielaDataGridViewTextBoxColumn
            // 
            this.nazwiskoNauczycielaDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko nauczyciela";
            this.nazwiskoNauczycielaDataGridViewTextBoxColumn.HeaderText = "Nazwisko nauczyciela";
            this.nazwiskoNauczycielaDataGridViewTextBoxColumn.Name = "nazwiskoNauczycielaDataGridViewTextBoxColumn";
            this.nazwiskoNauczycielaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubjectForm";
            this.Text = "Przedmioty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubjectForm_FormClosed);
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSubjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private Entities.SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource showSubjectsBindingSource;
        private Entities.SchoolDataSetTableAdapters.Show_SubjectsTableAdapter show_SubjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieNauczycielaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoNauczycielaDataGridViewTextBoxColumn;
    }
}