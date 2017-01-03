using System;

namespace CGW
{
    public sealed class Settings
    {
        private static volatile Settings instance;
        private static object syncRoot = new Object();

        private Settings() { }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Settings();
                    }
                }

                return instance;
            }
        }

        public string Login { get; set; }
        public string Password { get; set; }

    }
}
