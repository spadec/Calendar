
namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.weekendSecondDay = new System.Windows.Forms.RadioButton();
            this.weekendFirstDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.workSecondDay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.workFirstDay = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.weekendSecondDay);
            this.panel1.Controls.Add(this.weekendFirstDay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.workSecondDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.workFirstDay);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 76);
            this.panel1.TabIndex = 1;
            // 
            // weekendSecondDay
            // 
            this.weekendSecondDay.AutoSize = true;
            this.weekendSecondDay.Location = new System.Drawing.Point(189, 49);
            this.weekendSecondDay.Name = "weekendSecondDay";
            this.weekendSecondDay.Size = new System.Drawing.Size(92, 19);
            this.weekendSecondDay.TabIndex = 5;
            this.weekendSecondDay.TabStop = true;
            this.weekendSecondDay.Text = "второй день";
            this.weekendSecondDay.UseVisualStyleBackColor = true;
            // 
            // weekendFirstDay
            // 
            this.weekendFirstDay.AutoSize = true;
            this.weekendFirstDay.Location = new System.Drawing.Point(189, 24);
            this.weekendFirstDay.Name = "weekendFirstDay";
            this.weekendFirstDay.Size = new System.Drawing.Size(95, 19);
            this.weekendFirstDay.TabIndex = 4;
            this.weekendFirstDay.TabStop = true;
            this.weekendFirstDay.Text = "первый день";
            this.weekendFirstDay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сегодня я отдыхаю:";
            // 
            // workSecondDay
            // 
            this.workSecondDay.AutoSize = true;
            this.workSecondDay.Location = new System.Drawing.Point(9, 49);
            this.workSecondDay.Name = "workSecondDay";
            this.workSecondDay.Size = new System.Drawing.Size(92, 19);
            this.workSecondDay.TabIndex = 2;
            this.workSecondDay.TabStop = true;
            this.workSecondDay.Text = "второй день";
            this.workSecondDay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сегодня я работаю: ";
            // 
            // workFirstDay
            // 
            this.workFirstDay.AutoSize = true;
            this.workFirstDay.Location = new System.Drawing.Point(9, 24);
            this.workFirstDay.Name = "workFirstDay";
            this.workFirstDay.Size = new System.Drawing.Size(95, 19);
            this.workFirstDay.TabIndex = 2;
            this.workFirstDay.TabStop = true;
            this.workFirstDay.Text = "первый день";
            this.workFirstDay.UseVisualStyleBackColor = true;
            this.workFirstDay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InfoText;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.CausesValidation = false;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(7, 104);
            this.monthCalendar1.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Жирным, отмеченны рабочие смены";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton workSecondDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton workFirstDay;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton weekendSecondDay;
        private System.Windows.Forms.RadioButton weekendFirstDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

