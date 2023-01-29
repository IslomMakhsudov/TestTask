using FigureAreaCalculator.Figures;

Console.WriteLine("Write Type of Figure: ");
var figureName = Console.ReadLine().ToLower();

Figure? figure = null;

try
{
    figure = figureName switch
    {
        "triangle" => new Triangle(2, 3, 5),
        "circle" => new Circle(4),
        _ => throw new KeyNotFoundException("Invalid figure type"),
    };
}
catch(KeyNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

if(figure != null)
{
    var figureArea = figure.CalculateArea();
    var figureIsRightAngeleg = figure.IsRightAngled();

    
    Console.WriteLine($"{figureName} area: " + figureArea);
    Console.WriteLine($"{figureName} is right angeled: " + figureIsRightAngeleg);
}

Console.ReadLine();
