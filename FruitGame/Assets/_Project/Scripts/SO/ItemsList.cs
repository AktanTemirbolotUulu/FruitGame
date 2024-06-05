using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;
namespace SO
{
    [CreateAssetMenu ( fileName = "ItemsList", menuName =  "Configs/ItemsList") ]
public class ItemsList : ScriptableObject
{
    [SerializeField]
    public ItemBase[] items;
}
}
