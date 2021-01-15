using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erase_Hand : MonoBehaviour
{
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(deie());
    }
    IEnumerator deie()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f *5);
        Destroy(hand);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 15f * Time.deltaTime);
    }
}
