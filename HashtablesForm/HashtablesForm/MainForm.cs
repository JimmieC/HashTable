using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashtablesForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        //Declare new object of the class hashtable with ten positions
        Hashtable hashtable = new Hashtable(10);
        
        /// <summary>
        /// When the user clicks the Add button then an if statement checks to make sure the text boxes are not empty, otherwise 
        /// an error message is shown. Then method put from hashtable class is called with the text boxes input as parameters.
        /// Then update Gui to clear the text boxes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text != string.Empty && txtKey.Text != string.Empty)
            {
                hashtable.Put(txtKey.Text, txtvalue.Text);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("please enter a key and a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
               
        }

        /// <summary>
        /// Remove button, if the key textbox is not empty then method remove from hashtable
        /// class is called with parameter from the text box. If the text box is empty then an error message is displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (txtkey2.Text != string.Empty)
            {
                hashtable.Remove(txtkey2.Text);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Please enter a key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Find button, declare object texttofind and make it equal to the textboxes input. Declare another object valuereturn, 
        /// and make it equal to the method get from class hashtable which returns a value depending on the parameter. In this method
        /// the parameter for the get method is texttofind from the textbox. 
        ///     An if statement to check that the get method returns a value, if there is a value then the label to display results
        /// displays the valuereturn.Tostring to make it a string. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            object texttofind = txtkey3.Text;
            object valuereturn = hashtable.Get(texttofind);
            if (valuereturn != null)
            {
                lblreturn.Text = valuereturn.ToString();
            }
            else
            {
                //if no match is found then an error message and call updategui to clear text boxes. 
                MessageBox.Show("No match found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Method to clear all the text boxes and the label
        /// </summary>
        public void UpdateGUI()
        {
            txtKey.Clear();
            txtkey2.Clear();
            txtkey3.Clear();
            txtvalue.Clear();
            lblreturn.Text = null;
        }



        

    }
}
