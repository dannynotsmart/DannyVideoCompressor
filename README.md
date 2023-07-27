# DannyVideoCompressor

## Table of Contents:
### 1. [What is this?](#what-is-this)
### 2. [Security](#security)
### 3. [Pre-requisities (IMPORTANT)](#pre-requisites-important)
### 4. [How to Install and Run?](#how-to-install-and-run)
### 5. [How to use?](#how-to-use)
### 6. [Contributions/Feedback](#contributionsfeedback)
### 7. [Why this name?](#why-this-name)
### 8. [Expected Features](#expected-features)

### For quick use, read only 3, 4, and 5.

## What is this?
DannyVideoCompressor is a program that can compress any video file of any size to the following sizes:
- 8MB
- 25MB
- 50MB
- 100MB

Since Discord only allows you to upload files up to 25MB (as a non-nitro user) or 100MB (as a nitro user), I coded this application as a way to upload videos I want onto Discord with the cost of destroying it's quality.

This is meant to be a local alternative version of [8mb.video](https://8mb.video/), a common website that my friends and I use to compress videos. However, the problem with this is you have to wait for the video to be uploaded onto the site, wait for it to be compressed, then re-download the video. With bad internet, this could take ages. DannyVideoCompressor is coded to solve the time issue.

## Security
I do not have a certificate, or whatever Microsoft uses to publish applications made with .NET. This application is safe, and it is not a virus. You can verify this with:
- VirusTotal: Here is this [link](https://www.virustotal.com/gui/file-analysis/YWQ2MWVmODVkMzEzZTMxZjkxNTgzNDBiOWY3Yzc3MWY6MTY5MDQyODAwOQ==) to the VirusTotal scan. This scanned v1.0.0
- [dotPeek](https://www.jetbrains.com/decompiler/): You can decompile the Executable, since it is built in C# with .NET. From there, you can read the source code to ensure it's safe.
- Github: This is literally the Github repository for the application, go read the code.

If you really want, you can build the code yourself.

## Pre-requisites (IMPORTANT)
This application was created and tested only on Windows, so as of now, this application can only run on **Windows x64-86 architecture, Windows 7.0+.**.

This application uses FFmpeg, a bundle of different libraries used to handle different media files (videos, audio files). In order to use this application, you HAVE to install FFmpeg and add it to PATH. Without FFmpeg, DannyVideoCompressor will not work.

Here are some vital links you should follow:
- https://www.ffmpeg.org
- [How to install and add FFmpeg to PATH (recommended resource)](https://phoenixnap.com/kb/ffmpeg-windows)
- [How to install and add FFmpeg to PATH YouTube Tutorial (also recommended resource)](https://www.youtube.com/watch?v=EyIIvctDhYc)

## How to Install and Run?
Before reading this, make sure to read the [pre-requisites](#pre-requisites-important), or else this application may not work on your computer!

For a pre-compiled executable file, please head over to [Releases](https://github.com/dannynotsmart/DannyVideoCompressor/releases/tag/v1.0.0), and install the .exe file. 

If you would like to build this project yourself, you can easily do so by cloning this repository in Visual Studios, then build it.

## How to use?
1. Open up the application, `DannyVideoCompressor.exe`. Windows' AntiVirus will flag this EXE because I don't have a certificate or something, so it can't verify me as the author. Press `Run Anyway`.
2. Select the video to compress, by clicking the `CHOOSE` button next to `Choose Input Video`. You can also drag and drop a video file onto the button. **This will not work for videos under 8MB, because why would you compress those videos?**
3. Select the folder where the compressed video will be saved, by clicking the `CHOOSE` button next to `Choose Output Folder`. You can also drag and drop a folder onto the button.
4. Choose the new compressed size via the buttons that are enabled. For some reason, FFmpeg will actually compress it to a few megabytes less than your chosen compression size.
5. Press `Compress Video`. The button will be disabled, and the video will start being compressed. **Do not exit the Application**. Depending on the video size, it may vary in compressing times.
6. When the video is done being compressed, a message box will open up, as well as the folder that you selected.

## Contributions/Feedback
If you want to add anything, please create a PR, and I might take a look at it.

If you have feedback, I would greatly appreciate it! Please create a issue for your feedback.

If you would like to message me personally for any questions or such, my Discord username is @`applicationprogramminginterface` (sus). To have mutual servers, you can join `discord.gg/python`, `discord.gg/dpy`, or `discord.gg/csharp`.

## Expected Features
- Select specific compression size
- Clear input button
- Video tutorial