using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SIMPLECALCULATOR_IN_CS // Created by: Joshua C. Magoliman
{
    public partial class Form_Calculator : MaterialForm
    {

        #region Fields
        private double userInputNumbers = 0, answer = 0;
        private char arithmeticOperator = ' ';
        private SoundPlayer sound = new SoundPlayer();
        #endregion

        #region Constructor
        public Form_Calculator()
        {
            // Invoke this Built-in Method called InitializeComponent()
            InitializeComponent();
            // Set the Property called FormBorderStyle of this Form to None
            this.FormBorderStyle = FormBorderStyle.None;
            // Invoke the API Method called 'MakeThisFormRoundedRectangle' and give all necessary values in arguments
            Region = System.Drawing.Region.FromHrgn(MakeThisFormRoundedRectangle(0, 0, Width, Height, 20, 20));
        }
        #endregion

        #region Event Handler Methods (Default Naming Convention)
        private void Form_Main_Load(object sender, EventArgs e)
        {
            // Invoke this User Defined Method called SetTheThemeInThisForm and pass an argument
            SetTheThemeInThisForm("LIGHT");
            // Disable the textbox called txtDisplay
            txtDisplay.Enabled = false;
            // Set the location and filename of sound
            sound.SoundLocation = (Application.StartupPath + "\\WAV\\BUTTONCLICK.wav");
            // Invoke the Object called sound and use the Built-in Method called Load()
            sound.Load();
        }
        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            // Invoke the User Defined Method called SetTheThemeInThisForm and pass an argument
            SetTheThemeInThisForm("");
            // Invoke the Object called sound and use the Built-in Method called Play()
            sound.Play();
        }
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            // If the Property called Text of textbox is equal to 0
            if (txtDisplay.Text == "0")
            {
                // Use the class called Clipboard and invoke the Built-in Method called Clear()
                Clipboard.Clear();
            }
            // If the Property called Text of textbox is not equal to 0
            else
            {
                // Use the class called Clipboard and invoke the Built-in Method called SetText() and pass an argument
                Clipboard.SetText(txtDisplay.Text);
                // Show this messagebox
                MessageBox.Show("SUCCESSFULLY COPIED!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Invoke the Object called sound and use the Built-in Method called Play()
            sound.Play();
        }
        #endregion

        #region Event Handler Method (User Defined Naming Convention)
        private void OnClick(object param_Sender, EventArgs e)
        {
            // Invoke the Built-in Method called Focus()
            txtDisplay.Focus();
            // Check if the user click the button called btnDot
            if (param_Sender == btnDot)
            {
                // If the textbox called txtDisplay contains '.'
                if (txtDisplay.Text.Contains('.'))
                {
                    // End the execution of this Event Handler Method (User Defined Naming Convention) called OnClick
                    return;
                }
                // If the value of textbox called txtDisplay don't have "."
                else
                {
                    // Invoke this User Defined Method called GetInput() and pass this "." as an argument
                    GetInput(".");
                }
            }
            // THIS CODES IS FOR NUMERIC BUTTONS
            // Check if the user click the button called btnZero
            else if (param_Sender == btnZero)
            {
                // Invoke this User Defined Method called GetInput() and pass this "0" as a method argument
                GetInput("0");
            }
            // Check if the user click the button called btnOne
            else if (param_Sender == btnOne)
            {
                // Invoke this User Defined Method called GetInput() and pass this "1" as a method argument
                GetInput("1");
            }
            // Check if the user click the button called btnTwo
            else if (param_Sender == btnTwo)
            {
                // Invoke this User Defined Method called GetInput() and pass this "2" as a method argument
                GetInput("2");
            }
            // Check if the user click the button called btnThree
            else if (param_Sender == btnThree)
            {
                // Invoke this User Defined Method called GetInput() and pass this "3" as a method argument
                GetInput("3");
            }
            // Check if the user click the button called btnFour
            else if (param_Sender == btnFour)
            {
                // Invoke this User Defined Method called GetInput() and pass this "4" as a method argument
                GetInput("4");
            }
            // Check if the user click the button called btnFive
            else if (param_Sender == btnFive)
            {
                // Invoke this User Defined Method called GetInput() and pass this "5" as a method argument
                GetInput("5");
            }
            // Check if the user click the button called btnSix
            else if (param_Sender == btnSix)
            {
                // Invoke this User Defined Method called GetInput() and pass this "6" as a method argument
                GetInput("6");
            }
            // Check if the user click the button called btnSeven
            else if (param_Sender == btnSeven)
            {
                // Invoke this User Defined Method called GetInput() and pass this "7" as a method argument
                GetInput("7");
            }
            // Check if the user click the button called btnEight
            else if (param_Sender == btnEight)
            {
                // Invoke this User Defined Method called GetInput() and pass this "8" as a method argument
                GetInput("8");
            }
            // Check if the user click the button called btnNine
            else if (param_Sender == btnNine)
            {
                // Invoke this User Defined Method called GetInput() and pass this "9" as a method argument
                GetInput("9");
            }
            // THIS CODES IS FOR ARITHMETIC OPERATOR BUTTONS
            // Check if the user click the button called btnPlus
            else if (param_Sender == btnPlus)
            {
                // Invoke this User Defined Method called GetAnswer()
                GetAnswer();
                // Set the value of field called arithmeticOperator to plus
                arithmeticOperator = '+';
            }
            // Check if the user click the button called btnMinus
            else if (param_Sender == btnMinus)
            {
                // Invoke this User Defined Method called GetAnswer()
                GetAnswer();
                // Set the value of field called arithmeticOperator to minus
                arithmeticOperator = '-';
            }
            // Check if the user click the button called btnMultiply
            else if (param_Sender == btnMultiply)
            {
                // Invoke this User Defined Method called GetAnswer()
                GetAnswer();
                // Set the value of field called arithmeticOperator to times
                arithmeticOperator = '*';
            }
            // Check if the user click the button called btnDivide
            else if (param_Sender == btnDivide)
            {
                // Invoke this User Defined Method called GetAnswer()
                GetAnswer();
                // Set the value of field called arithmeticOperator to divide
                arithmeticOperator = '/';
            }
            // Check if the user click the button called btnDot
            else if (param_Sender == btnDot)
            {
                // Invoke this User Defined Method called GetAnswer()
                GetAnswer();
                // Invoke this User Defined Method called Clear()        
                Clear();
            }
            // Check if the user click the button called btnPositiveOrNegative
            else if (param_Sender == btnPositiveOrNegative)
            {
                // If the textbox called txtDisplay contain a text '-'
                if (txtDisplay.Text.Contains('-'))
                {
                    // Don't make negative sign the text in textbox called txtDisplay
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.IndexOf("-"), 1);
                }
                // If the textbox called txtDisplay don't contain a text '-'
                else
                {
                    // Add this text value "-" in textbox called txtDisplay
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
            // Check if the user click the button called btnEqual
            else if (param_Sender == btnEqual)
            {
                // Invoke this User Defined Method called GetAnswer()
                GetAnswer();
                // Invoke this User Defined Method called Clear()
                Clear();
            }
            // Check if the user click the button called btnErase
            else if (param_Sender == btnErase)
            {
                // If the text length value of textbox called txtDisplay is less than or equal to 1
                if (txtDisplay.Text.Length <= 1)
                {
                    // Invoke this User Defined Method called Clear()
                    Clear();
                    // Set the text value of textbox called txtDisplay to 0
                    txtDisplay.Text = "0";
                }
                // If the text length value of textbox called txtDisplay is greater than 1
                else if (txtDisplay.Text.Length > 1)
                {
                    // Remove one digit number in textbox called txtDisplay
                    txtDisplay.Text = txtDisplay.Text.Substring(0, (txtDisplay.Text.Length) - 1);
                }
            }
            // Check if the user click the button called btnClear
            else if (param_Sender == btnClear)
            {
                // Call this User Defined Method called Clear()
                Clear();
                // Set the value of Property called Text of textbox called txtDisplay to "0"
                txtDisplay.Text = "0";
            }
            // Invoke the object called 'sound' and use the Built-in Method called Play()
            sound.Play();
            // Invoke this User Defined Method called InsertCommas()
            InsertCommas();
        }
        #endregion

        #region API Method
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr MakeThisFormRoundedRectangle(int param_LeftSide, int param_TopSide, int param_RightSide, int param_BottomSide, int param_WidthSize, int param_HeightSize);
        #endregion

        #region User Defined Methods
        private void SetTheThemeInThisForm(string param_Theme)
        {

            // This Variable will able to use the class called MaterialSkinManager and hold the value of Property (static getter) called Instance
            var skinManager = MaterialSkinManager.Instance;
            // I've used this Built-in Method called AddFormToManage() and pass this Form
            skinManager.AddFormToManage(this);
            // I've initialized a local variable and assign it
            string valueText = "";
            // If the value of parameter called param_Theme is empty string
            if (param_Theme == "")
            {
                valueText = btnChangeTheme.Text;
            }
            // If the value of parameter called param_Theme is not empty string
            else
            {
                // If the value of parameter called param_Theme is LIGHT
                if (param_Theme == "LIGHT")
                {
                    // Re assign the value of local variable called valueText
                    valueText = "LIGHT";
                }
                // If the value of parameter called param_Theme is DARK
                else if (param_Theme == "DARK")
                {
                    // Re assign the value of local variable called valueText
                    valueText = "DARK";
                }
            }
            // Check the value of local variable called valueText
            switch (valueText)
            {
                // If the value of local variable called valueText is "DARK"
                case "DARK":
                    // Set the Theme of this Form to Light   
                    skinManager.Theme = MaterialSkinManager.Themes.DARK;
                    // Set the text of button called btnChangeTheme to "LIGHT"
                    btnChangeTheme.Text = "LIGHT";
                    break;
                // If the value of local variable called valueText is "LIGHT"
                case "LIGHT":
                    // Set the Theme of this Form to Light
                    skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    // Set the text of button called btnChangeTheme to "DARK"
                    btnChangeTheme.Text = "DARK";
                    break;
            }
            // Set the value for Property called ColorScheme
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Grey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE); // Setting the color of this form
        }
        private void InsertCommas()
        {
            // If the content text length of textbox called txtDisplay is greater than or equal to 4
            if (txtDisplay.Text.Length >= 4)
            {
                // I've initialized a local variable and assign it
                double patternFormat = Convert.ToDouble(txtDisplay.Text);
                // If the textbox called txtFirst don't contains "."
                if (!txtDisplay.Text.Contains("."))
                {
                    // Convert the string format of the text of textbox called txtDisplay 
                    txtDisplay.Text = patternFormat.ToString("#,##0");
                }
            }
        }
        private void GetInput(string param_String)
        {
            // If the text value of textbox called txtDisplay have "."
            if (txtDisplay.Text == ".")
            {
                // Add the string value of param_String to the text value of textbox called txtDisplay
                txtDisplay.Text += param_String;
            }
            // If the button called btnDot is already clicked and the number in textbox called txtDisplay is already converted to double
            else if (Convert.ToDouble(txtDisplay.Text) == answer)
            {
                // Set the text value of param_String in textbox called txtDisplay
                txtDisplay.Text = param_String;
            }
            else // If the text value of textbox called txtDisplay don't have "." and the number in textbox called txtDisplay is not already converted to double
            {
                // Add the text value of param_String to the textbox called txtDisplay
                txtDisplay.Text += param_String;
            }
        }
        private void GetAnswer()
        {
            try
            {
                // If the text value of textbox called txtDisplay is not "0"
                if (txtDisplay.Text != "0")
                {
                    // Set the value in field called userInputNumbers from text value that is converted to double in textbox called txtDisplay
                    userInputNumbers = Convert.ToDouble(txtDisplay.Text);
                    // If the value of field called answer is "0"
                    if (answer == 0)
                    {
                        // Set the value of field called answer from the value of field called userInputNumbers
                        answer = userInputNumbers;
                    }
                    // If the value of field called answer is not "0"
                    else
                    {
                        // Check the value of field called arithmeticOperator
                        switch (arithmeticOperator)
                        {
                            // If the value of field called arithmeticOperator is Plus
                            case '+':
                                // Then Add the value in field called answer from the value of field called userInputNumbers
                                answer += userInputNumbers;
                                break;
                            // If the value of field called arithmeticOperator is Minus
                            case '-':
                                // Then Minus the value in field called answer from the value of field called userInputNumbers
                                answer -= userInputNumbers;
                                break;
                            // If the value of field called arithmeticOperator is Times
                            case '*':
                                // Then Times the value in field called answer from the value of field called userInputNumbers
                                answer *= userInputNumbers;
                                break;
                            // If the value of field called arithmeticOperator is Divide
                            case '/':
                                // Then Divide the value in field called answer from the value of field called userInputNumbers
                                answer /= userInputNumbers;
                                break;
                        }
                    }
                    // Set the text value of textbox called txtDisplay from the value of field called answer that is converting to string data type
                    txtDisplay.Text = Convert.ToString(answer);
                }
            }
            catch (Exception ex) // I've declared here a General Exception
            {
                //  Show the error in meaningful way and trace the error line
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        private void Clear()
        {
            // Set the value of field called userInputNumbers to "0"
            userInputNumbers = 0;
            // Set the value of field called answer to "0"
            answer = 0;
            // Set the value of field called arithmeticOperator to ' '
            arithmeticOperator = ' ';
        }
        #endregion
    }
}
