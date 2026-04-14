# ChatBot
📘 ChatBot
📌 Overview

My ChatBot is a C# console-based chatbot developed using the .NET Framework. The application is designed to simulate an interactive assistant that helps users learn about cybersecurity awareness in a simple and engaging way.

The chatbot includes features such as:

Voice greeting using a .wav audio file
ASCII art display
User input and interaction
Cybersecurity-related responses
Console UI enhancements (colours and typing effect)
Structured, object-oriented code design
🛠️ Technologies Used
C#
.NET Framework (Console Application)
System.Media (for audio playback)
Visual Studio
📁 Project Structure
│
├── Program.cs        # Entry point of the application
├── Chatbot.cs        # Chat logic and responses
├── User.cs           # Handles user input and name storage
├── AudioPlayer.cs    # Plays greeting audio
└── greetings.wav      # Voice greeting file (placed in bin/Debug)
How it runs
1. Program Startup

The application begins in Program.cs, where:

The voice greeting is played
The ASCII logo is displayed
The user is prompted to enter their name
🔊 2. Voice Greeting

The AudioPlayer class:

Loads the greetings.wav file
Plays the audio using SoundPlayer

If the file is missing, the program continues without crashing.

3. ASCII Art Display

The chatbot displays a cybersecurity-themed ASCII logo using a multi-line string.

This improves the visual appeal of the console application.

4. User Interaction

The User class:

Prompts the user to enter their name
Validates that the input is not empty
Stores the name for personalised interaction

Example:

Enter your name: Nelisa
Hello, Nelisa!
💬 5. Chatbot Conversation

The Chatbot class:

Starts a continuous chat loop
Accepts user input
Converts input to lowercase for easier processing
Responds based on keywords
6. Response 

The chatbot uses conditional statements (if-else) to respond to user queries.

Supported topics include:

General conversation (e.g “How are you?”)
Chatbot purpose
Cybersecurity topics like:
Password safety
Phishing

Example:

You: What is phishing?
Bot: Phishing is when attackers trick you into giving personal info.
7. Input Validation

The program ensures:

Empty inputs are rejected
Unknown questions receive a fallback response

Example:

Bot: I don't understand that yet, but I'm learning!
8. Console UI Enhancements

The chatbot improves user experience through:

Coloured text (for user and bot messages)
Typing animation effect
Structured formatting
🔁 9. Exit Condition

The chatbot runs continuously until the user types:

exit

Then it safely terminates:

Bot: Goodbye! Stay safe online 🔐
▶️ How to Run the Project
Open the solution in Visual Studio
Build the project

Ensure Greeting.wav is located in:

bin/Debug/
Run the program (Ctrl + F5)
✅ Features Summary

✔ Voice greeting
✔ ASCII art logo
✔ User name personalisation
✔ Interactive chatbot
✔ Cybersecurity awareness responses
✔ Input validation
✔ Clean object-oriented structure

what i could've done better:
Add more cybersecurity topics
Implement menu-based navigation
Integrate AI/NLP for smarter responses
Improve UI with richer console design
