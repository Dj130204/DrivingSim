using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colider)
    {
        GameManager.GameTimer.End();
    }
}
