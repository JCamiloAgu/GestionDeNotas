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
			this.colCodPractice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDifficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.colDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNameTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtNameStudent = new System.Windows.Forms.TextBox();
			this.txtGroupsStudent = new System.Windows.Forms.TextBox();
			this.txtIdStudent = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCreateStudent = new System.Windows.Forms.Button();
			this.btnUpdateStudent = new System.Windows.Forms.Button();
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			this.btnDeleteExam = new System.Windows.Forms.Button();
			this.btnUpdateExam = new System.Windows.Forms.Button();
			this.btnCreateExam = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNumExam = new System.Windows.Forms.TextBox();
			this.dtpDateExam = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtIdExam = new System.Windows.Forms.TextBox();
			this.txtQuestionExam = new System.Windows.Forms.TextBox();
			this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colId,
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
			this.colExamNumber.Width = 90;
			// 
			// colQuestionsNumber
			// 
			this.colQuestionsNumber.Text = "Preguntas";
			this.colQuestionsNumber.Width = 100;
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
			// txtNameStudent
			// 
			this.txtNameStudent.Location = new System.Drawing.Point(137, 201);
			this.txtNameStudent.Name = "txtNameStudent";
			this.txtNameStudent.Size = new System.Drawing.Size(162, 20);
			this.txtNameStudent.TabIndex = 8;
			// 
			// txtGroupsStudent
			// 
			this.txtGroupsStudent.Location = new System.Drawing.Point(137, 240);
			this.txtGroupsStudent.Name = "txtGroupsStudent";
			this.txtGroupsStudent.Size = new System.Drawing.Size(162, 20);
			this.txtGroupsStudent.TabIndex = 9;
			// 
			// txtIdStudent
			// 
			this.txtIdStudent.Location = new System.Drawing.Point(200, 287);
			this.txtIdStudent.Name = "txtIdStudent";
			this.txtIdStudent.Size = new System.Drawing.Size(99, 20);
			this.txtIdStudent.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Nombre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 243);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Grupo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 290);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Numero de Matrícula";
			// 
			// btnCreateStudent
			// 
			this.btnCreateStudent.Location = new System.Drawing.Point(35, 372);
			this.btnCreateStudent.Name = "btnCreateStudent";
			this.btnCreateStudent.Size = new System.Drawing.Size(75, 23);
			this.btnCreateStudent.TabIndex = 14;
			this.btnCreateStudent.Text = "Crear";
			this.btnCreateStudent.UseVisualStyleBackColor = true;
			// 
			// btnUpdateStudent
			// 
			this.btnUpdateStudent.Location = new System.Drawing.Point(125, 372);
			this.btnUpdateStudent.Name = "btnUpdateStudent";
			this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateStudent.TabIndex = 16;
			this.btnUpdateStudent.Text = "Editar";
			this.btnUpdateStudent.UseVisualStyleBackColor = true;
			// 
			// btnDeleteStudent
			// 
			this.btnDeleteStudent.Location = new System.Drawing.Point(215, 372);
			this.btnDeleteStudent.Name = "btnDeleteStudent";
			this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteStudent.TabIndex = 17;
			this.btnDeleteStudent.Text = "Eliminar";
			this.btnDeleteStudent.UseVisualStyleBackColor = true;
			// 
			// btnDeleteExam
			// 
			this.btnDeleteExam.Location = new System.Drawing.Point(591, 372);
			this.btnDeleteExam.Name = "btnDeleteExam";
			this.btnDeleteExam.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteExam.TabIndex = 26;
			this.btnDeleteExam.Text = "Eliminar";
			this.btnDeleteExam.UseVisualStyleBackColor = true;
			// 
			// btnUpdateExam
			// 
			this.btnUpdateExam.Location = new System.Drawing.Point(470, 372);
			this.btnUpdateExam.Name = "btnUpdateExam";
			this.btnUpdateExam.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateExam.TabIndex = 25;
			this.btnUpdateExam.Text = "Actualizar";
			this.btnUpdateExam.UseVisualStyleBackColor = true;
			// 
			// btnCreateExam
			// 
			this.btnCreateExam.Location = new System.Drawing.Point(361, 372);
			this.btnCreateExam.Name = "btnCreateExam";
			this.btnCreateExam.Size = new System.Drawing.Size(75, 23);
			this.btnCreateExam.TabIndex = 24;
			this.btnCreateExam.Text = "Enviar";
			this.btnCreateExam.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(358, 204);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Numero de Exámen";
			// 
			// txtNumExam
			// 
			this.txtNumExam.Location = new System.Drawing.Point(504, 201);
			this.txtNumExam.Name = "txtNumExam";
			this.txtNumExam.Size = new System.Drawing.Size(162, 20);
			this.txtNumExam.TabIndex = 20;
			// 
			// dtpDateExam
			// 
			this.dtpDateExam.Location = new System.Drawing.Point(504, 243);
			this.dtpDateExam.Name = "dtpDateExam";
			this.dtpDateExam.Size = new System.Drawing.Size(162, 20);
			this.dtpDateExam.TabIndex = 27;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(358, 247);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 28;
			this.label8.Text = "Fecha";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(358, 287);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 13);
			this.label12.TabIndex = 32;
			this.label12.Text = "Pregunta";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(358, 333);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(16, 13);
			this.label13.TabIndex = 31;
			this.label13.Text = "Id";
			// 
			// txtIdExam
			// 
			this.txtIdExam.Location = new System.Drawing.Point(567, 330);
			this.txtIdExam.Name = "txtIdExam";
			this.txtIdExam.Size = new System.Drawing.Size(99, 20);
			this.txtIdExam.TabIndex = 30;
			// 
			// txtQuestionExam
			// 
			this.txtQuestionExam.Location = new System.Drawing.Point(504, 287);
			this.txtQuestionExam.Name = "txtQuestionExam";
			this.txtQuestionExam.Size = new System.Drawing.Size(162, 20);
			this.txtQuestionExam.TabIndex = 29;
			// 
			// colId
			// 
			this.colId.Text = "Id";
			this.colId.Width = 50;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 653);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtIdExam);
			this.Controls.Add(this.txtQuestionExam);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtpDateExam);
			this.Controls.Add(this.btnDeleteExam);
			this.Controls.Add(this.btnUpdateExam);
			this.Controls.Add(this.btnCreateExam);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtNumExam);
			this.Controls.Add(this.btnDeleteStudent);
			this.Controls.Add(this.btnUpdateStudent);
			this.Controls.Add(this.btnCreateStudent);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtIdStudent);
			this.Controls.Add(this.txtGroupsStudent);
			this.Controls.Add(this.txtNameStudent);
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
		private System.Windows.Forms.TextBox txtNameStudent;
		private System.Windows.Forms.TextBox txtGroupsStudent;
		private System.Windows.Forms.TextBox txtIdStudent;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCreateStudent;
		private System.Windows.Forms.Button btnUpdateStudent;
		private System.Windows.Forms.ColumnHeader colId;
		private System.Windows.Forms.Button btnDeleteStudent;
		private System.Windows.Forms.Button btnDeleteExam;
		private System.Windows.Forms.Button btnUpdateExam;
		private System.Windows.Forms.Button btnCreateExam;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtNumExam;
		private System.Windows.Forms.DateTimePicker dtpDateExam;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtIdExam;
		private System.Windows.Forms.TextBox txtQuestionExam;
	}
}

