using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  
  public static GameManager instance;
  private void Awake()
  {
    if (instance == null)
      instance = this;
  }

  public int EnemyTowerHealth;
  public int PlayerTowerHealth;

  public int enemyDamage;
  public int playerDamage;

  public TextMeshProUGUI enemyTowerText;
  public TextMeshProUGUI playerTowerText;

  public AudioSource collisonSound;
  public AudioSource createdSound;



  private void Start()
  {
    EnemyTowerHealth = 100;
    PlayerTowerHealth = 100;
    SetTexts();
  }

  public void GetDamage(string tag)
  {
    if (tag.Equals("Enemy"))
    {
      PlayerTowerHealth -= enemyDamage;
    }
    else if(tag.Equals("Player"))
    {
      EnemyTowerHealth -= playerDamage;
    }
    SetTexts();
  }

  private void SetTexts()
  {
    enemyTowerText.text = EnemyTowerHealth.ToString();
    playerTowerText.text = PlayerTowerHealth.ToString();
  }
}
