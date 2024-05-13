using UnityEditor;
using UnityEngine;
namespace Project
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _force = 700;
    private void Reset()
    {
        _force = 700;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        if(_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        _rigidbody.AddForce(Vector3.up * _force);
    }

    private void Update()
    {
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }

    }    public virtual void onCatch(){
        Destroy(gameObject);
    }

}}

