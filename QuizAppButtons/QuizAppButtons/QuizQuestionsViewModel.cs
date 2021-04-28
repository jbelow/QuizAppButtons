using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppButtons
{
    public class QuizQuestionsViewModel
    {


        public QuizQuestionsViewModel(string title, bool answer, string image)
        {

            Title = title;
            Answer = answer;
            Image = image;
        }

        public string Title { private set; get; }

        public bool Answer { private set; get; }

        public string Image { private set; get; }

        static QuizQuestionsViewModel()
        {
            All = new List<QuizQuestionsViewModel>
            {

                new QuizQuestionsViewModel("Are Husky puppies the cutest ever?", true, "puppy.jpg"),

                new QuizQuestionsViewModel("Is this a good question?", false, "questionmark.jpg"),

                new QuizQuestionsViewModel("Did Joshua Below write this code?", true, "josh.png"),

                new QuizQuestionsViewModel("is this a quiz?", true, "quiz.jpg"),

                new QuizQuestionsViewModel("Is there 28 hours in a day?", false, "hours.jpg"),


            };
        }

        public static IList<QuizQuestionsViewModel> All { private set; get; }


    }

}
