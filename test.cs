  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class test : MonoBehaviour
{

   // [SerializeField] Vector2 Line;
    [SerializeField] Vector a = new Vector(1f, 1f);
    void Start()
    {
        var a = new Vector(1f, 1f);
        var b = new Vector(1f, 1f);
        Vector r = a.SumaVectores(a);
        Vector r2 = a.RestaVectores(b);
        Debug.Log(r.a + "," + r.b);
        Debug.Log(r2.a + "," + r2.b);
        Debug.Log(r);
    }

    void Update()
    {
        a.Draw();
    }
}
