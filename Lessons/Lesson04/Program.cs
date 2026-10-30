/*
char letter = 'X';              // char — ОДИН символ, одинарные кавычки
string name = "Андрей";         // string — текст, двойные кавычки

string normal   = "C:\\temp\\new";          // обычная: \ надо удваивать
string normal1   = "asd\"zxc";              // Смотрим что делает \" (просто выводит двойнуб кавычку
string verbatim = @"C:\temp\new";           // verbatim (@): \ — просто символ
string interp   = $"Температура: {1}";      // интерполяция ($): {выражение} подставляется

Console.WriteLine(normal1);
Console.WriteLine(@"C:\temp\new");

double temp = 23.456;
int sensorId = 3;
Console.WriteLine($"Датчик {sensorId}: {temp:F1} °C");   // Датчик 3: 23.5 °C
Console.WriteLine($"Норма: {temp < 30}");                 // внутри {} может быть любое выражение

bool isRunning = true;          // только true или false. 0 и 1 в C# не являются bool!

var     a = 5;     // тип int, компилятор вывел его сам. Навсегда int
object  b = 5;     // тип object: «коробка», в которой лежит int
dynamic c = 5;     // тип проверяется только во время ВЫПОЛНЕНИЯ

a = a + 1;         // ✅ int + int
a = "текст";       // ❌ ошибка КОМПИЛЯЦИИ: a — int, тип не меняется

b = b + 1;         // ❌ ошибка компиляции: object + int не определено
b = (int)b + 1;    // ✅ сначала достать int из «коробки» (приведение)
b = "текст";       // ✅ в object можно положить что угодно

c = c + 1;         // ✅ компилятор не проверяет
c = "текст";       // ✅ можно
c.FlyToMoon();     // ✅ КОМПИЛИРУЕТСЯ!.. и падает при запуске: RuntimeBinderException

var sensors = new List<PressureSensor>();   // ✅ тип очевиден из правой части
var count = GetCount();                     // 🤔 непонятно: int? long? Лучше указать тип явно

int     i = default;     // 0
bool    f = default;     // false
string? s = default;     // null
double  d = default;     // 0

Console.WriteLine("C:\temp\new");
Console.WriteLine("C:\\temp\\new");
Console.WriteLine(@"C:\\temp\\new");
*/

double[] temps =
{
    2.99,
    3.11,
    2.96,
    3.06,
    2.89
};
Console.WriteLine("Программа температура:");
double sum = 0;
double max = temps[0];
for (int i = 0; i < temps.Length; i++)
{
    Console.WriteLine($"Замер{i + 1}: {temps[i]:F2}°C");
    sum += temps[i];
    if (temps[i] > max)
    {
        max = temps[i];
    }
}

Console.WriteLine($"Среднее значение температур: {sum / temps.Length:F2}" +
                  $"\nМаксимальное значение: {max:F2}");
//var a = temp[temp.Length];

DateTime a = default;
Console.Write(a);
if(a == default) Console.WriteLine();