using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace ITAcademyFormApp
{
    internal class Question: IEquatable<Question>
    {
        [JsonPropertyName("Question")]
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }

        public Guid QuestionId { get; set; }
        public Question()
        {

        }

        public Question(string text, ICollection<Answer> answers)
        {
            QuestionId = Guid.NewGuid();
            Text = text;   
            if(answers == null || answers.Count < 2 || answers.All(x=> !x.IsCorrect))
            {
                throw new ArgumentException("Должно быть минимум 2 ответа и один корректный");
            }
            Answers = answers.ToList();
        }

        public bool Equals(Question other)
        {
            return this.QuestionId == other.QuestionId;
        }
    }
}
