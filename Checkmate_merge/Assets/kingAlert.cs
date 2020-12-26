using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kingAlert : MonoBehaviour
{

    public GameObject kingPrefab;
    public GameObject kingAlt;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fisrtTimer());
    }

    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);

        setRound();
    }

    void setRound()
    {
        Instantiate(kingPrefab, this.transform.position + new Vector3(0, 0.314f, 0), Quaternion.identity);
        Destroy(kingAlt);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
