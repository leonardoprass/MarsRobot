using MarsRobot.Application;

Console.WriteLine("Please inform the plateau size. Ex: 5x5, 3x4");
string gridSize = Console.ReadLine()!;

Console.WriteLine("Please inform the multiple commands. Ex: LRFRRFF");
string instructions = Console.ReadLine()!;

var gridSizeSplit = gridSize.Split('x');

var board = new Board(Convert.ToInt32(gridSizeSplit[0]), Convert.ToInt32(gridSizeSplit[1]));
board.Navigate(instructions.ToUpper());

Console.WriteLine(board.GetResult());