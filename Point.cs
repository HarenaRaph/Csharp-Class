using System;


namespace Devoir1
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }


        public Point( int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point(int X):this(X, 0) {}
        public Point(): this(0, 0) {}

        public void Nord()
        {
            if(this.Y > 0)
            {
                this.Y--;
            }
        }
        
        public void Sud()
        {
            if(this.Y < 10)
            {
                this.Y++;
            }
        }

        public void Est()
        {
            if (this.X < 10 )
            {
                this.X++;
            }
        }

        public void Ouest()
        {
            if (this.X > 0)
            {
                this.X--;
            }
        }

        public string directionX( int X_objectif)
        {
            int difference = this.X - X_objectif;
            string direction ="";
            if (difference != 0)
            {
                if(difference < 0)
                {
                    for(int i = 0; i < Math.Abs(difference); i++)
                    {
                        this.Est();
                        Console.WriteLine(this.X + " " + this.Y);
                        direction += "E";
                    }
                }else
                {
                    for (int i = 0; i < difference; i++)
                    {
                        this.Ouest();
                        Console.WriteLine(this.X + " " + this.Y);
                        direction += "O";
                    }
                }
            }
            return direction;
        }

        public string directionY( int Y_objectif)
        {
            int difference = this.Y - Y_objectif;
            string direction = "";
            if (difference != 0)
            {
                if (difference < 0)
                {
                    for (int i = 0; i < Math.Abs(difference); i++)
                    {
                        this.Sud();
                        Console.WriteLine(this.X + " " + this.Y);
                        direction += "S";
                    }
                }
                else
                {
                    for (int i = 0; i < difference; i++)
                    {
                        this.Nord();
                        Console.WriteLine(this.X + " " + this.Y);
                        direction += "N";
                    }
                }
            }
            return direction;
        }

    }
}
