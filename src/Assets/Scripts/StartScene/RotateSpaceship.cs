using UnityEngine;

public class RotateSpaceship : MonoBehaviour {
    public float RotationSpeed = 10f;
    public float FloatingSpeed = 0.01f;
    private const float RandomYShiftDistance = 5f;
    private float _originalYPos = 0f;
    private float _yTarget = 0f;
    private float _lerpPos = 0f;

    private Vector3 _targetLerpPos = Vector3.zero;

    void Start() {
        _originalYPos = transform.localPosition.y;
        InvokeRepeating("AssignNewYTarget", 0, 3f);
    }

    private void AssignNewYTarget() {
        _yTarget = Random.Range(_originalYPos - RandomYShiftDistance, _originalYPos + RandomYShiftDistance);
        _targetLerpPos = new Vector3(transform.localPosition.x, _yTarget, transform.localPosition.z);
        _lerpPos = 0f;
    }

    void Update() {
        transform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);

        _lerpPos += 0.005f;

        var pos = Vector3.Lerp(transform.localPosition, _targetLerpPos, _lerpPos*Time.deltaTime);
        transform.localPosition = pos;
    }
}