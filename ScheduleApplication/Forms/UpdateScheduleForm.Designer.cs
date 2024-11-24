namespace ScheduleApplication.Forms
{
    partial class UpdateScheduleForm
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
            txtclassname = new TextBox();
            txtsection = new TextBox();
            txtcourse = new TextBox();
            txtroom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnupdate = new Button();
            SuspendLayout();
            // 
            // txtclassname
            // 
            txtclassname.Location = new Point(205, 60);
            txtclassname.Name = "txtclassname";
            txtclassname.Size = new Size(195, 27);
            txtclassname.TabIndex = 0;
            // 
            // txtsection
            // 
            txtsection.Location = new Point(174, 138);
            txtsection.Name = "txtsection";
            txtsection.Size = new Size(195, 27);
            txtsection.TabIndex = 1;
            // 
            // txtcourse
            // 
            txtcourse.Location = new Point(174, 208);
            txtcourse.Name = "txtcourse";
            txtcourse.Size = new Size(195, 27);
            txtcourse.TabIndex = 2;
            // 
            // txtroom
            // 
            txtroom.Location = new Point(163, 285);
            txtroom.Name = "txtroom";
            txtroom.Size = new Size(195, 27);
            txtroom.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(90, 60);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 4;
            label1.Text = "Class Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(90, 138);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 5;
            label2.Text = "Section";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(90, 212);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 6;
            label3.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(90, 289);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 7;
            label4.Text = "Room";
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(499, 317);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(204, 92);
            btnupdate.TabIndex = 8;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // UpdateScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 462);
            Controls.Add(btnupdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtroom);
            Controls.Add(txtcourse);
            Controls.Add(txtsection);
            Controls.Add(txtclassname);
            Name = "UpdateScheduleForm";
            Text = "UpdateScheduleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtclassname;
        private TextBox txtsection;
        private TextBox txtcourse;
        private TextBox txtroom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnupdate;
    }
}