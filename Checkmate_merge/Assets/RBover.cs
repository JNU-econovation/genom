using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBover : MonoBehaviour
{
    public GameObject RBo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RBDestory()
    {
        Destroy(RBo);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")//폰이 플레이어에 의해 죽음(1점 증가)
        {

            RBDestory();


        }
        if (collision.tag == "Hand")//폰이 플레이어에 의해 죽음(1점 증가)
        {

            RBDestory();


        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
