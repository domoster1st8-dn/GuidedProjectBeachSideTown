using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera_OverView;
    public Camera camera_Shop;
    public Camera camera_player;
    // Start is called before the first frame update
    void Start()
    {
        camera_OverView.gameObject.SetActive(true);
        camera_Shop.gameObject.SetActive(false);
        camera_player.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            OverViewCam();
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ShopCam();
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PlayerCam();
        }
    }

    void OverViewCam()
    {
        camera_OverView.gameObject.SetActive(true);
        camera_Shop.gameObject.SetActive(false);
        camera_player.gameObject.SetActive(false);
    }

    void ShopCam()
    {
        camera_OverView.gameObject.SetActive(false);
        camera_Shop.gameObject.SetActive(true);
        camera_player.gameObject.SetActive(false);
    }
    void PlayerCam()
    {
        camera_OverView.gameObject.SetActive(false);
        camera_Shop.gameObject.SetActive(false);
        camera_player.gameObject.SetActive(true);
    }
}
