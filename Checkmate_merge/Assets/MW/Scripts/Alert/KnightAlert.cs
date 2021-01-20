using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAlert : MonoBehaviour
{
    public int sortingOrder = 0;
    private SpriteRenderer sprite;

    public GameObject knightPrefab;
    public GameObject knightAlt;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fisrtTimer());
        sprite = GetComponent<SpriteRenderer>();
    }

    IEnumerator fisrtTimer()
    {
        yield return new WaitForSeconds(0.93023255813953488372093023255812f * 2);

        setRound();
    }

    void setRound()
    {
        Instantiate(knightPrefab, this.transform.position + new Vector3(0, 0.81f, 0), Quaternion.identity);
        Destroy(knightAlt);

    }


    // Update is called once per frame
    void Update()
    {
        if (knightPrefab.transform.position.y > 3.744f && knightPrefab.transform.position.y < 4.85f)
        {
            sprite.sortingOrder = 1;
        }
        if (knightPrefab.transform.position.y > 2.656f && knightPrefab.transform.position.y < 3.744f)
        {
            sprite.sortingOrder = 2;
        }
        if (knightPrefab.transform.position.y > 1.55f && knightPrefab.transform.position.y < 2.656f)
        {
            sprite.sortingOrder = 3;
        }
        if (knightPrefab.transform.position.y > 0.458f && knightPrefab.transform.position.y < 1.55f)
        {
            sprite.sortingOrder = 4;
        }
        if (knightPrefab.transform.position.y > -0.655f && knightPrefab.transform.position.y < 0.458f)
        {
            sprite.sortingOrder = 5;
        }
        if (knightPrefab.transform.position.y > -1.75f && knightPrefab.transform.position.y < -0.655f)
        {
            sprite.sortingOrder = 6;
        }

        if (knightPrefab.transform.position.y > -2.84f && knightPrefab.transform.position.y < -1.75f)
        {
            sprite.sortingOrder = 7;
        }
        if (knightPrefab.transform.position.y > -3.94f && knightPrefab.transform.position.y < -2.84f)
        {
            sprite.sortingOrder = 8;
        }
    }
}
