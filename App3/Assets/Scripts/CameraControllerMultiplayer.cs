using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class CameraControllerMultiplayer : MonoBehaviour
{

    public GameObject[] characters;
    private GameObject player;
    private Vector3 offset;            //Private variable to store the offset distance between the player and camera
    private Vector3 _InitialCamPos;
    public bool isPlayer1;

    // Use this for initialization
    void Start()
    {
        if (isPlayer1)
        {
            player = characters[TwoPlayer.playerOneSelection];
        }
        else
        {
            player = characters[TwoPlayer.playerTwoSelection];
        }
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        _InitialCamPos = transform.InverseTransformPoint(transform.position);

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        Vector3 back = -player.transform.forward;
        back.y = 0.5f; // this determines how high. Increase for higher view angle.
        transform.position = player.transform.position - back * -5;
        transform.forward = player.transform.position - transform.position;
    }
}