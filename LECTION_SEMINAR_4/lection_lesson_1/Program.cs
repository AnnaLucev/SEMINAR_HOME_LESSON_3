// Дан текст. В тексте необходимо все проблемы заменить черточками, маленькие буквы 'k' заменить большими 'К', а большие 'С' заменить маленькими 'с'.


string text = "Работая над четкостью и правильностью произнесения этих звуков, надо помнить, "
            + "что они не могут смягчиться и всегда, за редким исключением, "
            + "указанным в главе «Нормы литератур­ного произношения», произносятся твердо.";

string Replace(string text, char oldValue, char newValue)   // объявляем название и входные метода (функции)
{
    string result = String.Empty; // Закладываем пустую текстовую строку
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// Задаем условия замены в тексте (конкретика, примеры)

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine();    // задаем просто пустую строку (пробел)
newText = Replace(newText, 'С', 'с');

Console.WriteLine(newText);
