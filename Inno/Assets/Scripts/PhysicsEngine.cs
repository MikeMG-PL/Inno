using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEngine : MonoBehaviour
{
    public GameObject cone;

    void Awake()
    {
        Setup();
    }

    public static Rigidbody MR(Transform t, int num)
    {
        return t.GetChild(num).gameObject.GetComponent<Rigidbody>();
    }

    public static Rigidbody R(GameObject g)
    {
        return g.GetComponent<Rigidbody>();
    }

    public void Setup()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            MR(transform, i).isKinematic = true;
            transform.GetChild(i).gameObject.AddComponent<PieceAttributes>();
        }
    }
}
