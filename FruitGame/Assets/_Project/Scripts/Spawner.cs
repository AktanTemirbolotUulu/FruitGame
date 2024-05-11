using System.Collections;
using UnityEngine;
namespace Project
{
public class Spawner : MonoBehaviour
{
    [SerializeField] private ItemBase[] _items;
    [SerializeField] private float _spawRate = 2;
        private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn(){
        while(gameObject.activeSelf)
        {
            yield return new WaitForSeconds(_spawRate);
            int index = Random.Range(0, _items.Length);
            Instantiate(_items[index]);
        }
    }
}
}