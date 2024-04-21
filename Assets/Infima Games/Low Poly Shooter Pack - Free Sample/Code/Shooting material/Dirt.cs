using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour, IHaveProjectileReaction
{
    public Transform[] dirtImpactPrefabs;
    public Transform[] bloodImpactPrefabs;
    public void React()
    {
        Instantiate(dirtImpactPrefabs[Random.Range
                (0, bloodImpactPrefabs.Length)], transform.position,
                Quaternion.LookRotation(gameObject.transform.position));
    }


}