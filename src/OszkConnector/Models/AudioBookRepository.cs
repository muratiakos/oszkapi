﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OszkConnector.Models
{
    public class AudioBookRepository : IAudioBookRepository
    {
        public IQueryable<BookResult> Find(string query = "")
        {
            var client = new Client();
            return client.FindAudioBook(query).Result;
        }

        public Book Get(string Id)
        {
            var client = new Client();
            return client.GetBook(Id).Result;
        }

        public IQueryable<BookResult> GetAll()
        {
            return Find();
        }
    }
}
