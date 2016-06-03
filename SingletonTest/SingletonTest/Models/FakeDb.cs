using System;
using System.Collections.Generic;

namespace SingletonTest.Models
{
    public sealed class FakeDb
    {
        private readonly List<string> contentList;

        private static readonly Lazy<FakeDb> Lazy = new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance => Lazy.Value;

        private FakeDb()
        {
            contentList = new List<string> { "First string", "Second string" };
        }
        
        public void Add(string stringToAdd)
        {
            contentList.Add(stringToAdd);
        }

        public List<string> GetAll()
        {
            return contentList;
        }
    }
}