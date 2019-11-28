namespace GestionDeExamenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.regNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewExam = new System.Windows.Forms.ListView();
            this.colExamNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuestionsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPractice = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colCodPractice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDifficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.colDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewStudent
            // 
            this.listViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regNumber,
            this.colName,
            this.colGroup});
            this.listViewStudent.HideSelection = false;
            this.listViewStudent.Location = new System.Drawing.Point(12, 43);
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(287, 97);
            this.listViewStudent.TabIndex = 0;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.View = System.Windows.Forms.View.Details;
            // 
            // regNumber
            // 
            this.regNumber.Text = "Número de matrícula";
            this.regNumber.Width = 123;
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 112;
            // 
            // colGroup
            // 
            this.colGroup.Text = "Grupo";
            this.colGroup.Width = 45;
            // 
            // listViewExam
            // 
            this.listViewExam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colExamNumber,
            this.colQuestionsNumber,
            this.colDate});
            this.listViewExam.HideSelection = false;
            this.listViewExam.Location = new System.Drawing.Point(361, 43);
            this.listViewExam.Name = "listViewExam";
            this.listViewExam.Size = new System.Drawing.Size(305, 97);
            this.listViewExam.TabIndex = 1;
            this.listViewExam.UseCompatibleStateImageBehavior = false;
            this.listViewExam.View = System.Windows.Forms.View.Details;
            // 
            // colExamNumber
            // 
            this.colExamNumber.Text = "Número de exámen";
            // 
            // colQuestionsNumber
            // 
            this.colQuestionsNumber.Text = "Preguntas";
            // 
            // colDate
            // 
            this.colDate.Text = "Fecha";
            // 
            // listViewPractice
            // 
            this.listViewPractice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodPractice,
            this.colTitle,
            this.colDifficulty});
            this.listViewPractice.HideSelection = false;
            this.listViewPractice.Location = new System.Drawing.Point(817, 34);
            this.listViewPractice.Name = "listViewPractice";
            this.listViewPractice.Size = new System.Drawing.Size(276, 97);
            this.listViewPractice.TabIndex = 2;
            this.listViewPractice.UseCompatibleStateImageBehavior = false;
            this.listViewPractice.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(927, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prácticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exámenes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profesores";
            // 
            // colCodPractice
            // 
            this.colCodPractice.Text = "Código de la práctica";
            // 
            // colTitle
            // 
            this.colTitle.Text = "Título";
            // 
            // colDifficulty
            // 
            this.colDifficulty.Text = "Dificultad";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDni,
            this.colNameTeacher});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1172, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            // 
            // colNameTeacher
            // 
            this.colNameTeacher.Text = "Nombre";
            this.colNameTeacher.Width = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 653);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPractice);
            this.Controls.Add(this.listViewExam);
            this.Controls.Add(this.listViewStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ColumnHeader regNumber;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colGroup;
        private System.Windows.Forms.ListView listViewExam;
        private System.Windows.Forms.ListView listViewPractice;
        private System.Windows.Forms.ColumnHeader colExamNumber;
        private System.Windows.Forms.ColumnHeader colQuestionsNumber;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colCodPractice;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDifficulty;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colDni;
        private System.Windows.Forms.ColumnHeader colNameTeacher;
    }
}

