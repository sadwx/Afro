using UnityEngine;
using DG.Tweening;

public class SwayBody : MonoBehaviour
{
    public float Degree = 10f;
    public float Duration = 0.5f;
    public SwayDirection SwayDirection = SwayDirection.Left;

    float _degree;
    float _duration;
    SwayDirection _direction;
    Transform _transform;

    void createTweenMove()
    {
        _degree = Degree;
        _duration = Duration;
        _direction = SwayDirection;
        _transform.localRotation = Quaternion.Euler(0, 0, _degree * (_direction == SwayDirection.Left ? 1 : -1));
        _transform.DOLocalRotateQuaternion(Quaternion.Euler(0, 0, _degree * (_direction == SwayDirection.Left ? -1 : 1)), _duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear)
            .SetId(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        createTweenMove();
    }

    // Update is called once per frame
    void Update()
    {
        if (_degree != Degree || _duration != Duration || _direction != SwayDirection)
        {
            DOTween.Kill(gameObject);
            createTweenMove();
        }
    }

    void OnDisable()
    {
        DOTween.Pause(gameObject);
    }

    void OnEnable()
    {
        DOTween.Play(gameObject);
    }
}
