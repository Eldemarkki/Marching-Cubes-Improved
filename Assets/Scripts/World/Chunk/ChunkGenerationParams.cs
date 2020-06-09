﻿using UnityEngine;

namespace Eldemarkki.VoxelTerrain.World.Chunks
{
    /// <summary>
    /// Parameters that specify how a chunk will be generated
    /// </summary>
    [System.Serializable]
    public class ChunkGenerationParams
    {
        /// <summary>
        /// The chunk's size. This represents the width, height and depth in Unity units.
        /// </summary>
        [SerializeField] private int chunkSize = 16;

        /// <summary>
        /// The density level where a surface will be created. Densities below this will be inside the surface (solid),
        /// and densities above this will be outside the surface (air)
        /// </summary>
        [SerializeField] private float isolevel = 0;

        /// <summary>
        /// The chunk's prefab that will be instantiated
        /// </summary>
        [SerializeField] private GameObject chunkPrefab = null;

        /// <summary>
        /// The chunk's size. This represents the width, height and depth in Unity units.
        /// </summary>
        public int ChunkSize => chunkSize;

        /// <summary>
        /// The density level where a surface will be created. Densities below this will be inside the surface (solid),
        /// and densities above this will be outside the surface (air)
        /// </summary>
        public float Isolevel => isolevel;

        /// <summary>
        /// The chunk's prefab that will be instantiated
        /// </summary>
        public GameObject ChunkPrefab => chunkPrefab;
    }
}