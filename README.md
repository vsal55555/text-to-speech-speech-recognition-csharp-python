# 🎙️ Text To Speech & Speech Recognition Studio

A multilingual desktop application built using **C# WinForms** and **Python** that converts text into speech and speech back into text.

The application supports multiple languages including English, Nepali, Hindi, and Japanese through Text-to-Speech (TTS) and Speech-to-Text (STT) capabilities.

---

## 🚀 Features

### Text To Speech

✅ Read text from .txt files

✅ Convert text into MP3 audio

✅ Supports multiple languages

✅ Play generated audio

✅ Pause audio playback

✅ Stop audio playback

✅ Save generated MP3 files

---

### Speech Recognition

✅ Record live audio from microphone

✅ Convert speech to text using OpenAI Whisper

✅ Automatic language recognition

✅ Save recognized text as transcript

✅ Real-time transcription workflow

---

### Text Analytics

✅ Character Count

✅ Word Count

✅ Line Count

✅ Estimated Audio Duration

---

### Unicode & UTF-8 Support

✅ English Text

✅ Nepali Text (Unicode)

✅ Hindi Text (Unicode)

✅ Japanese Text (Unicode)

✅ UTF-8 Encoding Support

The application uses UTF-8 throughout the communication pipeline to ensure multilingual text is processed correctly.

---

## 🏗️ Application Architecture

```text
                 ┌───────────────┐
                 │   Text File   │
                 └───────┬───────┘
                         │
                         ▼
                C# WinForms UI
                         │
                         ▼
               Python (gTTS)
                         │
                         ▼
                    speech.mp3
                         │
                         ▼
                 Audio Playback

──────────────────────────────────

                 ┌───────────────┐
                 │  Microphone   │
                 └───────┬───────┘
                         │
                         ▼
              Python (OpenAI Whisper)
                         │
                         ▼
                  Recognized Text
                         │
                         ▼
                C# WinForms UI
```

---

## 🛠 Technologies Used

### Frontend

- C#
- .NET 10
- WinForms

### Backend

- Python

### Python Libraries

- gTTS
- OpenAI Whisper
- SoundDevice
- SciPy
- FFmpeg

### Other Tools

- Git
- GitHub

---

## 🌍 Supported Languages

| Language | TTS | STT |
|----------|-----|-----|
| English | ✅ | ✅ |
| Nepali | ✅ | ✅ |
| Hindi | ✅ | ✅ |
| Japanese | ✅ | ✅ |

---

## 🔤 UTF-8 Implementation

One of the key challenges during development was handling multilingual Unicode text correctly.

Speech recognition successfully recognized Nepali speech, but Windows console encoding created display issues for Unicode characters.

The solution was to standardize the communication pipeline using UTF-8.

### Python

```python
import sys

sys.stdout.reconfigure(
    encoding='utf-8'
)

sys.stderr.reconfigure(
    encoding='utf-8'
)
```

### C#

```csharp
psi.StandardOutputEncoding =
    Encoding.UTF8;

psi.StandardErrorEncoding =
    Encoding.UTF8;
```

This ensures proper processing of:

- Nepali
- Hindi
- Japanese
- Other Unicode languages

---

## 📂 Project Structure

```text
TextToSpeechConverter
│
├── TextToSpeechConverter.sln
│
├── frmTextToSpeech.cs
│
├── PythonScripts
│   ├── text_to_speech.py
│   └── live_speech.py
│
├── speech.mp3
│
├── Transcript_xxx.txt
│
└── README.md
```

---

## 🎯 Learning Outcomes

Through this project I learned:

- C# WinForms Development
- Python Integration with C#
- Process Management
- OpenAI Whisper
- Text-To-Speech Systems
- Speech-To-Text Systems
- Audio Processing
- UTF-8 Unicode Handling
- File Management
- Debugging Cross-Language Applications

---

## 🔮 Future Improvements

- Real-Time Live Transcription
- Translation Support
- AI Voice Assistant
- Speaker Identification
- Speech Summarization
- Cloud-Based Speech Services
- Azure Speech Services Integration

---

## Key Technical Learning

One of the most interesting challenges was implementing proper UTF-8 encoding between Python and C# to correctly process multilingual Unicode text such as Nepali speech recognition results.

---

## 👨‍💻 Author

### Bishal Shrestha

Technologies:
- C#
- .NET
- Python
- SQL
- Linux
- Git
- OpenAI Whisper
- Audio Processing

---

⭐ If you found this project useful, please consider giving it a star.
