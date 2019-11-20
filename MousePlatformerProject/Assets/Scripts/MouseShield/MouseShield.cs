using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShield : MonoBehaviour
{
    private GameObject _Player;
    private Vector3 _Mousepos;


    // Start is called before the first frame update
    void Start()
    {
        GetPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the mouse posistion
        _Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _Mousepos.z = 0;

        //Calculate the diffrence between the mouse posistion and the player position
        Vector3 ShieldDir = new Vector3(_Mousepos.x - _Player.transform.position.x, _Mousepos.y - _Player.transform.position.y,0);
        //Set the distance of this object equivalent to the player posistion and the diffrence calculated above normalized
        this.transform.position = _Player.transform.position + ShieldDir.normalized * 3;
        //Set and calculate the rataion through the use of the player and mouse posistion
        float angle = AngleBetweenTwoPoints(_Player.transform.position, _Mousepos);
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        //Tan(a.y - b.y, a.x - b.x) * (360/(PI*2))
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    public void GetPlayer()
    {
        //get player position
        _Player = GameObject.FindGameObjectWithTag("ShieldCon");
    }
}
