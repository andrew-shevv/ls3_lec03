// alphabet soup

string broth = "В связи со сложной эпидемиологической ситуацией, складывающейся в мире, "
             + "и необходимостью поддержания в университете санитарно-эпидемиологического благополучия, "
             + "настоятельно рекомендуем Вам заранее позаботиться о получении медицинских справок и документов "
             + "в территориальных амбулаторно-поликлинических учреждениях по месту жительства.";

// string s = asdfgh
//            012345 -- text.Length
// s[3] // f

string stock(string meat, char alpha, char beta){
    string pot = String.Empty;
    for (int i = 0; i < meat.Length; i++){
        if (meat[i] == alpha){
            pot = pot + $"{beta}";
        }
        else pot = pot + $"{meat[i]}";
    }
    return pot;
}

string soup = stock(broth, ' ', '|');
soup = stock(soup, 'ь', 'Ъ');
soup = stock(soup, 'е', 'э');
soup = stock(soup, 'и', 'ы');
soup = stock(soup, 'я', 'а');
soup = stock(soup, 'ю', 'у');
Console.WriteLine(soup);