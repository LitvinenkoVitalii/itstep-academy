using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Dictionary
{
    class Program
    {
        private static void DemoSpeech(string str1, string str2)
        {
            List<string> voices = new List<string>();
            int counter = 1;
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                voices.Add(voice.VoiceInfo.Name);
                Console.WriteLine($"{counter++}. {voice.VoiceInfo.Name} ({voice.VoiceInfo.Culture.Name})");
            }


            synthesizer.SelectVoice(voices[2]);

            synthesizer.Speak(str1);

            synthesizer.SelectVoice(voices[0]);

            synthesizer.Speak(str2);
        }

            static void Main(string[] args)
        {
            MyMap<string, string> dictionary = new MyMap<string, string>();
            int a = -1;

            do
            {
                a = -1;
                Console.Clear();
                Console.WriteLine($"Выберите действие: ");
                Console.WriteLine($"1 - Перевод слов: \n2 - Просмотр списка слов\n3 - Прочитать список слов\n0 - Выход");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        for (; ; )
                        {
                            Console.WriteLine("Для выхода введите \"exit\"");
                            Console.Write("Введите слово => _\b");
                            string question = Console.ReadLine().Trim().ToLower();
                            if (question == "exit")
                            {
                                break;
                            }
                            string answer;
                            if (dictionary.TryGetValue(question, out answer))
                            {
                                Console.WriteLine($"Перевод => {answer}");
                            }
                            else
                            {
                                Console.WriteLine($"Слово {question} отсутствует в словаре");
                                Console.Write("Введите перевод => _\b");
                                answer = Console.ReadLine().Trim().ToLower();
                                dictionary.Add(question, answer);


                            }


                        }
                        break;
                    case 2:
                        IEnumerator<KeyValuePair<string, string>> en1 = dictionary.GetEnumerator();
                        while (en1.MoveNext())
                        {
                            Console.WriteLine($"{en1.Current.Key} - {en1.Current.Value}\n");
                        }
                        Console.ReadKey();
                        break;


                    case 3:
                        IEnumerator<KeyValuePair<string, string>> en2 = dictionary.GetEnumerator();
                        while (en2.MoveNext())
                        {
                            DemoSpeech($"{en2.Current.Key}", $"{en2.Current.Value}");
                        }
                        break;
                    default:
                        if (a < 0 || a > 3)
                        {
                            Console.WriteLine("Некорректный ввод! \n");
                            Console.ReadKey();
                        }
                        

                        break;
                }

            } while (a != 0);
        }
    }
}

