using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public Transform Player1Transform;
    public Transform Player2Transform;
    public GameObject SingleHorseTailPlayer;
    public GameObject PunkPlayer;
    public GameObject DoubleHorseTailPlayer;
    public GameObject QuiffPlayer;

    AfroType GetPlayerAfroType(PlayerType type)
    {
        return type == PlayerType.Player1 ? (AfroType)ChooseHair.p1 : (AfroType)ChooseHair.p2;
    }

    Transform GetPlayerTransform(PlayerType playerType)
    {
        return playerType == PlayerType.Player1 ? Player1Transform : Player2Transform;
    }

    void CreatePlayer(PlayerType playerType)
    {
        GameObject player;
        switch (GetPlayerAfroType(playerType))
        {
            case AfroType.SingleHorseTail:
                player = Instantiate(SingleHorseTailPlayer);
                break;

            case AfroType.Punk:
                player = Instantiate(PunkPlayer);
                break;

            case AfroType.Quiff:
                player = Instantiate(QuiffPlayer);
                break;

            default:
                player = Instantiate(DoubleHorseTailPlayer);
                break;
        }

        player.SetActive(true);
        player.transform.position = GetPlayerTransform(playerType).position;
        var playerController = player.GetComponent<PlayerController>();
        playerController.SetPlayerType(playerType);
    }

    // Use this for initialization
    void Start()
    {
        CreatePlayer(PlayerType.Player1);
        CreatePlayer(PlayerType.Player2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
