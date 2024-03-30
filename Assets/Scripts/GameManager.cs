using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class GameManager : MonoBehaviour
{
    [SerializeField]public int Lap;
    [SerializeField]private int speed;
    [HideInInspector] AudioSource audioSource;


    public static GameManager instance;


    public TextMeshProUGUI Lap_text;
    public TextMeshProUGUI speed_text;
    public AudioClip LapSound;
    public AudioClip Crash;
    public TextMeshProUGUI game_finish_text;

    private CarController car;


    private void Start()
    {

        audioSource = GetComponent<AudioSource>();
        game_finish_text.text = "";
        instance = this;
    }

    private void Update()
    {
        car = FindObjectOfType<CarController>();
        speed = (int)car.CurrentSpeed;
        Lap_text.text = "Lap :" + Lap.ToString();
        speed_text.text = "Speed :"+ speed.ToString() + " KM/H";
       
        if(Lap >= 3) {
            game_finish_text.text = "Congratulation !.\nYou completed the race";
          
            FindObjectOfType<CarController>().enabled = false;
            FindObjectOfType<CarUserControl>().enabled = false;
            Invoke("DisableRigibody", 2f);
        }

    }

    public void PlayLapSound()
    {
        audioSource.PlayOneShot(LapSound);
    }

    public void PlayCrashSound()
    {
        audioSource.PlayOneShot(Crash);
    }

    private void DisableRigibody()
    {
        FindObjectOfType<Rigidbody>().isKinematic = true;
    }

}
