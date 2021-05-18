
namespace SchoolSystem.Forms.Grades
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveGrade = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.dataGridGrades = new System.Windows.Forms.DataGridView();
            this.przedmiotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indeksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showGradesWithSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new SchoolSystem.Entities.SchoolDataSet();
            this.show_GradesWithSubjectTableAdapter1 = new SchoolSystem.Entities.SchoolDataSetTableAdapters.Show_GradesWithSubjectTableAdapter();
            this.ocenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocenyTableAdapter = new SchoolSystem.Entities.SchoolDataSetTableAdapters.OcenyTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGradesWithSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridGrades, 0, 1);
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
            this.panel1.Controls.Add(this.btnRemoveGrade);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnAddGrade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoveGrade
            // 
            this.btnRemoveGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveGrade.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveGrade.Image")));
            this.btnRemoveGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveGrade.Location = new System.Drawing.Point(115, 0);
            this.btnRemoveGrade.Name = "btnRemoveGrade";
            this.btnRemoveGrade.Size = new System.Drawing.Size(105, 44);
            this.btnRemoveGrade.TabIndex = 3;
            this.btnRemoveGrade.Text = "Usuń";
            this.btnRemoveGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveGrade.UseVisualStyleBackColor = true;
            this.btnRemoveGrade.Click += new System.EventHandler(this.btnRemoveGrade_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(105, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 44);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddGrade.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGrade.Image")));
            this.btnAddGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddGrade.Location = new System.Drawing.Point(0, 0);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(105, 44);
            this.btnAddGrade.TabIndex = 1;
            this.btnAddGrade.Text = "Dodaj";
            this.btnAddGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // dataGridGrades
            // 
            this.dataGridGrades.AllowUserToAddRows = false;
            this.dataGridGrades.AllowUserToDeleteRows = false;
            this.dataGridGrades.AutoGenerateColumns = false;
            this.dataGridGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.przedmiotDataGridViewTextBoxColumn,
            this.ocenaDataGridViewTextBoxColumn,
            this.indeksDataGridViewTextBoxColumn});
            this.dataGridGrades.DataSource = this.showGradesWithSubjectBindingSource;
            this.dataGridGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGrades.Location = new System.Drawing.Point(3, 53);
            this.dataGridGrades.MultiSelect = false;
            this.dataGridGrades.Name = "dataGridGrades";
            this.dataGridGrades.ReadOnly = true;
            this.dataGridGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGrades.Size = new System.Drawing.Size(980, 390);
            this.dataGridGrades.TabIndex = 1;
            // 
            // przedmiotDataGridViewTextBoxColumn
            // 
            this.przedmiotDataGridViewTextBoxColumn.DataPropertyName = "Przedmiot";
            this.przedmiotDataGridViewTextBoxColumn.HeaderText = "Przedmiot";
            this.przedmiotDataGridViewTextBoxColumn.Name = "przedmiotDataGridViewTextBoxColumn";
            this.przedmiotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocenaDataGridViewTextBoxColumn
            // 
            this.ocenaDataGridViewTextBoxColumn.DataPropertyName = "Ocena";
            this.ocenaDataGridViewTextBoxColumn.HeaderText = "Ocena";
            this.ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            this.ocenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indeksDataGridViewTextBoxColumn
            // 
            this.indeksDataGridViewTextBoxColumn.DataPropertyName = "Indeks";
            this.indeksDataGridViewTextBoxColumn.HeaderText = "Indeks";
            this.indeksDataGridViewTextBoxColumn.Name = "indeksDataGridViewTextBoxColumn";
            this.indeksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showGradesWithSubjectBindingSource
            // 
            this.showGradesWithSubjectBindingSource.DataMember = "Show_GradesWithSubject";
            this.showGradesWithSubjectBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // show_GradesWithSubjectTableAdapter1
            // 
            this.show_GradesWithSubjectTableAdapter1.ClearBeforeFill = true;
            // 
            // ocenyBindingSource
            // 
            this.ocenyBindingSource.DataMember = "Oceny";
            this.ocenyBindingSource.DataSource = this.schoolDataSet1;
            // 
            // ocenyTableAdapter
            // 
            this.ocenyTableAdapter.ClearBeforeFill = true;
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GradesForm";
            this.Text = "Oceny";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GradesForm_FormClosed);
            this.Load += new System.EventHandler(this.GradesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGradesWithSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnRemoveGrade;
        private Entities.SchoolDataSet schoolDataSet1;
        private System.Windows.Forms.BindingSource showGradesWithSubjectBindingSource;
        private Entities.SchoolDataSetTableAdapters.Show_GradesWithSubjectTableAdapter show_GradesWithSubjectTableAdapter1;
        private System.Windows.Forms.BindingSource ocenyBindingSource;
        private Entities.SchoolDataSetTableAdapters.OcenyTableAdapter ocenyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn przedmiotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeksDataGridViewTextBoxColumn;
    }
}