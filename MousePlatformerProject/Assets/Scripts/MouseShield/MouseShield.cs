using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShield : MonoBehaviour
{
    private GameObject _Player;
    private Vector3 _Mousepos;
    private int _XMax = 10, _YMax = 10;


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
        /*this.transform.position = new Vector3((_Mousepos.x + _Mousepos.y)/2,(_Mousepos.x + _Mousepos.y) / 2, 0);
        if(this.transform.position.x < _Player.transform.position.x)
        {
            this.transform.position = new Vector3()
        }*/

         /*Vector3 test = new Vector3(Mathf.Pow((_Mousepos.x - _Player.transform.position.x),2), Mathf.Pow((_Mousepos.y - _Player.transform.position.y),2),0);
         this.transform.position = _Player.transform.position + test.normalized * 3;*/
        transform.RotateAround(_Player.transform.position, Vector3.up, - * 1f * Time.deltaTime);
    }

    public void GetPlayer()
    {
        _Player = GameObject.FindGameObjectWithTag("Player");
    }
}
