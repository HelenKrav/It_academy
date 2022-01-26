using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ITAcademyFormApp
{
    internal class Answer
    {
        public string Text { get; set; }

        public bool IsCorrect { get; set; }
        [JsonIgnore]      // атрибут, чтобы не записывать в json 
        public string Tag { get; set; }

        public Answer()
        {
                
        }

        public Answer(string text, bool isCorrect = false)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

    }
}
