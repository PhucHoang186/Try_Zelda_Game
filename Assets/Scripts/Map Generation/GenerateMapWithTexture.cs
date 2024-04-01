using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace MapGeneration
{
    public class GenerateMapWithTexture : MonoBehaviour
    {
        [SerializeField] float stepOffset;
        [SerializeField] Texture2D mapDataTexture;
        [SerializeField] List<MapObjectData> mapObjectDatas;
        private List<GameObject> mapObjects = new();

        [Button]
        public void GenerateMap()
        {
            DestroyMap();
            int width = mapDataTexture.width;
            int height = mapDataTexture.height;
            mapObjects.Clear();

            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < width; z++)
                {
                    Color pixelColor = mapDataTexture.GetPixel(x, z);
                    if (pixelColor.a == 0f)
                        continue;

                    MapObjectData mapObjectData = GetMapObjectDataByColor(pixelColor);
                    if (mapObjectData == null)
                        continue;

                    GameObject mapObject = Instantiate(mapObjectData.prefabMap, new Vector3(stepOffset * x, 0f, stepOffset * z), Quaternion.identity);
                    mapObject.transform.parent = transform;
                    mapObjects.Add(mapObject);
                }
            }
        }

        [Button]
        public void DestroyMap()
        {
            foreach (var mapObject in mapObjects)
            {
                DestroyImmediate(mapObject);
            }
            mapObjects.Clear();
        }

        private MapObjectData GetMapObjectDataByColor(Color color)
        {
            for (int i = 0; i < mapObjectDatas.Count; i++)
            {
                if (mapObjectDatas[i].colorMap == color)
                    return mapObjectDatas[i];
            }
            return null;
        }
    }

    [Serializable]
    public class MapObjectData
    {
        public Color colorMap;
        public GameObject prefabMap;
    }
}
