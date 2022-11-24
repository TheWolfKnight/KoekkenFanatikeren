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
                    new List<string>(){ "btn_1" },
                    Models.QuestionType.Select,
                    "Lorum Ibsum Denum",
                    new Dictionary<string, string>() {
                        { "btn_1", "Click Me" }
                    }),
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
            // Decroments the question pointer
            CurrentQuestion--;

            // Removes the current questions elements and selects the question at the pointer
            HideAllChildElements();
            Models.CustomerQuestion customerQuestion = Questions[CurrentQuestion];

            // Showes all the question elements and sets the question inputs
            DisplayQuestionElements(customerQuestion.DisplayElements, customerQuestion.Constraints);
            SetQuestionInputs(customerQuestion.Answer, customerQuestion.Type);
        }


        /// <summary>
        /// Handles the click of the btn_Submit element
        /// </summary>
        public void OnSubmitButtonClick( MouseEventArgs @event )
        {
            // Makes sure the left mouse button triggers the event
            if (@event.Button != MouseButtons.Left)
                return;

            Models.CustomerQuestion question = Questions[CurrentQuestion];

            switch(question.Type) {
                case Models.QuestionType.Select:
                    break;
                case Models.QuestionType.RangeInput:
                    break;
                case Models.QuestionType.SingleInput:
                    break;
                default:
                    throw new Exception("Unknown input from the quesiton list");
            }

            DisplayNextQuestion();
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
        /// <param name="answers"> The questions answer field. (KEY:VALUE) = (CONTROL_NAME:VALUE) </param>
        private void SetQuestionInputs(Dictionary<string, dynamic> answers, Models.QuestionType type) 
        {
            foreach (string key in answers.Keys)
            {
                try
                {
                    // Attemts to find the Control field that is specified in the Dict
                    // Key in this case should be a field name, and value should be a
                    // dynamic type that the control could take as a value.
                    Control target = (Control)Owner.GetType().GetField(key).GetValue(Owner);
                    target.Text = answers[key];
                } catch ( NullReferenceException ae )
                {
                    // TODO: Logging
                }
            }
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
            foreach (Control ctrl in Owner.Controls)
            {
                if ( relevantElements.Contains(ctrl.Name) )
                {
                    ctrl.Visible = true;
                    if (elementLables.TryGetValue(ctrl.Name, out string text))
                        ctrl.Text = text;
                }
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
            Owner.lb_Question.Text = text;

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

    }
}
