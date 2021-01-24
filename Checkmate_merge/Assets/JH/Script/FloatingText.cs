using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    [SerializeField] float destroyTime;
    [SerializeField] Animation ani;

    private void Start()
    {
        ani.Play();
        Destroy(gameObject, destroyTime);
    }
}
