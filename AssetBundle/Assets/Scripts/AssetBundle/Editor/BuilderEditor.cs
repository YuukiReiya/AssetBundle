using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class BuilderEditor : MonoBehaviour
{
    [System.Serializable]
    struct AssetBundleBuildData
    {
        public string assetBundleName;
        public string[] assetNames;
    }

    [SerializeField] string outputDir;
    [SerializeField] AssetBundleBuildData[] datas;
    //[SerializeField] BuildAssetBundleOptions buildOption;
    //[SerializeField] BuildTarget buildTarget;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [MenuItem("Assets/Build AssetBundles")]
#if false
    public void Build()
    {
        //  ディレクトリ確認(なければ生成)
        if (!System.IO.Directory.Exists(outputDir))
        {
            System.IO.Directory.CreateDirectory(outputDir);
        }

        //  ビルドデータ生成
        var builds = new List<AssetBundleBuild>();

        foreach(var it in datas)
        {
            var build = new AssetBundleBuild();
            build.assetBundleName = it.assetBundleName;
            build.assetNames = it.assetNames;
            builds.Add(build);
        }


        //BuildPipeline.BuildAssetBundles(outputDir, builds.ToArray(), buildOption, EditorUserBuildSettings.activeBuildTarget);
        BuildPipeline.BuildAssetBundles(outputDir, builds.ToArray(), 0, EditorUserBuildSettings.activeBuildTarget);
    }
#else 
    static void BuildAllAssetBundles()
    {
        //const string c_OutputDir = "Assets/StreamingAssets/AssetBundleResources";
        const string c_OutputDir = "Assets/AssetBundles";
        if (!System.IO.Directory.Exists(c_OutputDir))
        {
            System.IO.Directory.CreateDirectory(c_OutputDir);
        }
        BuildPipeline.BuildAssetBundles(c_OutputDir, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
#endif
}
