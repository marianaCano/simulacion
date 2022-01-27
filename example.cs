 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Vector
{
    public float a;
    public float b;
    
    public Vector(float v1, float v2) : this()
    {
        this.a = v1;
        this.b = v2;
    }

    public Vector SumaVectores(Vector other)
    {
        var numero = new Vector();
        numero.a = this.a + other.a;
        numero.b = this.b + other.b;
        return numero;
    }
    public Vector RestaVectores(Vector other)
    {
        var numero = new Vector();
        numero.a = this.a - other.a;
        numero.b = this.b - other.b;
        return numero;
    }
    public void Draw ()
    {
       Debug.DrawLine(Vector2.zero, new Vector2(a, b));
    }
}
