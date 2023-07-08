using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Operation") && this.gameObject.CompareTag("Player"))
        {
            Operations operations = new Operations();
            operations = other.GetComponent<Operations>();
            GameManager.instance.createdSound.Play();

            switch (operations.SelectOperation)
            {
                case Operations.Operation.Addition:
                    operations.AddPlayer(this.gameObject,operations.value);
                    break; 
            
                case Operations.Operation.Multiplication:
                    operations.MultiplePlayer(this.gameObject,operations.value);
                    break; 
            
                case Operations.Operation.Division:
                    Debug.Log("Bölme");
                    break; 
            
                case Operations.Operation.Subtraction:
                    Debug.Log("Çıkarma");
                    break;
            
            }
        }
       
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("CreatedEnemy") )
        {
            GameManager.instance.collisonSound.Play();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
          

        }

        if (collision.gameObject.CompareTag("EnemyTower"))
        {
            GameManager.instance.GetDamage("Enemy");
            Destroy(this.gameObject);
        }
    }
}
