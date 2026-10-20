using ScoreCalculator;

Console.WriteLine("Hello, World!");

Console.WriteLine(CalculateScore.Score([1])); //1 is an odd number, so, 3 will be the answer

Console.WriteLine(CalculateScore.Score([2])); //2 is an even number, so, 1 will the answer. 

Console.WriteLine(CalculateScore.Score([8])); // 8 is an even number, so, 5 + 1 = 6.

Console.WriteLine(CalculateScore.Score([1, 2, 3, 4, 5])); // 3 + 1 + 3 + 1 + 3 = 11

Console.WriteLine(CalculateScore.Score([6, 7, 8, 9, 10])); // 1 + 3 + 6 + 3 + 1 = 14

Console.WriteLine(CalculateScore.Score([1, 3, 5, 7, 9])); // 3 + 3 + 3 + 3 + 3 = 15

Console.WriteLine(CalculateScore.Score([2, 4, 6, 8, 10])); // 1 + 1 + 1 + 6 + 1 = 10


