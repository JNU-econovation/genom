using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingManager : MonoBehaviour
{
    public static FloatingManager instance;
    [SerializeField] GameObject Prefab_FlaotingCanvas;
    [SerializeField] GameObject Prefab_pos;

    private void Start()
    {
        instance = this;
    }

    public void CreateFloatingCanvas(string _text)
    {
        GameObject clone = Instantiate(Prefab_FlaotingCanvas, Prefab_pos.transform.position, Prefab_FlaotingCanvas.transform.rotation);
        clone.GetComponentInChildren<Text>().text = _text;
        
        clone.transform.SetParent(Prefab_pos.transform);

        //clone.transform.position = Prefab_pos.transform.position;
        //clone.GetComponentInChildren<Text>().rectTransform.anchoredPosition = Prefab_pos.transform.position;

        //clone.transform.position = Prefab_pos.transform.position;

        //clone.GetComponentInChildren<Text>().rectTransform.anchoredPosition = new Vector2(-225, 160);

        Debug.Log("클론 위치: " + clone.transform.position + "렉트위치: " + clone.GetComponentInChildren<Text>().rectTransform.anchoredPosition + "오브젝트: " + Prefab_pos.transform.position);

    }

}
