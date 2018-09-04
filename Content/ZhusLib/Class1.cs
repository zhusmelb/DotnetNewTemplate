﻿using System;
using com.zhusmelb.Util.Logging;

namespace ZhusLib
{
    public class Class1
    {
        private static readonly ILogger _log 
            = LogHelper.GetLogger(typeof(Class1).FullName);

#if (IsExe)
        public static void Main(string[] args) {
            _log.Info("Main starts ...");
            Console.WriteLine("Hellow World!");
            _log.Info("Main ends.");
        }
#endif
    }
}
