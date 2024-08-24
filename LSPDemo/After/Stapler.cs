﻿using ISPDemo.Models;

namespace ISPDemo.After
{
    public class Stapler : IStapler
    {
        public void Staple(List<Document> documents)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine("Stapling {0}...", doc.Text);
            }
            Console.WriteLine("Items stapled" + documents.Count);
        }
    }
}
