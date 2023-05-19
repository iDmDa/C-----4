//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

string enter_number (string info) {
    for(;;) {

        Console.Write(info);
        string a = Console.ReadLine();

        if(a.ToLower() == "q") System.Environment.Exit(0);

        if(!Int32.TryParse(a, out int a_int)) {
            msg_style("Ошибка! Введено не число!", "DarkRed");
            continue;
        };
        return a;
    }
}

int summ (string a) {
    int summ = 0;
    foreach(char item in a)
    {
        summ += Convert.ToInt32(item.ToString());
    }
    return summ;
}


msg_style("Введите число (для выхода введите 'q')", "Blue");
string a = enter_number ("Число: ");
msg_style($"{string.Join(" + ", a.ToCharArray())} = {summ(a)}", "Green");

