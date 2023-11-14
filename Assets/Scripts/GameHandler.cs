﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameHandler : MonoBehaviour {

    [SerializeField] private Snake snake;

    private LevelGrid levelGrid;

    private void Start() {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(10,10);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

}
