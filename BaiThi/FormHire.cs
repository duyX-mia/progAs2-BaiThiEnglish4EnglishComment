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
    public partial class FormHire : Form
    {
        public List<BookInfo> listBook; //List of available books 
        int id = 1;                     // Variable first ID
        List<HireInfo> listHire = new List<HireInfo>(); 

        public FormHire(List<BookInfo> listPassData)
        {
            InitializeComponent();
            txtHireDate.Text = DateTime.Now.ToString("dd/MM/yyyy"); //Set default date value as current date
            listBook = listPassData;                    //Pass existing list of books to this form
        }
        private bool ValidateData()                 //Function to check if the input data is complete
        {
            if (string.IsNullOrWhiteSpace(txtHireBy.Text))
            {
                MessageBox.Show("Borrower's name is not valid");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHireDate.Text))
            {
                MessageBox.Show("Invalid Borrow date");
                return false;
            }
            return true;
        }        
        private void btnHire_Click(object sender, EventArgs e)          //Event to click the book rental button
        {
            
            if (!ValidateData())            //Check if the input data is not enough then stop
                return;
            string bookName = cbBookName.SelectedItem.ToString();       //Get the title of the book
   
            listHire.Add(new HireInfo() { Id = id, HireBy = txtHireBy.Text, BookName = bookName, HireDate = txtHireDate.Text});

            dgvListHire.DataSource = null;                      //Display new data on datagridview
            dgvListHire.DataSource = listHire;

            
            id++;                           //Increase the id variable by 1 , id is not duplicated with the additional data next time
        }

        private void btnSearch_Click(object sender, EventArgs e)          //Search button click event
        {
     
            List<HireInfo> listSearch = new List<HireInfo>();           //Initialize a list to save search results
          
                foreach (HireInfo th in listHire)                       //Run each record in the list
            {
                
                if (th.HireBy.Equals(txtHireBy.Text))                   //If there is a name corresponding to the input textbox
                    
                    listSearch.Add(th);                                 //Add the newly found record to the search list
            }

            //Hiển thị list tìm kiếm lên datagridview
            dgvListHire.DataSource = listSearch;
        }

        private void FormHire_Load(object sender, EventArgs e)
        {
            
            if (listBook != null)               //Get the book title data to the combobox for the user to select the book
            {
                List<string> listBookName = new List<string>();
                for (int i = 0; i < listBook.Count; i++)
                {
                    listBookName.Add(listBook[i].BookName);
                }
                cbBookName.DataSource = listBookName;
            }
        }

        private void txtHireBy_TextChanged(object sender, EventArgs e) //Event-driven, get data from Event
        {

        }
    }
}
