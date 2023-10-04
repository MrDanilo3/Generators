using System.Text;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Тести для псевдовипадково згенерованих послідовностей";

            ShowTestOptions();

            string choiceTest = Console.ReadLine();
            Console.WriteLine();

            if (int.TryParse(choiceTest, out int result))
            {
                switch (result)
                {
                    case 1:
                        TestMonobit();
                        break;
                    case 2:
                        TestTwobit();
                        break;
                    case 3:
                        TestPoker();
                        break;
                    case 4:
                        TestSeries();
                        break;
                    case 5:
                        TestAutocorrelation();
                        break;
                    default:
                        Console.WriteLine("Некоректне введення. Має бути введено число від 1 - 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некоректне введення. Має бути введено число від 1- 7.");
            }
        }

        static void ShowTestOptions()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine("Оберіть тест:");
            stringBuilder.AppendLine("1 - Монобітний тест");
            stringBuilder.AppendLine("2 - Тест двобітних серій");
            stringBuilder.AppendLine("3 - Тест Покера");
            stringBuilder.AppendLine("4 - Тест серій");
            stringBuilder.AppendLine("5 - Автокореляційний тест");
            Console.WriteLine(stringBuilder.ToString());
        }

        static void TestMonobit()
        {
            List<int> listOne = Generators.NumbersGenerator(100);
            List<int> listTwo = Generators.NumbersGenerator(1000000);
            List<int> listThree = Generators.NumbersGenerator(1000000000);

            StringBuilder sb = new();
            sb.AppendLine("Монобітний тест:");
            sb.AppendLine("\nРозмір вибірки - 100");
            double monobitOne = MonobitTest.Monobit(listOne);
            sb.AppendLine("Статистичний параметер - " + monobitOne.ToString());
            sb.AppendLine(TestMonobitPassed(monobitOne));
            sb.AppendLine("\nРозмір вибірки - 1000000");
            double monobitTwo = MonobitTest.Monobit(listTwo);
            sb.AppendLine("Статистичний параметер - " + monobitTwo.ToString());
            sb.AppendLine(TestMonobitPassed(monobitTwo));
            sb.AppendLine("\nРозмір вибірки - 1000000000");
            double monobitThree = MonobitTest.Monobit(listThree);
            sb.AppendLine("Статистичний параметер - " + monobitThree.ToString());
            sb.AppendLine(TestMonobitPassed(monobitThree));
            Console.WriteLine(sb.ToString());
        }

        static void TestTwobit()
        {
            List<int> listOne = Generators.NumbersGenerator(100);
            List<int> listTwo = Generators.NumbersGenerator(1000000);
            List<int> listThree = Generators.NumbersGenerator(1000000000);

            StringBuilder sb = new();
            sb.AppendLine("Тест двобітних серій:");
            sb.AppendLine("\nРозмір вибірки - 100");
            double twobitOne = TwoBitTest.TwoBit(listOne);
            sb.AppendLine("Статистичний параметер - " + twobitOne.ToString());
            sb.AppendLine(TestTwobitPassed(twobitOne));
            sb.AppendLine("\nРозмір вибірки - 1000000");
            double twobitTwo = TwoBitTest.TwoBit(listTwo);
            sb.AppendLine("Статистичний параметер - " + twobitTwo.ToString());
            sb.AppendLine(TestTwobitPassed(twobitTwo));
            sb.AppendLine("\nРозмір вибірки - 1000000000");
            double twobitThree = TwoBitTest.TwoBit(listThree);
            sb.AppendLine("Статистичний параметер - " + twobitThree.ToString());
            sb.AppendLine(TestTwobitPassed(twobitThree));
            Console.WriteLine(sb.ToString());
        }

        static void TestPoker()
        {
            List<int> listOne = Generators.NumbersGenerator(100);
            List<int> listTwo = Generators.NumbersGenerator(1000000);
            List<int> listThree = Generators.NumbersGenerator(1000000000);

            StringBuilder sb = new();
            sb.AppendLine("Тест Покера:");
            sb.AppendLine("\nРозмір вибірки - 100");
            double pokerOne = PokerTest.Poker(listOne);
            sb.AppendLine("Статистичний параметер - " + pokerOne.ToString());
            sb.AppendLine(TestPokerPassed(pokerOne));
            sb.AppendLine("\nРозмір вибірки - 1000000");
            double pokerTwo = PokerTest.Poker(listTwo);
            sb.AppendLine("Статистичний параметер - " + pokerTwo.ToString());
            sb.AppendLine(TestPokerPassed(pokerTwo));
            sb.AppendLine("\nРозмір вибірки - 1000000000");
            double pokerThree = PokerTest.Poker(listThree);
            sb.AppendLine("Статистичний параметер - " + pokerThree.ToString());
            sb.AppendLine(TestPokerPassed(pokerThree));
            Console.WriteLine(sb.ToString());
        }

        static void TestSeries()
        {
            List<int> listOne = Generators.NumbersGenerator(100);
            List<int> listTwo = Generators.NumbersGenerator(1000000);
            List<int> listThree = Generators.NumbersGenerator(1000000000);

            StringBuilder sb = new();
            sb.AppendLine("Тест серій:");
            sb.AppendLine("\nРозмір вибірки - 100");
            double seriesOne = SeriesTest.Series(listOne);
            sb.AppendLine("Статистичний параметер - " + seriesOne.ToString());
            sb.AppendLine(TestSeriesPassed(seriesOne));
            sb.AppendLine("\nРозмір вибірки - 1000000");
            double seriesTwo = SeriesTest.Series(listTwo);
            sb.AppendLine("Статистичний параметер - " + seriesTwo.ToString());
            sb.AppendLine(TestSeriesPassed(seriesTwo));
            sb.AppendLine("\nРозмір вибірки - 1000000000");
            double seriesThree = SeriesTest.Series(listThree);
            sb.AppendLine("Статистичний параметер - " + seriesThree.ToString());
            sb.AppendLine(TestSeriesPassed(seriesThree));
            Console.WriteLine(sb.ToString());
        }

        static void TestAutocorrelation()
        {
            List<int> listOne = Generators.NumbersGenerator(100);
            List<int> listTwo = Generators.NumbersGenerator(1000000);
            List<int> listThree = Generators.NumbersGenerator(1000000000);

            StringBuilder sb = new();
            sb.AppendLine("Автокореляційний тест:");
            sb.AppendLine("\nРозмір вибірки - 100");
            double autocorrelationOne = AutocorrelationTest.Autocorrelation(listOne);
            sb.AppendLine("Статистичний параметер - " + autocorrelationOne.ToString());
            sb.AppendLine(TestAutocorrelationPassed(autocorrelationOne));
            sb.AppendLine("\nРозмір вибірки - 1000000");
            double autocorrelationTwo = AutocorrelationTest.Autocorrelation(listTwo);
            sb.AppendLine("Статистичний параметер - " + autocorrelationTwo.ToString());
            sb.AppendLine(TestAutocorrelationPassed(autocorrelationTwo));
            sb.AppendLine("\nРозмір вибірки - 1000000000");
            double autocorrelationThree = AutocorrelationTest.Autocorrelation(listThree);
            sb.AppendLine("Статистичний параметер - " + autocorrelationThree.ToString());
            sb.AppendLine(TestAutocorrelationPassed(autocorrelationThree));
            Console.WriteLine(sb.ToString());
        }


        static string TestMonobitPassed(double result)
        {
            return result <= 3.84 ? $"Тест пройдено {result} <= 3.84. Гіпотеза не відкидається."
                                   : $"Тест не пройдено {result} > 3.84. Гіпотеза відкидається.";
        }

        static string TestTwobitPassed(double result)
        {
            return result <= 5.99 ? $"Тест пройдено {result} <= 5.99. Гіпотеза не відкидається."
                                   : $"Тест не пройдено {result} > 5.99. Гіпотеза відкидається.";
        }

        static string TestPokerPassed(double result)
        {
            return result <= 14.076 ? $"Тест пройдено {result} <= 14.076. Гіпотеза не відкидається."
                                    : $"Тест не пройдено {result} > 14.076. Гіпотеза відкидається.";
        }

        static string TestSeriesPassed(double result)
        {
            return result <= 5.99 ? $"Тест пройдено {result} <= 5.99. Гіпотеза не відкидається."
                                  : $"Тест не пройдено {result} > 5.99. Гіпотеза відкидається.";
        }

        static string TestAutocorrelationPassed(double result)
        {
            return result >= -2.17 && result <= 2.17 ? $"Тест пройдено -2.17 <= {result} <= 2.17. Гіпотеза не відкидається."
                                                     : $"Тест не пройдено {result} не знаходиться в діапазоні [-2.17 ; 2.17]. Гіпотеза відкидається.";
        }


    }
}

