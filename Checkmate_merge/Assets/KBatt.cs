using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KBatt : MonoBehaviour
{
    public GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator destroy()
    {

        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        me.gameObject.tag = "skillATT";
        yield return new WaitForSeconds(0.5f);
        Destroy(me);


    }
}
