
namespace BaiThi
{
    partial class FormHire
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHireBy = new System.Windows.Forms.TextBox();
            this.cbBookName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.dgvListHire = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(424, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add borrow books";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Borrower";
            // 
            // txtHireBy
            // 
            this.txtHireBy.Location = new System.Drawing.Point(156, 68);
            this.txtHireBy.Name = "txtHireBy";
            this.txtHireBy.Size = new System.Drawing.Size(182, 20);
            this.txtHireBy.TabIndex = 2;
            this.txtHireBy.TextChanged += new System.EventHandler(this.txtHireBy_TextChanged);
            // 
            // cbBookName
            // 
            this.cbBookName.FormattingEnabled = true;
            this.cbBookName.Location = new System.Drawing.Point(156, 131);
            this.cbBookName.Name = "cbBookName";
            this.cbBookName.Size = new System.Drawing.Size(182, 21);
            this.cbBookName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MANAGEMENT OF BOOK RENTAL INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Borrow day";
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(524, 68);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(182, 20);
            this.txtHireDate.TabIndex = 7;
            // 
            // dgvListHire
            // 
            this.dgvListHire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHire.Location = new System.Drawing.Point(53, 194);
            this.dgvListHire.Name = "dgvListHire";
            this.dgvListHire.Size = new System.Drawing.Size(640, 220);
            this.dgvListHire.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(618, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvListHire);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBookName);
            this.Controls.Add(this.txtHireBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormHire";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormHire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHireBy;
        private System.Windows.Forms.ComboBox cbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.DataGridView dgvListHire;
        private System.Windows.Forms.Button btnSearch;
    }
}