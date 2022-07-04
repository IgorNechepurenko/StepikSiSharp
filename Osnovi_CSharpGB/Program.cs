// Console.WriteLine( "Эта программа поможет найти фильм, который будет вам по душе." );
// Console.WriteLine("Как вас зовут?");
// String name = Console.ReadLine();
			
// Console.WriteLine( "Здравствуте, " + name );

// Console.WriteLine( "Фильм какого жанра вы бы хотели посмотреть: комедия или драма" );
// String genre = Console.ReadLine();

// Console.WriteLine( "В таком случае, рекомендую посмотреть вам следуюдие фильмы:" );

// if (genre == "комедия" )
// 	{				
// 	Console.WriteLine( "* Иван Васильевич меняет профессию" );
// 	Console.WriteLine( "* Операция «Ы» и другие приключения Шурика" );
// 	Console.WriteLine( "* Назад в будущее" );
// 	Console.WriteLine( "* В джазе только девушки" );
// 	}
// 	else
// 	{
// 	Console.WriteLine( "* Зеленая миля" );
// 	Console.WriteLine( "* Побег из Шоушенка" );
// 	}

// Console.ReadLine();

string a = Console.ReadLine();
string b = Console.ReadLine();

int num1 = Int32.Parse(a);
int num2 = Int32.Parse(b);

int result = num1 + num2;
Console.WriteLine(result);
result = num1 * num2;
Console.WriteLine(result);
double average = (double)(num1 + num2) / 2;
Console.WriteLine(average);

Console.ReadLine();
