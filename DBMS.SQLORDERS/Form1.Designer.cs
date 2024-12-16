namespace DBMS.SQLORDERS
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
            dgvOrders = new DataGridView();
            dgvDetails = new DataGridView();
            ใบสั่งซื้อ = new TextBox();
            รายการสินค้า = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(27, 32);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(725, 187);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellMouseUp += dgvOrders_CellMouseUp;
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(27, 266);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.Size = new Size(725, 150);
            dgvDetails.TabIndex = 1;
            // 
            // ใบสั่งซื้อ
            // 
            ใบสั่งซื้อ.Location = new Point(27, 3);
            ใบสั่งซื้อ.Name = "ใบสั่งซื้อ";
            ใบสั่งซื้อ.Size = new Size(100, 23);
            ใบสั่งซื้อ.TabIndex = 2;
            // 
            // รายการสินค้า
            // 
            รายการสินค้า.Location = new Point(27, 237);
            รายการสินค้า.Name = "รายการสินค้า";
            รายการสินค้า.Size = new Size(100, 23);
            รายการสินค้า.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(รายการสินค้า);
            Controls.Add(ใบสั่งซื้อ);
            Controls.Add(dgvDetails);
            Controls.Add(dgvOrders);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private DataGridView dgvDetails;
        private TextBox ใบสั่งซื้อ;
        private TextBox รายการสินค้า;
    }
}
