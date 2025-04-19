using Snake;

Coord gridDimensions = new Coord( 50,20);
Coord snakePos = new Coord(10,1);
Random rand = new Random();
Coord applePos = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
int frameDelaysMilli = 100;
Direction movementDirection = Direction.Down;
int score = 0;

List<Coord> snakePositionHistory = new List<Coord>();
int tailLength = 1;

while(true){
    Console.Clear();
    Console.WriteLine("Score: " + score);
    snakePos.ApplyMovementDirection(movementDirection);

 for ( int y = 0; y < gridDimensions.Y; y++){

    for ( int x = 0; x < gridDimensions.X; x++){
       
       Coord currentCoord = new Coord (x,y);

        if(snakePos.Equals(currentCoord) || snakePositionHistory.Contains(currentCoord)){
            Console.WriteLine("■");
        }
        else if(applePos.Equals(currentCoord)){
            Console.Write("a");
        }
        else if(x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1){
               Console.Write("#");
        }
        else{
            Console.Write(" ");
        }
       
    }
    Console.WriteLine();
 }
 if(snakePos.Equals(applePos)){
  tailLength++;
  score++;
  applePos = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
 }
 else if(snakePos.X == 0 || snakePos.Y == 0 || snakePos.X == gridDimensions.X - 1 || snakePos.Y == gridDimensions.Y - 1 || snakePositionHistory.Contains(snakePos)){
    
    score = 0;
    tailLength = 1;
    snakePos = new Coord(10,1);
    snakePositionHistory.Clear();
    movementDirection = Direction.Down;
    continue;
    
 };

 snakePositionHistory.Add( new Coord(snakePos.X, snakePos.Y));

 if(snakePositionHistory.Count > tailLength){ 
  snakePositionHistory.RemoveAt(0);
 };
 DateTime time = DateTime.Now;

 while((DateTime.Now - time).Milliseconds < frameDelaysMilli){
    if(Console.KeyAvailable){
            ConsoleKey key = Console.ReadKey().Key;

            switch(key){
                case ConsoleKey.LeftArrow:
                   movementDirection = Direction.Left;
                   break;
                   case ConsoleKey.RightArrow:
                   movementDirection = Direction.Right;
                   break;
                   case ConsoleKey.UpArrow:
                   movementDirection = Direction.Up;
                   break;
                   case ConsoleKey.DownArrow:
                   movementDirection = Direction.Down;
                   break;
            }
    }
  }
}