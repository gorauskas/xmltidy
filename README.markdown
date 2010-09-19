# XML Tidy #

A very simple tool written in C Sharp to properly format XML files.

## Motivation ##

In the recent past I have been working with some large XML files that come to
me as a single line of XML output. There are times when I need to open one of
these files in an editor for reading, particularly when I am doing a
development task. This tool stems from the need to format these XML files into
a human-readable output.

There probably are other tools out there that achieve the same result, but it's
always more fun to write your own.

## Requirements ##

There are two main requirements for this tool to work:

1. **Mono.Options** - Find more about it
   [here](http://tirania.org/blog/archive/2008/Oct-14.html) and
   [here](http://www.ndesk.org/Options).  
   - What I have been doing is to
     compile the sources for Mono.Options on the target platform (.Net 4 or Mono
     2.6.7) and copying the respective assemblies to a dotnet or mono folder
     respectively. The build scripts use those folders to build XmlTidy.
2. **LINQ to XML** - Or more precisely, the System.Xml.Linq namespace.

## How it Works ##

After you compile the source, working with XmlTidy is as simple as making the
following call on the command line:

    xmltidy myxmlfile.xml

### Command Line Options ###

    C:\>xmltidy.exe -?
    
    Usage: xmltidy.exe [OPTIONS]* [FILENAME]+
    Properly formats and indents a valid XML file. At least one
    valid xml file name is expected. No options are required.
    
    Options:
      -?, -h, --help             Show this help message and exit.
      -V, --version              Show version information and exit.
      -v, --verbose              Increase message verbosity.
      -b, --backup               Make a copy of input before tidying it.

### Further Information ###

I wrote a blog post about XmlTidy and you can read it
[here](http://blog.theblinkingcursor.org/2010/09/tidy-up-your-xml-files.html). The
post goes into how XmlTidy works internally. You can run the rss and atom feed
files under the `samples` folder through XmlTidy to see the results. Right
after you run the build script, here is a how you can test it:

    .\bin\xmltidy.exe -v -b .\samples\blog.theblinkingcursor.org.atom.xml .\samples\esr.ibiblio.org.rss.xml

The above will echo verbose output, backup the files, and then process each
file in turn. I have run XmlTidy on Windows 7 with .NET 4 and on Ubuntu 10.04
with Mono 2.6.7

