namespace ScheduleApplication.Forms
{
    partial class AddScheduleForm
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
            txtClassName = new TextBox();
            txtSection = new TextBox();
            txtCourse = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtroom = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(227, 70);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(259, 27);
            txtClassName.TabIndex = 0;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(227, 139);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(259, 27);
            txtSection.TabIndex = 1;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(227, 201);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(259, 27);
            txtCourse.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(227, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 70);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Class Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 142);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Section";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 208);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Course";
            // 
            // txtroom
            // 
            txtroom.AutoSize = true;
            txtroom.Location = new Point(92, 277);
            txtroom.Name = "txtroom";
            txtroom.Size = new Size(49, 20);
            txtroom.TabIndex = 7;
            txtroom.Text = "Room";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(518, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtroom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(txtCourse);
            Controls.Add(txtSection);
            Controls.Add(txtClassName);
            Name = "AddScheduleForm";
            Text = "AddScheduleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClassName;
        private TextBox txtSection;
        private TextBox txtCourse;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtroom;
        private Button btnSave;
    }
}