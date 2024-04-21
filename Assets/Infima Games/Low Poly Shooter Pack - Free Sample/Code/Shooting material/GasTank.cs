using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GasTankScript))]
public class GasTank : MonoBehaviour, IHaveProjectileReaction
{
    public void React()
    {
        gameObject.GetComponent
                 <GasTankScript>().isHit = true;
    }


}