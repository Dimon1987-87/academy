


//TestVariables();

//Dates();

RandomNumbers();
void RandomNumbers()
{
    var rand = new Random();
    var r1 = rand.Next();
    var r2 = rand.Next(100);
    var r3 = rand.Next(100,1000);
    var r4 = rand.NextDouble();
    Console.ReadLine();
}

/*
void Dates()
{
    var datetime = DateTime.Now;
    var date = DateOnly.FromDateTime(datetime);
    var time = TimeOnly.FromDateTime(datetime);
    Console.WriteLine(" Input date: ");
    var strDate = Console.ReadLine();
    DateOnly.TryParse(strDate, out date );
    Console.ReadLine();
}

*/


/*

void TestVariables()
{
    //data types
    int value1 = 5;
    double v2 = 5.8;
    string str = "123";
    bool b = true;
    // var
    var someint = 5;
    var somedouble = 4.9;
    var mul = someint * somedouble;

    int sum = value1 + someint;
    Console.WriteLine("sum res" + sum);
    Console.WriteLine("mul res" + mul);
}*/