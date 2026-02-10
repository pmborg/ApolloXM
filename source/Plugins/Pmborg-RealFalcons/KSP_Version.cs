/*
    Used links:
    https://mit-license.org/
    https://www.guidgenerator.com/online-guid-generator.aspx
    Pmborg-RealFalcons v1.0.7.0
    F:\git\Pmborg-RealFalcons-v2

    INFO:
    https://wiki.kerbalspaceprogram.com/wiki/CFG_File_Documentation

    1.8.0:  https://forum.kerbalspaceprogram.com/index.php?/topic/188933-180-modders-notes/
    1.9.0:  https://forum.kerbalspaceprogram.com/index.php?/topic/191584-modders-notes-190/
    1.10.0: https://forum.kerbalspaceprogram.com/index.php?/topic/195178-modders-notes-1100/
*/

using System;
using UnityEngine;
using System.Collections.Generic;

namespace PMB
{
    public static class ModuleManagerSupport
    {
        // Return the KSP-version used in config files:
        public static IEnumerable<string> ModuleManagerAddToModList()
        {
            string[] KSP_Version = { "" };
            KSP_Version[0] = "RealFalcon-KSP-" + Versioning.version_major + "." + Versioning.version_minor;
            return KSP_Version;
        }
    }
}