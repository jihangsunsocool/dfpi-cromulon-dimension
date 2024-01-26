using UnityEngine;

public class Vector3Receiver : MonoBehaviour, IValue<Vector3>
{
    [SerializeField]
    private Vector3 value;

    public Vector3 Value
    {
        get => value;
        set => this.value = value;
    }
}
