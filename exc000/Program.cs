// Methods

// Type 1:

void Meth1(){
    Console.WriteLine("made by scug");
}
Meth1();

// no return no args. used by typing it's name().

// Type 2: 

void Meth2(int count, string helo, string gooday){
    for (int i = 0; i < count; i++){
        Console.WriteLine($"hi {helo}");
    }
    Console.WriteLine(gooday);
}
Meth2(gooday: "how was your day???", count: 3, helo: "angy");

// no return YES args. use by calling args

// Type 3:

int Meth3(){
    return DateTime.Now.Year;
}
int year = Meth3();
Console.WriteLine(year);

// YES return no args. use by assigning to smthing

// Type 4:

string Meth4(int count, string text){
    string res = String.Empty;
    for (int i = 0; i < count; i++){
        res = res + text;
    }
    return res;
}
string result = Meth4(10, "h");
Console.Write(result);

// YES return YES args. use by doing your best