using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerActive : MonoBehaviour
{
    [SerializeField] public float Speed;
    public List<GameObject> InventoryList;

    private void Update()
    {
        Movement();
        foreach (var item in InventoryList)
        {
            Debug.Log(item.name);
        }
    }

    private void Movement()
    {
        float MovH = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        transform.Translate(new Vector3(MovH, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            InventoryList.Add(collision.gameObject);
            /*Destroy(collision.gameObject);*/
        }
        if (collision.gameObject.name == "Sword")
        {

        }
    }
}
