/*
    Skrevet af: Philip Knudsen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KøkkenFanatikeren.Src.Models
{
    public class CustomerQuestion
    {
        public IEnumerable<string> DisplayElements { get; private set; }
        public QuestionType Type { get; private set; }
        public string Title { get; private set; }

        /// <summary>
        /// Contains a dictionary of where the key is the name of the element to change, and the value is the new {key}.Text to be writen
        /// </summary>
        public Dictionary<string, string> Constraints { get; private set; }

        /// <summary>
        /// The result of the customers questions
        /// </summary>
        public Dictionary<string, dynamic> Answer { get; set; }


        /// <summary>
        /// Creates a new instance of the CustomerQuestion class
        /// </summary>
        /// <param name="displayElements"> The name of the elements needed for the question </param>
        /// <param name="type"> The type of the question </param>
        /// <param name="title"> The actual question. WARNING: use a newline about every 20 chars </param>
        /// <param name="constaints"> The text for the diffection elements </param>
        public CustomerQuestion(
            IEnumerable<string> displayElements,
            QuestionType type,
            string title,
            Dictionary<string, string> constaints
        )
        {
            DisplayElements = displayElements;
            Type = type;
            Title = title;
            Constraints = constaints;
            Answer = new Dictionary<string, dynamic>();
        }
    }


    public enum QuestionType
    {
        Select,
        MultipleChoice,
        RangeInput,
        SingleInput,
    }

}
