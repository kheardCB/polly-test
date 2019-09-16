# polly-test

A simple test project for [Polly](http://www.thepollyproject.org)

Here are the [instructions](https://github.com/App-vNext/Polly/wiki/Polly-and-HttpClientFactory) on how to use Polly with HttpClientFactory.

## PollyTest.Api

A default web api project

## PollyTest.Client

A default web api project that uses Polly to call the PollyTest.Api, configured for retry.

References the Microsoft.Extensions.Http.Polly nuget package.