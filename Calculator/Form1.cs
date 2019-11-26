using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Author: Charif Ramadan an example from youtube
/// </summary>
namespace Calculator
{
    /// <summary>
    /// A Basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clear the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
            // or userinput.text= " ";
            FocusInputText();

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
           
            DeleteValue();
            FocusInputText();

        }

      
        #endregion

        #region Operator Methods

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void Multipbtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void Plusbtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            CalculateTheResult();
            FocusInputText();

        }

        #endregion

        #region Number Methods 
        private void Punktbtn_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void Zerobtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        private void Onebtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

      

        private void Twobtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void Threebtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void FourthBtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }
        private void Fifthbtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();

        }

        private void Sevenbtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void Eightbtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void NinthBtn_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }
        #endregion

        #region Private Helpers

        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        private void InsertTextValue( string  n)
        {
           
            // remmber selection start 
            var selectionstart = this.UserInputText.SelectionStart;

            // set new text 
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart,n );

            // restore the seletion start 
            this.UserInputText.SelectionStart = selectionstart + n.Length;

            // set selecion lenght to zero 
            this.UserInputText.SelectionLength = 0;

        }

        private void DeleteValue()
        {

            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            var selectionstart = this.UserInputText.SelectionStart;

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            this.UserInputText.SelectionStart = selectionstart;

            // set selecion lenght to zero 
            this.UserInputText.SelectionLength = 0;
        }
        #endregion

        #region Calculate the Equations
        /// <summary>
        /// calcuate all the numbers 
        /// </summary>
        private void CalculateTheResult()
        {
            FocusInputText();
            throw new NotImplementedException();
        }
        #endregion

    }
}