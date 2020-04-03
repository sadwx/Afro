using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void ChangeScene(string scenename){
        Application.LoadLevel (scenename);
    }
}
