using System;
using System.Collections.Generic;
using System.Linq;
namespace Millionaire_game
{
    class Program
    {
        static int score = 0;
        static void AnswerChecking(bool answer)
        {
            if (answer == true)
            {
                score += 10;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Answer is correct");
                System.Threading.Thread.Sleep(
                  (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
            }
            else
            {
                if (score == 0) score =0;
                else { score -= 10; }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong answer...");
                System.Threading.Thread.Sleep(
                  (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
            }
        }
        static void Questions()
        {
            //enum Renkler { Kirmizi, Yesil, Mavi };
            
            string[] questions = { "1)Qepiye gulle atan kimdir?", "2)Italiyanin paytaxti hansi seherdir?", "3)Caldiran doyusu necenci ilde bas vermisdir?", "4)Ingilizce xerite nece yazilir?", "5)15 sentyabr ne gunudur?", "6)Semed vurgun necenci ilde dogulmusdur?", "7)Kimyada gumus elementinin yazilisi necedir?", "8)Kohnelmis soz nece adlanir?", "9)Qiz qalasinin hundurluyu nece m dir?", "10)Biri ingilisceden penalty sozunun tercumesi deyil" };
            string[][] answers =
            {
               new string[] {"A)Kasib","B)Memur","C)Ingilis"},
               new string[]{ "A)London", "B)Sidney", "C)Roma" },
               new string[]{ "A)1510", "B)1614", "C)1514" },
               new string[]{ "A)Map", "B)Flag", "C)Arm" },
               new string[]{ "A)Qelebe", "B)Bilik", "C)Respublika" },
               new string[]{ "A)1910", "B)1906", "C)1912" },
               new string[]{ "A)Ag", "B)Hg", "C)Aq" },
               new string[]{ "A)Arxiv", "B)Arxaizm", "C)Terrorizm" },
               new string[]{ "A)28", "B)25", "C)26" },
               new string[]{ "A)Cerime", "B)Penalti", "C)Zerbe" },
            };
            for (int i = 0; i < 10; i++)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine(questions[i]);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(answers[i][j]);
                }
                Console.Write("Answer: ");
                char AnswerQuestion;AnswerQuestion = Convert.ToChar(Console.ReadLine());
                AnswerQuestion = char.ToUpper(AnswerQuestion);
                if (i == 0)
                {
                    if (AnswerQuestion == 'A') AnswerChecking(true);
                    else AnswerChecking(false); 
                }
                if (i == 1)
                {
                    if (AnswerQuestion == 'C') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 2)
                {
                    if (AnswerQuestion == 'C') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 3)
                {
                    if (AnswerQuestion == 'A') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 4)
                {
                    if (AnswerQuestion == 'B') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 5)
                {
                    if (AnswerQuestion == 'B') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 6)
                {
                    if (AnswerQuestion == 'A') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 7)
                {
                    if (AnswerQuestion == 'B') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 8)
                {
                    if (AnswerQuestion == 'A') AnswerChecking(true);
                    else AnswerChecking(false);
                }
                if (i == 9)
                {
                    if (AnswerQuestion == 'C') AnswerChecking(true);
                    else AnswerChecking(false);
                }
            }  
        }
        static void Main(string[] args)
        {
            Questions();
            Console.Clear();
            Console.WriteLine($"Quiz is end!!\nYour score: {score}");
        }
    }
}