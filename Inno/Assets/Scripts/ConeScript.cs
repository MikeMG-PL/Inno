using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PhysicsEngine.R(other.gameObject).isKinematic = false;
        PhysicsEngine.R(other.gameObject).AddForce(new Vector3(0, 0, 50), ForceMode.Impulse);
    }
}
