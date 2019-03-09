﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomButton : MonoBehaviour
{
    public static bool Cliker = false;
    public GameObject Room;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Cliker)
        {
            Instantiate(Room);
            Cliker = false;
        }
    }
}
