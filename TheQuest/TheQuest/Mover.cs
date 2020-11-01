using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Mover
    {
        private const int MoveInterval = 20;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;
        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && (Math.Abs(location.Y - locationToCheck.Y) < distance))
                return true;
            else
                return false;
        }
        public bool Nearby(Point enemyLocation, Point playerLocation, int distance)
        {
            if (Math.Abs(enemyLocation.X - playerLocation.X) < distance && (Math.Abs(enemyLocation.Y - playerLocation.Y) < distance))
                return true;
            else
                return false;
        }
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }
        public Point Move(Direction direction, Point playerLocation, Rectangle gameBoundaries)
        {
            Point newPlayerLocation = playerLocation;
            switch (direction)
            {
                case Direction.Up:
                    if (newPlayerLocation.Y - MoveInterval >= gameBoundaries.Top)
                    {
                        newPlayerLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newPlayerLocation.Y + MoveInterval <= gameBoundaries.Bottom)
                    {
                        newPlayerLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newPlayerLocation.X - MoveInterval >= gameBoundaries.Left)
                    {
                        newPlayerLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newPlayerLocation.X + MoveInterval <= gameBoundaries.Right)
                    {
                        newPlayerLocation.X += MoveInterval;
                    }
                    break;
                default: break;
            }

            return newPlayerLocation;
        }
    }
}
