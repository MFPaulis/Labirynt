using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PutMeSomewhere : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    public GameObject objectInRightPlace;
    GameObject rightPlace;
    Vector3 startPosition;
    Inventory inventory;
    int id;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    /*public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        Vector2 ray = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        RaycastHit2D hitInfo = Physics2D.Raycast(ray, Vector2.zero);
        if (hitInfo.collider != null && hitInfo.transform.gameObject == rightPlace)
        {
             inventory.isFull[id] = false;
             Instantiate(objectInRightPlace, rightPlace.transform, false);
             Destroy(gameObject);
        }
        else transform.position = startPosition;
    }*/


    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null && hit.transform.gameObject == rightPlace)
        {
            inventory.isFull[id] = false;
            Instantiate(objectInRightPlace, rightPlace.transform, false);
            Destroy(gameObject);
        }
        else
        {
            if (hit.collider != null) Debug.Log(hit.transform.gameObject.name);
            transform.position = startPosition;
        }
    }

    public void SetId(int newId)
    {
        id = newId;
    }

    public void SetRightPlace(GameObject newPlace)
    {
        rightPlace = newPlace;
    }

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }




}
