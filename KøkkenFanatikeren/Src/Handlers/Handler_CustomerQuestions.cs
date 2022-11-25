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
            Owner = owner;
            CurrentQuestion = -1;
            Questions = new List<Models.CustomerQuestion>() {
                new Models.CustomerQuestion(
                    new List<string>(){ "clb_MCQ" },
                    Models.QuestionType.MultipleChoice,
                    "Hvilket farver vil du gerne have i dit køkken?",
                    new Dictionary<string, string>() {
                        { "ctb_MCQ", "color" }, // When color repoes are ready
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
            };
        }


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
            SetQuestionLabel(currentQuestion.Question);

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
                case Models.QuestionType.Select:
                    SelectInputQuestionHandler(question);
                    break;
                case Models.QuestionType.MultipleChoice:
                    MultimpleChoiceInputQuestionHandler(question);
                    break;
                case Models.QuestionType.RangeInput:
                    RangeInputQuestionHandler(question);
                    break;
                case Models.QuestionType.SingleInput:
                    SingleInputQuestionHandler(question);
                    break;
                default:
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
        /// 
        /// </summary>
        /// <param name="question"></param>
        private void SelectInputQuestionHandler(Models.CustomerQuestion question)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets the data from the checkbox field, and stores it in the questiosn answer
        /// dictionary
        /// </summary>
        /// <param name="question"> The question that is beeing answerd </param>
        private void MultimpleChoiceInputQuestionHandler(Models.CustomerQuestion question)
        {
            // Gets the results from the check list box
            IEnumerable<string> results = Owner.clb_MCQ.CheckedItems.Cast<string>();

            // if the results key already exsits in for the Anser field,
            // do not create it, else create it
            if (!question.Answer.ContainsKey("results"))
                question.Answer.Add("results", null);

            // Sets the results to be the previusly defined results
            question.Answer["results"] = results;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        private void RangeInputQuestionHandler(Models.CustomerQuestion question)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        private void SingleInputQuestionHandler(Models.CustomerQuestion question)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Sets the answer inputs of the question boxes, when the user goes to an answerd question
        /// </summary>
        /// <param name="question"> The question beeing set to the screen </param>
        private void SetQuestionInputs(Models.CustomerQuestion question) 
        {
            throw new NotImplementedException();
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
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
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
        /// Sets the text of the label and move it to the center
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
            // Counts the amount of new lines in the input text
            int lineBrAmt = text.Count(chr => chr.ToString() == Environment.NewLine );

            Console.WriteLine(lineBrAmt);

            // Get the old font from the label
            Font lb_OldFont = Owner.lb_Question.Font;

            // Set the labels font to the same family
            // but change the size based on the amount of lines
            Owner.lb_Question.Font = new Font(lb_OldFont.FontFamily, lb_OldFont.Size - 2.5f * lineBrAmt);

            // set the text to be equal to the new formated text
            Owner.lb_Question.Text = text;
        }
    }
}
