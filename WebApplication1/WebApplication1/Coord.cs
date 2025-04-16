using System;


 namespace Snake
   {

      internal class Coord{

        private int x;
        private int y;

        public int X { get{ return x; } }

        public int Y { get{ return y; } }

        public Coord(int x, int y){ 
            this.x = x;
            this.y = Y;

        }

        public override bool Equals(object? obj)
        {
          if((obj == null) || !GetType().Equals(obj.GetType())){ 
                return false;


                Coord other = (Coord)obj;
                return other.x && y == other.y;
           }
        }

      }
    }