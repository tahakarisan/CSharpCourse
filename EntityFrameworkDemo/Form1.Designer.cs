namespace EntityFrameworkDemo
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
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.lblIdUpdate = new System.Windows.Forms.Label();
            this.tbxIdUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblStock2 = new System.Windows.Forms.Label();
            this.tbxStock2 = new System.Windows.Forms.TextBox();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.tbxName2 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.tbxPrice2 = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxUpdate.Controls.Add(this.lblIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxIdUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblStock2);
            this.gbxUpdate.Controls.Add(this.tbxStock2);
            this.gbxUpdate.Controls.Add(this.lblPrice2);
            this.gbxUpdate.Controls.Add(this.tbxName2);
            this.gbxUpdate.Controls.Add(this.lblName2);
            this.gbxUpdate.Controls.Add(this.tbxPrice2);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.White;
            this.gbxUpdate.Location = new System.Drawing.Point(489, 213);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(254, 216);
            this.gbxUpdate.TabIndex = 5;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Product Update";
            // 
            // lblIdUpdate
            // 
            this.lblIdUpdate.BackColor = System.Drawing.Color.White;
            this.lblIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblIdUpdate.Location = new System.Drawing.Point(6, 28);
            this.lblIdUpdate.Name = "lblIdUpdate";
            this.lblIdUpdate.Size = new System.Drawing.Size(102, 20);
            this.lblIdUpdate.TabIndex = 11;
            this.lblIdUpdate.Text = "Id";
            this.lblIdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIdUpdate
            // 
            this.tbxIdUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIdUpdate.Location = new System.Drawing.Point(135, 28);
            this.tbxIdUpdate.Name = "tbxIdUpdate";
            this.tbxIdUpdate.Size = new System.Drawing.Size(100, 23);
            this.tbxIdUpdate.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnUpdate.Location = new System.Drawing.Point(173, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStock2
            // 
            this.lblStock2.AutoSize = true;
            this.lblStock2.BackColor = System.Drawing.Color.White;
            this.lblStock2.CausesValidation = false;
            this.lblStock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStock2.ForeColor = System.Drawing.Color.Black;
            this.lblStock2.Location = new System.Drawing.Point(6, 141);
            this.lblStock2.Name = "lblStock2";
            this.lblStock2.Size = new System.Drawing.Size(102, 18);
            this.lblStock2.TabIndex = 4;
            this.lblStock2.Text = "Stock Amount";
            this.lblStock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxStock2
            // 
            this.tbxStock2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxStock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStock2.Location = new System.Drawing.Point(135, 139);
            this.tbxStock2.Name = "tbxStock2";
            this.tbxStock2.Size = new System.Drawing.Size(100, 23);
            this.tbxStock2.TabIndex = 7;
            // 
            // lblPrice2
            // 
            this.lblPrice2.BackColor = System.Drawing.Color.White;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice2.ForeColor = System.Drawing.Color.Black;
            this.lblPrice2.Location = new System.Drawing.Point(6, 98);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(102, 20);
            this.lblPrice2.TabIndex = 3;
            this.lblPrice2.Text = "Price";
            this.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName2
            // 
            this.tbxName2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName2.Location = new System.Drawing.Point(135, 62);
            this.tbxName2.Name = "tbxName2";
            this.tbxName2.Size = new System.Drawing.Size(100, 23);
            this.tbxName2.TabIndex = 5;
            // 
            // lblName2
            // 
            this.lblName2.BackColor = System.Drawing.Color.White;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName2.ForeColor = System.Drawing.Color.Black;
            this.lblName2.Location = new System.Drawing.Point(6, 62);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(102, 20);
            this.lblName2.TabIndex = 2;
            this.lblName2.Text = "Name";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPrice2
            // 
            this.tbxPrice2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPrice2.Location = new System.Drawing.Point(135, 98);
            this.tbxPrice2.Name = "tbxPrice2";
            this.tbxPrice2.Size = new System.Drawing.Size(100, 23);
            this.tbxPrice2.TabIndex = 6;
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxAdd.Controls.Add(this.tbxId);
            this.gbxAdd.Controls.Add(this.lblId);
            this.gbxAdd.Controls.Add(this.btnDelete);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblStock);
            this.gbxAdd.Controls.Add(this.tbxStock);
            this.gbxAdd.Controls.Add(this.lblPrice);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxPrice);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.gbxAdd.Location = new System.Drawing.Point(58, 213);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(254, 216);
            this.gbxAdd.TabIndex = 4;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Product Delete or Add";
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxId.Location = new System.Drawing.Point(132, 29);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 23);
            this.tbxId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(8, 29);
            this.lblId.MaximumSize = new System.Drawing.Size(120, 120);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(102, 20);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.Location = new System.Drawing.Point(53, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.UseWaitCursor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAdd.Location = new System.Drawing.Point(173, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(8, 144);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(102, 20);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock Amount";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxStock
            // 
            this.tbxStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStock.Location = new System.Drawing.Point(132, 141);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 23);
            this.tbxStock.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(8, 106);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(102, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(132, 67);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 23);
            this.tbxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(8, 67);
            this.lblName.MaximumSize = new System.Drawing.Size(120, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPrice.Location = new System.Drawing.Point(132, 106);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 23);
            this.tbxPrice.TabIndex = 6;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(58, 22);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(685, 132);
            this.dgwProducts.TabIndex = 3;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label lblIdUpdate;
        private System.Windows.Forms.TextBox tbxIdUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblStock2;
        private System.Windows.Forms.TextBox tbxStock2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.TextBox tbxName2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox tbxPrice2;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

