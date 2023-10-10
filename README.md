# SD9Tools Frontend

## Overview

SD9Tools Frontend is a graphical user interface (GUI) made in C# for the [SD9Tools](https://github.com/TheFooestBar/SD9Tool) script. SD9Tools is designed for working with .sd9 files, which are proprietary file formats containing audio data in the Microsoft ADPCM format. Using [ffmpeg](https://ffmpeg.org/), you can easily convert your audio files into the required format.

Right now the GUI can hardly be used and what is in the GUI are only visual elements that do not work much, at this moment this interface cannot operate with SD9 files, only reading properties of them.

## Features

- Export audio from SD9 files.
- Import audio into SD9 files.
- Transfer audio and parameters from one SD9 file to another.
- Adjust audio volume.
- Set section loops within SD9 files.

## Requirements

To use SD9Tools Frontend, ensure you have the following prerequisites installed:

- SD9Tool (i mean obviously)
- Python 3.6 or higher
- ffmpeg
- Visual Studio 2022

## Dependencies

SD9Tools Frontend relies on the default dependencies included with Visual Studio 2022, so you don't need to install any additional dependencies separately.

## How to Build

To build SD9Tools Frontend, follow these steps:

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/Winberhouls/SD9Tools-Front-End.git
   ```

2. Open the project in Visual Studio 2022.

3. Build the project using the provided build options in Visual Studio.

## To Do list

- Add proper code for each elements of the GUI
- Add the code to be able to extract and repack .sd9 files
- Add the code to be able to transfer properties from one SD9 to another.
- Add the code to be able to modify existing SD9s.
## Contributing

We welcome contributions to SD9Tools Frontend. To contribute, follow these steps:

1. Fork the repository to your GitHub account.

2. Clone your forked repository to your local machine.

3. Create a new branch for your contribution:

   ```bash
   git checkout -b feature/your-feature-name
   ```

4. Make your changes and commit them with clear and concise messages.

5. Push your changes to your forked repository.

6. Create a pull request (PR) to the main repository, explaining your changes and why they should be merged.


## License

SD9Tools Frontend is licensed under the Apache License 2.0. You can find the full text of the license in the [LICENSE](github.com/Winberhouls/SD9Tools-Front-End/blob/main/LICENSE.md) file.