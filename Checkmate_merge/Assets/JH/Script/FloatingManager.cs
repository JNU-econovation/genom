using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingManager : MonoBehaviour
{
    public static FloatingManager instance;
    [SerializeField] GameObject Prefab_FlaotingCanvas;

    private void Start()
    {
        instance = this;
    }

    public void CreateFloatingCanvas(string _text)
    {
        GameObject clone = Instantiate(Prefab_FlaotingCanvas, new Vector2(0,0), Prefab_FlaotingCanvas.transform.rotation);
        clone.GetComponentInChildren<Text>().text = _text;
        clone.GetComponentInChildren<Text>().rectTransform.anchoredPosition = new Vector2(-225, 160);

        Debug.Log("클론 위치:" +clone.transform.position + "클론 렉트 위치: " + clone.GetComponentInChildren<Text>().rectTransform.anchoredPosition);
    }
}
