using UnityEngine;

public enum PlayerId
{
	p1, p2
}

public enum SelectStatus
{
	selecting, done
}

public class Menu_ChooseHair : MonoBehaviour
{
	public GameObject hair01;
	public GameObject hair02;
	public GameObject hair03;

	public KeyCode Left;
	public KeyCode Right;
	public KeyCode Enter;

	public PlayerId player;

	int _choose;
	PlayerType _playerType;
	SelectStatus status = SelectStatus.selecting;

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

		if (Input.GetKeyDown(Right) && status == SelectStatus.selecting)
		{
			_choose += 1;
			if (_choose > 3)
			{
				_choose = 1;
			}
		}
		if (Input.GetKeyDown(Left) && status == SelectStatus.selecting)
		{
			_choose -= 1;
			if (_choose < 1)
			{
				_choose = 3;
			}
		}
		if (Input.GetKeyDown(Enter) && status == SelectStatus.selecting)
		{
			status = SelectStatus.done;
			switch (player)
			{
				case PlayerId.p1:
					ChooseHair.p1 = _choose;
					break;

				default:
					ChooseHair.p2 = _choose;
					break;
			}
		}

		switch (_choose)
		{
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

		// switch (_playerType)
		// {
		// 	case PlayerType.Player1:
		// 		ChooseHair.p1 = _choose;
		// 		break;

		// 	default:
		// 		ChooseHair.p2 = _choose;
		// 		break;
		// }
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
