using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandeler : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {
	public static GameObject itemBeingDragged;
	Vector3 startPosition;

    public Image bone;
    public Image progressbar;
    public bool coolingDown;
    public float waitTime = 30.0f;

    void Update()
    {
        if (coolingDown == true)
        {
            //Reduce fill amount over 30 seconds
         //   cooldown.fillAmount -= 1.0f / waitTime * Time.deltaTime;
        }
    }
	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = this.transform.position;

	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		this.transform.position = Input.mousePosition;
        progressbar.fillAmount += 5.0f / waitTime * Time.deltaTime;
        bone.fillAmount += 1.0f / waitTime * Time.deltaTime;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
       
		//this.transform.position = startPosition;
	}

    



	#endregion
	
}
