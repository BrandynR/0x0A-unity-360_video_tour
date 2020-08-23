using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSkybox : MonoBehaviour {
   GameObject hotspotImage;
   public GameObject infoBox;
   //public GameObject infoButton;
 //public Material skybox;
 //public GameObject hotspot;
 //public GameObject currentHotspot;

 // Use this for initialization
 /*public void SkyboxSwitch () {
    currentHotspot.SetActive(false);
    hotspot.SetActive(true);
    RenderSettings.skybox = skybox;
 }*/
 public void Awake()
 {
    hotspotImage = GameObject.FindWithTag("Hotspot");
 }
 public void LoadCantina()
 {
   hotspotImage.transform.localScale = new Vector3(3f, 3f, 3f);
   SceneManager.LoadScene(1);
 }
 
 public void LoadCube()
 {
    hotspotImage.transform.localScale = new Vector3(3f, 3f, 3f);
    SceneManager.LoadScene(2);
 }
 
 public void LoadLivingRoom()
 {
    hotspotImage.transform.localScale = new Vector3(3f, 3f, 3f);
    SceneManager.LoadScene(0);
 }
 
 public void LoadMezzanine()
 {
    hotspotImage.transform.localScale = new Vector3(3f, 3f, 3f);
    SceneManager.LoadScene(3);
 }
 public void InfoBoxPopUp()
 {
    if (infoBox.activeInHierarchy == false)
   {
      //infoButton.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
      infoBox.SetActive(true);
   }
   else
   {
      //infoButton.transform.localScale = new Vector3(1f, 1f, 1f);
      infoBox.SetActive(false);
   }
 }

}
