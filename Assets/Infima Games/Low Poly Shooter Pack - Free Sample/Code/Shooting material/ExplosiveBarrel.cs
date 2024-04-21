using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ExplosiveBarrelScript))]
public class ExplosiveBarrel : MonoBehaviour, IHaveProjectileReaction
{
    public void React()
    {
        gameObject.GetComponent
                <ExplosiveBarrelScript>().explode = true;
    }


}
