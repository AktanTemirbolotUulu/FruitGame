using System.Collections;
using UnityEngine;
namespace Project
{
public class Spawner : MonoBehaviour
{
    [SerializeField] private ItemBase[] _items;
    [SerializeField] private float _spawRate = 1;
        private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn(){
        while(gameObject.activeSelf)
        {
            yield return new WaitForSeconds(_spawRate);
            int index = Random.Range(0, _items.Length);
            ItemBase itemCopy = Instantiate(_items[index]);

            Vector3 itemPosition = new Vector3();
            itemPosition.x = Random.Range(-10, 10);
            itemPosition.y = 0;
            itemPosition.z = 0;
            //itemCopy.transform.position =  Vector3.right * Random.Range(-10, 10);
        }
    }
}
}