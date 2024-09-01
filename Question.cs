﻿namespace MillionaireGame
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string text, List<Answer> answers)
        {
            Text = text;
            Answers = answers;
        }
    }
}