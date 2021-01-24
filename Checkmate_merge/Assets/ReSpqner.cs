using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpqner : MonoBehaviour
{
    Vector2 PlayerPos;
    public GameObject PlayerPonPivot;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = PlayerPonPivot.transform.position;
    }

    public void reSpawner()
    {
        Debug.Log("사망");
        Instantiate(Player, PlayerPos, Quaternion.identity);
    }
}
