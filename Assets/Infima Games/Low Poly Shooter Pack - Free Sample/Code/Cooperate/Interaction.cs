using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float _interactDistance;

    private IIntractable nearestIntractable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithNearest();
        }
    }

    private void InteractWithNearest()
    {
        Collider[] colliders = Physics.OverlapSphere
                (transform.position, _interactDistance);

        IIntractable nowIntractable = null;
        float nearestDistance = float.MaxValue;

        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent<IIntractable>(out nowIntractable))
            {
                float distance = Vector3.Distance(transform.position, collider.transform.position);
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    nearestIntractable = nowIntractable;
                }
            }
        }
        if(nearestIntractable !=null)
        {
            nearestIntractable.Interact();
        }
        
    }
}
