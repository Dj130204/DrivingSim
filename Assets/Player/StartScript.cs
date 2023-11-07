using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] GameObject colider;

    private void OnTriggerEnter2D(Collider2D colider)
    {
        GameManager.GameTimer.timerIsRunning = true;
    }


}
