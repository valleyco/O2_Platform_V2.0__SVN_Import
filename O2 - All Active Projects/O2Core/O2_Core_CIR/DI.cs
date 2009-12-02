﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using O2.Core.CIR.CirObjects;
using O2.Kernel;
using O2.Kernel.Interfaces.CIR;
using O2.Kernel.Interfaces.O2Core;
using O2.Kernel.InterfacesBaseImpl;

namespace O2.Core.CIR
{
    class DI
    {
        static DI()
        {
            log = PublicDI.log;            
            reflection = PublicDI.reflection;  // new O2FormsReflectionASCX();
            config = PublicDI.config;
            defaultDirectoryForCirCreationQueue = Path.Combine(DI.config.O2TempDir, "_temp_CirCreationQueue");
            defaultDirectoryForCreatedCirFiles = Path.Combine(DI.config.O2TempDir,"_temp_CreatedCirFiles");
            PathToGac = Path.Combine(Environment.GetEnvironmentVariable("windir") ?? "", "Assembly\\GAC_MSIL");
        }

        // DI Targets
        //public static IReflectionASCX reflection { get; set; }
        public static IReflection reflection { get; set; }
        public static IO2Log log { get; set; }        
        public static IO2Config config { get; set; }


        // local global vars
     //   public static ICirData cirData;
        public static string defaultDirectoryForCirCreationQueue { get; set; }
        public static string defaultDirectoryForCreatedCirFiles { get; set; }
        public static string CONST_NEED_SIGNATURE = "[need signature]";
        public static string PathToGac { get; set; }
    }
}
