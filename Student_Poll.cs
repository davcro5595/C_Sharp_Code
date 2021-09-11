/* Requirements: 
Create a Windows Form that prompts the user for survey responses and outputs each response to a file. 
Use StreamWriter to create a file called txt. Each integer should be written using method Write.  (Note that the program will need to remember values every time the Enter button is pressed while the TextBox is the focus. 
Add a TextBox that will output the frequency of survey responses. 
Modify the code in Fig. 8.8 to read the survey responses from txt. The responses should be read from the file by using a StreamReader. 
Class string’s Split method should be used to split the input string into separate responses. 
Each response should be converted to an integer. 
The program should continue to read responses until it reaches the end of file. The results should be output to the TextBox. 
*/
/* David Crouch  
*  CIS 317  
*  Final Exam 
*  07/11/2021  
* */ 
using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.IO; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
  
namespace StudentPoll 
{ 
    public partial class StudentPollForm : Form 
    { 
         
        //sets file to where data is written 
        private StreamWriter fileWriter; //writes data to a text file 
        private StreamReader fileReader; //reads data from a text file 
        private int[] values = new int[10]; 
        private string fileName = "C:\\Users\\davcro5595\\Documents\\Visual Studio 2015\\Projects\\StudentPoll\\txt.txt"; 
  
        public StudentPollForm() 
        { 
            InitializeComponent(); 
        }             
  
        //method for recording entries when the Enter button is pressed. 
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e) 
        { 
            if (e.KeyCode == Keys.Enter) 
            { 
                string input = inputTextBox.Text; 
                if (int.Parse(input) > 0 && int.Parse(input) < 11) 
                { 
                    //increment the appropriate value in the array 
                    values[int.Parse(input) - 1]++; 
                    //test code -- So far, it works! 
                    //MessageBox.Show(Convert.ToString(values[int.Parse(input) - 1]), "Error", 
                      //     MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } 
            }             
        }//end method inputTextBox_KeyDown 
  
  
        private void doneButton_Click(object sender, EventArgs e) 
        { 
             
  
            //open the file to later insert the data 
            try 
            { 
                //open file with write access 
                var output = new FileStream(fileName, FileMode.OpenOrCreate, 
                    FileAccess.Write); 
                //sets file to where data is written 
                fileWriter = new StreamWriter(output);                 
            } 
            catch (IOException) 
            { 
                MessageBox.Show("Error opening file", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }//end try/catch block 
  
            //store the responses in a string 
            //The string starts by having the table headers of 'Reading" and "Frequency" listed. 
            string valueString = ""; 
            foreach (int value in values) 
            { 
                valueString += "," + (value); 
            } 
  
            //test code for seeing if the valueString is being stored correctly 
            //MessageBox.Show(valueString, "Error", 
              //      MessageBoxButtons.OK, MessageBoxIcon.Error); 
  
            //write the array to the file 
            fileWriter.Write($"{valueString}"); 
            fileWriter?.Close(); //close the StreamWriter and underlying file 
        }//end method doneButton_Click 
  
        private void viewResultsButton_Click(object sender, EventArgs e) 
        { 
            //This method will only read one line.  I want a method which will write all the lines int he file... 
            try 
            { 
                //create FileStream to obtain read access to file 
                FileStream input = new FileStream(fileName, 
                    FileMode.Open, FileAccess.Read); 
  
                // set file from where data is read 
                fileReader = new StreamReader(input); 
  
                doneButton.Enabled = false; //disable Done button 
            } 
            catch (IOException) 
            { 
                MessageBox.Show("Error reading from file", 
                    "File Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error); 
            }//end try/catch block 
  
            try 
            { 
                //get next record available in file 
                var inputRecord = fileReader.ReadLine(); 
  
                if (inputRecord != null) 
                { 
                    string[] inputFields = inputRecord.Split(','); 
  
                    //test code 
                    //MessageBox.Show(inputRecord, 
                    //"File Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
  
                    //display the data in the resultsTextBox 
                    resultsTextBox.AppendText($"{"Rating",-10} " + 
                            $"\t{"Frequency",-10} \n"); 
                    for (int i = 1; i < (inputFields.Length); i++) 
                    {                         
                        resultsTextBox.AppendText($"{i,-10} " + 
                            $"\t{inputFields[i],-10} \n"); 
                    } 
  
                    //resultsTextBox.AppendTextinputFields); ////LOOK AT SetTextBoxValues method to figure out the next steps. 
                    //inputRecord = fileReader.ReadLine(); ///I don't know why I have this line... 
                }//end if              
            }//end try 
            catch (IOException) 
            { 
                MessageBox.Show("Error reading from file", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }//end catch         
        }//end method viewResultsButton_Click 
  
  
    }//end class StudentPollForm 
}//end namespace StudentPoll 