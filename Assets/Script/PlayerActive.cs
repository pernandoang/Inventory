using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActive : MonoBehaviour
{
    [SerializeField] public float Speed;
    public Image item1;
    public List<GameObject> InventoryList;

    private void Update()
    {
        Movement();
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
            item1.sprite = collision.gameObject.GetComponent<SpriteRenderer>().sprite;
            item1.color = Color.blue;
            /*Destroy(collision.gameObject);*/
        }
        if (collision.gameObject.name == "Sword")
        {

        }
    }
}
