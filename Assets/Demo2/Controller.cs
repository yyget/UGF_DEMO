using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
public class Controller : MonoBehaviour
{
    public void EnterGame()
    {
        SceneComponent Scene =  GameEntry.GetComponent<SceneComponent>();
        Scene.LoadScene("Assets/Demo2/Demo2Game.unity", this);
    }
}
