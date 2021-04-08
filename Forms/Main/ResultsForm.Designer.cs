
namespace SchoolSystem.Forms.Main
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.showStudentsWithGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new SchoolSystem.Entities.SchoolDataSet();
            this.show_StudentsWithGradesTableAdapter = new SchoolSystem.Entities.SchoolDataSetTableAdapters.Show_StudentsWithGradesTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.przedmiotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerIndeksuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAll = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsWithGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showStudentsWithGradesBindingSource
            // 
            this.showStudentsWithGradesBindingSource.DataMember = "Show_StudentsWithGrades";
            this.showStudentsWithGradesBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // show_StudentsWithGradesTableAdapter
            // 
            this.show_StudentsWithGradesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridAll, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 446);
            this.tableLayoutPanel1.TabIndex = 1;
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
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerIndeksuDataGridViewTextBoxColumn
            // 
            this.numerIndeksuDataGridViewTextBoxColumn.DataPropertyName = "Numer indeksu";
            this.numerIndeksuDataGridViewTextBoxColumn.HeaderText = "Numer indeksu";
            this.numerIndeksuDataGridViewTextBoxColumn.Name = "numerIndeksuDataGridViewTextBoxColumn";
            this.numerIndeksuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridAll
            // 
            this.dataGridAll.AllowUserToAddRows = false;
            this.dataGridAll.AllowUserToDeleteRows = false;
            this.dataGridAll.AutoGenerateColumns = false;
            this.dataGridAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerIndeksuDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.ocenaDataGridViewTextBoxColumn,
            this.przedmiotDataGridViewTextBoxColumn});
            this.dataGridAll.DataSource = this.showStudentsWithGradesBindingSource;
            this.dataGridAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAll.Location = new System.Drawing.Point(3, 53);
            this.dataGridAll.MultiSelect = false;
            this.dataGridAll.Name = "dataGridAll";
            this.dataGridAll.ReadOnly = true;
            this.dataGridAll.Size = new System.Drawing.Size(980, 390);
            this.dataGridAll.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 44);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResultsForm";
            this.Text = "Rezultaty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsWithGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Entities.SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource showStudentsWithGradesBindingSource;
        private Entities.SchoolDataSetTableAdapters.Show_StudentsWithGradesTableAdapter show_StudentsWithGradesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerIndeksuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przedmiotDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
    }
}