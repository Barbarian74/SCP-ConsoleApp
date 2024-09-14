using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace SCPFoundationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение состояния комплекса
            string уровеньУгрозы = "Grün";
            bool зонаЛегкогоСодержанияАктивна = true;
            bool зонаТяжелогоСодержанияАктивна = true;

            int rickrollProgress = 0;

            // Получаем путь к папке "sound"
            string soundFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound");

            // Создаем объекты SoundPlayer для каждого звука
            SoundPlayer звукЛегкого = new SoundPlayer(Path.Combine(soundFolderPath, "звук_легкого_содержания.wav"));
            SoundPlayer звукТяжелого = new SoundPlayer(Path.Combine(soundFolderPath, "звук_тяжелого_содержания.wav"));
            SoundPlayer codeblack = new SoundPlayer(Path.Combine(soundFolderPath, "codeblack.wav"));
            SoundPlayer codeblacke = new SoundPlayer(Path.Combine(soundFolderPath, "codeblacke.wav"));
            SoundPlayer codeblackd = new SoundPlayer(Path.Combine(soundFolderPath, "codeblackd.wav"));
            SoundPlayer echo = new SoundPlayer(Path.Combine(soundFolderPath, "echo.wav"));
            SoundPlayer rickroll = new SoundPlayer(Path.Combine(soundFolderPath, "rick.wav"));

            // КД для групп
            int[] cdГрупп = new int[3] { 0, 0, 0 }; // КД для Альфа-1, Тау-5, Епсилон-11

            // Основной цикл приложения
            while (true)
            {
                Console.Clear();

                // Вывод заголовка
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║           Konsole                 ║");
                Console.WriteLine("║           SCP-Komplex             ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                // Панель вызова мобильных оперативных групп
                Console.WriteLine("\n╔═══════════════════════════════════╗");
                Console.WriteLine("║       Trupprufleiste              ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("1. Alfa-1");
                Console.WriteLine("2. Tau-5");
                Console.WriteLine("3. Epsilon-11");

                // Панель изменения уровня угрозы
                Console.WriteLine("\n╔═══════════════════════════════════╗");
                Console.WriteLine("║      Bereich Bedrohungsänderungen ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                // Установка цвета для уровня угрозы
                switch (уровеньУгрозы)
                {
                    case "Grün":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "Gelb":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Rot":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "Schwarz":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                // Вывод уровня угрозы с цветом
                Console.WriteLine($"Aktuelles Niveau: {уровеньУгрозы}");
                Console.ResetColor(); // Сброс цвета

                Console.WriteLine("4. Grün");
                Console.WriteLine("5. Gelb");
                Console.WriteLine("6. Rot");
                Console.WriteLine("7. Schwarz");

                // Панель перезагрузки зон
                Console.WriteLine("\n╔═══════════════════════════════════╗");
                Console.WriteLine("║         Neustartleiste            ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine($"Bereich des leichten Unterhalts: {(зонаЛегкогоСодержанияАктивна ? "Aktiv" : "Abgeschaltet")}");
                Console.WriteLine($"Schwerbehinderter Bereich: {(зонаТяжелогоСодержанияАктивна ? "Aktiv" : "Abgeschaltet")}");
                Console.WriteLine("8. Einfache Inhaltszone neu laden");
                Console.WriteLine("9. Schwere Inhaltszone neu laden");

                // Ввод пользователя
                Console.Write("\nGeben Sie die Aktionsnummer ein: ");
                string ввод = Console.ReadLine();

                // Обработка выбора пользователя
                if (ввод == "Schwarz-1")
                {
                    codeblacke.Play();
                }
                else if (ввод == "Schwarz-2")
                {
                    codeblackd.Play();
                }
                else if (ввод == "ESIARCN2024")
                {
                    rickroll.Play();
                    rickrollProgress = 0; // Сбрасываем прогресс
                    Task.Run(() =>
                    {
                        // Создание текстового файла
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string filePath = Path.Combine(desktopPath, "Hausaufgaben auf Russisch.txt");
                        File.WriteAllText(filePath, "Du wurdest geschieden, du Scheißkerl! LEG DEINEN STIEFVATER AN DIE MUSCHI! ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА-ХА");

                        while (rickrollProgress < 100)
                        {
                            rickrollProgress++;
                            Console.WriteLine($"Hausaufgaben in Russisch herunterladen [6.9 TB]: {rickrollProgress}% von 100%");
                            Thread.Sleep(1500); // Задержка в 1500 миллисекунд
                        }
                        Console.WriteLine("Download abgeschlossen.");

                    });
                }
                else if (ввод == "Echo-14")
                {
                    echo.Play();
                }
                else
                {
                    // Обработка выбора пользователя из предыдущего кода:
                    try
                    {
                        int выбор = Convert.ToInt32(ввод); // Преобразуем ввод в целое число
                        switch (выбор)
                        {
                            case 1: // Альфа-1
                                if (cdГрупп[0] == 0)
                                {
                                    Console.WriteLine("Alpha-1 wurde gerufen");
                                    cdГрупп[0] = 20; // Установка КД на 20 секунд
                                    Thread thread = new Thread(() =>
                                    {
                                        Thread.Sleep(20000); // Пауза на 20 секунд
                                        cdГрупп[0] = 0; // Сброс КД
                                    });
                                    thread.Start();
                                }
                                else
                                {
                                    Console.WriteLine("Alpha-1 ist nicht verfügbar. Caldown: {0} Sekunden", cdГрупп[0]);
                                }
                                break;

                            case 2: // Тау-5
                                if (cdГрупп[1] == 0)
                                {
                                    Console.WriteLine("Tau-5 wurde gerufen");
                                    cdГрупп[1] = 20;
                                    Thread thread = new Thread(() =>
                                    {
                                        Thread.Sleep(20000);
                                        cdГрупп[1] = 0;
                                    });
                                    thread.Start();
                                }
                                else
                                {
                                    Console.WriteLine("Tau-5 ist nicht verfügbar. Caldown: {0} Sekunden", cdГрупп[1]);
                                }
                                break;

                            case 3: // Епсилон-11
                                if (cdГрупп[2] == 0)
                                {
                                    Console.WriteLine("Epsilon-11 wurde gerufen");
                                    cdГрупп[2] = 20;
                                    Thread thread = new Thread(() =>
                                    {
                                        Thread.Sleep(20000);
                                        cdГрупп[2] = 0;
                                    });
                                    thread.Start();
                                }
                                else
                                {
                                    Console.WriteLine("Epsilon-11 ist nicht verfügbar. Caldown: {0} Sekunden", cdГрупп[2]);
                                }
                                break;

                            case 4:
                                уровеньУгрозы = "Grün";
                                Console.WriteLine("Bedrohungsstufe auf Grün geändert");
                                break;
                            case 5:
                                уровеньУгрозы = "Gelb";
                                Console.WriteLine("Bedrohungsstufe auf Gelb geändert");
                                break;
                            case 6:
                                уровеньУгрозы = "Rot";
                                Console.WriteLine("Bedrohungsstufe auf Rot geändert");
                                break;
                            case 7:
                                уровеньУгрозы = "Schwarz";
                                Console.WriteLine("Bedrohungsstufe auf Schwarz geändert");
                                codeblack.Play(); // Проигрываем звук codeblack
                                break;
                            case 8:
                                зонаЛегкогоСодержанияАктивна = !зонаЛегкогоСодержанияАктивна;
                                Console.WriteLine($"Bereich des leichten Unterhalts {(зонаЛегкогоСодержанияАктивна ? "Eingeschaltet" : "Abgeschaltet")}");
                                звукЛегкого.Play();
                                break;
                            case 9:
                                зонаТяжелогоСодержанияАктивна = !зонаТяжелогоСодержанияАктивна;
                                Console.WriteLine($"Schwerbehinderter Bereich {(зонаТяжелогоСодержанияАктивна ? "Eingeschaltet" : "Abgeschaltet")}");
                                звукТяжелого.Play();
                                break;
                            default:
                                Console.WriteLine("Falsche Wahl");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Falsche Eingabe. Geben Sie eine Zahl zwischen 1 und 9 ein.");
                    }
                }

                Console.ReadKey();
            }
        }
    }
}