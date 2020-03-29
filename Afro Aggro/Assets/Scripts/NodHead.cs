using DG.Tweening;
using UnityEngine;

public class NodHead : MonoBehaviour
{
    public SwayDirection SwayDirection;
    public Ease NodeEase = Ease.InOutFlash;
    public float Duration = 0.1f;
    public float NodAngle = 30f;

    Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Nod()
    {
        // Grab a free Sequence to use
        var sequence = DOTween.Sequence();
        switch (SwayDirection)
        {
            case SwayDirection.Left:
                sequence.Append(_transform.DORotateQuaternion(Quaternion.Euler(0, 0, NodAngle), Duration).SetEase(NodeEase));
                break;

            default:
                sequence.Append(_transform.DORotateQuaternion(Quaternion.Euler(0, 0, -NodAngle), Duration).SetEase(NodeEase));
                break;
        }
        sequence.Append(_transform.DORotateQuaternion(Quaternion.identity, Duration).OnComplete(() => _transform.localRotation = Quaternion.identity));
        sequence.Play();
    }
}
