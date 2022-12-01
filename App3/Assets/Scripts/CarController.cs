using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

// referenced from https://www.youtube.com/watch?v=Z4HA8zJhGEk&t=17s
public class CarController : MonoBehaviour
{

    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    public HealthBar healthBar;
    public int maxHealth = 10;
    public int currentHealth;

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentbreakForce;
    private bool isBreaking;

    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject player;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    void Start()
    {
        currentHealth = maxHealth;
        if (healthBar)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetString("lastLevelString", SceneManager.GetActiveScene().name);
        resetHealth();
    }

    public void resetHealth()
    {
        currentHealth = maxHealth;
        if (healthBar)
        {
            healthBar.SetHealth(currentHealth);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (healthBar)
        {
            healthBar.SetHealth(currentHealth);
        }
        if (currentHealth <= 0)
        {
            player.transform.position = respawnPoint.transform.position;
            player.transform.rotation = Quaternion.Euler(0f, 1f, 0f);
            resetHealth();
        }
    }

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
    }


    private void GetInput()
    {
        horizontalInput = 0;
        verticalInput = 0;
        if (player.name == "Player" || player.name == "Player 1" || player.name == "Player 2")
        {
            if (Input.GetKey(KeyCode.A))
            {
                horizontalInput = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                horizontalInput = 1;
            }
            if (Input.GetKey(KeyCode.W))
            {
                verticalInput = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                verticalInput = -1;
            }
            isBreaking = Input.GetKey(KeyCode.Tab);
        } else
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                horizontalInput = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                horizontalInput = 1;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                verticalInput = 1;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                verticalInput = -1;
            }
            isBreaking = Input.GetKey(KeyCode.Space);
           
        }
         
    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pylon")
        { 
            TakeDamage(1);
        }
        if (collision.gameObject.tag == "Chicken")
        {
            TakeDamage(10);
        }
        if (collision.gameObject.tag == "Chick")
        {
            TakeDamage(5);
        }
        if (collision.gameObject.tag == "Tree")
        {
            TakeDamage(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TenCoin")
        {
            PlayerName.tempCoins += 10;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "FiveCoin")
        {
            PlayerName.tempCoins += 5;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "OneCoin")
        {
            PlayerName.tempCoins += 1;
            Destroy(other.gameObject);
        }
    }
}