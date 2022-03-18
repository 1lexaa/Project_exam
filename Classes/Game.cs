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
            _questions.Add(new Question("Итак, первый вопрос!На каком инструменте, как считается, играл древнерусский певец и сказитель Боян?", 1,1, "на гуслях","на виолончели","на баяне","на гитаре"));
            _questions.Add(new Question("Продолжаем игру. В какой из этих стран один из официальных языков - французский?", 1,1, "Республика Гаити","Кения","Эквадор","Венесуэла"));
            _questions.Add(new Question("В каком из этих фильмов не снимался Александр Абдулов?", 1, 2,"Карнавал","Московские каникулы","Чародеи","Убить дракона"));
            _questions.Add(new Question("В каком году произошла Куликовская битва?", 1, 1,"1380","1569","1616","1773"));
            _questions.Add(new Question("Вопрос номер пять. Кто автор музыки к детской песенке Чунга-Чанга?", 1, 1,"Шаинский","Зацепин","Дербенёв","Шпиц"));
            _questions.Add(new Question("Какая картина Малевича находится в Русском музее?", 1, 1,"Красный квадрат","Белый квадрат","Черный квадрат","Точильщик"));
            _questions.Add(new Question("Вы почти дошли до финала! Шкала Сковилла - это шкала оценки...", 1, 3,"Качество атмосферного воздуха","Привлекательности женщин","Остроты перца","Уровня моря"));
            _questions.Add(new Question("Восьмой вопрос! Какой титул имел Дон Кихот?", 1, 3,"Барон","Маркиз","Идальго","Вождь"));
            _questions.Add(new Question("Кто автор антиутопического романа 'О дивный новый мир'?",1,1,"Олдос Хаксли","Рэй Брэдбери","Джордж Оруэлл","Сомерсет Моэм"));
            _questions.Add(new Question("Решающий вопрос. Как называется самая глубокая точка поверхности Земли, находящаяся на дне Марианской впадины?",1,2,"Филиппинская плита","Бездна Челленджера","Кермадек","Черное логово"));




            Start();
            
        }

        protected  void Start()
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