using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bishopAlert : MonoBehaviour
{

    public GameObject bishopPrefab;
    public GameObject bishopAlt;
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
        Instantiate(bishopPrefab, this.transform.position + new Vector3(0, 0.31f, 0), Quaternion.identity);
        Destroy(bishopAlt);

    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
