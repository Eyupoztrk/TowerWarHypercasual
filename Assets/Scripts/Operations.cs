using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public int value;
    public enum Operation
    {
        Addition, Subtraction, Multiplication, Division
    }

    public Operation SelectOperation;

    public void AddPlayer(GameObject player, int Times)
    {
        for (int i = 0; i < Times; i++)
        {
            GameObject createdPlayer = Instantiate(player, player.gameObject.transform.position, Quaternion.identity);
            if (createdPlayer.CompareTag("Enemy"))
            {
                createdPlayer.transform.localEulerAngles = new Vector3(0,180,0);
                createdPlayer.gameObject.tag = "CreatedEnemy";
            }
            else
               createdPlayer.gameObject.tag = "CreatedPlayer";
        }
      
    }
    
    public void MultiplePlayer(GameObject player, int Times)
    {
        for (int i = 0; i < Times-1; i++)
        {
            GameObject createdPlayer = Instantiate(player, player.gameObject.transform.position, Quaternion.identity);
            if (createdPlayer.CompareTag("Enemy"))
            {
                createdPlayer.transform.localEulerAngles = new Vector3(0,180,0);
                createdPlayer.gameObject.tag = "CreatedEnemy";
            }
            else
                createdPlayer.gameObject.tag = "CreatedPlayer";
        }
      
    }
}
