using System;
namespace Pattern
{
    //Client Code
    //Logger l1 = Logger.GetLogger();
    //Logger l2 = Logger.GetLogger();
    //Console.WriteLine(l1==l2);

    public class Logger
    {
        private static Logger instance;
        private Logger()
        {

        }
        public static Logger GetLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }
    }
}
