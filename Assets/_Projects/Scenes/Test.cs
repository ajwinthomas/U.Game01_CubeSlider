using System.Diagnostics.CodeAnalysis;
using UnityEditor.Animations;
using UnityEngine;

public class Test : MonoBehaviour
{
     Transform dad;
    Vector3 localPosition;
    Quaternion localRotation;

    private void Start()
    {
        dad = transform.GetChild(0);

    }
    void Update()
    {
        

        dad.GetLocalPositionAndRotation(out localPosition, out localRotation);

        transform.localPosition = localPosition;
        transform.localRotation = localRotation;

    }

}
