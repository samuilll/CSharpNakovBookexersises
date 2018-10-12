﻿using Utilities;

namespace Chapter_11_CreatingAndUsingObjects.Problem11
{
    class Problem_11 : Problem
    {
        public override void Run()
        {
            AdvertisementMessagesGenerator advertisementGenerator = new AdvertisementMessagesGenerator();

            Writer.WriteLine("Random message generator says:");
            Writer.WriteLine(advertisementGenerator.Generate());
        }
    }
}