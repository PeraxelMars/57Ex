using System;
using System.ComponentModel.DataAnnotations;
using _57_Exercises.ViewModels;

namespace _57_Exercises.Models
{
    public class Ex32
    {
        public static int GetRandomRightNumber(Ex32ViewModel vm)
        {
            int rightNumber = 0;
            Random rand = new Random(DateTime.Now.Second);

            switch (vm.DifficultyLevel)
            {
                case 1:
                    rightNumber = rand.Next(0, 10);
                    break;

                case 2:
                    rightNumber = rand.Next(0, 100);
                    break;

                case 3:
                    rightNumber = rand.Next(0, 1000);
                    break;
            }
            return rightNumber;
        }

        public static AnswerStatus CheckAnswer(int answer, int rightNumber)
        {
            return answer == rightNumber
                ? AnswerStatus.Correct
                : answer < rightNumber
                    ? AnswerStatus.Low
                    : AnswerStatus.High;
        }
    }

    public enum AnswerStatus
    {
        Unknown,
        [Display(Name = "Too low")]
        Low,
        [Display(Name = "Too high")]
        High,
        Correct
    }
}