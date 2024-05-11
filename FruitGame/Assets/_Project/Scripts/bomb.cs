using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project{
public class bomb : ItemBase
{  
    public override void onCatch()
        {
            Debug.Log("-1 score");
        }

}
}