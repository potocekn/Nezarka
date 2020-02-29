using System.Drawing;

namespace JumpingPlatformGame {
    //test comment
    struct WorldPoint
    {
        public Meter X { get; set; }
        public Meter Y { get; set; }
    }

    struct Horizontal
    {
        public Meter LowerBound { get; set; }
        public Meter UpperBound { get; set; }
        public MetersPerSeconds Speed { get; set; }
    }

    struct Vertical
    {
        public Meter LowerBound { get; set; }
        public Meter UpperBound { get; set; }
        public MetersPerSeconds Speed { get; set; }
    }

    class Entity {
		public virtual Color Color => Color.Black;
        public WorldPoint Location;
        public virtual void Update(Second seconds) { }
    }   

	class MovableEntity : Entity {
        public Horizontal Horizontal;

        public override void Update(Second seconds)
        {
            Location.X += Horizontal.Speed * seconds;
            if (Location.X < Horizontal.LowerBound)
            {
                Horizontal.Speed = -Horizontal.Speed;
                Location.X = Horizontal.LowerBound;
            }
            if (Location.X > Horizontal.UpperBound)
            {
                Horizontal.Speed = -Horizontal.Speed;
                Location.X = Horizontal.UpperBound;
            }
        }
    }

	class MovableJumpingEntity : MovableEntity {
        public Vertical Vertical;

        public override void Update(Second seconds)
        {
            base.Update(seconds);
            Location.Y += Vertical.Speed * seconds;
            if (Location.Y < Vertical.LowerBound)
            {               
                Location.Y = Vertical.LowerBound;
            }
            if (Location.Y > Vertical.UpperBound)
            {
                Vertical.Speed = -Vertical.Speed;
                Location.Y = Vertical.UpperBound;
            }
        }
    }

	class Joe : MovableEntity {
		public override string ToString() => "Joe";
		public override Color Color => Color.Blue;
	}

	class Jack : MovableEntity {
		public override string ToString() => "Jack";
		public override Color Color => Color.LightBlue;
	}

	class Jane : MovableJumpingEntity {
		public override string ToString() => "Jane";
		public override Color Color => Color.Red;
	}

	class Jill : MovableJumpingEntity {
		public override string ToString() => "Jill";
		public override Color Color => Color.Pink;
	}

}