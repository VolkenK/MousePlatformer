using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerMovement _Movement;
    private GroundChecker _GroundChecker;
    private float _MoveSpeed = 2;
    private float _JumpSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        _Movement = GetComponent<PlayerMovement>();
        _GroundChecker = GetComponentInChildren<GroundChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
    }

    // Link the actions to the buttons
    private void InputHandler()
    {
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            _Movement.MoveLeft(_MoveSpeed);
        }

        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            _Movement.MoveRight(_MoveSpeed);
        }

        if (Input.GetButton("Jump") && _GroundChecker.grounded)
        {
            _Movement.Jump(_JumpSpeed);
        }
    }
}
