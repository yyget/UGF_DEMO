using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
public class Controller : MonoBehaviour
{
    public void EnterGame()
    {
        SceneComponent Scene =  GameEntry.GetComponent<SceneComponent>();

        // ж�����г���
        string[] loadedSceneAssetNames = Scene.GetLoadedSceneAssetNames();
        for (int i = 0; i < loadedSceneAssetNames.Length; i++)
        {
            Scene.UnloadScene(loadedSceneAssetNames[i]);
        }

        // ������Ϸ����
        Scene.LoadScene("Assets/Demo2/Demo2Game.unity", this);
    }
}
