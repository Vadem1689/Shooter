using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWthObjects : MonoBehaviour
{

    private void Update()
    {
        print("2");
    }
    //    [SerializeField] private float _interactDistance;

    //    private IIntractable nearestIntractable;

    //    //void Update()
    //    //{
    //    //    print("��������");
    //    //    if (Input.GetKeyDown(KeyCode.E))
    //    //    {
    //    //        GetNearest();
    //    //        print("��������");
    //    //    }
    //    //}

    //    private void Update()
    //    {
    //        print("��������");
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            GetNearest();
    //            print("��������");
    //        }
    //    }

    //    private void GetNearest()
    //    {
    //        Collider[] colliders = Physics.OverlapSphere
    //                (transform.position, _interactDistance);

    //        IIntractable nowIntractable = null;
    //        float nearestDistance = float.MaxValue;

    //        foreach (Collider collider in colliders)
    //        {
    //            if (collider.TryGetComponent<IIntractable>(out nowIntractable))
    //            {
    //                float distance = Vector3.Distance(transform.position, collider.transform.position);
    //                if (distance < nearestDistance)
    //                {
    //                    nearestDistance = distance;
    //                    nearestIntractable = nowIntractable;
    //                }
    //            }
    //        }
    //        nearestIntractable.Interaction();
    //        print("������");
    //    }
}
