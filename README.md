# AnimateForms

[![Travis (.com)](https://img.shields.io/travis/com/SDBagel/AnimateForms.svg?style=flat-square)](https://travis-ci.com/SDBagel/AnimateForms) [![GitHub All Releases](https://img.shields.io/github/downloads/SDBagel/AnimateForms/total.svg?style=flat-square)](https://github.com/SDBagel/AnimateForms/releases)

[![Nuget](https://img.shields.io/nuget/v/AnimateForms.svg?style=flat-square)](https://www.nuget.org/packages/AnimateForms/)  [![Nuget](https://img.shields.io/nuget/dt/AnimateForms.svg?label=nuget%20downloads&style=flat-square)](https://www.nuget.org/packages/AnimateForms/)

AnimateForms is a lightweight, async library for Windows Forms that provides an easy to use API. This library is inspired by the JS library [anime.js](https://animejs.com), and aims to implement some basic features similar to or functionally equivalent to that library.

# Installation, Usage, and Documentation

Complete code documentation is available [here](https://sdbagel.github.io/AnimateForms/). It includes methods and detailed descriptions on all aspects of the library. If something is missing, please create a pull request or an issue on this repository.

A beginner's quickstart guide can be found [here](https://sdbagel.github.io/AnimateForms/Quickstart/). This covers creating a new WinForms project, installing the library, and putting together a small application using AnimateForms and the tools it offers. 

A version number will appear at the top of both pages - this is the version that they are updated to, and downloading a newer version of the library may result in unexpected behaviour.

# What's Next

Due to general limitations with WinForms, not everything can be as cleanly ported over to this library as I would like, at least immediately. As such, syntax of using the library may change drastically over development in an attempt to make things as neat as possible. Semver will be used (X.Y.Z) where X indicates breaking changes, Y indicates backwards compatible feature or code implementations, and Z indicates bug fixes. We are currently in alpha, meaning potentially lots of breaking changes, and very fast. The "I Changed My Mind" counter (version number) will be reset to 1.0.0 when beta comes around.

Because spamming commits writing down every new idea I have isn't exactly the most efficient thing ever, this repo has a project board outlining stuff I personally want added. If you want something added that isn't there, make a feature request!