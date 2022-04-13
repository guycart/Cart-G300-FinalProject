using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{

    public float desiredTime;
    public float timer;

    [SerializeField] Camera cam;

    void Update()
    {
        if(timer < desiredTime)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f,0.5f));
                if(Physics.Raycast(ray, out RaycastHit hit))
                {
                    Target target = hit.collider.gameObject.GetComponent<Target>();

                    if(target != null)
                    {
                        target.Hit();
                    }
                }
            }
        }
    }
}
