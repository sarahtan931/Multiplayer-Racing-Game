using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public Rigidbody[] targets;
    private Rigidbody target;

    public float maxSpeed = 0.0f;

    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;

    [Header("UI")]
    public TextMeshProUGUI speedLabel;
    public RectTransform arrow;
    public float speed;

    private void Start()
    {
        target = targets[PlayerName.playerSelection];
    }
    private void Update()
    {
        speed = target.velocity.magnitude * 3.6f;

        if (speedLabel != null)
        {
            speedLabel.text = ((int)speed) + " km/h";
        }
        if (arrow != null)
        {
            arrow.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed));
        }

    }
}
