using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Crash();
    }

    private void Crash()
    {
        print("trigger entered!");
        SendMessage("ControlIsDead");
    }
}
