using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public Transform Player1Position;
    public Transform Player2Position;
    public GameObject SingleHorseTailPlayer;
    public GameObject PunkPlayer;
    public GameObject DoubleHorseTailPlayer;

    AfroType Player1AfroType
    {
        get
        {
            return (AfroType)ChooseHair.p1;
        }
    }

    void CreatePlayer1()
    {
        GameObject player1;
        switch (Player1AfroType)
        {
            case AfroType.SingleHorseTail:
                player1 = Instantiate(SingleHorseTailPlayer);
                break;

            case AfroType.Punk:
                player1 = Instantiate(PunkPlayer);
                break;

            default:
                player1 = Instantiate(DoubleHorseTailPlayer);
                break;
        }

        player1.SetActive(true);
        player1.transform.position = Player1Position.position;
    }

    // Use this for initialization
    void Start()
    {
        CreatePlayer1();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
