# Sidera Keyword Parsing Library
Copyright &copy; 2024 Sidera Enterprises. All rights reserved.

## Introduction
This library provides keyword parsing functionality which application developers can implement into their own projects.

A **keyword** is defined in this context as a substring of a given expression which is assigned a value of a given data type. A keyword must be encapsulated in a pair of opening and closing square brackets to form a **placeholder**. A keyword may also precede formatting instructions such as a format string, substring range, and character casing in any combination.

A placeholder is defined in the following format:

<code>[keyword(format){m, n}:casing]</code>

such that:
* <code>keyword</code> represents the keyword name defined in the parser dictionary;
* <code>format</code> represents the format string by which to represent the resultant value;
* <code>m</code> represents the start index of the substring range and <code>n</code> represents the length of the substring captured;
* <code>casing</code> may be "UPPERCASE" or "LOWERCASE"; and
* these are optional and may be placed in any order, but must be preceded by the keyword.
