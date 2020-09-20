﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  [Header("Ball")]
  public GameObject ball;

  [Header("Player 1")]
  public GameObject Player1Paddle;
  public GameObject Player1Goal;

  [Header("Player 2")]
  public GameObject Player2Paddle;
  public GameObject Player2Goal;

  [Header("Score UI")]
  public GameObject Player1Text;
  public GameObject Player2Text;

  private int Player1Score;
  private int Player2Score;

  public void Player1Scored()
  {
      Player1Score++;
      Player1Text.GetComponent<Player1Score>().text = Player1Score.ToString();
      ResetPosition();
  }

  public void Player2Scored()
{
    Player2Score++;
    Player2Text.GetComponent<Player2Score>().text = Player2Score.ToString();
}  
}
