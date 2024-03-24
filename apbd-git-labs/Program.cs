// See https://aka.ms/new-console-template for more information


using apbd_git_labs;

int[] numbers = [1, 2, 3, 4];
var avg = MathUtils.Avg(numbers);
var max = MathUtils.Max(numbers);

Console.WriteLine($"Avg : {avg}");
Console.WriteLine($"Max : {max}");
