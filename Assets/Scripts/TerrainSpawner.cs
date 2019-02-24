﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public Terrain terrain;
    public GameObject road;

    GameObject player;

    List<Terrain> terrains;
    List<GameObject> roads;

    float defaultTerrainX = -250;
    float defaultTerrainY = -3;

    Terrain terrain1;
    Terrain terrain2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        terrains = new List<Terrain>();
        roads = new List<GameObject>();

        Terrain terrain1 = Instantiate(terrain, new Vector3(defaultTerrainX, defaultTerrainY, -10), Quaternion.identity, null);
        terrains.Add(terrain1);

        Terrain terrain2 = Instantiate(terrain, new Vector3(defaultTerrainX, defaultTerrainY, 490), Quaternion.identity, null);
        terrains.Add(terrain2);

        GameObject road1 = Instantiate(road, new Vector3(0, -2.6f, 240), Quaternion.identity, null);
        roads.Add(road1);

        GameObject road2 = Instantiate(road, new Vector3(0, -2.6f, 740), Quaternion.identity, null);
        roads.Add(road2);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > (terrains[0].transform.position.z + terrain.terrainData.size.z))
        {
            terrains[0].transform.Translate(0, 0,  terrains[1].terrainData.size.z * 2);

            Terrain temp = terrains[0];
            terrains.Remove(terrains[0]);
            terrains.Add(temp);


            roads[0].transform.Translate(0, 0, terrains[1].terrainData.size.z * 2);

            GameObject tempRoad = roads[0];
            roads.Remove(roads[0]);
            roads.Add(tempRoad);

        }
        

        // if the player reaches the second terrain
        // delete the first terrain
        // spawn a new one in front of the second original terrain

        // if the first terrain 
    }
}