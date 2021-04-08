
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
            this.dataGridAll = new System.Windows.Forms.DataGridView();
            this.numerIndeksuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przedmiotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showStudentsWithGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new SchoolSystem.Entities.SchoolDataSet();
            this.show_StudentsWithGradesTableAdapter = new SchoolSystem.Entities.SchoolDataSetTableAdapters.Show_StudentsWithGradesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsWithGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridAll.Location = new System.Drawing.Point(0, 0);
            this.dataGridAll.MultiSelect = false;
            this.dataGridAll.Name = "dataGridAll";
            this.dataGridAll.ReadOnly = true;
            this.dataGridAll.Size = new System.Drawing.Size(986, 446);
            this.dataGridAll.TabIndex = 0;
            // 
            // numerIndeksuDataGridViewTextBoxColumn
            // 
            this.numerIndeksuDataGridViewTextBoxColumn.DataPropertyName = "Numer indeksu";
            this.numerIndeksuDataGridViewTextBoxColumn.HeaderText = "Numer indeksu";
            this.numerIndeksuDataGridViewTextBoxColumn.Name = "numerIndeksuDataGridViewTextBoxColumn";
            this.numerIndeksuDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ocenaDataGridViewTextBoxColumn
            // 
            this.ocenaDataGridViewTextBoxColumn.DataPropertyName = "Ocena";
            this.ocenaDataGridViewTextBoxColumn.HeaderText = "Ocena";
            this.ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            this.ocenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // przedmiotDataGridViewTextBoxColumn
            // 
            this.przedmiotDataGridViewTextBoxColumn.DataPropertyName = "Przedmiot";
            this.przedmiotDataGridViewTextBoxColumn.HeaderText = "Przedmiot";
            this.przedmiotDataGridViewTextBoxColumn.Name = "przedmiotDataGridViewTextBoxColumn";
            this.przedmiotDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 446);
            this.Controls.Add(this.dataGridAll);
            this.Name = "ResultsForm";
            this.Text = "Rezultaty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentsWithGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAll;
        private Entities.SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource showStudentsWithGradesBindingSource;
        private Entities.SchoolDataSetTableAdapters.Show_StudentsWithGradesTableAdapter show_StudentsWithGradesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerIndeksuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przedmiotDataGridViewTextBoxColumn;
    }
}