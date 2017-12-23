using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Lior_Yuval
{
    public sealed class SingeltonGameController
    {
        private static SingeltonGameController s_Instance = null;
        private static object s_LockObj = new Object();

        private SingeltonGameController() { }

        public static SingeltonGameController Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new SingeltonGameController();
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
