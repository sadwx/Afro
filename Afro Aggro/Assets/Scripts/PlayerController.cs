using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SwayBody _sway;
    private NodHead _nodHead;
    private Transform _transform;

    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _sway = GetComponentInChildren<SwayBody>();
        _nodHead = GetComponentInChildren<NodHead>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerType(PlayerType playerType)
    {
        name = playerType.ToString();
        switch (playerType)
        {
            case PlayerType.Player1:
                _sway.SwayDirection = SwayDirection.Right;
                _nodHead.SwayDirection = SwayDirection.Right;
                _transform.localRotation = Quaternion.identity;
                break;

            default:
                //_sway.SwayDirection = SwayDirection.Left;
                //_nodHead.SwayDirection = SwayDirection.Left;
                _sway.SwayDirection = SwayDirection.Right;
                _nodHead.SwayDirection = SwayDirection.Right;
                _transform.localRotation = Quaternion.Euler(new Vector3(0, -180f, 0));
                break;
        }
    }
}
