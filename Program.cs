using System.Diagnostics;

namespace Vehicles
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Vehicles[] vehicles =
            {
                new Truck("MAN", 20),
                new Fighter("F-16", 100) {TypeOfConstruction = "A", MaxSpeed = 500},
                new Helicopter("Apachi", 50) {TypeOfConstruction = "B", MaxSpeed = 20}
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
                vehicle.Drive();
            }
        }

        public abstract class Vehicles
        {
            protected Vehicles(string model, float fuelConsumption)
            {
                Model = model;
                FuelConsumption = fuelConsumption;
            }

            public string Model { get; set; }
            protected float fuelConsumption;
            public abstract float FuelConsumption { get; set; }
            public abstract void Drive();

            public override string ToString()
            {
                return $"Model - {Model} | FuelConsumption - {FuelConsumption}";
            }
        }

        public class Truck : Vehicles
        {
            public Truck(string model, float fuelConsumption) : base(model, fuelConsumption)
            {
            }

            public override float FuelConsumption
            {
                get => fuelConsumption;
                set => fuelConsumption = value > 10 && value < 50 ? value : throw new Exception("Not valid FuelConsumption!");
            }

            public override void Drive()
            {
                Console.WriteLine("Грузовик едет.");
            }

            public override string ToString()
            {
                return $"{base.ToString()}";
            }
        }

        public abstract class Aircraft : Vehicles
        {
            public Aircraft(string model, float fuelConsumption) : base(model, fuelConsumption)
            {
            }
            protected string typeOfConstruction;
            public abstract string TypeOfConstruction { get; set; }

            protected float maxSpeed;
            public abstract float MaxSpeed { get; set; }

            public override string ToString()
            {
                return $"{base.ToString()} | TypeOfConstruction - {typeOfConstruction} | MaxSpeed - {maxSpeed}";
            }
        }

        public class Helicopter : Aircraft
        {
            public Helicopter(string model, float fuelConsumption) : base(model, fuelConsumption)
            {
            }

            public override string TypeOfConstruction { get; set; }
            public override float MaxSpeed
            {
                get => maxSpeed;
                set => maxSpeed = value > 0 && value < 100 ? value : throw new Exception("Not valid MaxSpeed!");
            }
            public override float FuelConsumption
            {
                get => fuelConsumption;
                set => fuelConsumption = value > 5 && value < 75 ? value : throw new Exception("Not valid FuelConsumption!");
            }

            public override void Drive()
            {
                Console.WriteLine("Вертолет летит.");
            }
        }

        public class Fighter : Aircraft
        {
            public Fighter(string model, float fuelConsumption) : base(model, fuelConsumption)
            {
            }

            public override string TypeOfConstruction { get; set; }
            public override float MaxSpeed
            {
                get => maxSpeed;
                set => maxSpeed = value > 50 && value < 700 ? value : throw new Exception("Not valid MaxSpeed!");
            }
            public override float FuelConsumption
            {
                get => fuelConsumption;
                set => fuelConsumption = value > 20 && value < 150 ? value : throw new Exception("Not valid FuelConsumption!");
            }

            public override void Drive()
            {
                Console.WriteLine("Истребитель летит.");
            }
        }
    }*/

    /*public class AdditionalTask1
    {
        static void Main()
        {
            Person[] people =
            {
                new Employee("Джо", "Senior Dev"),
                new Client("Олег", 10_000m)
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.DisplayInfo());
            }
        }

        public abstract class Person
        {
            protected string name;

            protected Person(string name)
            {
                this.name = name;
            }

            public abstract string DisplayInfo();
        }

        public class Employee : Person
        {
            private string position;

            public Employee(string name, string position) : base(name)
            {
                this.position = position;
            }

            public override string DisplayInfo()
            {
                return $"Имя - {name}, Должность - {position}";
            }
        }

        public class Client : Person
        {
            private decimal balance;
            public Client(string name, decimal balance) : base(name)
            {
                this.balance = balance;
            }

            public override string DisplayInfo()
            {
                 return $"Имя - {name}, Баланс на счете - {balance}";
            }
        }
    }*/

    /*public class AdditionalTask2
    {
        static void Main()
        {
            Body[] bodies =
            {
                new Parallelepiped(10, 5, 7),
                new Ball(5)
            };

            foreach (var body in bodies)
            {
                Console.WriteLine($"Площадь - {body.Square()}, Объём - {body.Volume()}");
            }
        }

        public abstract class Body
        {
            public abstract double Square();
            public abstract double Volume();
        }

        public class Parallelepiped : Body
        {
            public Parallelepiped(double a, double b, double c)
            {
                A = a;
                B = b;
                H = c;
            }

            public double A { get; set; }
            public double B { get; set; }
            public double H { get; set; }

            public override double Square()
            {
                return 2 * (A * B + B * H + A * H);
            }

            public override double Volume()
            {
                return A * B * H;
            }
        }

        public class Ball : Body
        {
            public Ball(double r)
            {
                R = r;
            }

            public double R { get; set; }

            public override double Square()
            {
                return 4 * Math.PI * Math.Pow(R, 2);
            }

            public override double Volume()
            {
                return (double)4 / 3 * Math.PI * Math.Pow(R, 3);
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main()
        {
            Ticket[] tickets =
            {
                new RegularTicket(5),
                new LuxuryTicket(25),
            };

            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.Info());
            }
        }

        public abstract class Ticket
        {
            protected decimal price;

            protected Ticket(decimal price)
            {
                this.price = price;
            }

            public abstract decimal Price { get; set; }

            public abstract string Info();
        }

        public class RegularTicket : Ticket
        {
            public RegularTicket(decimal price) : base(price)
            {
            }

            public override decimal Price 
            { 
                get => price; 
                set => price = value > 0 && value < 10 ? value : throw new Exception("Not valid Price"); 
            }

            public override string Info()
            {
                return $"Билет обычного автобуса стоимостью {Price}$";
            }
        }

        public class LuxuryTicket : Ticket
        {
            public LuxuryTicket(decimal price) : base(price)
            {
            }

            public override decimal Price
            {
                get => price;
                set => price = value > 10 && value < 100 ? value : throw new Exception("Not valid Price");
            }
            public override string Info()
            {
                return $"Билет автобуса с повышенной комфортностью стоимостью {Price}$";
            }

        }
    }*/

    /*public class AdditionalTask4and5
    {
        static void Main()
        {
            Triangle figure = new TriangleColor("Triangle", 10, 7, 6, "red");

            double a = 0, b = 0, c = 0;

            figure.GetABC(ref a, ref b, ref c);

            Console.WriteLine($"{a} | {b} | {c}");

            Console.WriteLine(figure.Print());
            Console.WriteLine(figure.Area2);
            Console.WriteLine(figure.Area());
        }

        public abstract class Figure
        {
            protected string name;

            protected Figure(string name)
            {
                this.name = name;
            }

            public string Name { get => name; set => name = value; }

            public abstract double Area2 { get; }

            public abstract double Area();

            public virtual string Print()
            {
                return $"Name - {name}";
            }
        }

        public class Triangle : Figure
        {
            protected double a;
            protected double b;
            protected double c;

            public Triangle(string name, double a, double b, double c) : base(name)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public void SetABC(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public void GetABC(ref double a, ref double b, ref double c)
            {
                a = this.a;
                b = this.b;
                c = this.c;
            }

            public override double Area2 
            {
                get
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }

            public override double Area()
            {
                return Area2;
            }

            public override string Print()
            {
                return $"{base.Print()} | a = {a} | b = {b} | c = {c}";
            }
        }

        public class TriangleColor : Triangle
        {
            private string color;

            public TriangleColor(string name, double a, double b, double c, string color) : base(name, a, b, c)
            {
                this.color = color;
            }
            public string Color { get => color; set => color = value; }
            public override string Print()
            {
                return $"{base.Print()} | color = {color}";
            }
        }
    }*/

    /*public class AdditionalTask6
    {
        static void Main()
        {
            Random random = new Random();

            Figure[] figures = new Figure[1250];

            int circleIndex = random.Next(0, figures.Length);
            figures[circleIndex] = new Circle() { R = 10 };

            for (int i = 0; i < figures.Length; i++)
            {
                if (i == circleIndex)
                {
                    continue;
                }
                int figureNumber = random.Next(0, 2);
                if (figureNumber == 0)
                {
                    figures[i] = new Square() { A = random.Next(1, 10), B = random.Next(1, 10) };
                }
                else if (figureNumber == 1)
                {
                    figures[i] = new Triangle() { A = random.Next(1, 10), B = random.Next(1, 10), C = random.Next(1, 10) };
                }
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (Figure figure in figures)
            {
                if(figure is Circle circle)
                {
                    Console.WriteLine(circle.Info());
                }
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);
        }

        public abstract class Figure
        {
            public virtual string Name { get; set; }
            public virtual string Info()
            {
                return $"Name - {Name}";
            }
        }

        public class Square : Figure
        {
            public override string Name { get; set; } = "Square";
            public double A { get; set; }
            public double B { get; set; }

            public override string Info()
            {
                return $"{base.Info()} | A = {A} | B = {B}";
            }
        }

        public class Circle : Figure
        {
            public override string Name { get; set; } = "Circle";
            public double R { get; set; }

            public override string Info()
            {
                return $"{base.Info()} | Radius = {R}";
            }
        }

        public class Triangle : Figure
        {
            public override string Name { get; set; } = "Triangle";
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public override string Info()
            {
                return $"{base.Info()} | A = {A} | B = {B} | C = {C}";
            }
        }
    }*/

    /*public class AdditionalTask7
    {
        static void Main()
        {
            Edition[] catalogue =
            {
                new Book("Book", "Joel", 1999, "Walter"),
                new Article("Article", "Kira", "Smith", 23, 2012),
                new ElectronicResource("ER1", "Izkal", "https.com.s", "yes"),
                new ElectronicResource("ER2", "Izkal", "dsdfsdm.sda", "no"),
                new Book("Book2", "Mena", 1875, "Marion"),
                new Article("Article2", "Mgff", "dsfg", 23423, 1993),
                new Book("Book3", "FDMD", 2043, "gfdngie"),
                new Book("Book4", "ALLk", 1999, "fdsufgid"),
            };

            foreach (var catalog in catalogue)
            {
                Console.WriteLine(catalog.Info());
            }

            Console.WriteLine("\n\nПОИСК ИЗДАНИЙ ПО АВТОРУ\n\n");

            Edition[] editions = FindByAuthorSurname(catalogue, "Izkal");
            foreach (Edition edition in editions)
            {
                Console.WriteLine(edition.Info());
            }
        }

        public static Edition[] FindByAuthorSurname(Edition[] editions, string surname)
        {   
            int requiredCount = 0;
            for (int i = 0, j = 0; i < editions.Length; i++)
            {
                if (editions[i].AuthorSurname == surname)
                {
                    requiredCount++;
                }
            }

            Edition[] requiredEditions = new Edition[requiredCount];

            for (int i = 0, j = 0; i < editions.Length; i++)
            {
                if (editions[i].AuthorSurname == surname)
                {
                    requiredEditions[j++] = editions[i];
                }
            }
            return requiredEditions;
        }

        public abstract class Edition
        {
            protected Edition(string title, string authorSurname)
            {
                Title = title;
                AuthorSurname = authorSurname;
            }

            public string Title { get; set; }
            public string AuthorSurname { get; set; }
            public virtual string Info()
            {
                return $"Title - {Title} | Author Surname - {AuthorSurname}";
            }
        }

        public class Book : Edition
        {
            public Book(string title, string authorSurname, int yearOfPublication, string publisher) : base(title, authorSurname)
            {
                YearOfPublication = yearOfPublication;
                Publisher = publisher;
            }

            public int YearOfPublication { get; set; }
            public string Publisher { get; set; }

            public override string Info()
            {
                return $"{base.Info()} | Year of Publication - {YearOfPublication} | Publisher - {Publisher}";
            }
        }

        public class Article : Edition
        {
            public Article(string title, string authorSurname, string magazineTitle, int magazineNumber, int yearOfPublication) : base(title, authorSurname)
            {
                MagazineTitle = magazineTitle;
                MagazineNumber = magazineNumber;
                YearOfPublication = yearOfPublication;
            }

            public string MagazineTitle { get; set; }
            public int MagazineNumber { get; set; }
            public int YearOfPublication { get; set; }

            public override string Info()
            {
                return $"{base.Info()} | Magazine Title - {MagazineTitle} | Magazine Number - {MagazineNumber} | " +
                    $"Year Of Publication - {YearOfPublication} ";
            }
        }

        public class ElectronicResource : Edition
        {
            public ElectronicResource(string title, string authorSurname, string link, string annotation) : base(title, authorSurname)
            {
                Link = link;
                Annotation = annotation;
            }

            public string Link { get; set; }
            public string Annotation { get; set; }

            public override string Info()
            {
                return $"{base.Info()} | Link - {Link} | Annotation - {Annotation}";
            }
        } 
    }*/
}
