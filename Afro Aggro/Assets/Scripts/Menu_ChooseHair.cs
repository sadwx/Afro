using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu_ChooseHair : MonoBehaviour
{
    public GameObject hair01;
    public GameObject hair02;
    public GameObject hair03;

    //Vector3 h1 = hair01.transform.position;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 h1 = hair01.transform.position;
        transform.position = h1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 h1 = hair01.transform.position;
        Vector3 h2 = hair02.transform.position;
        Vector3 h3 = hair03.transform.position;

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            ChooseHair.p1 += 1;
            if(ChooseHair.p1>3){
                ChooseHair.p1 = 1;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            ChooseHair.p1 -= 1;
            if(ChooseHair.p1<1){
                ChooseHair.p1 = 3;
            }
        }

        switch(ChooseHair.p1){
            case 1:
                transform.position = h1;
                break;
            case 2:
                transform.position = h2;
                break;
            case 3:
                transform.position = h3;
                break;
        }
        //Debug.Log(h1);
        //Debug.Log(my);
        //player01.transform.position = h1;
        //Debug.Log(my);  
    }
}
