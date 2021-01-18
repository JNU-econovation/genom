using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloatingTextManager : MonoBehaviour
{
    public static FloatingTextManager instance;
    [SerializeField] GameObject Prefab_floatingText;

    private void Start()
    {
        instance = this;
    }

    public void CreateFloatingText(Vector3 pos, string _text)
    {
        GameObject clone = Instantiate(Prefab_floatingText, pos, Prefab_floatingText.transform.rotation);

        clone.GetComponentInChildren<Text>().text = _text;


        Debug.Log("텍스트 위치: " + pos + "클론 위치: " + clone.transform.position);

    }
}
