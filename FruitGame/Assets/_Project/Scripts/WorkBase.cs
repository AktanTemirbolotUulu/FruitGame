using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class WorkBase : MonoBehaviour
    {
        public virtual void Work()
    {
        transform.position += Vector3.forward;
    }
    }


}