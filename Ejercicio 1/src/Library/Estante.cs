﻿using System;
using System.Collections.Generic;


namespace SRP
{
    public class ShelveBook
    {

        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        
        public ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }


    }
}
