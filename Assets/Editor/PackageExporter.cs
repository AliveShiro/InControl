﻿#if UNITY_EDITOR
using UnityEditor;


namespace InControl
{
    public class PackageExporter
    {
        [MenuItem("Assets/InControl/Generate Unity Package")]
        static void CreateUnityPackage()
        {
            var assetPathNames = new string[] {
                "Assets/InControl"
            };
            var packageName = "Packages/InControl-" + VersionInfo.InControlVersion().ToShortString() + ".unitypackage";
            AssetDatabase.ExportPackage(assetPathNames, packageName, ExportPackageOptions.Recurse);
        }
    }
}
#endif

