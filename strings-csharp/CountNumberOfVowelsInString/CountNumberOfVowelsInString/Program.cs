﻿using System.Buffers;
using BenchmarkDotNet.Running;
using CountNumberOfVowelsInString;

var vowels = new HashSet<char> { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
var vowelsAsSpan = "AEIOUaeiou".AsSpan();
var sentence = "In the vast expanse of the universe, countless galaxies swirl in a cosmic dance, each telling a unique story of creation and destruction.";
var sentenceAsSpan = "In the vast expanse of the universe, countless galaxies swirl in a cosmic dance, each telling a unique story of creation and destruction.".AsSpan();
SearchValues<char> vowelsSearchValues = SearchValues.Create(vowelsAsSpan);

Console.WriteLine(sentence);

Console.WriteLine($"The number of vowels counted using For loop is: {VowelCounters.CountVowelsUsingForLoop(sentenceAsSpan, vowelsAsSpan)}");
Console.WriteLine($"The number of vowels counted using ForEach loop is: {VowelCounters.CountVowelsUsingForEachLoop(sentenceAsSpan, vowelsAsSpan)}");
Console.WriteLine($"The number of vowels counted using SearchValues is: {VowelCounters.CountVowelsUsingSearchValues(sentenceAsSpan, vowelsSearchValues)}");
Console.WriteLine($"The number of vowels counted using Switch statement is: {VowelCounters.CountVowelsUsingSwitchStatement(sentenceAsSpan)}");
Console.WriteLine($"The number of vowels counted using RegEx is: {VowelCounters.CountVowelsUsingRegEx(sentence)}");
Console.WriteLine($"The number of vowels counted using Regex Replace and Length is: {VowelCounters.CountVowelsUsingRegexReplaceAndLength(sentence)}");
Console.WriteLine($"The number of vowels counted using LINQ is: {VowelCounters.CountVowelsUsingLinq(sentence, vowels)}");

//BenchmarkRunner.Run<VowelCountersBenchmarks>();