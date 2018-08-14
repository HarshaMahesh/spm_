namespace Intern_forms_management_system.Diary
{
    partial class NewEntryUI
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metroLabelTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.richTextBoxEntry = new System.Windows.Forms.RichTextBox();
            this.metroButton_AddEntry = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroPanel1.Controls.Add(this.metroButtonCancel);
            this.metroPanel1.Controls.Add(this.metroButton_AddEntry);
            this.metroPanel1.Controls.Add(this.richTextBoxEntry);
            this.metroPanel1.Controls.Add(this.dateTimePicker);
            this.metroPanel1.Controls.Add(this.metroLabelTime);
            this.metroPanel1.Controls.Add(this.metroLabelDate);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(776, 426);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(514, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // metroLabelTime
            // 
            this.metroLabelTime.AutoSize = true;
            this.metroLabelTime.Location = new System.Drawing.Point(272, 61);
            this.metroLabelTime.Name = "metroLabelTime";
            this.metroLabelTime.Size = new System.Drawing.Size(38, 19);
            this.metroLabelTime.TabIndex = 3;
            this.metroLabelTime.Text = "Time";
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.Location = new System.Drawing.Point(96, 62);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(36, 19);
            this.metroLabelDate.TabIndex = 2;
            this.metroLabelDate.Text = "Date";
            // 
            // richTextBoxEntry
            // 
            this.richTextBoxEntry.Location = new System.Drawing.Point(96, 141);
            this.richTextBoxEntry.Name = "richTextBoxEntry";
            this.richTextBoxEntry.Size = new System.Drawing.Size(618, 195);
            this.richTextBoxEntry.TabIndex = 5;
            this.richTextBoxEntry.Text = "";
            // 
            // metroButton_AddEntry
            // 
            this.metroButton_AddEntry.Location = new System.Drawing.Point(472, 381);
            this.metroButton_AddEntry.Name = "metroButton_AddEntry";
            this.metroButton_AddEntry.Size = new System.Drawing.Size(110, 23);
            this.metroButton_AddEntry.TabIndex = 6;
            this.metroButton_AddEntry.Text = "Add Entry";
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(610, 381);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(93, 23);
            this.metroButtonCancel.TabIndex = 7;
            this.metroButtonCancel.Text = "Cancel";
            // 
            // NewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "NewEntry";
            this.Text = "NewEntry";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MetroFramework.Controls.MetroLabel metroLabelTime;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private MetroFramework.Controls.MetroButton metroButton_AddEntry;
        private System.Windows.Forms.RichTextBox richTextBoxEntry;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
    }
}