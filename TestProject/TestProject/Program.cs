using FigureAreaCalculator.Figures;

Console.WriteLine("Write Type of Figure: ");
var figureName = Console.ReadLine().ToLower();

Figure? figure = null;

try
{
    figure = figureName switch
    {
        "triangle" => new Triangle(5, 3, 5),
        "circle" => new Circle(4),
        _ => throw new KeyNotFoundException("Invalid figure type"),
    };
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

if(figure != null)
{
    var figureArea = figure.CalculateArea();
    var figureIsRightAngled = figure.IsRightAngled();

    
    Console.WriteLine($"{figureName} area: " + figureArea);
    Console.WriteLine($"{figureName} is right angled: " + figureIsRightAngled);
}

Console.ReadLine();
