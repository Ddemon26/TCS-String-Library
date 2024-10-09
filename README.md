# TCS String Library

![License](https://img.shields.io/github/license/Ddemon26/TCS-String-Library?style=flat-square) ![GitHub issues](https://img.shields.io/github/issues/Ddemon26/TCS-String-Library?style=flat-square) ![GitHub stars](https://img.shields.io/github/stars/Ddemon26/TCS-String-Library?style=flat-square) ![GitHub forks](https://img.shields.io/github/forks/Ddemon26/TCS-String-Library?style=flat-square) ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/Ddemon26/TCS-String-Library/ci.yml?branch=main&style=flat-square)

## Overview
The **TCS String Library** is a comprehensive collection of utilities and data structures designed to facilitate sophisticated handling and manipulation of strings within Unity environments. This library encompasses a wide array of unique string datasets, including but not limited to names, surnames, countries, animals, and occupations. As such, it is an invaluable tool for dialogue systems, procedural content generation, and any scenario necessitating dynamic textual manipulation.

Crafted with Unity developers in mind, this library offers precompiled string resources and extensive extensions that simplify typical string operations. The package is developed with an emphasis on modularity, reusability, and efficiency, providing an elegant approach to handle the common yet complex aspects of text processing in game development.

## Features
- **Comprehensive String Collections**: A repository of predefined, unique string collections, such as personal names, surnames, geographical locations, animal species, and occupational titles.
- **Advanced String Extensions**: Utility methods provided as extensions to facilitate sophisticated string manipulation and formatting.
- **Seamless Unity Integration**: Structured for compatibility with Unity, utilizing Unity's assembly definition (`.asmdef`) to ensure modular integration, minimizing project coupling and build complexity.
- **Extensive Testing Suite**: A robust suite of unit tests to validate the functionality and reliability of the library, thus ensuring consistent performance in a production environment.

## Installation
To incorporate the TCS String Library into your Unity project:

1. Clone the repository or download the provided ZIP archive.
2. Extract the contents to the `Assets` directory of your Unity project.
3. Ensure proper placement of the `TCS.StringLibrary.asmdef` to facilitate seamless integration into Unity's assembly definition system.

Alternatively, the repository can be added as a Git submodule or integrated via Unity's package manager for greater modularity.

## Usage
The primary interface of the library is the `StringLibrary` class, which provides static methods to access diverse string categories and operations. Consider the following usage scenario:

```csharp
using TC.StringLibrary;
using UnityEngine;

public class ExampleUsage : MonoBehaviour {
    void Start() {
        // Accessing unique names from the library
        string randomName = StringLibrary.GetRandomName();
        Debug.Log("Random Name: " + randomName);
    }
}
```

In the above example, `StringLibrary.GetRandomName()` retrieves a randomly selected name from the precompiled collection of unique names, demonstrating how easily developers can leverage the library's resources.

### Core Components
- **StringLibrary.cs**: The principal static class that facilitates access to various unique string datasets, including names, surnames, countries, and more.
- **StringLibraryExtensions.cs**: Contains extension methods that augment Unity's string handling capabilities, offering enhanced functionality for querying and manipulating strings.

## Testing
The repository includes a comprehensive set of unit tests that verify the correctness and robustness of the library's functionality. These tests are housed in the `Tests` directory and can be executed using Unity's native Test Runner tool.

To execute the tests:
1. Open Unity and navigate to the `Test Runner` window.
2. Select and run the tests to verify the library's correct operation.

## Project Structure
- **Runtime/Core**: Houses the core utilities that form the backbone of the string library, including `StringLibrary.cs` and the associated extension methods.
- **Runtime/People**: Contains scripts related to the generation and manipulation of personal names and related data.
- **Runtime**: Encompasses the primary components that are directly utilized within Unity scenes.
- **Tests**: Includes unit tests that ensure the reliability and consistency of the library's functionalities.
- **Resources**: Contains supplementary data or assets that are required by the library during runtime execution.

## Contributing
Contributions to the TCS String Library are highly encouraged. To contribute:
1. Fork the repository.
2. Create a feature branch (`feature/your-feature-name`).
3. Commit your changes with clear and concise messages.
4. Submit a pull request for review.

Please ensure that any new functionality is covered by appropriate unit tests to maintain code integrity.

## License
This project is licensed under the MIT License. Refer to the [LICENSE](LICENSE) file for complete details.

## Acknowledgements
- **JetBrains Annotations**: This library leverages JetBrains Annotations to improve code quality, enhance maintainability, and ensure precise, readable implementation.
- **Unity**: Developed with native Unity compatibility, enabling effortless integration into existing Unity projects and enhancing development workflows.

## Contact
For inquiries, feature requests, or to report issues, please open an issue in the GitHub repository.

---

Empower your Unity projects with sophisticated string manipulation capabilities using the TCS String Library. The community welcomes exploration, use, and contributions to further enhance this tool's utility.

