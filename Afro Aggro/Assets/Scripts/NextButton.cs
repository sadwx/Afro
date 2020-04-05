using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject Menu_ChooseHair;

    private Menu_ChooseHair _menu_ChooseHair;
    private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        _menu_ChooseHair = Menu_ChooseHair.GetComponent<Menu_ChooseHair>();
        _text = GetComponentInChildren<Text>();
        _text.text = $"Select {_menu_ChooseHair.CurrentPlayer}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if (_menu_ChooseHair.HasNextPlayer)
        {
            _menu_ChooseHair.SelectNextPlayer();
            _text.text = $"Select {_menu_ChooseHair.CurrentPlayer}";
        }
        else
        {
            Menu_ChooseHair.SetActive(false);
            gameObject.SetActive(false);
            StartButton.SetActive(true);
        }
    }
}
