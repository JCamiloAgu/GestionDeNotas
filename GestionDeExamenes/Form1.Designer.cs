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
            this.txtCodPractice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitlePractice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDifficultyPractice = new System.Windows.Forms.TextBox();
            this.btnCreatePractice = new System.Windows.Forms.Button();
            this.btnDeletePractice = new System.Windows.Forms.Button();
            this.btnUpdatePractice = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNameTeacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
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
            this.colExamNumber.Width = 131;
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
            this.listViewPractice.Location = new System.Drawing.Point(766, 43);
            this.listViewPractice.Name = "listViewPractice";
            this.listViewPractice.Size = new System.Drawing.Size(276, 97);
            this.listViewPractice.TabIndex = 2;
            this.listViewPractice.UseCompatibleStateImageBehavior = false;
            this.listViewPractice.View = System.Windows.Forms.View.Details;
            this.listViewPractice.SelectedIndexChanged += new System.EventHandler(this.listViewPractice_SelectedIndexChanged);
            // 
            // colCodPractice
            // 
            this.colCodPractice.Text = "Código de la práctica";
            this.colCodPractice.Width = 122;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Titulo";
            this.colTitle.Width = 57;
            // 
            // colDifficulty
            // 
            this.colDifficulty.Text = "Dificultad";
            this.colDifficulty.Width = 86;
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
            this.label2.Location = new System.Drawing.Point(876, 18);
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
            this.label4.Location = new System.Drawing.Point(1231, 18);
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
            this.listView1.Location = new System.Drawing.Point(1121, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            this.colDni.Width = 95;
            // 
            // colNameTeacher
            // 
            this.colNameTeacher.Text = "Nombre";
            this.colNameTeacher.Width = 166;
            // 
            // txtCodPractice
            // 
            this.txtCodPractice.Location = new System.Drawing.Point(942, 180);
            this.txtCodPractice.Name = "txtCodPractice";
            this.txtCodPractice.Size = new System.Drawing.Size(100, 20);
            this.txtCodPractice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código de la práctica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Titulo de la práctica";
            // 
            // txtTitlePractice
            // 
            this.txtTitlePractice.Location = new System.Drawing.Point(942, 214);
            this.txtTitlePractice.Name = "txtTitlePractice";
            this.txtTitlePractice.Size = new System.Drawing.Size(100, 20);
            this.txtTitlePractice.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dificultad de la práctica";
            // 
            // txtDifficultyPractice
            // 
            this.txtDifficultyPractice.Location = new System.Drawing.Point(942, 247);
            this.txtDifficultyPractice.Name = "txtDifficultyPractice";
            this.txtDifficultyPractice.Size = new System.Drawing.Size(100, 20);
            this.txtDifficultyPractice.TabIndex = 12;
            // 
            // btnCreatePractice
            // 
            this.btnCreatePractice.Location = new System.Drawing.Point(766, 300);
            this.btnCreatePractice.Name = "btnCreatePractice";
            this.btnCreatePractice.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePractice.TabIndex = 14;
            this.btnCreatePractice.Text = "Crear";
            this.btnCreatePractice.UseVisualStyleBackColor = true;
            // 
            // btnDeletePractice
            // 
            this.btnDeletePractice.Location = new System.Drawing.Point(967, 300);
            this.btnDeletePractice.Name = "btnDeletePractice";
            this.btnDeletePractice.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePractice.TabIndex = 15;
            this.btnDeletePractice.Text = "Eliminar";
            this.btnDeletePractice.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePractice
            // 
            this.btnUpdatePractice.Location = new System.Drawing.Point(867, 300);
            this.btnUpdatePractice.Name = "btnUpdatePractice";
            this.btnUpdatePractice.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePractice.TabIndex = 16;
            this.btnUpdatePractice.Text = "Editar";
            this.btnUpdatePractice.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Location = new System.Drawing.Point(1222, 300);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTeacher.TabIndex = 25;
            this.btnUpdateTeacher.Text = "Editar";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(1322, 300);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTeacher.TabIndex = 24;
            this.btnDeleteTeacher.Text = "Eliminar";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.Location = new System.Drawing.Point(1121, 300);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTeacher.TabIndex = 23;
            this.btnCreateTeacher.Text = "Crear";
            this.btnCreateTeacher.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1121, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre del  profesor";
            // 
            // txtNameTeacher
            // 
            this.txtNameTeacher.Location = new System.Drawing.Point(1297, 214);
            this.txtNameTeacher.Name = "txtNameTeacher";
            this.txtNameTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtNameTeacher.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1121, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(1297, 180);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 653);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnCreateTeacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNameTeacher);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnUpdatePractice);
            this.Controls.Add(this.btnDeletePractice);
            this.Controls.Add(this.btnCreatePractice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDifficultyPractice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTitlePractice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodPractice);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtCodPractice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitlePractice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDifficultyPractice;
        private System.Windows.Forms.Button btnCreatePractice;
        private System.Windows.Forms.Button btnDeletePractice;
        private System.Windows.Forms.Button btnUpdatePractice;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNameTeacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDni;
    }
}

