using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TheRoadtoFameGame
{
    internal class Program
    {
        static void Consl()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }


        static void Main(string[] args)
        {
            Consl();
            string plot1 = "Тучи сгущаются над славным королеством Сишарпстании. Враги окружают нас повсюду, баги и злостные вирусы терзают наши замечательные, красивые коды. Наступает пора тени и мрака. И только настоящий девелопер, истинный герой, может помочь спасти королевство от краха.\nТак скажи же, путник, как тебя зовут?\nВведите имя персонажа:";
            foreach (char letter in plot1)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }

            Hero hero = new Hero("developer");
            hero.Name = Console.ReadLine();
            Console.WriteLine(hero.HeroInfo());
            Console.Clear();

            string plot2 = hero.Name + "? Неужели? Пророчество гласит, что некий путешественник, именующий себя " + hero.Name + ", прибудет в Сишарпстанию, дабы спасти всех нас от багучего гнёта. Пойдём со мной, путник, я должен тебе кое-что показать...\n";

            foreach (char letter in plot2)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            Console.WriteLine("Нажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }


            string plot3 = "Королевский советник отвёл Вас в покои правителя сквозь мрачный, но завораживающе красивый замок. За окном сияло ясное солнце, а король, склонившись над картой королевства, размышлял над государственными делами.\n-Ваше Премноговысочество... - тихо объявил советник. -Дело государственной важности! Я думаю, что мы нашли его...\nКороль, сразу поняв, о чём говорил советник, резко отстранился от своих дел, нахмурил брови и с лёгкой ноткой сомнения сказал.\n-Прошу тебя, Фридрих, перестань. Ты же сам прекрасно понимаешь, что всё это не более, чем простолюдинские небылицы.\n-Но Ваше Высочество, Вы должны послушать! Если верить пророчествам, то это действительно тот, кто нам нужен.\n-Я устал от этих небылиц, Фридрих, целыми днями я ищу решение наших проблем, а Вы предлагаете мне лишь тупых шарлатанов с их дешёвыми трюками. Хватит! Я устал от этого, - король тяжело выдохнул и оглядел Вас с ног до головы, - если ты и вправду так хорош, как он тебя нахваливает, то попробуй избавиться от призрака подмезелья. Держу пари, ты и двух с ним не протянешь.\n";
            foreach (char letter in plot3)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }

            string plot4 = "Подземелье встретило Вас мрачным видом и отвратительным запахом гнили: солнце еле светило сквозь редкие окна, через разрушенные стены протекала вода, а где-то вдали крысы доедали полуразложившийся труп одного из несчатных уздников катакомб.\nАккуратно, следя за каждым своим шагом, Вы пробирались сквозь тусклый мрак подземелий, держа в руке едва освещающий тьму фонарь. Хоть Вы спустились в подземелье совсем недавно, казалось, что прошло уже несколько часов: Вы петляли по множественным коридорам, охватывающим подземелья, сворачивали на поворатах, проходили через тайный ходы, пока в один момент не услышали странные звуки, доносящиеся из темноты.\nИз густой тьмы, издавая дьявольски страшные звуки, вырисовывался мрачный силуэт: он худой, высокого роста, но невероятно скрюченный, его большие жёлтые глаза ярко светились в темноте, а запах, исходящий от него, мог погубить и роту добротных королевских солдат.\nПродолжая идти вперёд, монстр полностью показался Вам на глаза. Это был... БОМЖ!\nСтарый, хромой и пропитый, с огромными синяками на глазах и мертвецки бледным цветом кожи, он больше походил на живой труп, нежели чем на человека. Долгие годы он плутал по подземельям, питаясь подвальными крысами и грибной плесенью.\nБомж выпрямился, оглядел Вас с ног до головы, ехидно ухмыльнулся, облизал губы и бросился на Вас с криком «ХИИИИЯ!»\n";
            foreach (char letter in plot4)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            Console.WriteLine("Нажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            Enemy enemy = new Enemy("bomzh");
            enemy.EnemyName = "Подземный бомж";
            string prefightintro = "Вам предстоит тяжкий бой с подземным бомжом. Ваш противник суров, а количество вашего здоровья ограничено. Следите за своими шагами и тщательно обдумывайте решения.\n";

            foreach (char letter in prefightintro)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            Console.WriteLine("Нажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }

            Random random = new Random();


            string choice = "Вам предстоит нанести первый ошеломляющий удар! Что вы хотите сделать?\n1)С размаху ударить бомжа мечом.\n2)Подпрыгнуть и в стиле ниндзя пнуть противника ногой.\n3)Мощным ударом кулака отпихнуть неприятеля в сторону.\n";
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(hero.HeroInfo());
            foreach (char letter in choice)
            {
                Console.Write(letter);
                Thread.Sleep(0);
            }
            int vybor = int.Parse(Console.ReadLine());
            Console.Clear();
            if (vybor == 1)
            {

                string vybor1 = "Со всего размаху Вы ударили бомжа мощной двуручной клейморой. Пусть познает вкус махакамской стали!\n";
                enemy.EnemyHP = enemy.EnemyHP - 30;
                foreach (char letter in vybor1)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }

            }
            else if (vybor == 2)
            {
                string vybor2 = "Закрутившись в изящном шаулиньском прыжке, Вы совершенно недооценили воздействие силы притяжение на человека и плашмя упали на землю. Больно, неприятно и обидно.\n";
                hero.HP = hero.HP - 10;
                foreach (char letter in vybor2)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            else if (vybor == 3)
            {
                string vybor3 = "Словно Майк Тайсон в свои лучшие годы, Вы пихнули кулаком бомжа в грудь, отчего тот с громким свистом упал на землю, больно ударившись головой о плитку.\n";
                enemy.EnemyHP = enemy.EnemyHP - 40;
                foreach (char letter in vybor3)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(enemy.EnemyInfo());
            Console.WriteLine("\nНажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            string bomzh = "Противник набрался сил и готов совершить свой ход. Бомж наносит ответный удар!\n";
            foreach (char letter in bomzh)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            vybor = random.Next(1, 4);
            if (vybor == 1)
            {
                string vybor1 = "С громким визгом бомж кинулся на Вас, царапая лицо и руки. Больше походит на драку с вшивым котом.\n";
                hero.HP = hero.HP - 30;
                foreach (char letter in vybor1)
                {
                    Console.Write(letter);
                    Thread.Sleep(0);
                }
            }
            else if (vybor == 2)
            {
                string vybor2 = "Подняв с земли небольшой камушек и размахнувшись, бомж кинул его Вам в лоб. Кровь течёт алым ручьём. Неприятно.\n";
                hero.HP = hero.HP - 40;
                foreach (char letter in vybor2)
                {
                    Console.Write(letter);
                    Thread.Sleep(0);
                }
            }
            else if (vybor == 3)
            {
                string vybor3 = "Собираясь нанести серию ошеломляющих ударов, бомж пять раз промахнулся, поскользнулся на луже и упал. Вы заливаетесь хохотом. Ваш боевой дух увеличен.\n";
                //Боевой дух чертовски поднят. Кстати, Вы и вправду читаете код? 
                enemy.EnemyHP = enemy.EnemyHP - 20;
                foreach (char letter in vybor3)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(enemy.EnemyInfo());
            Console.WriteLine("\nНажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            choice = "Кажется, что бомж начинает терять хватку - самое время ударить в ответ!\n1)Пырнуть бомжа в глаз.\n2)Облить бомжа токсичным зельем (ослиной мочой).\n3) Поставить ловкую подножку.\n";
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(enemy.EnemyInfo());
            foreach (char letter in choice)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            vybor = int.Parse(Console.ReadLine());
            Console.Clear();
            if (vybor == 1)
            {

                string vybor1 = "Метким ударом меча Вы выкололи глаз неприятелю. Бомж истошно катается по полу и кричит от боли. Кажется, ему это не понравилось.\n";
                enemy.EnemyHP = enemy.EnemyHP - 30;
                foreach (char letter in vybor1)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }

            }
            else if (vybor == 2)
            {
                string vybor2 = "Открыв флакон с истощающим прелестный аромат зельем, Вы вылили его прямо в лицо бомжу. Удивительно, но он не растаял. Кажется, с ним вообще ничего не случилось.\n";
                foreach (char letter in vybor2)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            else if (vybor == 3)
            {
                string vybor3 = "Одно ловкое движение ногой и бомж плашмя падает на пол. Противник унижен, а Вы довольны собой.\n";
                enemy.EnemyHP = enemy.EnemyHP - 20;
                foreach (char letter in vybor3)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(enemy.EnemyInfo());
            Console.WriteLine("\nНажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            bomzh = "Бомж явно недоволен Вашими успехами и собираеться что-то предпринять. Вы только поглядите на него!\n";
            foreach (char letter in bomzh)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            vybor = random.Next(1, 4);
            if (vybor == 1)
            {
                string vybor1 = "Словно настоящий борец, бомж кинулся Вам под дых и начал валить на землю. Вам повезло и Вы смогли выбраться, но осадочек-то остался...\n";
                hero.HP = hero.HP - 20;
                foreach (char letter in vybor1)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            else if (vybor == 2)
            {
                string vybor2 = "Неожиданно бомж выхватил заточку из кармана и полоснул Вас по шее. Вам стало больно.\n";
                hero.HP = hero.HP - 30;
                foreach (char letter in vybor2)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            else if (vybor == 3)
            {
                string vybor3 = "Бомж разбежался и замахнулся ногой в Вашу сторону, но поскользнулся на луже и с громким криком БЛЕААЫВАА упал в близлежащую канаву. Там ему и место.\n";
                enemy.EnemyHP = enemy.EnemyHP - 5;
                foreach (char letter in vybor3)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(enemy.EnemyInfo());
            Console.WriteLine("\nНажмите пробел, чтобы продолжить:");

            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            choice = "Кажется, что противник выбивается из сил. Пора нанести последний, ошеломляющий удар!\n1)Отрубить бомжу голову.\n2) С криком ЗА СПАРТУ пнуть бомжа в канаву.3)\nПощадить врага.";
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(hero.HeroInfo());
            foreach (char letter in choice)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }
            vybor = int.Parse(Console.ReadLine());
            Console.Clear();
            if (vybor == 1)
            {

                string vybor1 = "Мощным ударом меча Вы отселки противнику голову. Бомж повержен - ещё одна сил света!\n";
                enemy.EnemyHP = enemy.EnemyHP - 100;
                foreach (char letter in vybor1)
                {
                    Console.Write(letter);
                    Thread.Sleep(0);
                }

            }
            else if (vybor == 2)
            {
                string vybor2 = "С мощным рёвом и нечеловеской яростью в глазах Вы отпиннули противника в канаву. Бомж пролетел два метра, упал и сдох. Это победа!\n";
                hero.HP = enemy.EnemyHP - 50;
                foreach (char letter in vybor2)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            else if (vybor == 3)
            {
                string vybor3 = "Вы решали пощадить бедного бомжа и не стали его убивать. И вправду, зачем нужно всё это насилие? Под дружеский хохот и весёлые песни Вы уходите с бомжом вглубь подземелий...\n";
                foreach (char letter in vybor3)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }
            Console.WriteLine(hero.HeroInfo());
            Console.WriteLine(enemy.EnemyInfo());
            Console.WriteLine("\nНажмите пробел, чтобы продолжить:");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
            }
            Console.ReadKey();

            string win = "                                                Вы смогли победить силы зла и отстоять честь королевства - народ гордится Вами!";
            string lose = "                                               Вы проиграли, а Ваше бездыханное тело доедает подземный бомж. Стоит попытаться ещё!";

            if (enemy.EnemyHP <= 0)
            {
                foreach (char letter in win)
                {
                    Console.Write(letter);
                    Thread.Sleep(30);
                }
            }

            string end = "Игра закончена. Спасибо за прохождение!\nЧтобы выйти из игры, нажмите пробел.\nЧтобы вернуться в начало, нажмите Enter.";
            for (; ; )
            {
                foreach (char letter in end)
                {
                    Console.Write(end);
                    Thread.Sleep(30);
                }
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    Main(args);
                }
                else if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    break;
                }
                else
                    continue;

            }
        }
    }
}

