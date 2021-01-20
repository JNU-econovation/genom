using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Ver : MonoBehaviour
{
    public GameObject verPrifep;
    public GameObject verAlert;
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
        Instantiate(verPrifep, this.transform.position + new Vector3(0, 10f, 0), Quaternion.identity);
        Destroy(verAlert);

    }
}
