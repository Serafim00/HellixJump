using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class TowerRotater : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private Rigidbody _rigitbody;

    private void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float torque = touch.deltaPosition.x * Time.deltaTime * _rotateSpeed;
                 _rigitbody.AddTorque(Vector3.up * torque);
            }
        }
    }
}
