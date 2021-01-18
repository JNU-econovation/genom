using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{

    [SerializeField] float destroyTime;
    [SerializeField] Animation anim;

    private void Start()
    {
        anim.Play();
        Destroy(gameObject, destroyTime);
    }

}
