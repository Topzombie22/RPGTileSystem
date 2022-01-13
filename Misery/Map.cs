﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Misery
{
    class Map
    {
        private List<CollisionTiles> collisionTiles = new List<CollisionTiles>();

        public int currentTile;

        public List<CollisionTiles> CollisionTiles
        {
            get { return collisionTiles; }
        }

        private int width, height;
        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public Map() { }

        public void Generate(int[,] map, int size)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    int number = map[y, x];

                    if (number > 0)
                    {
                        collisionTiles.Add(new CollisionTiles(number, new Rectangle(x * size, y * size, size, size)));
                    }

                    width = (x + 1) * size;
                    height = (y + 1) * size;
                }
            }
        }

        public void MapStory(int Tile)
        {
            if (Tile == 0)
            {

                Generate(new int[,] {
            {2,2,2,2,2,2,2,0},
            {1,1,1,1,2,1,1,0},
            {1,1,1,1,2,1,1,1},
            {2,2,2,2,2,1,1,2},
            {1,1,1,1,2,1,1,2}, }, 64);

            }

            if (Tile == 1)
            {

                Generate(new int[,] {
            {2,1,1,1,1,1,1,0},
            {1,1,1,1,2,1,1,0},
            {1,1,1,1,2,1,1,1},
            {2,2,2,2,2,1,1,2},
            {1,1,1,1,2,1,1,2}, }, 64);

            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (CollisionTiles tile in collisionTiles)
            {
                tile.Draw(spriteBatch);
            }
        }

    }
}
