using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;

public class sc : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject Con;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {


        Con.SetActive(true);
        Con.transform.position = Input.mousePosition;   
    }

    private void OnMouseUp()
    {

        Con.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Con.SetActive(false);
    }


}
