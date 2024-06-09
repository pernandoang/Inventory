using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActive : MonoBehaviour
{
    [SerializeField] public float Speed;
    public GameObject ItemSpawn;
    public Image item1;
    public List<GameObject> InventoryList;

    private void Update()
    {
        Movement();
        SpawnItem();
    }

    private void Movement()
    {
        float MovH = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        transform.Translate(new Vector3(MovH, 0));
    }
    private void SpawnItem()
    {
        if (Input.GetKey(KeyCode.E))
        {
            int CountSpawn = 0;
            CountSpawn++;
            if (CountSpawn <= InventoryList.Count)
            {
                Instantiate(InventoryList[0],ItemSpawn.transform.position,ItemSpawn.transform.rotation);
                InventoryList.RemoveAt(0);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            InventoryList.Add(collision.gameObject);
            item1.sprite = collision.gameObject.GetComponent<SpriteRenderer>().sprite;
            item1.color = Color.blue;
        }
        if (collision.gameObject.name == "Sword")
        {

        }
    }
}
