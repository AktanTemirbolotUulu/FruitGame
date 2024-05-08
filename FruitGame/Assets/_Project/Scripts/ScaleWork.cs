using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

namespace Project
{
public class ScaleWork : WorkBase
{
    public override void Work()
    {
        transform.localScale += Vector3.one;
    }
}
}
