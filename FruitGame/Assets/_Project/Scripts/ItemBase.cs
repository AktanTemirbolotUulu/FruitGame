using UnityEditor;
using UnityEngine;
namespace Project{
public abstract class ItemBase : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }

    }
    private void OnMouseUp(){
        onCatch();
    }
    public virtual void onCatch(){
        Destroy(gameObject);
    }

}}

