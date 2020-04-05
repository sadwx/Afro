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

    AfroType Player2AfroType
    {
        get { return (AfroType)ChooseHair.p2; }
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
        var playerController = player1.GetComponent<PlayerController>();
        playerController.SetPlayerType(PlayerType.Player1);
    }

    void CreatePlayer2()
    {
        GameObject player2;
        switch (Player2AfroType)
        {
            case AfroType.SingleHorseTail:
                player2 = Instantiate(SingleHorseTailPlayer);
                break;

            case AfroType.Punk:
                player2 = Instantiate(PunkPlayer);
                break;

            default:
                player2 = Instantiate(DoubleHorseTailPlayer);
                break;
        }
        player2.SetActive(true);
        player2.transform.position = Player2Position.position;
        var playerController = player2.GetComponent<PlayerController>();
        playerController.SetPlayerType(PlayerType.Player2);
    }

    // Use this for initialization
    void Start()
    {
        CreatePlayer1();
        CreatePlayer2();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
