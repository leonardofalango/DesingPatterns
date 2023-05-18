namespace ProjectPatterns;


// For const and unique objects
public class Flyweight
{
    private static Object? ObjectA_;
    public static Object ObjectA
    {
        get
        {
            if (ObjectA_ == null)
                ObjectA_ = new Object();
            return ObjectA_;
        }
        private set {}
    }

    private static double[][]? matrix;
    public static double[][] Matrix
    {
        get
        {
            if (matrix == null)
                matrix = new double[][] {
                    new double[] {1.0d, 0d, 0d},
                    new double[] {0d, 1.0d, 0d},
                    new double[] {0d, 0d, 1.0d},
                };
            return matrix;
        }
        private set {}
    }
    
}