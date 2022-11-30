/*
    Skrevet af: Philip Knudsen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

using KøkkenFanatikeren.Frontend;

namespace KøkkenFanatikeren.Src.Handlers
{
    public class Handler_CustomerQuestions
    {
        /// <summary>
        /// The window to which this handler belongs
        /// </summary>
        private readonly Form_CustomerQuestions Owner;

        public int CurrentQuestion { get; private set; }
        public List<Models.CustomerQuestion> Questions { get; private set; }

        /// <summary>
        /// Creates a new instance of the Handler_CustomerQuestions class
        /// </summary>
        /// <param name="owner"> The window creating this instance </param>
        public Handler_CustomerQuestions(Form_CustomerQuestions owner)
        {
            // Sets the Owner field to be the owner argument
            Owner = owner;

            // Initiates the current question to be -1
            CurrentQuestion = -1;

            // Sets the questions for the customer, the array consists of CustomerQuestio instances
            Questions = new List<Models.CustomerQuestion>() {
                // Creates a new CustomerQuestion instance
                new Models.CustomerQuestion(
                    // Tells the program to show clb_MCQ
                    new List<string>(){ "clb_MCQ" },
                    // Tells the program that the type of Question is Multiple Choice
                    Models.QuestionType.MultipleChoice,
                    // Sets the title of the question
                    "Hvilket farver vil du gerne have i dit køkken? Eller skal vi prøve at finde dig nogle gardiner i stedet. Det kunne da være fint",
                    // Sets the text for different elements on the screen
                    new Dictionary<string, string>() {
                        { "clb_MCQ", "color,dims,lands" }, // When color repoes are ready
                    }),
                new Models.CustomerQuestion(
                    new List<string>(){ "tb_MinInput1", "tb_MinInput2", "tb_MinInput3", "tb_MaxInput1", "tb_MaxInput2", "tb_MaxInput3", "lb_Input1", "lb_Input2", "lb_Input3" },
                    Models.QuestionType.RangeInput,
                    "Hvor stort et skab skal du bruge?",
                    new Dictionary<string, string>()
                    {
                        { "lb_Input1", "Højde:" },
                        { "lb_Input2", "Brede:" },
                        { "lb_Input3", "Dybte:" }
                    }
                    ),
                new Models.CustomerQuestion(
                    new List<string>{},
                    Models.QuestionType.MultipleChoice,
                    "Hvilket matrilaer vil du have i dit køken?",
                    new Dictionary<string, string>(){}
                    ),
                new Models.CustomerQuestion(
                    new List<string>(){},
                    Models.QuestionType.MultipleChoice,
                    "Hvilke typer låger leder du efter?",
                    new Dictionary<string, string>(){}
                    ),
                new Models.CustomerQuestion(
                    new List<string>(){ },
                    Models.QuestionType.RangeInput,
                    "Dit pris loft",
                    new Dictionary<string, string>(){}
                    ),
            };
        }


        /// <summary>
        /// Runnes the setup for when the form origionaly loads in
        /// </summary>
        public void OnForm_CustomerQuestionsLoadEvent()
        {
            HideAllChildElements();
            DisplayNextQuestion();
        }


        /// <summary>
        /// Displayes the next question in the Questions field, closes the window when the questions are done.
        /// </summary>
        public void DisplayNextQuestion()
        {
            // Incroments the question pointer
            CurrentQuestion++;

            // checks if the current question is the last one
            if ( CurrentQuestion == Questions.Count )
            {
                DialogResult result = MessageBox.Show("Er du færig med skemate", "Du er ved at lukke vinduet", MessageBoxButtons.YesNo);

                // if so, the program asks if you want to finish
                // if yes, the answers are feed into the parent of Form_CustomerQuestions,
                // and the form is terminated
                if (result == DialogResult.Yes)
                {
                    Owner.Owner.Answer = Questions;
                    Owner.Close();
                }

                // if no, the box goes away and nothing happens
                CurrentQuestion--;
                return;

            }
            // Resets the window, and pulles the current question from the questions list
            HideAllChildElements();
            Models.CustomerQuestion currentQuestion = Questions[CurrentQuestion];

            // showes the elements from the question
            DisplayQuestionElements(currentQuestion.DisplayElements, currentQuestion.Constraints);

            // Sets the question label
            SetQuestionLabel(currentQuestion.Title);

            // Resets the input
            ResetInputControls();
        }


        /// <summary>
        /// Displayes the previus question, with all the information from the answer
        /// </summary>
        public void DisplayPreviousQuestion()
        {
            // Makes sure an out of index error does not happen
            if (CurrentQuestion - 1 < 0)
                return;

            // Decroments the question pointer
            CurrentQuestion--;

            // Removes the current questions elements and selects the question at the pointer
            HideAllChildElements();
            Models.CustomerQuestion customerQuestion = Questions[CurrentQuestion];

            // Showes all the question elements and sets the question inputs
            DisplayQuestionElements(customerQuestion.DisplayElements, customerQuestion.Constraints);
            SetQuestionInputs(customerQuestion);
        }


        /// <summary>
        /// Handles the click of the btn_Submit element
        /// </summary>
        /// <param name="event"> The event when the button is clicked </param>
        public void OnSubmitButtonClick( MouseEventArgs @event )
        {
            // Makes sure the left mouse button triggers the event
            if (@event.Button != MouseButtons.Left)
                return;

            // Gets the current question
            Models.CustomerQuestion question = Questions[CurrentQuestion];

            // Determins the type of the question, then routes the
            // handling of the question to the designated method
            switch(question.Type) {
                case Models.QuestionType.MultipleChoice:
                    MultimpleChoiceInputQuestionHandler(question);
                    break;
                case Models.QuestionType.RangeInput:
                    try
                    {
                        RangeInputQuestionHandler(question);
                    } catch (Exception)
                    {
                        return;
                    }
                    break;
                default:
                    // Handel logging here
                    throw new Exception("Unknown input from the quesiton list");
            }

            // Displayes the next question
            DisplayNextQuestion();
        }


        /// <summary>
        /// Handels the Mouse click event for the btn_PrevQuest Element
        /// </summary>
        /// <param name="event"> The event when the button is clicked </param>
        public void OnPrevQuestButtonClick(MouseEventArgs @event)
        {
            // Makes sure you click with the left mouse button
            if (@event.Button != MouseButtons.Left)
                return;

            // Goes back to the previus question
            DisplayPreviousQuestion();
        }


        /// <summary>
        /// Gets the data from the checkbox field, and stores it in the questiosn answer
        /// dictionary
        /// </summary>
        /// <param name="question"> The question that is beeing answerd </param>
        private void MultimpleChoiceInputQuestionHandler(Models.CustomerQuestion question)
        {
            // Creates a IEnumerable of the index for the checked item amount
            IEnumerable<int> index = Enumerable.Range(0, Owner.clb_MCQ.Items.Count);
            // Turns the checked items in the CheckedListBox into a IEnumerable
            IEnumerable<string> items = Owner.clb_MCQ.Items.Cast<string>();
            // Zip the index and the item toggether, if the item is not checked in the clb,
            // set it to -1 and with a text of "" (empty string)
            List<(int, string)> results = index.Zip(items, (i, item) => Owner.clb_MCQ.GetItemChecked(i) ? (i, item) : (-1, "") ).ToList();

            // Remove all the -1 elements in the list
            results.RemoveAll(item => item.Item1 == -1);

            // If the results key already exsits in for the Answer field,
            // do not create it, else create it
            if (!question.Answer.ContainsKey("results"))
                question.Answer.Add("results", null);
            // Do the same for the result_type key
            if (!question.Answer.ContainsKey("result_type"))
                question.Answer.Add("result_type", null);


            // Sets the results to be the previusly defined results
            question.Answer["results"] = results;
            // Set the result_type to be the type of 
            question.Answer["result_type"] = "mult";
        }


        /// <summary>
        /// Gets the data from the input range fields, then converts them to ints
        /// and stores them in the questions answer dictionary
        /// </summary>
        /// <param name="question"> The question that is beeing answerd </param>
        private void RangeInputQuestionHandler(Models.CustomerQuestion question)
        {
            // Gets the control elements on for the question
            Control[] input_1 = new Control[] { Owner.tb_MinInput1, Owner.tb_MaxInput1 };
            Control[] input_2 = new Control[] { Owner.tb_MinInput2, Owner.tb_MaxInput2 };
            Control[] input_3 = new Control[] { Owner.tb_MinInput3, Owner.tb_MaxInput3 };

            // Checks to see if the result_type key is missing
            // if so, add it
            if (!question.Answer.ContainsKey("result_type"))
                question.Answer.Add("result_type", null);

            // Checks to see if the results keys are missing
            // if so, add them
            if (!question.Answer.ContainsKey("results_1"))
                question.Answer.Add("results_1", null);
            if (!question.Answer.ContainsKey("results_2"))
                question.Answer.Add("results_2", null);
            if (!question.Answer.ContainsKey("results_3"))
                question.Answer.Add("results_3", null);

            question.Answer["result_type"] = "range";

            // Tries to convert the Control arrays to integers
            // if successfull, add them to the answers.
            try
            {
                question.Answer["results_1"] = ControlToInt(input_1);
                question.Answer["results_2"] = ControlToInt(input_2);
                question.Answer["results_3"] = ControlToInt(input_3);
            }
            // Else catch the InvalidCastException
            catch (InvalidCastException ice)
            {
                // Handle logging here
                throw new Exception("Unfinished data grep");
            } catch (Exception)
            {
                // Handle logging here
                throw new Exception("Unfinished data grep");
            }

        }


        /// <summary>
        /// Sets the answer inputs of the question boxes, when the user goes to an answerd question
        /// </summary>
        /// <param name="question"> The question beeing set to the screen </param>
        private void SetQuestionInputs(Models.CustomerQuestion question) 
        {
            // Asserts that a "result_type" key is pressent in the questions
            // Answer field. If not, the program throws an error
            bool isPressent = question.Answer.TryGetValue("result_type", out dynamic dynamic_Type);
            if (!isPressent)
            {
                // Logging here
                throw new Exception();
            }

            // gets the result type as a string, in sted of a dynamic type
            string type = (string)dynamic_Type;

            // Match the type against known types
            switch (type)
            {
                case "mult":
                    // Go over the answer, and sets the checked status to true
                    foreach ((int, string) elem in question.Answer["results"])
                        Owner.clb_MCQ.SetItemChecked(elem.Item1, true);
                    break;
                case "range":

                    // TODO: SET THE RANGE BOXES

                    break;
                default:
                    throw new Exception();
            }
        }


        /// <summary>
        /// Takes in a IEnumarble of elements, then converts them to a List of ints
        /// </summary>
        /// <param name="elems"> The elements to be converted </param>
        /// <returns> A list of ints, that have been parsed out of the Control array </returns>
        private List<int> ControlToInt(IEnumerable<Control> elems)
        {
            return elems.Select(elem => {
                elem.ForeColor = Color.Black;
                if (string.IsNullOrEmpty(elem.Text))
                {
                    MessageBox.Show("Du skal udfylde alle bokse med hele tal!", "WARNING", MessageBoxButtons.OK);
                    throw new Exception("Empty string");
                }

                // Try converting the text to an int
                bool couldParse = int.TryParse(elem.Text, out int result);

                // If the program could not convert to an int,
                // change the text color to red, and show a warrning
                if (!couldParse)
                {
                    elem.ForeColor = Color.Red;
                    MessageBox.Show("Du må kun skrive hele tal i boksen!", "WARNING", MessageBoxButtons.OK);
                    // Then the program throwes an exception
                    throw new InvalidCastException($"Could not parse the number \"{elem.Text}\"");
                }
                // Else return the result
                return result;
            }).ToList();
        }


        /// <summary>
        /// Resets the input values of all control items
        /// </summary>
        private void ResetInputControls()
        {
            // Create a list with all input control elements names in it
            HashSet<string> inputs = new HashSet<string>() { };

            // Loops over them, then sets the text to an empty string
            // if the name is in the inputs list
            foreach (Control ctrl in Owner.Controls)
            {
                if (inputs.Contains(ctrl.Name))
                    ctrl.Text = "";
            }
        }


        /// <summary>
        /// Displayes the elements of the next question, and sets relevant elements text
        /// </summary>
        /// <param name="relevantElements"> The namse of the elements needed for the question </param>
        /// <param name="elementLables"> The { name, value } pairs of the relevant elements </param>
        private void DisplayQuestionElements(IEnumerable<string> relevantElements, Dictionary<string, string> elementLables)
        {
            // Loopes over all control elements on the owner
            foreach (Control ctrl in Owner.Controls)
            {
                if ( relevantElements.Contains(ctrl.Name) )
                {
                    // Starts by setting the element visiblity to true
                    ctrl.Visible = true;

                    // then check if the element has some accositated text with it
                    // if not the program continues
                    bool isPresent = elementLables.TryGetValue(ctrl.Name, out string text);
                    if (!isPresent)
                        continue;

                    // sets the relevant data for each type of control element
                    HandelElementLables(ctrl.Name, text);
                }
            }

        }


        /// <summary>
        /// Sets the text in Control elements, to the specifed text
        /// </summary>
        /// <param name="name"> The name of the target element </param>
        /// <param name="text"> The text for that element </param>
        private void HandelElementLables(string name, string text)
        {
            // Gets the type definition from the front of the control name
            // EXAMPLE: lb_Test is a label, as can be seen by the lb.
            string controlElementType = name.Substring(0, name.IndexOf('_'));

            // Asserts the element of the item, then sets the coresponding data
            switch (controlElementType)
            {
                // Label case
                case "lb":
                    // Gets the field from the type of the Owner,
                    // Then sets the Text field to the text variable
                    ((Label)Owner.GetType().GetField(name).GetValue(Owner)).Text = text;
                    break;
                case "tb":
                    // Gets the field from the type of the Owner,
                    // Then sets the Text field on the TextBox to the text variable
                    ((TextBox)Owner.GetType().GetField(name).GetValue(Owner)).Text = text;
                    break;
                case "clb":
                    // Gets the target Control item.
                    CheckedListBox target = (CheckedListBox)Owner.GetType().GetField(name).GetValue(Owner);
                    // Clears all the items from the target
                    target.Items.Clear();
                    // Adds the desired items from the text argument
                    text.Split(',').ToList().ForEach(item => target.Items.Add(item));
                    break;
                default:
                    Console.WriteLine(name);
                    break;
            }

        }


        /// <summary>
        /// Makes all elements on the screen invisible
        /// </summary>
        private void HideAllChildElements()
        {
            // Contains all control elements that should allways be visible
            HashSet<string> constantItems = new HashSet<string>() { "btn_Submit", "btn_PrevQuest", "lb_Question" };

            // Loopes over all the controlers of the Owner, and sets
            // the Visible field to false
            foreach (Control ctrl in Owner.Controls)
            {
                // makes sure specified items are allways visible
                if (constantItems.Contains(ctrl.Name)) continue;
                ctrl.Visible = false;
            }
        }


        /// <summary>
        /// Sets the text of the title label and move it to the center
        /// </summary>
        /// <param name="text"> The new label text </param>
        private void SetQuestionLabel(string text)
        {
            // Defines the midel of the screen element
            int formXMidt = (int)Math.Round(Owner.Size.Width / 2.0f);

            // Sets the text of the label
            FormatTextLabel(text);

            // Gets the size of the label, and finds its half width
            Size lb_Size= Owner.lb_Question.Size;
            float halfWidthMargin = lb_Size.Width / 2;

            // Gets the old loctaion for the label, and calculates the new
            // location
            int lb_OldYLoc = Owner.lb_Question.Location.Y;
            Point lb_NewLoc = new Point(
                (int)Math.Round(formXMidt - halfWidthMargin),
                lb_OldYLoc
            );

            // Sets the new location point to the label,
            // moving it to the midel of the screen.
            Owner.lb_Question.Location = lb_NewLoc;
        }


        /// <summary>
        /// Formats the text so it does not go over the screen, and changes size based on the
        /// amount of chars on the screen
        /// </summary>
        /// <param name="text"> The input text to be displayed on the screen </param>
        private void FormatTextLabel(string text)
        {
            // Define the line length for each question title
            const int LINE_LENGTH = 50;

            // The finished string, going into the label.Text field
            string newText = "";

            // The length for the line currently beeing worked on
            int currentLineLength = 0;

            // The amount of line breaks in the final text
            int lineBreaks = 0;

            // Loops all the text snippets base on the amount of spaces
            foreach ( string textSnippet in text.Split(' ') )
            {
                // If the curren lines length plus the textSnippets length would excede the LINE_LENGTH constant
                // break the line, add 1 to lineBreaks, and reset the currentLineLenght
                if (currentLineLength + textSnippet.Length > LINE_LENGTH) {
                    lineBreaks++;
                    currentLineLength = 0;
                    newText += Environment.NewLine;
                }

                // Add the textSnippet to the formated newText variable
                newText += textSnippet;
                // Add a space to coriaget for the missing one, after the split
                newText += " ";
                // Add the textSnippets length to the current lines length
                currentLineLength += textSnippet.Length;
            }

            // Get the old font from the label
            Font lb_OldFont = Owner.lb_Question.Font;

            // Set the labels font to the same family
            // but change the size based on the amount of lines
            Owner.lb_Question.Font = new Font(lb_OldFont.FontFamily, lb_OldFont.Size - 2.5f * lineBreaks);

            // set the text to be equal to the new formated text
            Owner.lb_Question.Text = newText;
        }
    }
}
