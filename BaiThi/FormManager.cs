using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThi
{
    public partial class FormManager : Form
    {

        int currentId; //Variable to store the ID of the book to be edited or deleted
        List<string> listTopic = new List<string>();
        List<string> listType = new List<string>(); 
        List<string> listCategory = new List<string>();
        static int id = 1;                  // Variable initial ID to initialize new books

        List<BookInfo> listBook = new List<BookInfo>();         //List stores the list of books

        public FormManager()
        {
            InitializeComponent();
            BindCombobox();                                     //Assign list of categories, genres, topics
        }

        public void BindCombobox()                      //Initialize data assign to combobox
        {
            listTopic.Add("Travel");
            listTopic.Add("Movie");
            listTopic.Add("Healthy");
            listTopic.Add("Beauty");
            listTopic.Add("Food");
            listTopic.Add("Tet's Holiday");
            listTopic.Add("Fashion");
            listTopic.Add("Love");
            cbTopic.DataSource = listTopic;

            listType.Add("Political - Law Book");
            listType.Add("Book of Science, Technology - Economics");
            listType.Add("Literature and Art Book");
            listType.Add("Social-Cultural Books - History");
            listType.Add("Textbook");
            listType.Add("Stories, Novels");
            listType.Add("Psychology, spirituality, religion");
            listType.Add("Children's Books");
            cbType.DataSource = listType;

            listCategory.Add("Literature");
            listCategory.Add("Mystic Fantasy");
            listCategory.Add("Canon");
            listCategory.Add("Detective");
            listCategory.Add("Text");
            listCategory.Add("Biology");
            listCategory.Add("Music");
            listCategory.Add("Spiritual");
            listCategory.Add("Science");
            listCategory.Add("Working Skills");
            listCategory.Add("Finance");
            listCategory.Add("Travel");
            cbCategory.DataSource = listCategory;
        }

        private bool ValidateData()                             //Function to check if the input data is complete
        {
            if (string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("Invalid book title");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Invalid Author Name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPublishBy.Text))
            {
                MessageBox.Show("Invalid Publisher Name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Invalid Country Name");
                return false;
            }
            if (!int.TryParse(txtPageCount.Text, out int pageCount))
            {
                MessageBox.Show("Invalid Page Number");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)       //Event click add new button
        {
          
            if (!ValidateData())
                return;
          
            string topic = cbTopic.SelectedItem.ToString();
            string type = cbType.SelectedItem.ToString();
            string category = cbCategory.SelectedItem.ToString();

            //Add to the list of available data
            listBook.Add(new BookInfo() { Id = id ,BookName = txtBookName.Text, Author = txtAuthor.Text, PublishDate = dtPublishDate.Value.ToString("dd/MM/yyyy"), PublishBy = txtPublishBy.Text, Country = txtCountry.Text, Topic = topic, Category = category, Type = type, PageCount = Int32.Parse(txtPageCount.Text) });

            dgvListBook.DataSource = null;          //Display new data on datagridview
            dgvListBook.DataSource = listBook;
         
            id++;

            
            resetForm();            //Reset the form after adding a new one
        }
     
        void resetForm() {
            txtCountry.Text = "";
            txtPublishBy.Text = "";
            txtAuthor.Text = "";
            txtBookName.Text = "";
            txtPageCount.Text = "";
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (!ValidateData())
                return;
            
            for (int i = 0; i < listBook.Count; i++)            //Run each record in the data list
            {
                
                if (listBook[i].Id == currentId)                //Find record with id to edit
                {
                    
                    listBook[i].BookName = txtBookName.Text;            //Reassign the updated data
                    listBook[i].Author = txtAuthor.Text;
                    string topic = cbTopic.SelectedItem.ToString();
                    string type = cbType.SelectedItem.ToString();
                    string category = cbCategory.SelectedItem.ToString();

                    listBook[i].PublishDate = dtPublishDate.Value.ToString("dd/MM/yyyy");
                    listBook[i].PublishBy = txtPublishBy.Text;
                    listBook[i].Country = txtCountry.Text;
                    listBook[i].Topic = topic;
                    listBook[i].Category = category;
                    listBook[i].Type = type;
                    listBook[i].PageCount = Int32.Parse(txtPageCount.Text);
                    break;
                }
            }

            MessageBox.Show("Fix Successfully !!!");
            
            dgvListBook.DataSource = null;                  //Display new data on datagridview
            dgvListBook.DataSource = listBook;
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            for (int i=0;i<listBook.Count;i++)
            {
               
                if (listBook[i].Id == currentId)            //Find record with id to delete
                {
                    listBook.RemoveAt(i);                   //Delete the record from the data list
                }
            }

             MessageBox.Show("Delete successfully !!!");
           
            dgvListBook.DataSource = null;
            dgvListBook.DataSource = listBook;
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e) //click a record in datagridview
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvListBook.Rows[e.RowIndex];                 //e.RowIndex is the number of records the user clicked on

            currentId = Int32.Parse(row.Cells[0].Value.ToString()); // Assign variable currentId = id of the record just clicked

            txtBookName.Text = row.Cells[1].Value.ToString();       //Display data on textbox to edit
            txtAuthor.Text = row.Cells[2].Value.ToString();
            txtPageCount.Text = row.Cells[9].Value.ToString();
            txtPublishBy.Text = row.Cells[4].Value.ToString();
            txtCountry.Text = row.Cells[5].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)       // Search button click event
        {
            
            List<BookInfo> list = new List<BookInfo>();
            
            if (rdSearchByName.Checked)                             //Check if search by name
            {
                
                for (int i = 0; i < listBook.Count; i++)
                {
                    
                    if (listBook[i].BookName.Equals(txtBookName.Text))  //If there is a name corresponding input textbox
                    {
                        
                        list.Add(listBook[i]);                          //Add the newly found record to the search list
                    }
                }
                
                dgvListBook.DataSource = list;
            }
           
            else if (rdSearchByAuthor.Checked)
            {
                for (int i = 0; i < listBook.Count; i++)
                {
                    if (listBook[i].Author.Equals(txtAuthor.Text))
                    {
                        list.Add(listBook[i]);
                    }
                }
                dgvListBook.DataSource = list;

            }
            else if (rdSearchByType.Checked)
            {
                string theLoai = cbType.SelectedItem.ToString();

                for (int i = 0; i < listBook.Count; i++)
                {
                    if (listBook[i].Type.Equals(theLoai))
                    {
                        list.Add(listBook[i]);
                    }
                }
                dgvListBook.DataSource = list;
            }
            else if (rdSearchByPublishDate.Checked)
            {
                for (int i = 0; i < listBook.Count; i++)
                {
                    if (listBook[i].PublishDate.Equals(dtPublishDate.Value.ToString("dd/MM/yyyy")))
                    {
                        list.Add(listBook[i]);
                    }
                }
                dgvListBook.DataSource = list;
            }

            
            resetForm();
        }

        private void btnOpenHireForm_Click(object sender, EventArgs e)      // Click event to open the book rental form
        {
                    
            FormHire Child = new FormHire(listBook);            //transfer the existing book data to the book rental form
            
            Child.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
