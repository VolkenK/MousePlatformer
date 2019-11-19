using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour 
{
    private bool _Grounded = false;

    public bool grounded
    {
        get { return _Grounded; }
        set
        {
            _Grounded = value;
        }
    }

    // Change the boolean based on if there is ground below us

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _Grounded = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _Grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _Grounded = false;
    }
}
