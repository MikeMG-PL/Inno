using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceAttributes : MonoBehaviour
{
    ConeScript cone;

    private void OnMouseDown()
    {
        Hit();
    }

    void Hit()
    {
        cone = GetComponentInParent<PhysicsEngine>().cone.transform.GetChild(0).GetComponent<ConeScript>();

        Vector3 hitPos = new Vector3();
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            hitPos = hit.point;
        }

        Instantiate(cone.transform.parent, hitPos, new Quaternion(180, 0, 0, 0));
    }
}
