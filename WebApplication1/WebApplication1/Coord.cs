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

        /*public override bool Equals(object? obj)
        {
          if((obj == null) || !GetType().Equals(obj.GetType())){ 
                return false;


                Coord other = (Coord)obj;
                return other.x && y == other.y;
           }
        }*/
        public override bool Equals(object? obj)
        {
            // Check for null and type mismatch first
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Safely cast the object to Coord
            Coord other = (Coord)obj;

            // Compare the properties for equality
            return x == other.x && y == other.y; // Corrected comparison
        }

      }
    }