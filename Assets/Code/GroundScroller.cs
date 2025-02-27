﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float _ScrollSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get the current offset
        Vector2 currentTextureOffset = GetComponent<Renderer>().material.GetTextureOffset("_MainTex");

        // Determine the amount to scroll this frame
        float distancetoScroll = Time.deltaTime * _ScrollSpeed;

        // Calculate the new offset (Add current + distance)
        float newTextureOffset_X = currentTextureOffset.x + distancetoScroll;

        // Create a new Vector2 with the updated offset
        currentTextureOffset = new Vector2(newTextureOffset_X, currentTextureOffset.y);

        // Set the offset to our new value
        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", currentTextureOffset);
    }
}
