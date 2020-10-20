# Advent Of Code 2019 C# repo

## To create a new csharp project through terminal for use with VS Code or Github Codespaces, follow these steps:

```
dotnet new console
```

Then to run the freshly created sourcecode:

```
dotnet run
```
Source: https://code.visualstudio.com/docs/languages/dotnet


## .gitignore

To make it easier tracking changes in git, add a .gitignore file containing the artifacts folders created by the compiler:


```
touch .gitignore
```

Add following text in the new .gitignore:

```
obj
bin
```