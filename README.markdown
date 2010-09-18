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

1. **Mono.Options** - Can be found here: 
2. **LINQ to XML** - Or more precisely, the System.Xml.Linq namespace.

## How it Works ##

