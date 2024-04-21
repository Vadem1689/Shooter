using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concrete : MonoBehaviour, IHaveProjectileReaction
{
    public Transform[] concreteImpactPrefabs;
    public Transform[] bloodImpactPrefabs;
    public void React()
    {
        Instantiate(concreteImpactPrefabs[Random.Range
                (0, bloodImpactPrefabs.Length)], transform.position,
                Quaternion.LookRotation(gameObject.transform.position));
    }


}
