using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace QuizAppButtons
{
    public partial class MainPage : ContentPage
    {

        IList<QuizQuestionsViewModel> questions = new List<QuizQuestionsViewModel>();
        private int index;
        private int correct;
        private int wrong;

        public MainPage()
        {
            InitializeComponent();
        }

        void btnStartClicked(object sender, EventArgs args)
        {
            questions = QuizQuestionsViewModel.All;
            index = 0;
            theLabel.Text = questions[index].Title;
            theImage.Source = questions[index].Image;
            btnStart.IsVisible = false;
            btnTrue.IsVisible = true;
            btnFalse.IsVisible = true;
        }

        void btnTrueClicked(object sender, EventArgs args)
        {
            calculate(true);
        }

        void btnFalseClicked(object sender, EventArgs args)
        {
            calculate(false);
        }


        void calculate(bool btnAnswer)
        {
            if (index < questions.Count)
            {
                //theLabel.Text = e.Direction.ToString() + " " + index;
                
                if (questions[index].Answer == btnAnswer)
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }
                

            }

            if (index >= questions.Count - 1)
            {
                btnTrue.IsVisible = false;
                btnFalse.IsVisible = false;

                theLabel.Text = "You Answered: " + correct + " correct" + " / Wrong: " + wrong;
                theImage.Source = "finished.png";
                //this is for the if check on line 47
                index++;


            }
            else
            {
                index++;
                theLabel.Text = questions[index].Title;
                theImage.Source = questions[index].Image;
            }
        }
    }
}