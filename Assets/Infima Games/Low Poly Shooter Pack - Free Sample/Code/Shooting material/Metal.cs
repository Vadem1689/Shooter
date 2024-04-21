using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour, IHaveProjectileReaction
{
    public Transform[] metalImpactPrefabs;
    public Transform[] bloodImpactPrefabs;
    public void React()
    {
        Instantiate(metalImpactPrefabs[Random.Range
                 (0, bloodImpactPrefabs.Length)], transform.position,
                 Quaternion.LookRotation(gameObject.transform.position));
    }


}
