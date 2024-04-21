using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TargetScript))]
public class Target : MonoBehaviour, IHaveProjectileReaction
{
    public void React()
    {
        gameObject.GetComponent
                 <TargetScript>().isHit = true;
    }


}