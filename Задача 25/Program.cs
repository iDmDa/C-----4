//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

#nullable disable

var cons_color = new Dictionary<string, int>();
for (int i = 0; i < 16; i++) cons_color.Add(((ConsoleColor)i).ToString(), i);

void msg_style (string message, string status = "Green") {
    //Black, DarkBlue, DarkGreen, DarkCyan, 
    //DarkRed, DarkMagenta, DarkYellow, Gray, 
    //DarkGray, Blue, Green, Cyan, 
    //Red, Magenta, Yellow, White

    Console.ForegroundColor = (ConsoleColor)cons_color[status];
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

int enter_number (string info) {
    for(;;) {

        Console.Write(info);
        string a = Console.ReadLine();

        if(a.ToLower() == "q") System.Environment.Exit(0);

        if(!Int32.TryParse(a, out int a_int)) {
            msg_style("Ошибка! Введено не число!", "DarkRed");
            continue;
        };
        return a_int;
    }
}


msg_style("Введите основание степени (для выхода введите 'q')", "Blue");
int a = enter_number ("A: ");
msg_style("Введите показатель степени (для выхода введите 'q')", "Blue");
int b = enter_number ("B: ");

msg_style($"{a}, {b} -> {Math.Pow(a, b)}", "Green");
