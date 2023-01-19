using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    public Transform canvas;

    public void activeWindow(string windowName) {
        GameObject window = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Windows/"+windowName+".prefab", typeof(GameObject));
        Instantiate(window, canvas);
    }

    public void unActiveWindow() {
        GameObject window = gameObject.transform.parent.gameObject;
        Destroy(window);
    }
}
