using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonController : MonoBehaviour
{
    [SerializeField] GameObject pon;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PonKilledByPlayer()
    {
        Destroy(pon);
    }



    void Update()
    {

        PonDestroy();
    }
    public void PonDestroy() 
    {
        if (pon.transform.position.x > 5.5)
        {
            Destroy(pon);

        }
        if (pon.transform.position.x < -4)
        {
            Destroy(pon);
        }

        if (pon.transform.position.y > 4.5)
        {
            Destroy(pon);
        }
        if (pon.transform.position.y < -5)
        {
            Destroy(pon);
        }

    }

}
