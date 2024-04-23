using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable 
{
    string Name { get; set; }
     void GetInputMovement();
}
