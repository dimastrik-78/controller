using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _jumpForce;
    [SerializeField] float _rotateSpeed;

    public GameObject Bullet;

    public Transform Position;

    private CharacteRotater _rotater;
    private CharacterMovement _move;
    private CharacterJump _jump;
    private CharacterCombat _fire;
    
    private Rigidbody _rb;
    private bool _canMove = true;
    void Start()
    {
        _rotater = new CharacteRotater();
        _move = new CharacterMovement();
        _jump = new CharacterJump();
        _fire = new CharacterCombat();
        
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && _canMove)
            _canMove = false;
        else if (Input.GetKeyDown(KeyCode.Mouse0) && !_canMove)
            _canMove = true;
        Debug.Log(transform.rotation);

        if (_canMove)
        {
            if (Input.GetAxis("Vertical") != 0)
            {
                _move.Move(_rb, _speed);
            }
            
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                _rotater.Rotate(_rb, _rotateSpeed);
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _jump.Jump(_rb, _jumpForce);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                _fire.Fire(Bullet, Position);
            }
        }
        else if (Input.anyKey)
            Debug.Log("You can't use 'Move', 'Rotate' and 'jump'. Please press 'Mouse0'");
    }
}
