using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project
{
public class Blade : MonoBehaviour
{
    [SerializeField] private GameObject _bladePrefab;
    [SerializeField] private float _cutDistance = 100;
    private GameObject _blade;
    private Vector3 _mouseStartPosition;
    private void Start()
    {
        _blade = Instantiate(_bladePrefab);
    }
    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _mouseStartPosition = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            //жаны нур
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //нурду корсот
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
            //нур бир нерсеге тийсе, hit тийген обьект тууралуу
            if(Physics.Raycast(ray , out RaycastHit hit))
            {
                //тийген обьекте ItemBase бар болсо
                ItemBase item = hit.collider.GetComponent<ItemBase>();
                
                if(Vector3.Distance(_mouseStartPosition, Input.mousePosition) > _cutDistance)
                {
                item?.onCatch();//аны кес
                }
            }

            _blade.transform.position = new Vector3(ray.origin.x, ray.origin.y, 0);

        }
    }
}
}
