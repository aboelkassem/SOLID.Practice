﻿using ISPDemo.Models;

namespace ISPDemo.Before
{
    interface IMachine
    {
        void Print(List<Document> documents);
        void Fax(List<Document> documents);
        void Scan(List<Document> documents);
        void PhotoCopy(List<Document> documents);
    }
}
