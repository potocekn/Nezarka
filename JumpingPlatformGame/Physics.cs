namespace JumpingPlatformGame {

    public struct Meter
    {
        public double Value { get; set; }
        public Meter(double value)
        {
            this.Value = value;
        }

        public static Meter operator +(Meter m1, Meter m2)
        {
            return new Meter(m1.Value + m2.Value);
        }

        public static bool operator >(Meter m1, Meter m2)
        {   
            return m1.Value > m2.Value;
        }

        public static bool operator <(Meter m1, Meter m2)
        {
            return m1.Value < m2.Value;
        }

        public static MetersPerSeconds operator /(Meter m, Second s)
        {
            return new MetersPerSeconds(m.Value / s.Value);
        }

        public static Second operator /(Meter m, MetersPerSeconds mps)
        {
            return new Second(m.Value / mps.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }         
    }
    
    public struct Second
    {
        public double Value { get; set; }
        public Second(double value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public struct MetersPerSeconds
    {
        public double Value { get; set; }

        public MetersPerSeconds(double value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }       

         

        public static MetersPerSeconds operator -(MetersPerSeconds mps)
        {
            return new MetersPerSeconds(-mps.Value);
        }
      
        public static Meter operator *(MetersPerSeconds mps, Second s)
        { 
            return new Meter(mps.Value * s.Value);
        }      
    }

    //extensions
    static class MeterExtenssions
    {
        public static Meter Meters(this int value)
        {
            return new Meter(value);
        }
    }
    static class SecondExtenssions
    {
        public static Second Seconds(this int value)
        {
            return new Second(value);
        }

        public static Second Seconds(this double value)
        {
            return new Second(value);
        }
    }
    static class MetersPerSecondsExtenssions
    {
        public static MetersPerSeconds MeterPerSeconds(this int value)
        {
            return new MetersPerSeconds(value);
        }

        public static MetersPerSeconds MeterPerSeconds(this double value)
        {
            return new MetersPerSeconds(value);
        }
    }

}