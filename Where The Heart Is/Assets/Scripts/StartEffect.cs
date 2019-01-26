using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartEffect : MonoBehaviour

    
{
    public GameObject image;

    private void Start()
    {
        // MopImage = gameObject.transform.Find("Sprite").gameObject;

        Show(image);
    }

    //If button is being hovered over show Mop on the Left
    public void OnMouseEnter()
    {
        Debug.Log("Jeb");
        Hide(image);
    }
    private void OnMouseOver()
    {
        Hide(image);
    }
    private void OnMouseExit() //hide mop when not hovered
    {
        Show(image);
    }

    ////same as above but with controller
    //void ISelectHandler.OnSelect(BaseEventData eventData)
    //{
    //    Hide(image);
    //}
    //void IDeselectHandler.OnDeselect(BaseEventData eventData)
    //{
    //    Show(image);
    //}

    // shows and hides objects
    public void Show(GameObject TheObject)
    {
        TheObject.SetActive(true);
    }

    public void Hide(GameObject TheObject)
    {
        TheObject.SetActive(false);
    }
    //    public GameObject PictureStart;

    //// Start is called before the first frame update
    //void Start()
    //    {
    //        PictureStart.SetActive(true);  
    //    }

    //    public void OnMouseEnter()
    //    {
    //        PictureStart.SetActive(false);
    //    }

    //    public void OnMouseOver()
    //    {
    //        Debug.Log("off");
    //        PictureStart.SetActive(false);
    //    }

    //    public void OnMouseExit()
    //    {
    //        Debug.Log("on");
    //        PictureStart.SetActive(true);
    //    }
}
