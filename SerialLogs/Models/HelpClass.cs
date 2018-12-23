using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialLogs
{
    static class HelpClass
    {
        

        /// <summary>
        /// Edit Page Help Button Clicked
        /// </summary>
        /// <returns></returns>
        static public string EditPageHelpButton()
        {
            string HelpButtonClicked = "Search by Serial or Customer in the top menu\n" +
                "If you would like to edit the log you searched\n\n" +
                "-With the row selected, push the Edit button\n" +
                "-When finished editing, push the Save button\n\n" +
                "If you would like to delete a serial log\n" +
                "***WARRNING DELETING A SERIAL LOG CAN'T BE UNDONE***\n\n" +
                "-Select the row you would like to delte and push Edit then Delete buttons\n\n" +
                "If you need any more help please Contact Murray Duke @ murrayduke@rogers.com";
            return HelpButtonClicked;
        }

        /// <summary>
        /// MainForm Help button clicked
        /// </summary>
        /// <returns></returns>
        static public string MainFormHelpButton()
        {
            string HelpButtonClicked = "To issue a new serial number for a job click Click the New button and fill out the form. \n\n" +
                "To search for a record click the search button\n\n" +
                "To search for customers click the customers button, here you can search for customer contact info\n\n" +
                "If you have any questions please" + "\ncontact: Murray Duke @ murrayduke@rogers.com";

            return HelpButtonClicked;
        }

        /// <summary>
        /// New Serial Number page help button clicked!
        /// </summary>
        /// <returns></returns>
        static public string NewSerialNumberHelp()
        {
            string HelpButtonClicked = "Quick help options!\n\n" +
                "1. If there is no serial number in the serial number box\n" +
                "or if you need to start a new year. Then click the \n" +
                "Start new year button in the top left!\n" +
                "this will allow you to enter a new serial year\n\n" +
                "WARNING!!! Serial numbers are auto incremented, so if\n" +
                "if there is a serial number in the serial box. Do NOT\n" +
                "push the start new year unless you are starting a new year.\n\n" +
                "Any other issue please forward them to\n" +
                "Murray Duke @ murrayduke@rogers.com";

            return HelpButtonClicked;
        }
    }
}
