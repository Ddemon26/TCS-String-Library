# TCS String Library

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)
![Discord](https://img.shields.io/discord/1047781241010794506)

![GitHub Forks](https://img.shields.io/github/forks/Ddemon26/TCS-String-Library)
![GitHub Contributors](https://img.shields.io/github/contributors/Ddemon26/TCS-String-Library)
![GitHub Stars](https://img.shields.io/github/stars/Ddemon26/TCS-String-Library)
![GitHub Repo Size](https://img.shields.io/github/repo-size/Ddemon26/TCS-String-Library)

## Overview

The **TCS String Library** is a Unity-focused library designed for generating various random strings used in gameplay scenarios. This library provides a simple interface for developers to generate random names, surnames, occupations, countries, animals, and different types of dialogues. The goal is to aid developers by providing a quick way to access dynamic text elements during runtime, enhancing player immersion and interaction with procedurally generated content.

### Key Features

- **Random String Generation**: Generate random names, surnames, occupations, and countries.
- **Dialogue Generation**: Generate various types of dialogues, including jokes, greetings, threats, and more.
- **Extension Methods**: Access the library's functionality through convenient string extension methods.

## Installation

1. Clone the repository into your Unity project's `Assets` folder:
   ```bash
   git clone https://github.com/Ddemon26/TCS-String-Library.git
   ```
2. Open your Unity project, and the library will be automatically detected as part of the solution.

## Usage

### Example 1: Generating Random Names

```csharp
using TC.StringLibrary;

public class ExampleScript : MonoBehaviour {
    void Start() {
        string randomName = "".GetRandomName();
        Debug.Log("Random Name: " + randomName);
    }
}
```

### Example 2: Generating Random Dialogue

```csharp
using TC.StringLibrary;

public class DialogueScript : MonoBehaviour {
    void Start() {
        string randomDialogue = "".GetRandomDialogue();
        Debug.Log("Random Dialogue: " + randomDialogue);
    }
}
```

### Example 3: Getting a Random Country

```csharp
using TC.StringLibrary;

public class CountryScript : MonoBehaviour {
    void Start() {
        string randomCountry = "".GetRandomCountry();
        Debug.Log("Random Country: " + randomCountry);
    }
}
```

## Contributing

We welcome contributions! Feel free to submit a pull request or open an issue if you find any bugs or have suggestions for improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
