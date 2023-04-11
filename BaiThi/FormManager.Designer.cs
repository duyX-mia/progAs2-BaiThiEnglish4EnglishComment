
namespace BaiThi
{
    partial class FormManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPublishDate = new System.Windows.Forms.DateTimePicker();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTopic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPublishBy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdSearchByPublishDate = new System.Windows.Forms.RadioButton();
            this.rdSearchByType = new System.Windows.Forms.RadioButton();
            this.rdSearchByAuthor = new System.Windows.Forms.RadioButton();
            this.rdSearchByName = new System.Windows.Forms.RadioButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnOpenHireForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publication date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(113, 57);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(154, 20);
            this.txtBookName.TabIndex = 3;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(113, 105);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(154, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = " LIBRARY MANAGEMENT";
            // 
            // dtPublishDate
            // 
            this.dtPublishDate.Location = new System.Drawing.Point(113, 153);
            this.dtPublishDate.Name = "dtPublishDate";
            this.dtPublishDate.Size = new System.Drawing.Size(200, 20);
            this.dtPublishDate.TabIndex = 7;
            // 
            // dgvListBook
            // 
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(29, 292);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.Size = new System.Drawing.Size(742, 234);
            this.dgvListBook.TabIndex = 8;
            this.dgvListBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBook_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book list";
            // 
            // cbTopic
            // 
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.Location = new System.Drawing.Point(557, 61);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(177, 21);
            this.cbTopic.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Theme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Publishing company";
            // 
            // txtPublishBy
            // 
            this.txtPublishBy.Location = new System.Drawing.Point(113, 202);
            this.txtPublishBy.Name = "txtPublishBy";
            this.txtPublishBy.Size = new System.Drawing.Size(177, 20);
            this.txtPublishBy.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pages";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(557, 198);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(177, 20);
            this.txtPageCount.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(113, 249);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(177, 20);
            this.txtCountry.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(457, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(586, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit books";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(696, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdSearchByPublishDate);
            this.groupBox1.Controls.Add(this.rdSearchByType);
            this.groupBox1.Controls.Add(this.rdSearchByAuthor);
            this.groupBox1.Controls.Add(this.rdSearchByName);
            this.groupBox1.Location = new System.Drawing.Point(29, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 65);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdSearchByPublishDate
            // 
            this.rdSearchByPublishDate.AutoSize = true;
            this.rdSearchByPublishDate.Location = new System.Drawing.Point(328, 31);
            this.rdSearchByPublishDate.Name = "rdSearchByPublishDate";
            this.rdSearchByPublishDate.Size = new System.Drawing.Size(101, 17);
            this.rdSearchByPublishDate.TabIndex = 3;
            this.rdSearchByPublishDate.TabStop = true;
            this.rdSearchByPublishDate.Text = "Publication date";
            this.rdSearchByPublishDate.UseVisualStyleBackColor = true;
            // 
            // rdSearchByType
            // 
            this.rdSearchByType.AutoSize = true;
            this.rdSearchByType.Location = new System.Drawing.Point(233, 31);
            this.rdSearchByType.Name = "rdSearchByType";
            this.rdSearchByType.Size = new System.Drawing.Size(49, 17);
            this.rdSearchByType.TabIndex = 2;
            this.rdSearchByType.TabStop = true;
            this.rdSearchByType.Text = "Type";
            this.rdSearchByType.UseVisualStyleBackColor = true;
            // 
            // rdSearchByAuthor
            // 
            this.rdSearchByAuthor.AutoSize = true;
            this.rdSearchByAuthor.Location = new System.Drawing.Point(137, 31);
            this.rdSearchByAuthor.Name = "rdSearchByAuthor";
            this.rdSearchByAuthor.Size = new System.Drawing.Size(56, 17);
            this.rdSearchByAuthor.TabIndex = 1;
            this.rdSearchByAuthor.TabStop = true;
            this.rdSearchByAuthor.Text = "Author";
            this.rdSearchByAuthor.UseVisualStyleBackColor = true;
            // 
            // rdSearchByName
            // 
            this.rdSearchByName.AutoSize = true;
            this.rdSearchByName.Location = new System.Drawing.Point(24, 31);
            this.rdSearchByName.Name = "rdSearchByName";
            this.rdSearchByName.Size = new System.Drawing.Size(81, 17);
            this.rdSearchByName.TabIndex = 0;
            this.rdSearchByName.TabStop = true;
            this.rdSearchByName.Text = "Book Name";
            this.rdSearchByName.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(557, 112);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(177, 21);
            this.cbCategory.TabIndex = 26;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(557, 151);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(177, 21);
            this.cbType.TabIndex = 27;
            // 
            // btnOpenHireForm
            // 
            this.btnOpenHireForm.Location = new System.Drawing.Point(655, 19);
            this.btnOpenHireForm.Name = "btnOpenHireForm";
            this.btnOpenHireForm.Size = new System.Drawing.Size(133, 23);
            this.btnOpenHireForm.TabIndex = 28;
            this.btnOpenHireForm.Text = "Borrow Management";
            this.btnOpenHireForm.UseVisualStyleBackColor = true;
            this.btnOpenHireForm.Click += new System.EventHandler(this.btnOpenHireForm_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.btnOpenHireForm);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPublishBy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTopic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListBook);
            this.Controls.Add(this.dtPublishDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManager";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPublishDate;
        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPublishBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSearchByPublishDate;
        private System.Windows.Forms.RadioButton rdSearchByType;
        private System.Windows.Forms.RadioButton rdSearchByAuthor;
        private System.Windows.Forms.RadioButton rdSearchByName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpenHireForm;
    }
}

