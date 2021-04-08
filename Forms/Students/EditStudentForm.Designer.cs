
namespace SchoolSystem.Forms.Students
{
    partial class EditStudentForm
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
            this.groubEditStudent = new System.Windows.Forms.GroupBox();
            this.dtPickerStudentEdit = new System.Windows.Forms.DateTimePicker();
            this.boxIndexEdit = new System.Windows.Forms.TextBox();
            this.boxNazwiskoEdit = new System.Windows.Forms.TextBox();
            this.boxImieEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groubEditStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groubEditStudent
            // 
            this.groubEditStudent.Controls.Add(this.dtPickerStudentEdit);
            this.groubEditStudent.Controls.Add(this.boxIndexEdit);
            this.groubEditStudent.Controls.Add(this.boxNazwiskoEdit);
            this.groubEditStudent.Controls.Add(this.boxImieEdit);
            this.groubEditStudent.Controls.Add(this.label4);
            this.groubEditStudent.Controls.Add(this.label3);
            this.groubEditStudent.Controls.Add(this.label2);
            this.groubEditStudent.Controls.Add(this.label1);
            this.groubEditStudent.Controls.Add(this.btnEdit);
            this.groubEditStudent.Location = new System.Drawing.Point(13, 12);
            this.groubEditStudent.Name = "groubEditStudent";
            this.groubEditStudent.Size = new System.Drawing.Size(359, 436);
            this.groubEditStudent.TabIndex = 1;
            this.groubEditStudent.TabStop = false;
            this.groubEditStudent.Text = "Dodanie studenta";
            // 
            // dtPickerStudentEdit
            // 
            this.dtPickerStudentEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerStudentEdit.Location = new System.Drawing.Point(144, 196);
            this.dtPickerStudentEdit.Name = "dtPickerStudentEdit";
            this.dtPickerStudentEdit.Size = new System.Drawing.Size(200, 22);
            this.dtPickerStudentEdit.TabIndex = 8;
            // 
            // boxIndexEdit
            // 
            this.boxIndexEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxIndexEdit.Location = new System.Drawing.Point(144, 155);
            this.boxIndexEdit.Name = "boxIndexEdit";
            this.boxIndexEdit.Size = new System.Drawing.Size(202, 22);
            this.boxIndexEdit.TabIndex = 7;
            // 
            // boxNazwiskoEdit
            // 
            this.boxNazwiskoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxNazwiskoEdit.Location = new System.Drawing.Point(144, 116);
            this.boxNazwiskoEdit.Name = "boxNazwiskoEdit";
            this.boxNazwiskoEdit.Size = new System.Drawing.Size(202, 22);
            this.boxNazwiskoEdit.TabIndex = 6;
            // 
            // boxImieEdit
            // 
            this.boxImieEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxImieEdit.Location = new System.Drawing.Point(144, 76);
            this.boxImieEdit.Name = "boxImieEdit";
            this.boxImieEdit.Size = new System.Drawing.Size(202, 22);
            this.boxImieEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numer indeksu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(118, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.groubEditStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularz Edycji";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.groubEditStudent.ResumeLayout(false);
            this.groubEditStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groubEditStudent;
        private System.Windows.Forms.DateTimePicker dtPickerStudentEdit;
        private System.Windows.Forms.TextBox boxIndexEdit;
        private System.Windows.Forms.TextBox boxNazwiskoEdit;
        private System.Windows.Forms.TextBox boxImieEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
    }
}