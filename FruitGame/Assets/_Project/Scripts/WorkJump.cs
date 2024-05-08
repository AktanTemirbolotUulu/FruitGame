using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project
{
public class WorkJump : WorkBase
{
    public override void Work()
    {
        transform.position +=new Vector3(0, 1, 0);
    }
}
}