namespace FoodChoice
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbEmployee = new System.Windows.Forms.TabControl();
            this.tbFoods = new System.Windows.Forms.TabPage();
            this.tbCompany = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbEmployee
            // 
            this.tbEmployee.Controls.Add(this.tbFoods);
            this.tbEmployee.Controls.Add(this.tbCompany);
            this.tbEmployee.Controls.Add(this.tabPage3);
            this.tbEmployee.Location = new System.Drawing.Point(12, 12);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.SelectedIndex = 0;
            this.tbEmployee.Size = new System.Drawing.Size(759, 613);
            this.tbEmployee.TabIndex = 2;
            this.tbEmployee.Tag = "";
            // 
            // tbFoods
            // 
            this.tbFoods.Location = new System.Drawing.Point(4, 22);
            this.tbFoods.Name = "tbFoods";
            this.tbFoods.Padding = new System.Windows.Forms.Padding(3);
            this.tbFoods.Size = new System.Drawing.Size(751, 587);
            this.tbFoods.TabIndex = 0;
            this.tbFoods.Text = "Foods";
            this.tbFoods.UseVisualStyleBackColor = true;
            this.tbFoods.Click += new System.EventHandler(this.tbFoods_Click);
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(4, 22);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tbCompany.Size = new System.Drawing.Size(751, 587);
            this.tbCompany.TabIndex = 1;
            this.tbCompany.Text = "Company List";
            this.tbCompany.UseVisualStyleBackColor = true;
            this.tbCompany.Click += new System.EventHandler(this.tbCompany_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(751, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 624);
            this.Controls.Add(this.tbEmployee);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tbEmployee;
        private System.Windows.Forms.TabPage tbFoods;
        private System.Windows.Forms.TabPage tbCompany;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

