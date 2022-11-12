namespace Practice_Project2WFA
{
    partial class CSVeditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVeditor));
            this.Seperator_Changer = new System.Windows.Forms.Button();
            this.New_Seperator_Input = new System.Windows.Forms.TextBox();
            this.ChangeSection = new System.Windows.Forms.GroupBox();
            this.Label_To_Appended_Data = new System.Windows.Forms.Label();
            this.Appended_Coloumn_Data = new System.Windows.Forms.TextBox();
            this.Coloumn_Number = new System.Windows.Forms.ComboBox();
            this.Coloumn_Appender = new System.Windows.Forms.Button();
            this.Lock_Seperator = new System.Windows.Forms.CheckBox();
            this.New_Seperator_Input_Label = new System.Windows.Forms.Label();
            this.Seperator_UserInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Detected_Provided_Colooumn_Num = new System.Windows.Forms.Label();
            this.openFileDialog_Search_CSV = new System.Windows.Forms.OpenFileDialog();
            this.Search_File_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.File_Path_Text_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Problem_Msg = new System.Windows.Forms.Label();
            this.File_Path_Text_Box_Locker = new System.Windows.Forms.CheckBox();
            this.ChangeSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Seperator_Changer
            // 
            this.Seperator_Changer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seperator_Changer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seperator_Changer.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.Seperator_Changer.Location = new System.Drawing.Point(88, 327);
            this.Seperator_Changer.Margin = new System.Windows.Forms.Padding(1);
            this.Seperator_Changer.Name = "Seperator_Changer";
            this.Seperator_Changer.Size = new System.Drawing.Size(140, 45);
            this.Seperator_Changer.TabIndex = 0;
            this.Seperator_Changer.Text = "Change Seperator";
            this.Seperator_Changer.UseVisualStyleBackColor = true;
            // 
            // New_Seperator_Input
            // 
            this.New_Seperator_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.New_Seperator_Input.Location = new System.Drawing.Point(241, 337);
            this.New_Seperator_Input.Name = "New_Seperator_Input";
            this.New_Seperator_Input.Size = new System.Drawing.Size(118, 23);
            this.New_Seperator_Input.TabIndex = 1;
            // 
            // ChangeSection
            // 
            this.ChangeSection.Controls.Add(this.Label_To_Appended_Data);
            this.ChangeSection.Controls.Add(this.Appended_Coloumn_Data);
            this.ChangeSection.Controls.Add(this.Coloumn_Number);
            this.ChangeSection.Controls.Add(this.Coloumn_Appender);
            this.ChangeSection.Controls.Add(this.Lock_Seperator);
            this.ChangeSection.Controls.Add(this.New_Seperator_Input_Label);
            this.ChangeSection.Controls.Add(this.Seperator_UserInput);
            this.ChangeSection.Controls.Add(this.label6);
            this.ChangeSection.Controls.Add(this.label4);
            this.ChangeSection.Controls.Add(this.Detected_Provided_Colooumn_Num);
            this.ChangeSection.Controls.Add(this.New_Seperator_Input);
            this.ChangeSection.Controls.Add(this.Seperator_Changer);
            this.ChangeSection.Location = new System.Drawing.Point(2, 2);
            this.ChangeSection.Name = "ChangeSection";
            this.ChangeSection.Size = new System.Drawing.Size(489, 567);
            this.ChangeSection.TabIndex = 3;
            this.ChangeSection.TabStop = false;
            this.ChangeSection.Text = "Changes Section";
            // 
            // Label_To_Appended_Data
            // 
            this.Label_To_Appended_Data.AutoSize = true;
            this.Label_To_Appended_Data.Location = new System.Drawing.Point(360, 265);
            this.Label_To_Appended_Data.Name = "Label_To_Appended_Data";
            this.Label_To_Appended_Data.Size = new System.Drawing.Size(125, 13);
            this.Label_To_Appended_Data.TabIndex = 20;
            this.Label_To_Appended_Data.Text = "- Provide data to Append";
            // 
            // Appended_Coloumn_Data
            // 
            this.Appended_Coloumn_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Appended_Coloumn_Data.Location = new System.Drawing.Point(241, 260);
            this.Appended_Coloumn_Data.Name = "Appended_Coloumn_Data";
            this.Appended_Coloumn_Data.Size = new System.Drawing.Size(118, 23);
            this.Appended_Coloumn_Data.TabIndex = 19;
            // 
            // Coloumn_Number
            // 
            this.Coloumn_Number.FormattingEnabled = true;
            this.Coloumn_Number.Location = new System.Drawing.Point(24, 260);
            this.Coloumn_Number.Name = "Coloumn_Number";
            this.Coloumn_Number.Size = new System.Drawing.Size(47, 21);
            this.Coloumn_Number.TabIndex = 18;
            this.Coloumn_Number.SelectedIndexChanged += new System.EventHandler(this.Coloumn_Number_SelectedIndexChanged);
            // 
            // Coloumn_Appender
            // 
            this.Coloumn_Appender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coloumn_Appender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coloumn_Appender.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.Coloumn_Appender.Location = new System.Drawing.Point(88, 248);
            this.Coloumn_Appender.Margin = new System.Windows.Forms.Padding(1);
            this.Coloumn_Appender.Name = "Coloumn_Appender";
            this.Coloumn_Appender.Size = new System.Drawing.Size(140, 45);
            this.Coloumn_Appender.TabIndex = 17;
            this.Coloumn_Appender.Text = "Append To Coloumn Data";
            this.Coloumn_Appender.UseVisualStyleBackColor = true;
            // 
            // Lock_Seperator
            // 
            this.Lock_Seperator.AutoSize = true;
            this.Lock_Seperator.Location = new System.Drawing.Point(384, 58);
            this.Lock_Seperator.Name = "Lock_Seperator";
            this.Lock_Seperator.Size = new System.Drawing.Size(99, 17);
            this.Lock_Seperator.TabIndex = 16;
            this.Lock_Seperator.Text = "Lock Seperator";
            this.Lock_Seperator.UseVisualStyleBackColor = true;
            this.Lock_Seperator.CheckedChanged += new System.EventHandler(this.Lock_Seperator_CheckedChanged);
            // 
            // New_Seperator_Input_Label
            // 
            this.New_Seperator_Input_Label.AutoSize = true;
            this.New_Seperator_Input_Label.Location = new System.Drawing.Point(365, 342);
            this.New_Seperator_Input_Label.Name = "New_Seperator_Input_Label";
            this.New_Seperator_Input_Label.Size = new System.Drawing.Size(123, 13);
            this.New_Seperator_Input_Label.TabIndex = 15;
            this.New_Seperator_Input_Label.Text = "- Provide New Seperator";
            // 
            // Seperator_UserInput
            // 
            this.Seperator_UserInput.Location = new System.Drawing.Point(107, 58);
            this.Seperator_UserInput.Name = "Seperator_UserInput";
            this.Seperator_UserInput.Size = new System.Drawing.Size(100, 20);
            this.Seperator_UserInput.TabIndex = 14;
            this.Seperator_UserInput.TextChanged += new System.EventHandler(this.Seperator_UserInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detected/Provided No\' of Coloumns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Provide Seperator:";
            // 
            // Detected_Provided_Colooumn_Num
            // 
            this.Detected_Provided_Colooumn_Num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Detected_Provided_Colooumn_Num.Location = new System.Drawing.Point(241, 55);
            this.Detected_Provided_Colooumn_Num.Name = "Detected_Provided_Colooumn_Num";
            this.Detected_Provided_Colooumn_Num.Size = new System.Drawing.Size(124, 25);
            this.Detected_Provided_Colooumn_Num.TabIndex = 11;
            this.Detected_Provided_Colooumn_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog_Search_CSV
            // 
            this.openFileDialog_Search_CSV.Title = "Select .CSV file:";
            this.openFileDialog_Search_CSV.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_Search_CSV_FileOk);
            // 
            // Search_File_Button
            // 
            this.Search_File_Button.Location = new System.Drawing.Point(636, 235);
            this.Search_File_Button.Name = "Search_File_Button";
            this.Search_File_Button.Size = new System.Drawing.Size(143, 35);
            this.Search_File_Button.TabIndex = 4;
            this.Search_File_Button.Text = "Search File";
            this.Search_File_Button.UseVisualStyleBackColor = true;
            this.Search_File_Button.Click += new System.EventHandler(this.Search_File_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(576, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search and Select .CSV File to Edit";
            // 
            // File_Path_Text_Box
            // 
            this.File_Path_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.File_Path_Text_Box.Location = new System.Drawing.Point(636, 199);
            this.File_Path_Text_Box.Name = "File_Path_Text_Box";
            this.File_Path_Text_Box.Size = new System.Drawing.Size(143, 26);
            this.File_Path_Text_Box.TabIndex = 6;
            this.File_Path_Text_Box.TextChanged += new System.EventHandler(this.File_Path_Text_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(694, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "or";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(563, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Provide the path in the Text Box above.";
            // 
            // Problem_Msg
            // 
            this.Problem_Msg.AutoSize = true;
            this.Problem_Msg.Location = new System.Drawing.Point(524, 424);
            this.Problem_Msg.Name = "Problem_Msg";
            this.Problem_Msg.Size = new System.Drawing.Size(0, 13);
            this.Problem_Msg.TabIndex = 9;
            // 
            // File_Path_Text_Box_Locker
            // 
            this.File_Path_Text_Box_Locker.AutoSize = true;
            this.File_Path_Text_Box_Locker.Location = new System.Drawing.Point(785, 206);
            this.File_Path_Text_Box_Locker.Name = "File_Path_Text_Box_Locker";
            this.File_Path_Text_Box_Locker.Size = new System.Drawing.Size(139, 17);
            this.File_Path_Text_Box_Locker.TabIndex = 10;
            this.File_Path_Text_Box_Locker.Text = "Lock file path for editing";
            this.File_Path_Text_Box_Locker.UseVisualStyleBackColor = true;
            this.File_Path_Text_Box_Locker.CheckedChanged += new System.EventHandler(this.File_Path_Text_Box_Locker_CheckedChanged);
            // 
            // CSVeditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(975, 581);
            this.Controls.Add(this.File_Path_Text_Box_Locker);
            this.Controls.Add(this.Problem_Msg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.File_Path_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_File_Button);
            this.Controls.Add(this.ChangeSection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CSVeditor";
            this.Text = "Fast CSV Editor";
            this.Load += new System.EventHandler(this.CSVeditor_Load);
            this.ChangeSection.ResumeLayout(false);
            this.ChangeSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Seperator_Changer;
        private System.Windows.Forms.TextBox New_Seperator_Input;
        private System.Windows.Forms.GroupBox ChangeSection;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Search_CSV;
        private System.Windows.Forms.Button Search_File_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox File_Path_Text_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Problem_Msg;
        private System.Windows.Forms.CheckBox File_Path_Text_Box_Locker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Detected_Provided_Colooumn_Num;
        private System.Windows.Forms.TextBox Seperator_UserInput;
        private System.Windows.Forms.Label New_Seperator_Input_Label;
        private System.Windows.Forms.CheckBox Lock_Seperator;
        private System.Windows.Forms.TextBox Appended_Coloumn_Data;
        private System.Windows.Forms.ComboBox Coloumn_Number;
        private System.Windows.Forms.Button Coloumn_Appender;
        private System.Windows.Forms.Label Label_To_Appended_Data;
    }
}

