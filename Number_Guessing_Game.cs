/* David Crouch  
*  CIS 214  
*  Number Guessing Game
*  01/17/2021  
* */ 
using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
  
namespace Unit4_GradedExercise2 
{ 
    public partial class Form1 : Form 
    { 
        //initiliaze variables 
        int secret = 0; 
        int lastGuess = 0; 
        bool firstGuess = true; 
  
        //constructor method 
        public Form1() 
        { 
            InitializeComponent(); 
        } 
  
        // randomly generate a secret number (1-1000) 
        private void GenerateSecret() 
        { 
            Random randomNumber = new Random(); 
            secret = randomNumber.Next(1000) + 1; 
        } // end method GenerateSecret 
  
        //method for checking if the user's guess is correct 
        private int CheckGuess(int user) 
        { 
            if (user > secret) // too high 
                return 1; 
            if (user < secret) // too low 
                return -1; 
            else // correct 
                return 0; 
        } // end method CheckGuess 
  
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e) 
        { 
            // allow user to press enter in textbox 
            if (e.KeyCode == Keys.Enter) 
            {   //store the textbox info as the userGuess 
                int userGuess = Convert.ToInt32(inputTextBox.Text);  
  
                // check if user is warmer or colder. Red = warmer, Blue = colder 
                if (!firstGuess) 
                { 
                    if (Math.Abs(userGuess - secret) < 
                    Math.Abs(lastGuess - secret)) 
                        BackColor = Color.Red; 
                    else 
                        BackColor = Color.LightBlue; 
                } 
                //after the first time, set the firstGuess to false 
                firstGuess = false; 
  
                // CheckGuess returns 0 if correct, -1 if too low, 
                // 1 if too high 
                int rightOrWrong = CheckGuess(userGuess); 
  
                // if guess is right allow user to play again 
                if (rightOrWrong == 0) 
                { 
                    outputLabel.Text = "Correct!"; 
                    newGameButton.Enabled = true; 
                    inputTextBox.ReadOnly = true; 
                    BackColor = Color.LightGreen; 
                    firstGuess = true; 
                } // end if 
                else if (rightOrWrong == -1) 
                    outputLabel.Text = "Too Low!"; 
                else 
                    outputLabel.Text = "Too High!"; 
  
                // clear guess 
                inputTextBox.SelectAll(); 
                lastGuess = userGuess; 
            } // end if 
        } // end method inputTextBox_KeyDown 
  
        private void newGameButton_Click(object sender, EventArgs e) 
        { 
            outputLabel.Text = "New Game Started!"; 
  
            GenerateSecret(); 
  
            newGameButton.Enabled = false; 
            inputTextBox.ReadOnly = false; 
            BackColor = Color.FromName("Control"); 
        } // end method newGameButton_Click 
  
         
        private void Form1_Load(object sender, EventArgs e) 
        { 
            inputTextBox.ReadOnly = true; 
        } 
  
    }//end Class 
}//end namespace 
 