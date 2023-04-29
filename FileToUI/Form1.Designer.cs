namespace FileToUI
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.specific = new System.Windows.Forms.Label();
            this.fdiag1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Fyear = new System.Windows.Forms.TextBox();
            this.Fcity = new System.Windows.Forms.TextBox();
            this.Ffaculty = new System.Windows.Forms.TextBox();
            this.Frole = new System.Windows.Forms.TextBox();
            this.Fspecific = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Full Name:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(12, 83);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(67, 13);
            this.year.TabIndex = 1;
            this.year.Text = "Year of birth:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(13, 110);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(27, 13);
            this.city.TabIndex = 3;
            this.city.Text = "City:";
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Location = new System.Drawing.Point(13, 136);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(44, 13);
            this.faculty.TabIndex = 5;
            this.faculty.Text = "Faculty:";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(13, 162);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(32, 13);
            this.role.TabIndex = 7;
            this.role.Text = "Role:";
            // 
            // specific
            // 
            this.specific.AutoSize = true;
            this.specific.Location = new System.Drawing.Point(12, 187);
            this.specific.Name = "specific";
            this.specific.Size = new System.Drawing.Size(73, 13);
            this.specific.TabIndex = 8;
            this.specific.Text = "[RoleSpecific]";
            // 
            // fdiag1
            // 
            this.fdiag1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Choose file...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(127, 57);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(154, 20);
            this.Fname.TabIndex = 10;
            // 
            // Fyear
            // 
            this.Fyear.Location = new System.Drawing.Point(127, 83);
            this.Fyear.Name = "Fyear";
            this.Fyear.Size = new System.Drawing.Size(154, 20);
            this.Fyear.TabIndex = 11;
            // 
            // Fcity
            // 
            this.Fcity.Location = new System.Drawing.Point(127, 110);
            this.Fcity.Name = "Fcity";
            this.Fcity.Size = new System.Drawing.Size(154, 20);
            this.Fcity.TabIndex = 12;
            // 
            // Ffaculty
            // 
            this.Ffaculty.Location = new System.Drawing.Point(127, 136);
            this.Ffaculty.Name = "Ffaculty";
            this.Ffaculty.Size = new System.Drawing.Size(154, 20);
            this.Ffaculty.TabIndex = 13;
            // 
            // Frole
            // 
            this.Frole.Location = new System.Drawing.Point(127, 162);
            this.Frole.Name = "Frole";
            this.Frole.Size = new System.Drawing.Size(154, 20);
            this.Frole.TabIndex = 14;
            // 
            // Fspecific
            // 
            this.Fspecific.Location = new System.Drawing.Point(127, 188);
            this.Fspecific.Name = "Fspecific";
            this.Fspecific.Size = new System.Drawing.Size(154, 20);
            this.Fspecific.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.Fspecific);
            this.Controls.Add(this.Frole);
            this.Controls.Add(this.Ffaculty);
            this.Controls.Add(this.Fcity);
            this.Controls.Add(this.Fyear);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specific);
            this.Controls.Add(this.role);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.city);
            this.Controls.Add(this.year);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label faculty;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label specific;
        private System.Windows.Forms.OpenFileDialog fdiag1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Fyear;
        private System.Windows.Forms.TextBox Fcity;
        private System.Windows.Forms.TextBox Ffaculty;
        private System.Windows.Forms.TextBox Frole;
        private System.Windows.Forms.TextBox Fspecific;
    }
}

