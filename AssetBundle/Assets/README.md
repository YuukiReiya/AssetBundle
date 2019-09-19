アセット読み込み基礎知識
参考:https://qiita.com/k7a/items/df6dd8ea66cbc5a1e21d

アセット読み込みの手法
・Resources.Load
・StreamingAssets
・AssetDatabase.LoadAssetPath
・AssetBundle.LoadAsset


1.Resources.Load
<概要>
Assetフォルダ以下に"Resources"フォルダを作成。
読み込むアセットを"Resources"フォルダに入れる。
スクリプトからResources.Load(assetName)でロードが可。

※注意
読み込みはビルドインデータ(本来のリソース + メタファイルの加工されたデータ)で行われてしまう。

<メリット>
簡単

<デメリット>
ビルド時間:増
アプリサイズ:増
起動時間:増

2.StreamingAssets
<概要>
Assetフォルダ以下に"StreamingAssets"フォルダを作成。
読み込むアセットを"StreamingAssets"フォルダに入れる。
System.IOでロードする。
Resources.Loadの加工なし版のイメージ。

※注意
ビルドインデータではないが差し替え出来ない点。

<メリット>
アプリにバイナリデータとして格納できる。

<デメリット>
アプリ内格納のためアプリサイズ:増
StreamingAssetsは書き込み不可領域のためリソースの差し替え不可。


3.AssetDatabase.LoadAssetAtPath
<概要>
Editor上での外部ファイル読み込み。

<メリット>
どんなアセットでも読み込むことが可能。

<デメリット>
UnityEditor限定。


4.AssetBundle.LoadAsset
<概要>
①アセットを格納したAssetBundleをビルドする
②ビルドしたAssetBundleをどこか（WebサーバーかStreamingAssets）に配置する
③配置したAssetBundleをロードする
④assetBundle.LoadAsset(assetName)でAssetBundleからアセットをロードする
よくわからない…　Let's Learning!!

