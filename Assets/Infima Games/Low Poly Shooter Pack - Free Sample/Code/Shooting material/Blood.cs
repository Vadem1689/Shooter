using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour,IHaveProjectileReaction
{
    public Transform[] bloodImpactPrefabs;
    public void React()
    {
        Instantiate(bloodImpactPrefabs[Random.Range
                (0, bloodImpactPrefabs.Length)], transform.position,
                Quaternion.LookRotation(gameObject.transform));
        //Destroy bullet object
        Destroy(gameObject);
    }

    
}
