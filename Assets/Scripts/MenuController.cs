using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public RectTransform panel;
    public RectTransform carMenu;
    public float moveSpeed = 5f; // Speed at which the camera moves
    public float width = 1400f;

    public int currentItemIndex = 0; // Current index of the visible item
   

    public void MoveRight()
    {
        if (currentItemIndex < 2) // Index of the last item
        {
            currentItemIndex++;
           
        }
    }

    public void MoveLeft()
    {
        if (currentItemIndex > 0) // Index of the first item
        {
            currentItemIndex--;
          
        }
    }


    private void Update()
    {
        Vector3 finalposition = new Vector3(-currentItemIndex * width, 0f, 0f);
        panel.transform.localPosition = Vector3.Lerp(panel.transform.localPosition, finalposition, 0.1f);
    }

    public void SetTrack(int track_num)
    {
        PlayerPrefs.SetInt("Track", track_num);
        panel.gameObject.SetActive(false);
        ActivateCarMenu();

    }

    public void SetCar(int car_num)
    {
        PlayerPrefs.SetInt("Car", car_num);
        SceneManager.LoadScene("Circuit " + PlayerPrefs.GetInt("Track"));
    }


    public void ActivateCarMenu()
    {
        currentItemIndex = 0;
        carMenu.gameObject.SetActive(true);
        GameObject.Find("TrackMenu").transform.gameObject.SetActive(false);

    }



}
