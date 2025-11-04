using System.Collections.Generic;
using UnityEngine;

class UnityReplay : MonoBehaviour
{
    public List<Vector3> uplayerPositionVectors = new();
    public List<Quaternion> uplayerRotationQuaternions = new();
    public List<Quaternion> ucameraRotationQuaternions = new();
    public List<int> ushootTimings = new();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            ReplayManager.ReplayRecording();
        }
    }

    void Awake()
    {
    }
}