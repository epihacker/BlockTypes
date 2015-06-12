﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BlockTypesLibrary.Helpers
{
    public class ResourceLoader
    {
        public static byte[] Load(string file)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // load resource
                typeof(ResourceLoader).Assembly.GetManifestResourceStream(file).CopyTo(ms);

                return ms.ToArray();
            }
        }

        public static string[] Files()
        {
            // return list of embeded resource available
            return typeof(ResourceLoader).Assembly.GetManifestResourceNames();
        }
    }
}
