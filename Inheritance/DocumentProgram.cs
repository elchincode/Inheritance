﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class DocumentProgram
    {
        public string basic = "";
        public string pro = "";
        public string expert = "";




        
    public void OpenDocument()
    {
        Console.WriteLine("Document Opened ");

    }
    public virtual void  EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");

    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }

    }
}
