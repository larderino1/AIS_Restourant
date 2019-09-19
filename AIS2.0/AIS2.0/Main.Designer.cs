namespace AIS2._0
{
    partial class Main
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addItem = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.createOrder = new System.Windows.Forms.Button();
            this.billView = new System.Windows.Forms.DataGridView();
            this.printBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(443, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(0, 79);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(200, 50);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Додати страву";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(0, 203);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(200, 51);
            this.deleteItem.TabIndex = 4;
            this.deleteItem.Text = "Забрати страву";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(0, 326);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(200, 51);
            this.createOrder.TabIndex = 5;
            this.createOrder.Text = "Створити замовлення";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // billView
            // 
            this.billView.AllowUserToOrderColumns = true;
            this.billView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billView.Location = new System.Drawing.Point(252, 79);
            this.billView.Name = "billView";
            this.billView.RowTemplate.Height = 28;
            this.billView.Size = new System.Drawing.Size(600, 298);
            this.billView.TabIndex = 6;
            this.billView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billView_CellContentClick);
            // 
            // printBill
            // 
            this.printBill.Location = new System.Drawing.Point(252, 465);
            this.printBill.Name = "printBill";
            this.printBill.Size = new System.Drawing.Size(600, 50);
            this.printBill.TabIndex = 7;
            this.printBill.Text = "Розрахувати";
            this.printBill.UseVisualStyleBackColor = true;
            this.printBill.Click += new System.EventHandler(this.printBill_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 588);
            this.Controls.Add(this.printBill);
            this.Controls.Add(this.billView);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.DataGridView billView;
        private System.Windows.Forms.Button printBill;
    }
}