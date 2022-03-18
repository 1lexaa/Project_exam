using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Text.Json;


namespace Project
{
    public class Game 
    {
        protected int _count = 0;
        List<Question> _questions = new List<Question>(); // Коллекция вопросов
 
        public void Init()
        {
            _questions.Add(new Question("Сколько ног у слона?", 1,4, "1","2","3","4"));
            _questions.Add(new Question("Сколько хвостов у слона?", 1,1, "1","2","3"));
            _questions.Add(new Question("Сколько глаз у слона?", 2, 2,"1","2","3","4"));
            Start();
            
        }

        protected async void Start()
        {
            for ( int i = 0 ; i < _questions.Count; i++)
            {
                Console.WriteLine(String.Concat(_questions[i].Name,
                "\r\n",_questions[i].GetAnswers()," "));


                int res = _questions[i].SetAnswers(Console.ReadLine());
                _count += res;
                if(res > 0)
                {
                    Console.WriteLine("Вверно!");
                }
                else 
                {
                    Console.WriteLine("Неверно");
                }
                Console.WriteLine("Ваш результат: " + _count);
            }
        }
    }





}