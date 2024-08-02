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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDailyFoodList = new System.Windows.Forms.TabPage();
            this.tabPageCompanyList = new System.Windows.Forms.TabPage();
            this.tabPageEmployeeList = new System.Windows.Forms.TabPage();
            this.dgwFoods = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageDailyFoodList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDailyFoodList);
            this.tabControl1.Controls.Add(this.tabPageCompanyList);
            this.tabControl1.Controls.Add(this.tabPageEmployeeList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 499);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageDailyFoodList
            // 
            this.tabPageDailyFoodList.Controls.Add(this.dgwFoods);
            this.tabPageDailyFoodList.Location = new System.Drawing.Point(4, 22);
            this.tabPageDailyFoodList.Name = "tabPageDailyFoodList";
            this.tabPageDailyFoodList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDailyFoodList.Size = new System.Drawing.Size(945, 473);
            this.tabPageDailyFoodList.TabIndex = 0;
            this.tabPageDailyFoodList.Text = "Günlük Yemek Listesi";
            this.tabPageDailyFoodList.UseVisualStyleBackColor = true;
            // 
            // tabPageCompanyList
            // 
            this.tabPageCompanyList.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompanyList.Name = "tabPageCompanyList";
            this.tabPageCompanyList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompanyList.Size = new System.Drawing.Size(945, 473);
            this.tabPageCompanyList.TabIndex = 1;
            this.tabPageCompanyList.Text = "Şirket Listesi";
            this.tabPageCompanyList.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployeeList
            // 
            this.tabPageEmployeeList.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployeeList.Name = "tabPageEmployeeList";
            this.tabPageEmployeeList.Size = new System.Drawing.Size(945, 473);
            this.tabPageEmployeeList.TabIndex = 2;
            this.tabPageEmployeeList.Text = "Çalışan Listesi";
            this.tabPageEmployeeList.UseVisualStyleBackColor = true;
            // 
            // dgwFoods
            // 
            this.dgwFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFoods.Location = new System.Drawing.Point(8, 6);
            this.dgwFoods.Name = "dgwFoods";
            this.dgwFoods.Size = new System.Drawing.Size(467, 459);
            this.dgwFoods.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(953, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDailyFoodList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDailyFoodList;
        private System.Windows.Forms.TabPage tabPageCompanyList;
        private System.Windows.Forms.TabPage tabPageEmployeeList;
        private System.Windows.Forms.DataGridView dgwFoods;
    }
}

