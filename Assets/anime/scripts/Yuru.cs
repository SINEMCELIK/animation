using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class Yuru : MonoBehaviour
{
    int coin = 0;
    public Text coinShow;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
        if(_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isWalking", true);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Skateboard")
        {
            coin++;
            Destroy(col.gameObject);
            coinShow.text = "score= " +coin;

        }

    }
}
