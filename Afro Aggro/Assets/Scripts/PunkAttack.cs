using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunkAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
            attack();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("J");
            attack();
        }
    }

    void attack(){
        // gameObject.GetComponentInChildren()
    }
}
