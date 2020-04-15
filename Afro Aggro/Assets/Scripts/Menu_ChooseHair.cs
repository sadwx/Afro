using UnityEngine;

public class Menu_ChooseHair : MonoBehaviour
{
    public GameObject[] hairs;
    public float Distance = 300f;

    int _choose = 1;
    PlayerType _playerType;

    //Vector3 h1 = hair01.transform.position;
    
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < hairs.Length; ++i)
            hairs[i].transform.position = hairs[0].transform.position + new Vector3(Distance * i, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            _choose += 1;
            if(_choose > hairs.Length){
                _choose = 1;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            _choose -= 1;
            if(_choose < 1){
                _choose = hairs.Length;
            }
        }

        transform.position = hairs[_choose - 1].transform.position;

        switch (_playerType)
        {
            case PlayerType.Player1:
                ChooseHair.p1 = _choose;
                break;

            default:
                ChooseHair.p2 = _choose;
                break;
        }
        //Debug.Log(h1);
        //Debug.Log(my);
        //player01.transform.position = h1;
        //Debug.Log(my);  
    }

    public void SelectNextPlayer()
    {
        switch (_playerType)
        {
            case PlayerType.Player1:
                _playerType = PlayerType.Player2;
                break;
        }
    }

    public PlayerType CurrentPlayer
    {
        get { return _playerType; }
    }

    public bool HasNextPlayer
    {
        get { return _playerType != PlayerType.Player2; }
    }
}
