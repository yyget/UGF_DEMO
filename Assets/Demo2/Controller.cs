using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
public class Controller : MonoBehaviour
{
    public void EnterGame()
    {
        SceneComponent Scene =  GameEntry.GetComponent<SceneComponent>();

        // 卸载所有场景
        string[] loadedSceneAssetNames = Scene.GetLoadedSceneAssetNames();
        for (int i = 0; i < loadedSceneAssetNames.Length; i++)
        {
            Scene.UnloadScene(loadedSceneAssetNames[i]);
        }

        // 加载游戏场景
        Scene.LoadScene("Assets/Demo2/Demo2Game.unity", this);
    }
}
