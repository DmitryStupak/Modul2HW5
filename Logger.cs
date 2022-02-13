namespace Module2HW5
{
    public class Logger
    {
        private static Logger instance = new Logger();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void LogWrite(LogType log)
        {
            Console.WriteLine(log.ToString());
            AddToLog(log.ToString());
        }

        private static void AddToLog(string str)
        {
            FileService.CreateFile(str);
        }
    }
}
