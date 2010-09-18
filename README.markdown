# XML Tidy #

A very simple tool written in C Sharp to properly format XML files.

## Motivation ##

In the recent past I have been working with some large XML files that come to
me as a single line of XML output. There are time when I need to open one of
these files in an editor for reading, particularly when I am doing a
development task. This tool is the result for the need to format these XML
files into a human-readable output. 

There probably are other tools out that that achieve the same, but it's always
more fun to write your own. 

## Requirements ## 

There are two main requirements for this tool to work:

1. **Mono.Options** - Find more about it [here](http://tirania.org/blog/archive/2008/Oct-14.html) and [here](http://www.ndesk.org/Options). 
2. **LINQ to XML** - Or more precisely, the System.Xml.Linq namespace.

## How it Works ##

After you compile the source, working with XmlTidy is as simple as making the
following call on the command line:

    xmltidy myxmlfile.xml

### Command Line Options ###


### Further Information ###

I wrote a blog post about XmlTidy and you can read it [here](). 
