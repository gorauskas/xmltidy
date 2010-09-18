using System;
using System.IO;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

using Mono.Options;

namespace XmlTidy 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      ParseCommandLine(args);
      try 
      {
        XmlTidy(args[0]);
      } 
      catch (FileNotFoundException ex) 
      {
        Console.WriteLine("{0}: {1}", ex.Message, ex.FileName);
      }
    }

    static void XmlTidy(string filename) 
    {
      if (File.Exists(filename)) 
      {
        var doc = XDocument.Load(filename);
        doc.Save(filename, SaveOptions.None);
      } 
      else 
      {
        throw new FileNotFoundException("File not found", filename);
      }
    }

    static void ParseCommandLine(string[] args)
    {
      
    }

    static void ShowVersion()
    {
      
    }

    static void ShowUsage()
    {
      
    }

    
  }
}
