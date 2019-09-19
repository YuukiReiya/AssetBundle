using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//参考:http://karaagedigital.hatenablog.jp/entry/2016/11/19/170927
public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DownLoad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DownLoad()
    {
        //StreamingAssetsを使ったローカルの使用例
        //"StreamingAssetsパス" + "対象のAssetBundleまでのパス"
        string bundleURL = Application.streamingAssetsPath + "/AssetBundleResources/testassetbundle";
        AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(bundleURL);
        while(!request.isDone)
        {
            yield return null;
        }
        AssetBundle bundle = request.assetBundle;
        AssetBundleRequest asset = bundle.LoadAssetAsync<GameObject>("Canvas");
        //  ここまで!

        //下記 生成しているだけ
        GameObject obj = (GameObject)Instantiate(asset.asset);
    }
}
