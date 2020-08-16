using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class Game
    {
        static string[] questions = new string[]
        {
                "David Beckham was a football player",
                "Liverpool FC are Premier League champions of the 19/20 season",
                "Shrewsbury Town FC have played in the Premier League",
                "Ronnie O'Sullivan is a cricket player"
        };

        bool[] answers = new bool[]
        {
                true,
                true,
                false,
                false
        };

        bool[] responses = new bool[questions.Length];

        int askingIndex = 0;

        public void PlayGame()
        {
            Intro();
            checkQuestionsandAnswersLength();
            AskQuestions();
            checkAnswers();
        }

        public void Intro()
        {
            Console.WriteLine("Welcome to my 'True or False' Game\n");
        }

        public void checkQuestionsandAnswersLength()
        {
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning");
            }
        }

        public void AskQuestions()
        {
            foreach (string question in questions)
            {
                bool isBool;
                bool inputBool;
                  
                Console.WriteLine(question);
                Console.WriteLine("True or False");
                string input = Console.ReadLine();
                Console.WriteLine("\n");
                

                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please enter true or false");

                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                    Console.WriteLine("\n");
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
                Console.Clear();
            }
            
        }

        public void checkAnswers()
        {
                int scoringIndex = 0;
                int score = 0;
                Console.WriteLine();
                foreach (bool answer in answers)
                {
                    bool response = responses[scoringIndex];

                    Console.Write(scoringIndex + 1 + ".");
                    Console.WriteLine($"You Entered: {response} | Correct Answer: {answer}");

                    if (response == answer)
                    {
                        score++;
                    }
                    scoringIndex++;
                }
                Console.WriteLine();
                Console.WriteLine($"You got {score} out of {questions.Length} correct");
                Console.ReadLine();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
        }
    }

 }

