using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

using KøkkenFanatikeren.Frontend;
using KøkkenFanatikeren.Src;

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
            CurrentQuestion = 0;
            Questions = new List<Models.CustomerQuestion>() {
                new Models.CustomerQuestion(
                    new List<string>(){ "btn_1" },
                    Models.QuestionType.Select,
                    "Click Me",
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
            if ( CurrentQuestion+1 == Questions.Count )
            {

                if (MessageBox.Show("Er du færig med skemate", "Du er ved at lukke vinduet", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                Owner.Owner.Answer = Questions;
                Owner.Close();
            }

            HideAllChildElements();
            Models.CustomerQuestion currentQuestion = Questions[CurrentQuestion];

            DisplayQuestionElements(currentQuestion.DisplayElements, currentQuestion.Constraints);
            ResetInputControls();

            CurrentQuestion++;
        }


        public void DisplayPreviousQuestion()
        {
            // Decroments the question pointer
            CurrentQuestion--;

            // Removes the current questions elements and selects the question at the pointer
            HideAllChildElements();
            Models.CustomerQuestion customerQuestion = Questions[CurrentQuestion];

            // Showes all the question elements and sets the question inputs
            DisplayQuestionElements(customerQuestion.DisplayElements, customerQuestion.Constraints);
            SetQuestionInputs(customerQuestion.Answer);
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
        /// 
        /// </summary>
        /// <param name="answers"></param>
        private void SetQuestionInputs(Dictionary<string, dynamic> answers) 
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Resets the input values of all control items
        /// </summary>
        private void ResetInputControls()
        {
            // Create a list with all input control elements names in it
            List<string> inputs = new List<string>() { };

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
            // Loopes over all the controlers of the Owner, and sets
            // the Visible field to false
            foreach (Control ctrl in Owner.Controls)
            {
                // makes sure the submit button is allways visible
                if (ctrl.Name == "btn_Submit") continue;
                ctrl.Visible = false;
            }
        }
    }
}
